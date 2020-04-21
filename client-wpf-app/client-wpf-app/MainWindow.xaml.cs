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
            string url = "https://siposm.hu/api/endpoint.php";
            WebClient wc = new WebClient();
            string x = wc.DownloadString(url);
            return JsonConvert.DeserializeObject<List<Person>>(x);
        }

    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataFetcherService dfs = new DataFetcherService();
            dfs.FetchData().ForEach(x => gui_listbox.Items.Add(x));
        }
    }
}
