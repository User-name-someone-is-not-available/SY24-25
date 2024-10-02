using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minesweeper
{

    public partial class Form1 : Form
    {
        Random Random = new Random();
        Button[] btnGrid = new Button[100];
        tile[] tileGrid = new tile[100];
        public Form1()
        {
            InitializeComponent();
            reset();
        }
        private Button GetButton(int R, int C) 
        {
            int idx = (R - 1) * 10 + (C - 1);
            return btnGrid[idx];
        }
        private int getIndex(Button b)
        {
            string tmp = b.Name.Substring(6);
            int retVal = 0;
            int.TryParse(tmp, out retVal);
            return retVal-1; 
        }
        private void Setcounts()
        {
            //for everytile on the board,add 1 for every ajecent mine, set that count in the tile 
            for (int r=1; r<11; r++)
            {
                for (int c=1; c<11; c++)
                {
                    GetButton(r, c).BackColor = Color.AliceBlue;

                }

            }
        }
        private int countadj(int r, int c)
        {
            int minecount = 0;
            if (r > 1 && c > 1)
            {
              if(tileGrid[getIndex(GetButton(r - 1, c - 1))].getmine()) { minecount ++; }
            }
            if (r > 1 )
            {
                if (tileGrid[getIndex(GetButton(r - 1, c))].getmine()) { minecount++; }
            }
            if (r > 1 && c < 10)
            {
                if (tileGrid[getIndex(GetButton(r - 1, c + 1))].getmine()) { minecount++; }
            }
            if (c > 1)
            {
                if (tileGrid[getIndex(GetButton(r, c - 1))].getmine()) { minecount++; }
            } 
            if (c < 10) 
            {
                if (tileGrid[getIndex(GetButton(r, c + 1))].getmine()) { minecount++; }
            }
            if (r < 10 && c > 1) 
            {
                if (tileGrid[getIndex(GetButton(r + 1, c - 1))].getmine()) { minecount++; }
            }

            if (r < 10)
            {
                if (tileGrid[getIndex(GetButton(r + 1, c))].getmine()) { minecount++; }
            }
            if (r < 10 && c < 10)
            {
                if (tileGrid[getIndex(GetButton(r + 1, c + 1))].getmine()) { minecount++; }
            }
            return minecount;
        }
        private int countadjFlag(int r, int c)
        {
            int flagcount = 0;
            if (r > 1 && c > 1)
            {
                if (tileGrid[getIndex(GetButton(r - 1, c - 1))].getflag()) { flagcount++; }
            }
            if (r > 1)
            {
                if (tileGrid[getIndex(GetButton(r - 1, c))].getflag()) { flagcount++; }
            }
            if (r > 1 && c < 10)
            {
                if (tileGrid[getIndex(GetButton(r - 1, c + 1))].getflag()) { flagcount++; }
            }
            if (c > 1)
            {
                if (tileGrid[getIndex(GetButton(r, c - 1))].getflag()) { flagcount++; }
            }
            if (c < 10)
            {
                if (tileGrid[getIndex(GetButton(r, c + 1))].getflag()) { flagcount++; }
            }
            if (r < 10 && c > 1)
            {
                if (tileGrid[getIndex(GetButton(r + 1, c - 1))].getflag()) { flagcount++; }
            }

            if (r < 10)
            {
                if (tileGrid[getIndex(GetButton(r + 1, c))].getflag()) { flagcount++; }
            }
            if (r < 10 && c < 10)
            {
                if (tileGrid[getIndex(GetButton(r + 1, c + 1))].getflag()) { flagcount++; }
            }
            return flagcount;
        }
        private void dignear(int r, int c)
        {
            
            if (r > 1 && c > 1)
            {
                tileGrid[getIndex(GetButton(r - 1, c - 1))].setdug();
            }
            if (r > 1)
            {
                tileGrid[getIndex(GetButton(r - 1, c))].setdug();
            }
            if (r > 1 && c < 10)
            {
                tileGrid[getIndex(GetButton(r - 1, c + 1))].setdug();
            }
            if (c > 1)
            {
                tileGrid[getIndex(GetButton(r, c - 1))].setdug();
            }
            if (c < 10)
            {
                tileGrid[getIndex(GetButton(r, c + 1))].setdug();
            }
            if (r < 10 && c > 1)
            {
                tileGrid[getIndex(GetButton(r + 1, c - 1))].setdug();
            }

            if (r < 10)
            {
               tileGrid[getIndex(GetButton(r + 1, c))].setdug();
            }
            if (r < 10 && c < 10)
            {
                tileGrid[getIndex(GetButton(r + 1, c + 1))].setdug();
            }
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //    for (int r = 1; r< 11; r++)
        //        {
        //          for (int c = 1; c< 11; c++)
        //             {
        //                  tileGrid[getIndex(GetButton(r, c))].setnearby(countadj(r, c));
        // tileGrid[getIndex(GetButton(r, c))].setnearbyFlags(countadjFlag(r, c));

        // }
        private void reveal() {
            for (int r = 1; r < 11; r++)
            {
                for (int c = 1; c < 11; c++)
                {
                    tileGrid[getIndex(GetButton(r, c))].setnearby(countadj(r, c));
                    tileGrid[getIndex(GetButton(r, c))].setnearbyFlags(countadjFlag(r, c));
                }
            }
        }
        private void Middleclick(object sender, MouseEventArgs e, int r, int c )
        {
            
            Button b = sender as Button;
            tile T = tileGrid[getIndex(b)];
            if (e.Button == MouseButtons.Middle )
            {
                if (countadj(r,c ) == countadjFlag(r, c)) 
                { 
                    dignear(r, c);
                }
                                
                

                
            }
        }
        
        private void button_MouseDown(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;
            tile T = tileGrid[getIndex(b)];


            if (e.Button == MouseButtons.Right)
            {

                T.setflag();
            }

            else if (e.Button == MouseButtons.Left)
                T.setdug();
        }
        private void button101_Click(object sender, EventArgs e)
        {
            reset();
        }
        private void createmines(int nubmines)
        {
            int minecount = 0;
            //    untill we have enough mines]
            while (minecount < nubmines)
            {
                //generate nuber 1-100    set mine on that tile if it doesnt have a mine
                int rNum = Random.Next(0, 100);
                if(tileGrid[rNum].getmine() == false)
                {
                    minecount++;
                    tileGrid[rNum].setmine(true); 
                }

            }
        }
        private void reset()
        {
            reset();

            void reset()
            {
                for (int i = 0; i < 100; i++)
                {
                    
                    btnGrid[i] = (Button)Controls["Button" + (i + 1)];
                    tileGrid[i] = new tile(btnGrid[i]);
                    tileGrid[i].setflagimage(flagpicturebox.Image);
                    tileGrid[i].setmineimage(minePIcturebox.Image);
                    

                }
                createmines(30);
                //Setcounts();
                // countadj(10,10);
                // countadj(1, 10);
                // countadj(1, 1);
                // countadj(10, 1);
                // countadj(5, 5);
                for (int r = 1; r<11; r++)
                {
                    for( int c=1; c < 11; c++)
                    {
                        tileGrid[getIndex(GetButton(r, c))].setnearby(countadj(r,c));
                    }
                }
              
            }
            
        }

     
    }
}
