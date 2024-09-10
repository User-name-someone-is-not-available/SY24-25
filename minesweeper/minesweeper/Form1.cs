using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minesweeper
{
    public partial class Form1 : Form
    {
        Button[] btnGrid = new Button[100];
        tile[] tileGrid = new tile[100];
        public Form1()
        {
            InitializeComponent();
      
            for(int i = 0; i < 100; i++)
            {
                btnGrid[i] = (Button)Controls["Button" + (i+1)];
                btnGrid[i].BackColor = Color.Gray;
                tileGrid[i] = new tile(btnGrid[i]); 
            }
        

        }
        private Button GetButton(int R, int C) 
        {
            return (Button)GetButton(R, C);
        }
        private int getIndex(Button b)
        {
            string tmp = b.Name.Substring(6);
            int retVal = 0;
            int.TryParse(tmp, out retVal);
            return retVal-1; 
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void button91_MouseDown(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;
            b.BackColor = Color.Red;
        }
    }
}
