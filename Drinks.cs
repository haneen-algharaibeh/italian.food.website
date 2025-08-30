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
    public partial class Drinks : Form
    {
        int larg = 0, total = 0;
        public static int sump = 0;
        public Drinks()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void cbwater_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btntotal_Click(object sender, EventArgs e)
        {
            
            int total,water ,fanta,pepci,sprite;
            total = 0;
            water = int.Parse(txtwater.Text) * 1;
            sprite = int.Parse(txtsprite.Text) * 1;
            fanta = int.Parse(txtfanta.Text) * 1;
            pepci = int.Parse(txtpepci.Text) * 1;
            total = water + sprite + fanta + pepci;


            /*
            foreach (Control ctrl in this.Controls)
            {

                if ((ctrl is CheckBox) && ((CheckBox)ctrl).Checked)
                {
                    
                    total += Convert.ToInt32(ctrl.Tag);
                    
                }
             
            }
            */

           txttotal.Text = total.ToString();
           sump = total;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            Total s10 = new Total();
            this.Hide();
            s10.ShowDialog();
        }

        private void btnbreviuos_Click(object sender, EventArgs e)
        {
            Choose_Food s11 = new Choose_Food();
            this.Hide();
            s11.ShowDialog();
        }

        private void Drinks_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            larg = int.Parse(txtwater.Text) + 1;
            txtwater.Text = larg.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            larg = int.Parse(txtwater.Text) - 1;
            txtwater.Text = larg.ToString();
            if (int.Parse(txtwater.Text) <= 0)
            {
                larg = 0;
                txtwater.Text = larg.ToString();
            }

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            larg = int.Parse(txtsprite.Text) + 1;
            txtsprite.Text = larg.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            larg = int.Parse(txtsprite.Text) - 1;
            txtsprite.Text = larg.ToString();
            if (int.Parse(txtsprite.Text) <= 0)
            {
                larg = 0;
                txtsprite.Text = larg.ToString();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            larg = int.Parse(txtfanta.Text) + 1;
            txtfanta.Text = larg.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            larg = int.Parse(txtfanta.Text) - 1;
            txtfanta.Text = larg.ToString();
            if (int.Parse(txtfanta.Text) <= 0)
            {
                larg = 0;
                txtfanta.Text = larg.ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            larg = int.Parse(txtpepci.Text) + 1;
            txtpepci.Text = larg.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            larg = int.Parse(txtpepci.Text) - 1;
            txtpepci.Text = larg.ToString();
            if (int.Parse(txtpepci.Text) <= 0)
            {
                larg = 0;
                txtpepci.Text = larg.ToString();
            }
        }
    }
}
