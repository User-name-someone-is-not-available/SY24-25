using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        int SMoney;
        public Form1()
        {
            InitializeComponent();
        }
        private void Getproduct(object sender)
        {
            Output.Image = null ; OutputL.Text = ""; 
            Output.Visible = true;
            Output.Image = (sender as PictureBox).Image;
            if (Output.Image == A1.Image) { OutputL.Text = A1L.Text; }
            if (Output.Image == A2.Image) { OutputL.Text = A2L.Text; }
            if (Output.Image == A3.Image) { OutputL.Text = A3L.Text; }
            if (Output.Image == A4.Image) { OutputL.Text = A4L.Text; }
            if (Output.Image == B1.Image) { OutputL.Text = B1L.Text; }
            if (Output.Image == B2.Image) { OutputL.Text = B2L.Text; }
            if (Output.Image == B3.Image) { OutputL.Text = B3L.Text; }
            if (Output.Image == B4.Image) { OutputL.Text = B4L.Text; }
            if (Output.Image == C1.Image) { OutputL.Text = C1L.Text; }
            if (Output.Image == C2.Image) { OutputL.Text = C2L.Text; }
            if (Output.Image == C3.Image) { OutputL.Text = C3L.Text; }
            if (Output.Image == C4.Image) { OutputL.Text = C4L.Text; }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void QuarterB_Click(object sender, EventArgs e)
        {
            SMoney = SMoney + 25;
            moneylabel.Text = SMoney.ToString();
        }

        private void DimeB_Click(object sender, EventArgs e)
        {
            SMoney = SMoney + 10;
            moneylabel.Text = SMoney.ToString();
        }

        private void NickelB_Click(object sender, EventArgs e)
        {
            SMoney = SMoney + 5;
            moneylabel.Text = SMoney.ToString();
        }

        private void DollarB_Click(object sender, EventArgs e)
        {
            SMoney = SMoney + 100;
            moneylabel.Text = SMoney.ToString();
        }

        private void A1_Click(object sender, EventArgs e)
        {
            Getproduct(A1);

        }

        private void B4_Click(object sender, EventArgs e)
        {
            Getproduct(B4);
        }

        private void B1_Click(object sender, EventArgs e)
        {
            Getproduct(B1);
        }

        private void C1_Click(object sender, EventArgs e)
        {
            Getproduct(C1);
        }

        private void C2_Click(object sender, EventArgs e)
        {
            Getproduct(C2);
        }

        private void B2_Click(object sender, EventArgs e)
        {
            Getproduct(B2);
        }

        private void A2_Click(object sender, EventArgs e)
        {
            Getproduct(A2);
        }

        private void A3_Click(object sender, EventArgs e)
        {
            Getproduct(A3);
        }

        private void B3_Click(object sender, EventArgs e)
        {
            Getproduct(B3);
        }

        private void C3_Click(object sender, EventArgs e)
        {
            Getproduct(C3);
        }

        private void C4_Click(object sender, EventArgs e)
        {
            Getproduct(C4);
        }

        private void A4_Click(object sender, EventArgs e)
        {
            Getproduct(A4);
        }
    }
}
