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
    public partial class Pasta : Form
    {
        int larg = 0;
        public static  int sump = 0;
        int total = 0;
        
        public Pasta()
        {
            InitializeComponent();
        }

        private void btnbreviuos_Click(object sender, EventArgs e)
        {
            Choose_Food s5 = new Choose_Food();
            this.Hide();
            s5.ShowDialog();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            Total s6 = new Total();
            this.Hide();
            s6.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           



            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            

        }

        private void btna_Click(object sender, EventArgs e)
        {
          


        }

        private void button3_Click(object sender, EventArgs e)
        {
            int total , crbonara , futtucceni , arrbiata , napoli;
            total = 0;

            crbonara = int.Parse(txtpennecrboara.Text) * 4;

            futtucceni = int.Parse(txtfuttuccinealfrado.Text) * 5;
            arrbiata = int.Parse(txtpennearrbiata.Text) * 2;
            napoli = int.Parse(txtspaghettinapoli.Text) * 3;
            total = futtucceni + arrbiata + napoli + crbonara;
            txttotal.Text = total.ToString();

            sump = total;
            

            /*
            
            int crbonara, spaghetti, arrbiata, futtuccine, result;
            crbonara = 4;
            spaghetti = 3;
            arrbiata = 2;
            futtuccine = 5;
            result = 0;


            //if penne crborata checked
            if (cbcrbonara.Checked )
            {
                result = crbonara;
                txttotal.Text = result.ToString();
            }
                

            if (cbnapoli.Checked ) // if spaghetti napoli checked
            {
                result = spaghetti;
                txttotal.Text = result.ToString();

            }

            if (cbarrabbiata.Checked) // if penne arabiata checked
            {
                result = arrbiata;
                txttotal.Text = result.ToString();
            }

            if (cbfutuccine.Checked) // if penne futtuccine checked
            {
                result = futtuccine;
                txttotal.Text = result.ToString();
            }

            //...............................


            if (cbcrbonara.Checked && cbarrabbiata.Checked) //if penne crborata + penne arabiata checked
            
            {
                result = crbonara + arrbiata ;
                txttotal.Text = result.ToString();
                //txttotal.Clear();

            }

            if (cbcrbonara.Checked && cbfutuccine.Checked) //if penne crbomara + ffutuccine checked
            {
                result = crbonara + futtuccine;
                txttotal.Text = result.ToString();
            }


            if (cbcrbonara.Checked && cbnapoli.Checked) //if penne crbomara + spaghetti nepoli checked
            {
                result = crbonara + spaghetti;
                txttotal.Text = result.ToString();
            }


            // ...................
            
            
            

            if (cbnapoli.Checked && cbfutuccine.Checked) // if spaghetti napoli + ffutuccine checked
            {
                result = spaghetti + futtuccine;
                txttotal.Text = result.ToString();
            }
            
            //.............
            
            if (cbarrabbiata.Checked && cbfutuccine.Checked) // if enne arabiata + ffutuccine checked
            {
                result = arrbiata + futtuccine;
                txttotal.Text = result.ToString();
            }
            //..........
            
            if (cbcrbonara.Checked && cbcrbonara.Checked && cbfutuccine.Checked && cbarrabbiata.Checked) // all of them checked
            {
                result = crbonara + spaghetti + arrbiata + futtuccine;
                txttotal.Text = result.ToString();
            }
            //.........
            
            if (cbcrbonara.Checked && cbnapoli.Checked && cbarrabbiata.Checked) // 
            {
                result = crbonara + spaghetti + arrbiata ;
                txttotal.Text = result.ToString();
            }
            

            if (cbcrbonara.Checked && cbfutuccine.Checked && cbarrabbiata.Checked) // 
            {
                result = crbonara +  arrbiata + futtuccine;
                txttotal.Text = result.ToString();
            }
            
            if ( cbnapoli.Checked && cbfutuccine.Checked && cbarrabbiata.Checked)
            {
                result = spaghetti + arrbiata + futtuccine;
                txttotal.Text = result.ToString();
            }
            if (cbcrbonara.Checked && cbfutuccine.Checked && cbnapoli.Checked) // 
            {
                result = crbonara + spaghetti + futtuccine;
                txttotal.Text = result.ToString();
            }
                
            

            foreach (Control ctrl in this.Controls)
            {

                if ((ctrl is CheckBox) && ((CheckBox)ctrl).Checked)
                {
                    
                    total += Convert.ToInt32(ctrl.Tag);
                }
            }

            */







        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Pasta_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            larg = int.Parse(txtpennecrboara.Text) - 1;
            txtpennecrboara.Text = larg.ToString();
            if (int.Parse(txtpennecrboara.Text) <= 0)
            {
                larg = 0;
                txtpennecrboara.Text = larg.ToString();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            larg = int.Parse(txtpennecrboara.Text) + 1;
            txtpennecrboara.Text = larg.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            larg = int.Parse(txtpennearrbiata.Text) - 1;
            txtspaghettinapoli.Text = larg.ToString();
            if (int.Parse(txtspaghettinapoli.Text) <= 0)
            {
                larg = 0;
                txtspaghettinapoli.Text = larg.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            larg = int.Parse(txtspaghettinapoli.Text) + 1;
            txtspaghettinapoli.Text = larg.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            larg = int.Parse(txtpennearrbiata.Text) + 1;
            txtpennearrbiata.Text = larg.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            larg = int.Parse(txtpennearrbiata.Text) - 1;
            txtpennearrbiata.Text = larg.ToString();
            if (int.Parse(txtpennearrbiata.Text) <= 0)
            {
                larg = 0;
                txtpennearrbiata.Text = larg.ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            larg = int.Parse(txtfuttuccinealfrado.Text) + 1;
            txtfuttuccinealfrado.Text = larg.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            larg = int.Parse(txtfuttuccinealfrado.Text) - 1;
            txtfuttuccinealfrado.Text = larg.ToString();
            if (int.Parse(txtfuttuccinealfrado.Text) <= 0)
            {
                larg = 0;
                txtfuttuccinealfrado.Text = larg.ToString();
            }
        }
    }
}
