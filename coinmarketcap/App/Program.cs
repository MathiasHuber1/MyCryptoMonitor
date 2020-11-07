using CoinMarketCap;
using CoinMarketCap.Models.Cryptocurrency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new CoinMarketCapClient("4997f8be-c76d-4801-8383-4c47e9eb36ce");
            var list = c.GetLatestListings(new ListingLatestParameters { Limit = 5000 }).Data;

            foreach (var item in list)
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadLine();
        }
    }
}
