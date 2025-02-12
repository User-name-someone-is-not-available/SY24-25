using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace vending_questionmark
{
    
    internal class coinslot
    {
        private double totalAmount;
        public coinslot() { }
        public void InsertCoin(string coin)
        {
            switch (coin.ToLower())
            {
                case "nickel":
                    totalAmount += 0.05;
                    break;
                case "dime":
                    totalAmount += 0.10;
                    break;
                case "quarter":
                    totalAmount += 0.25;
                    break;
                case "dollar":
                    totalAmount += 1.00;
                    break;
                default:
                    throw new ArgumentException("Invalid coin type.");
            }
        }
        public double total() 
        {
            return totalAmount;
        }
        public void coinReturn() { totalAmount = 0.0; }   
    }
}
