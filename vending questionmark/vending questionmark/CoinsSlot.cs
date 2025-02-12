using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vending_questionmark
{
    internal class CoinsSlot
    {
        private double M_money; 
        public void insert(string coin)
        {
            /*
            if (coin == "nickel") M_money += .05;
            if (coin == "dime") M_money += .10;
            if (coin == "quarter") M_money += .25;
            if (coin == "dollar") M_money += 1;
            */
            switch (coin)
            {
                default:
                case "quarter":
                    M_money += .25;
                    break;
                case "dime":
                    M_money += .1;
                    break;
                case "nickel":
                    M_money += .05;
                    break;
                case "dollar":
                    M_money += 1;
                    break;

            }
        }
        public double total() 
        { 
           return M_money; 
        }
        public void coinreturn () 
        {
            
           M_money = 0;
        }



    }
}
