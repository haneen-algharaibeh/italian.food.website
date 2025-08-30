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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                loginDataSetTableAdapters.upTableAdapter user = new loginDataSetTableAdapters.upTableAdapter();
                loginDataSet.upDataTable dt = user.GetDataBy(txtusername.Text, txtpassword.Text);
                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Correct UserName & Password");
                    Choose_Food s1 = new Choose_Food();
                    this.Hide();

                    s1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Wrong UserName & Password");

                    txtpassword.Text = "";
                    txtusername.Text = "";
                }

            }
            catch(Exception e2)
            {
                MessageBox.Show("ERROR" + e2);
                
            }


        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
              loginDataSetTableAdapters.upTableAdapter user = new loginDataSetTableAdapters.upTableAdapter();
                loginDataSet.upDataTable dt = user.GetDataBy(txtusername.Text, txtpassword.Text);
                if (dt.Rows.Count == 1)
                {
                    Choose_Food s1 = new Choose_Food();
                    this.Hide();

                    s1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("please login ");

                    txtpassword.Text = "";
                    txtusername.Text = "";
                }
            /*
            Choose_Food s1 = new Choose_Food();
            this.Hide();

            s1.ShowDialog();
             */
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
