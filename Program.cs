using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            start_get();
            Console.ReadLine();
        }
        public static List<Item> items = new List<Item>();

        public static List<Item> start_get() {
            HttpWebRequest webRequest = 
                (HttpWebRequest) WebRequest.Create(string.Format("https://pkgstore.datahub.io/core/gold-prices/annual_json/data/5c28a0c1f31afd9904833df9fa908d7d/annual_json.json"));

            webRequest.Method = "GET";

            HttpWebResponse response = (HttpWebResponse)webRequest.GetResponse();

            Console.WriteLine(response.StatusCode);
            Console.WriteLine(response.Server);

            string jsonString;

            using (Stream stream = response.GetResponseStream()) {
                StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                jsonString = reader.ReadToEnd();
            }

            items = JsonConvert.DeserializeObject<List<Item>>(jsonString);
            
            //Console.WriteLine(items.Count);

           /*foreach (var item in items)
            {
                Console.WriteLine(item.date + " : " + item.price);
            }*/

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Form1 f1 = new Form1();
            f1.ShowDialog();

            return items;
        }
    }

    public class Item {
        public string date { get; set; }
        public string price { get; set; }
    }
}