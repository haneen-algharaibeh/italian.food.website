using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ITALIAN_FOOD
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }
        Timer tmr;
        private void welcome_Load(object sender, EventArgs e)
        {
            lblwelcome.BackColor = System.Drawing.Color.Transparent;
            //timer1.Enabled = true;
           

           

            this.Hide();
            //...........
            
            tmr = new Timer();
            tmr.Interval = 3000;
            tmr.Start();
            tmr.Tick += tmr_Tick;
        }
        void tmr_Tick(object sender, EventArgs e)
        {
            tmr.Stop();

            //display mainform

            
            login mf = new login();

            mf.Show();
            

           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*
            this.Hide();
            Application.Exit();
             * */
            
        }
    }
}
       
