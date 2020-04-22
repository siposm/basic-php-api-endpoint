using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace client_wpf_app
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Job { get; set; }
        public int Salary { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Age} - {Job} - {Salary}";
        }
    }

    class DataFetcherService
    {
        public List<Person> FetchData()
        {
            string url = "https://siposm.hu/demo/api/endpoint.php";
            WebClient wc = new WebClient();
            string x = wc.DownloadString(url);
            return JsonConvert.DeserializeObject<List<Person>>(x);
        }
        public List<Person> FetchData(int age)
        {
            string url = "https://siposm.hu/demo/api/endpoint.php?age=" + age;
            WebClient wc = new WebClient();
            string x = wc.DownloadString(url);
            return JsonConvert.DeserializeObject<List<Person>>(x);
        }
    }

    public partial class MainWindow : Window
    {
        private DataFetcherService dfs;

        public MainWindow()
        {
            InitializeComponent();

            dfs = new DataFetcherService();

            // by default, all records are fetched
            FetchAllClick(this, null);
        }

        private void FetchByAgeClick(object sender, RoutedEventArgs e)
        {
            Purge();
            dfs.FetchData(22).ForEach(x => gui_listbox.Items.Add(x));
        }

        private void FetchAllClick(object sender, RoutedEventArgs e)
        {
            Purge();
            dfs.FetchData().ForEach(x => gui_listbox.Items.Add(x));
        }

        private void Purge()
        {
            gui_listbox.Items.Clear();
        }
    }
}
