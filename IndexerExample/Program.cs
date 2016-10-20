using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerExample
{
    public class Program
    { 
        public  class HttpCookie
        {

            private readonly Dictionary<string, string> _dictionary;
            public DateTime Expiry { get; set; }

            public HttpCookie()
            {
                _dictionary = new Dictionary<string, string>();
            }

            public string this[string key]
            {
                get { return _dictionary[key]; }
                set { _dictionary[key] = value; }
            }
        }

        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "mosh";
            Console.WriteLine(cookie["name"]);
        }
    
    }
}
