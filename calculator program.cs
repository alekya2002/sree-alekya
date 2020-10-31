using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int prev;
        private void getdigits(object sender, EventArgs e)
        {
            if (status == true)
            {
                prev = int.Parse(lblscreen.Text);
                lblscreen.Text = "";
            }
            lblscreen.Text += ((Button)sender).Text;
        }


        
        private void getoperator(object sender, EventArgs e)
        {
        }
        string op;
        bool status = false;

        private void getOperator(object sender, EventArgs e)
        {
            op = ((Button)sender).Text;
            status = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if(op=="+")
                    {
                lblscreen.Text = (prev + int.Parse(lblscreen.Text)).ToString();

                      }
            if (op == "-")
            {
                lblscreen.Text = (prev - int.Parse(lblscreen.Text)).ToString();

            }
            if (op == "*")
            {
                lblscreen.Text = (prev * int.Parse(lblscreen.Text)).ToString();

            }
            if (op == "/")
            {
                lblscreen.Text = (prev / int.Parse(lblscreen.Text)).ToString();

            }
            if (op == "%")
            {
                lblscreen.Text = (prev % int.Parse(lblscreen.Text)).ToString();

            }
            status = true;
        }

    }

}

