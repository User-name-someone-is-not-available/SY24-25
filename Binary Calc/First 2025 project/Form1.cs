using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        int[] bits = new int[8];
        int[] bitsB = new int[8];
        public Form1()
        {
            InitializeComponent();
        }
        private void calculateValue()
        {
            Value = 0;
            if (bits[7] != 0) Value += 1;
            if (bits[6] != 0) Value += 2;
            if (bits[5] != 0) Value += 4;
            if (bits[4] != 0) Value += 8;
            if (bits[3] != 0) Value += 16;
            if (bits[2] != 0) Value += 32;
            if (bits[1] != 0) Value += 64;
            if (bits[0] != 0) Value += 128;
            totalLabel.Text = Value.ToString();
        }
        //The Change We Made 
        private void Bit6_TextChanged(object sender, EventArgs e)
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

            calculateValue();
        }

       
        private void calculateValueB()
        {
            Value = 0;
            if (bits[7] != 0) Value += 1;
            if (bits[6] != 0) Value += 2;
            if (bits[5] != 0) Value += 4;
            if (bits[4] != 0) Value += 8;
            if (bits[3] != 0) Value += 16;
            if (bits[2] != 0) Value += 32;
            if (bits[1] != 0) Value += 64;
            if (bits[0] != 0) Value += 128;
            TotallabelB.Text = Value.ToString();
        }
        private void BitB1_TextChanged(object sender, EventArgs e)
        {
            if (BitB8.Text == "1") bits[7] = 1;
            else bits[7] = 0;
            //bit1
            if (BitB7.Text == "1") bits[6] = 1;
            else bits[6] = 0;
            //bit2
            if (BitB6.Text == "1") bits[5] = 1;
            else bits[5] = 0;
            //bit3
            if (BitB5.Text == "1") bits[4] = 1;
            else bits[4] = 0;
            //bit4
            if (BitB4.Text == "1") bits[3] = 1;
            else bits[3] = 0;
            //bit3
            if (BitB3.Text == "1") bits[2] = 1;
            else bits[2] = 0;
            //bit6
            if (BitB2.Text == "1") bits[1] = 1;
            else bits[1] = 0;
            //bit7
            if (BitB1.Text == "1") bits[0] = 1;
            else bits[0] = 0;
            calculateValueB();
        }
    }
}
