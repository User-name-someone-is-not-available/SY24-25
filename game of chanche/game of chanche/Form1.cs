using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game_of_chanche
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int p1 = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            Random goal = new Random();
            int goalnum = goal.Next(1, 101);
            textBox3.Text = goalnum.ToString();
            if (textBox1.Text == textBox3.Text)
            {
                label2.Visible = true;
                button1.Visible = true;
                label2.Text = "you win";
                label1.Visible = false;
                button3.Visible = false;
       
         
            }
            else
            {
                label2.Visible = true;
                button1.Visible = true;
                label2.Text = "you lose";
                label1.Visible = false;
                button3.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e) 
        {
        
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox3.Text = "";
            label1.Visible = true;
            label2.Visible = false;
            button3.Visible = true;
            textBox1 .Visible = true;
            textBox3.Visible = true;
            button1.Visible = false;
        }
    }
    }

