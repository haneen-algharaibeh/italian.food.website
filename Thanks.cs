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
    public partial class Thanks : Form
    {
        public Thanks()
        {
            InitializeComponent();
        }
        Timer tmr;
        private void Thanks_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            
            lblthanks.BackColor = System.Drawing.Color.Transparent;
            /*
            tmr = new Timer();
            tmr.Interval = 3000;
            tmr.Start();
            tmr.Tick += tmr_Tick;
        }
        void tmr_Tick(object sender, EventArgs e)
        {
            tmr.Stop();

            //display mainform
             * 

           // login mf = new login();

           // mf.Show();

            //hide this form

            this.Hide();
            Application.Exit();
        }
    }
    */

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

            //display mainform
            

           

           

           this.Hide();
            Application.Exit();
        }
    }
}