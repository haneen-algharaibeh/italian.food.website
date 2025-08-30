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
    public partial class Total : Form
    {
        public Total()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0;
            sum = pizza.sump + Pasta.sump + Drinks.sump;
            txtTotal.Text = sum.ToString();




            MessageBox.Show("TOTAL :   " + checkedListBox1.SelectedItem + "   " + txtTotal.Text + "JD "+"  Taxes Included");
            opinion s12 = new opinion();
            this.Hide();
            s12.ShowDialog();

            


        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {

        }

        private void btnbreviuos_Click(object sender, EventArgs e)
        {

        }

        private void Total_Load(object sender, EventArgs e)
        {
            btnTotal.BackColor = Color.DarkOrange;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
