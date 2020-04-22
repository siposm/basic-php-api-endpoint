using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace client_console_app
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

    }

    class Program
    {
        static void Main(string[] args)
        {
            DataFetcherService dfs = new DataFetcherService();
            dfs.FetchData().ForEach(x => Console.WriteLine(x));
        }
    }
}
