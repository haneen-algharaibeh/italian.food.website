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
    public partial class pizza : Form
    {
        int total = 0, larg = 0;
        public static int sump = 0;
        public pizza()
        {

            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            Total s6 = new Total();
            this.Hide();
            s6.ShowDialog();
        }

        private void btnbreviuos_Click(object sender, EventArgs e)
        {
            Choose_Food s4 = new Choose_Food();
            this.Hide();
            s4.Show();

        }





        private void btntotal_Click(object sender, EventArgs e)
        {

            /*
            int total,largolive,mediumolive, smallolive,largsalami,mediumsalami,smallsalami,largcheese,medimcheese,smallcheese,
                largmushroom,mediummushroom,smallmushroom;
            total = 0;
            largolive =6;
            mediumolive = 4;
            
            
            
            if (cblargolive.Checked)
            {
                total += largolive;
                

            }

            if (cbmediumolive.Checked)
            {
                total += mediumolive;
            }
            if (cbsmallolive.Checked)
            {
              //  total += smallolive;
            }
             */







            int total, largolive, mediumolive, smallolive, largsalami, mediumsalami, smallsalami, largcheese, medimcheese, smallcheese,
                largmushroom, mediummushroom, smallmushroom;
            total = 0;


            /*
            foreach (Control ctrl in this.Controls)
            {

                if (( ctrl is CheckBox ) && ((CheckBox) ctrl).Checked ) 
                {
                    //if ( ctrl
                    total += Convert.ToInt32(ctrl.Tag);
                    
                    //total = total * int.Parse(txtlareolive.Text);
                    

                }
            }
            */

            largolive = int.Parse(txtlareolive.Text) * 6;

            mediumolive = int.Parse(txtmediumolive.Text) * 4;

            smallolive = int.Parse(txtsmallolive.Text) * 3;


            largsalami = int.Parse(txtlargesalmai.Text) * 6;
            mediumsalami = int.Parse(txtmediumsalami.Text) * 4;
            smallsalami = int.Parse(txtsmallsalami.Text) * 3;


            largcheese = int.Parse(txtlargecheese.Text) * 6;
            medimcheese = int.Parse(txtmediumcheese.Text) * 4;
            smallcheese = int.Parse(txtsmallcheese.Text) * 3;



            largmushroom = int.Parse(txtlargemushroom.Text) * 6;
            mediummushroom = int.Parse(txtmediummushroom.Text) * 4;
            smallmushroom = int.Parse(txtsmallnushroom.Text) * 3;


            total += largolive + mediumolive + smallolive + largsalami + mediumsalami + smallsalami + largcheese + medimcheese + smallcheese + largmushroom + mediummushroom + smallmushroom;

            //txttotal.Text = total.ToString();



            txttotal.Text = total.ToString();
            sump = total;

            /*
            foreach (object item1 in checkedd.CheckedItems)
            {
                total += (int)item1;//Convert.ToInt32(checkedd.Items[(int)item]);
            }
            txttotal.Text = total.ToString();

            */



        }





        private void cbxolive_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            foreach(string s1 in cbxolive.CheckedItems)
            {
            */
        }

        private void pizza_Load(object sender, EventArgs e)
        {

        }

        private void cblargsalami_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbsmallsalami_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbmediumsalami_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void txtlareolive_TextChanged(object sender, EventArgs e)
        {
            total = total * int.Parse(txtlareolive.Text);
            //total = total * Convert.ToInt32(txtlareolive.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            larg = int.Parse(txtlargecheese.Text) - 1;
            txtlargecheese.Text = larg.ToString();
            if (int.Parse(txtlargecheese.Text) <= 0)
            {
                larg = 0;
                txtlargecheese.Text = larg.ToString();
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            int larg;
            larg = 0;
            larg = int.Parse(txtlareolive.Text) + 1;
            txtlareolive.Text = larg.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int larg;
            larg = 0;
            larg = int.Parse(txtlareolive.Text) - 1;
            txtlareolive.Text = larg.ToString();
            if (int.Parse(txtlareolive.Text) <= 0)
            {
                larg = 0;
                txtlareolive.Text = larg.ToString();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            larg = int.Parse(txtmediumolive.Text) + 1;
            txtmediumolive.Text = larg.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            larg = int.Parse(txtmediumolive.Text) - 1;
            txtmediumolive.Text = larg.ToString();
            if (int.Parse(txtmediumolive.Text) <= 0)
            {
                larg = 0;
                txtmediumolive.Text = larg.ToString();

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            larg = int.Parse(txtsmallolive.Text) + 1;
            txtsmallolive.Text = larg.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            larg = int.Parse(txtsmallolive.Text) - 1;
            txtsmallolive.Text = larg.ToString();
            if (int.Parse(txtsmallolive.Text) <= 0)
            {
                larg = 0;
                txtsmallolive.Text = larg.ToString();

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            larg = int.Parse(txtlargesalmai.Text) + 1;
            txtlargesalmai.Text = larg.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            larg = int.Parse(txtlargesalmai.Text) - 1;
            txtlargesalmai.Text = larg.ToString();
            if (int.Parse(txtlargesalmai.Text) <= 0)
            {
                larg = 0;
                txtlargesalmai.Text = larg.ToString();

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            larg = int.Parse(txtmediumsalami.Text) + 1;
            txtmediumsalami.Text = larg.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            larg = int.Parse(txtmediumsalami.Text) - 1;
            txtmediumsalami.Text = larg.ToString();
            if (int.Parse(txtmediumsalami.Text) <= 0)
            {
                larg = 0;
                txtmediumsalami.Text = larg.ToString();

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            larg = int.Parse(txtsmallsalami.Text) + 1;
            txtsmallsalami.Text = larg.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            larg = int.Parse(txtsmallsalami.Text) - 1;
            txtsmallsalami.Text = larg.ToString();
            if (int.Parse(txtsmallsalami.Text) <= 0)
            {
                larg = 0;
                txtsmallsalami.Text = larg.ToString();
            }

            /*
            private void txtlargesalmai_TextChanged(object sender, EventArgs e)
            {
                total += total * int.Parse(txtmediumolive.Text);
            }

            private void txtlargesalmai_TextChanged(object sender, EventArgs e)
            {
                total = total * int.Parse(txtsmallolive.Text);
            }

            private void txtlargesalmai_TextChanged(object sender, EventArgs e)
            {
                total = total * int.Parse(txtlargesalmai.Text);
            }
    
             */

        }

        private void button14_Click(object sender, EventArgs e)
        {
            larg = int.Parse(txtlargecheese.Text) + 1;
            txtlargecheese.Text = larg.ToString();

        }

        private void button16_Click(object sender, EventArgs e)
        {
            larg = int.Parse(txtmediumcheese.Text) + 1;
            txtmediumcheese.Text = larg.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            larg = int.Parse(txtmediumcheese.Text) - 1;
            txtmediumcheese.Text = larg.ToString();
            if (int.Parse(txtmediumcheese.Text) <= 0)
            {
                larg = 0;
                txtmediumcheese.Text = larg.ToString();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            larg = int.Parse(txtsmallcheese.Text) + 1;
            txtsmallcheese.Text = larg.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            larg = int.Parse(txtsmallcheese.Text) - 1;
            txtsmallcheese.Text = larg.ToString();
            if (int.Parse(txtsmallcheese.Text) <= 0)
            {
                larg = 0;
                txtsmallcheese.Text = larg.ToString();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            larg = int.Parse(txtlargemushroom.Text) + 1;
            txtlargemushroom.Text = larg.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            larg = int.Parse(txtlargemushroom.Text) - 1;
            txtlargemushroom.Text = larg.ToString();
            if (int.Parse(txtlargemushroom.Text) <= 0)
            {
                larg = 0;
                txtlargemushroom.Text = larg.ToString();
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            larg = int.Parse(txtmediummushroom.Text) + 1;
            txtmediummushroom.Text = larg.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            larg = int.Parse(txtmediummushroom.Text) - 1;
            txtmediummushroom.Text = larg.ToString();
            if (int.Parse(txtmediummushroom.Text) <= 0)
            {
                larg = 0;
                txtmediummushroom.Text = larg.ToString();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            larg = int.Parse(txtmediummushroom.Text) - 1;
            txtsmallnushroom.Text = larg.ToString();
            if (int.Parse(txtsmallnushroom.Text) <= 0)
            {
                larg = 0;
                txtsmallnushroom.Text = larg.ToString();
            }
        }

        private void txtsmallnushroom_TextChanged(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            larg = int.Parse(txtsmallnushroom.Text) + 1;
            txtsmallnushroom.Text = larg.ToString();
                
        }
    }
}

    






