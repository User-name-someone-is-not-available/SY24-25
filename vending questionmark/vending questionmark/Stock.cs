using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vending_questionmark
{
    internal class Stock
    {
        private Dictionary<string, (decimal Price, int Stock)> items;

        public CoinsSlot CS = new CoinsSlot();
        Dictionary<string, int> merch= new Dictionary<string, int>(); 
        int AMOUNT; 
        public int buycount = 1;
        public void AddProduct(string product, int amount)
        {
          
        }

        public Stock()
        {
            items = new Dictionary<string, (decimal Price, int Stock)>
            {
                { "A1", (2.50m, 10) },
                { "A2", (1.00m, 10) },
                { "A3", (1.50m, 10) },
                { "A4", (2.00m, 10) },
                { "B1", (2.69m, 10) },
                { "B2", (2.00m, 10) },
                { "B3", (1.00m, 10) },
                { "B4", (1.50m, 10) },
                { "C1", (1.50m, 10) },
                { "C2", (1.99m, 10) },
                { "C3", (2.50m, 10) },
                { "C4", (3.00m, 10) }
            };
        }

        public (decimal Price, int Stock) GetProductInfo(string productName)
        {
            if (items.TryGetValue(productName, out var productInfo))
            {
                return productInfo;
            }
            return (0, 0);
        }

        public bool BuyProduct(string product)
        {
            if (items.ContainsKey(product) && items[product].Stock > 0)
            {
                items[product] = (items[product].Price, items[product].Stock - 1);
                return true;
            }
            return false;
        }
        public bool IsProductAvailable(string productName)
        {
            return items.ContainsKey(productName) && items[productName].Stock > 0;
        }
    }
}
