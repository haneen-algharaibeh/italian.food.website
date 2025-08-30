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
    public partial class Choose_Food : Form
    {
        public Choose_Food()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            Total s13 = new Total();
            this.Hide();
            s13.ShowDialog();
        }

        private void btnbreviuos_Click(object sender, EventArgs e)
        {
            login s2 = new login();
            this.Hide();
            s2.ShowDialog();
        }

        private void btnpizza_Click(object sender, EventArgs e)
        {
            pizza s3 = new pizza();
            s3.ShowDialog();
        }

        private void btnpasta_Click(object sender, EventArgs e)
        {
            Pasta s7 = new Pasta();
            this.Hide();
            s7.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Drinks s9 = new Drinks();
            this.Hide();
            s9.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Choose_Food_Load(object sender, EventArgs e)
        {

        }

        
    }
}
