using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_2025_project
{
    public partial class Form1 : Form
    {
        int Value = 0;
        int valueB = 0;
        int valuec = 0;

        int[] bits = new int[8];
        int[] bitsB = new int[8];
        int[] bitsC = new int[8];
        public Form1()
        {
            InitializeComponent();
        }
        private void calculateValue()
        {
            if (Bit8.Text == "1") bits[7] = 1;
            else bits[7] = 0;
            //bit1
            if (Bit7.Text == "1") bits[6] = 1;
            else bits[6] = 0;
            //bit2
            if (Bit6.Text == "1") bits[5] = 1;
            else bits[5] = 0;
            //bit3
            if (Bit5.Text == "1") bits[4] = 1;
            else bits[4] = 0;
            //bit4
            if (Bit4.Text == "1") bits[3] = 1;
            else bits[3] = 0;
            //bit3
            if (Bit3.Text == "1") bits[2] = 1;
            else bits[2] = 0;
            //bit6
            if (Bit2.Text == "1") bits[1] = 1;
            else bits[1] = 0;
            //bit7
            if (Bit1.Text == "1") bits[0] = 1;
            else bits[0] = 0;
            //bit8

            Value = 0;
            for (int i = 0; i < bits.Length; i++) { if (bits[i] != 0) { Value +=(int)Math.Pow(2, i); } }

            totalLabel.Text = Value.ToString();
        }
        //The Change We Made 
        

       
        private void calculateValueB()
        {   
            if (BitB8.Text == "1") bitsB[7] = 1;
            else bitsB[7] = 0;
            //bit1
            if (BitB7.Text == "1") bitsB[6] = 1;
            else bitsB[6] = 0;
            //bit2
            if (BitB6.Text == "1") bitsB[5] = 1;
            else bitsB[5] = 0;
            //bit3
            if (BitB5.Text == "1") bitsB[4] = 1;
            else bitsB[4] = 0;
            //bit4
            if (BitB4.Text == "1") bitsB[3] = 1;
            else bitsB[3] = 0;
            //bit3
            if (BitB3.Text == "1") bitsB[2] = 1;
            else bitsB[2] = 0;
            //bit6
            if (BitB2.Text == "1") bitsB[1] = 1;
            else bitsB[1] = 0;
            //bit7
            if (BitB1.Text == "1") bitsB[0] = 1;
            else bitsB[0] = 0;


            valueB = 0;
           
            for (int i = 0; i < bitsB.Length; i++) { if (bitsB[i] != 0) { valueB += (int)Math.Pow(2, i); } }

          
            TotallabelB.Text = valueB.ToString();
        }
        private void calculateValueC()
        {
            if (BitC8.Text == "1") bitsC[7] = 1;
            else bitsC[7] = 0;
            //bit1
            if (BitC7.Text == "1") bitsC[6] = 1;
            else bitsC[6] = 0;
            //bit2
            if (BitC6.Text == "1") bitsC[5] = 1;
            else bitsC[5] = 0;
            //bit3
            if (BitC5.Text == "1") bitsC[4] = 1;
            else bitsC[4] = 0;
            //bit4
            if (BitC4.Text == "1") bitsC[3] = 1;
            else bitsC[3] = 0;
            //bit3
            if (BitC3.Text == "1") bitsC[2] = 1;
            else bitsC[2] = 0;
            //bit6
            if (BitC2.Text == "1") bitsC[1] = 1;
            else bitsC[1] = 0;
            //bit7
            if (BitC1.Text == "1") bitsC[0] = 1;
            else bitsC[0] = 0;


            valuec = 0;
            for (int i = 0; i < bitsC.Length; i++) { if (bitsC[i] != 0) { valuec += (int)Math.Pow(2, i); } }

            LabelTotalC.Text = valuec.ToString();
        }
      
        private void BitB8_MouseDown(object sender, MouseEventArgs e)
        {
            if (((TextBox)sender).Text == "0")
                ((TextBox)sender).Text = "1";
            else
                ((TextBox)sender).Text = "0";
            calculateValue();
            calculateValueB();

            Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bits.Length; i++) { bits[i] = 0; Update(); }
            for (int i = 0; i < bitsB.Length; i++) { bitsB[i] = 0; Update(); }
            for (int i = 0; i < bitsC.Length; i++) { bitsC[i] = 0; Update(); }
            
        }
        private void Update()
        { 
                Bit1.Text = (bits[0] == 1 ? "1" : "0");
                Bit2.Text = (bits[1] == 1 ? "1" : "0");
                Bit3.Text = (bits[2] == 1 ? "1" : "0");
                Bit4.Text = (bits[3] == 1 ? "1" : "0");
                Bit5.Text = (bits[4] == 1 ? "1" : "0");
                Bit6.Text = (bits[5] == 1 ? "1" : "0");
                Bit7.Text = (bits[6] == 1 ? "1" : "0");
                Bit8.Text = (bits[7] == 1 ? "1" : "0");
                BitB1.Text = (bitsB[0] == 1 ? "1" : "0");
                BitB2.Text = (bitsB[1] == 1 ? "1" : "0");
                BitB3.Text = (bitsB[2] == 1 ? "1" : "0");
                BitB4.Text = (bitsB[3] == 1 ? "1" : "0");
                BitB5.Text = (bitsB[4] == 1 ? "1" : "0");
                BitB6.Text = (bitsB[5] == 1 ? "1" : "0");
                BitB7.Text = (bitsB[6] == 1 ? "1" : "0");
                BitB8.Text = (bitsB[7] == 1 ? "1" : "0");
                BitC1.Text = (bitsC[0] == 1 ? "1" : "0");
                BitC2.Text = (bitsC[1] == 1 ? "1" : "0");
                BitC3.Text = (bitsC[2] == 1 ? "1" : "0");
                BitC4.Text = (bitsC[3] == 1 ? "1" : "0");
                BitC5.Text = (bitsC[4] == 1 ? "1" : "0");
                BitC6.Text = (bitsC[5] == 1 ? "1" : "0");
                BitC7.Text = (bitsC[6] == 1 ? "1" : "0");
                BitC8.Text = (bitsC[7] == 1 ? "1" : "0");
            calculateValue();
            calculateValueB();
            calculateValueC();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bits.Length - 1; i++)
            {
                //if (bits[7] == 1) { bits[7 - 1] = 1; bits[7] = 0; } 
                bits[i] = bits[i + 1];
                
            }
            bits[7] = 0 ; 
            Update();
            for (int i = 0; i < bitsB.Length - 1; i++)
            {
                bitsB[i] = bitsB[i + 1];
            }
            bitsB[7] = 0;
            Update();
        }

        private void Cclear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bitsC.Length; i++) { bitsC[i] = 0; Update(); }
        }

        private void Bclear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bitsB.Length; i++) { bitsB[i] = 0; Update(); }
        }

        private void Aclear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bits.Length; i++) { bits[i] = 0; Update(); }
        }

        private void shiftR_Click(object sender, EventArgs e)
        {
            for (int i = bits.Length - 1; i > 0; i--)
            {
                bits[i] = bits[i - 1];
            }
            bits[0] = 0;
            Update();
            for (int i =bitsB.Length -1; i>0; i--)
            {
                bitsB[i] = bitsB[i - 1];
            }
            bitsB[0] = 0;
            Update();
        }

        private void ANDIT_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i] * bitsB[i] == 1) { bitsC[i] = 1; }
                if (bits[i] * bitsB[i] == 0) { bitsC[i] = 0; }

            Update();
            }
        }

        private void ORIT_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i] == 0 || bitsB[i] == 1) { bitsC[i] = 1; }
                if (bits[i] == 1 || bitsB[i] == 0) { bitsC[i] = 1; }
                if (bits[i] == 0 || bitsB[i] == 0) { bitsC[i] = 0; }
                if (bits[i] == 1 || bitsB[i] == 1) { bitsC[i] = 1; }

                Update();
            }
        }

        private void XORIT_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i] == 1 || bitsB[i] == 1) { bitsC[i] = 0; }
                if (bits[i] == 0 || bitsB[i] == 0) { bitsC[i] = 0; }
                if (bits[i] == 0 && bitsB[i] == 1) { bitsC[i] = 1; }
                if (bits[i] == 1 && bitsB[i] == 0) { bitsC[i] = 1; }

                Update();
            }
        }

        private void ADDIT_Click(object sender, EventArgs e)
        {
            int carry = 0;
            for (int i = 0; i < bits.Length; i++)
            {
         
                int sum = bits[i] + bitsB[i] + carry;

            
                if (sum == 0)
                {
                    bitsC[i] = 0;
                    carry = 0;
                }
                else if (sum == 1)
                {
                    bitsC[i] = 1;
                    carry = 0;
                }
                else if (sum == 2)
                {
                    bitsC[i] = 0;
                    carry = 1;
                }
                else 
                {
                    bitsC[i] = 1;
                    carry = 1;
                }
            }


            if (carry == 1)
            {
     
                bitsC[bits.Length] = 1; 
            }

            Update();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int A = Value - valueB;
            LabelTotalC.Text = A.ToString();
        }
    }
}
