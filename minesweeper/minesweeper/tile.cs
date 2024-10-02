using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minesweeper
{
    internal class tile
    {
        private Button T_b;
        private Boolean T_flag;
        private Boolean T_dug;
        private Boolean T_mine;
        int T_nearmines;
        private Image T_flagimage;
        private Image T_mineimage;
        int T_nearflags;
        public tile(Button b)
        {

            T_b = b;
            T_b.BackColor = Color.Gray;
        }
        
        public void setnearby(int N) 
        {
            
            T_nearmines = N;
            T_b.Text = T_nearmines.ToString();
        }
        public void setnearbyFlags(int N)
        {

            T_nearflags = N;
            T_b.Text = T_nearflags.ToString();
        }
        public void setflagimage(Image flagimage) { T_flagimage = flagimage; }
        public void setmineimage(Image mineimage) { T_mineimage = mineimage; }
        public void setdug() 
        {
            T_dug = true;
            if (T_mine)
                T_b.BackgroundImage = T_mineimage;
            else
                T_b.BackColor = Color.Beige;
            

        }
        public Boolean getmine() { return T_mine; }
        public Boolean getflag() { return T_flag; }
        public void setmine(Boolean b) 
        {
            T_mine = b;
          
        }
        public void setflag()
        {
            
            T_flag = !T_flag;
            if (T_flag)
                T_b.BackgroundImage = T_flagimage;
            
            else
                T_b.BackgroundImage = null;
        }
    }
}
