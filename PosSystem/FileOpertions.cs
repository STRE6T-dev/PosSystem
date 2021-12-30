using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosSystem
{
    class FileOpertions
    {
        String[] Name = new string[100];
        public static List<Stock> ReadFromFle()
        {
            var lines = File.ReadAllLines(@"Textfiles\Stock.txt");
            var list = new List<Stock>();
            foreach (var line in lines)
            {
                var values = line.Split(',');
                var stock = new Stock();
                stock.Name = values[0];
                stock.Price = Convert.ToDouble(values[1]);
                stock.Qty = Convert.ToInt32(values[2]);
                stock.Date = values[3];
                list.Add(stock);
                
                //return list;
            }
            
            return list;
        }
    }
}
