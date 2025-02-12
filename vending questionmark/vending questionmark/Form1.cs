using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vending_questionmark
{
    public partial class Form1 : Form
    { 
        Stock prods = new Stock();
        
        private decimal totalAmount = 0;
        private string selectedProductName;
        private decimal selectedProductPrice;
        private coinslot coinSlot;
        private CoinsSlot CS;
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Getproduct(string productName, decimal price)
        {
            var productInfo = prods.GetProductInfo(ProductName);
            if (productInfo.Price != totalAmount)
            {
                lblPurchaseMessage.Text = "Product price mismatch.";
                return;
            }

            selectedProductName = ProductName;
            selectedProductPrice = productInfo.Price;
            lblProductName.Text = ProductName;
            lblProductPrice.Text = productInfo.Price.ToString("C");

            // Check if the product is available
            if (productInfo.Stock <= 0)
            {
                lblPurchaseMessage.Text = "This product is out of stock.";
            }
            else
            {
                lblPurchaseMessage.Text = "";
            }
        }
        private void UpdateTotalLabel()
        {
            moneylabel.Text = prods.CS.total().ToString() + "$";
           
        }


        private void QuarterB_Click(object sender, EventArgs e)
        {
            prods.CS.insert("quarter");
            UpdateTotalLabel();

        }

        private void DimeB_Click(object sender, EventArgs e)
        {

            prods.CS.insert("dime");
            UpdateTotalLabel();
        }

        private void NickelB_Click(object sender, EventArgs e)
        {
            prods.CS.insert("nickel");
            UpdateTotalLabel();
        }

        private void DollarB_Click(object sender, EventArgs e)
        {
            prods.CS.insert("dollar");
            UpdateTotalLabel();
        }

        private void A1_Click(object sender, EventArgs e)
        {
            Getproduct("A1", 2.50m);

        }

        private void B4_Click(object sender, EventArgs e)
        {
            Getproduct("B4", 1.50m);

        }

        private void B1_Click(object sender, EventArgs e)
        {
     

            Getproduct("B1", 2.69m);
        }

        private void C1_Click(object sender, EventArgs e)
        {
            Getproduct("C1", 1.50m);
       

        }

        private void C2_Click(object sender, EventArgs e)
        {
            Getproduct("C2", 1.99m);
        }

        private void B2_Click(object sender, EventArgs e)
        {
        
            Getproduct("B2", 2.00m);
        }

        private void A2_Click(object sender, EventArgs e)
        {
           

            Getproduct("A2", 1.00m);
        }

        private void A3_Click(object sender, EventArgs e)
        {
           
            Getproduct("A3", 1.50m);
        }

        private void B3_Click(object sender, EventArgs e)
        {
          
            Getproduct("B3", 1.00m);
        }

        private void C3_Click(object sender, EventArgs e)
        {
            Getproduct("C3", 2.50m);
           
        }

        private void C4_Click(object sender, EventArgs e)
        {
            Getproduct("C4", 3.00m);
           
        }

        private void A4_Click(object sender, EventArgs e)
        {
            Getproduct("A4", 2.00m);
          
        }
        private void button1_Click(object sender, EventArgs e)
        {
            moneylabel.Text = "0";
            CS.coinreturn();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            prods.buycount = prods.buycount + 1; 
            label1.Text = "Amount: " + prods.buycount.ToString();
            if (prods.buycount >20 ) { label1.Text = "ERROR"; prods.buycount = 0; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedProductName))
            {
                lblPurchaseMessage.Text = "Please select a product.";
                return;
            }
            if (!prods.IsProductAvailable(selectedProductName))
            {
                lblPurchaseMessage.Text = "This product is out of stock.";
                return;
            }

            if ((decimal)CS.total() >= selectedProductPrice)
            {
                if (prods.BuyProduct(selectedProductName))
                {
                    CS.coinreturn(); 
                    moneylabel.Text = CS.total().ToString("C");
                    lblPurchaseMessage.Text = $"You purchased {selectedProductName}!";
                    selectedProductName = null;
                    selectedProductPrice = 0;
                    lblProductName.Text = "";
                    lblProductPrice.Text = "";
                }
                else
                {
                    lblPurchaseMessage.Text = "Product purchase failed.";
                }
            }
            else
            {
                lblPurchaseMessage.Text = "Not enough money deposited.";
            }
        }
    }
}
