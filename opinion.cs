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
    public partial class opinion : Form
    {
        public opinion()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {





            if (checkedListBox1.SelectedIndex == 0)
            {
                Thanks s13 = new Thanks();
                this.Hide();
                s13.ShowDialog();
            }


            if (checkedListBox1.SelectedIndex == 1)
            {
                Thanks s13 = new Thanks();
                this.Hide();
                s13.ShowDialog();
            }

            if (checkedListBox1.SelectedIndex == 2)
            {
                Thanks s13 = new Thanks();
                this.Hide();
                s13.ShowDialog();
            }

            if (checkedListBox1.SelectedIndex == 3)
            {
                Thanks s13 = new Thanks();
                this.Hide();
                s13.ShowDialog();
            }


            if (checkedListBox1.SelectedIndex == 4)
            {
                Thanks s13 = new Thanks();
                this.Hide();
                s13.ShowDialog();
            }
        }

            
             
           
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void opinion_Load(object sender, EventArgs e)
        {

        }
    }
}
