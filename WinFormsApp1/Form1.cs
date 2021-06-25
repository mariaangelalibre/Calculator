using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        bool arithmeticClicked = false;
        Double num1 = 0;
        Double result = 0;
        String sign = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnce_Click(object sender, EventArgs e)
        {
            lbl.Text = "0";
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            lbl.Text = "0";
            txtbx.Text = "";
        }

        private void numbtns(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (lbl.Text == "0")
            {
                lbl.Text = btn.Text;
            }
            else if (arithmeticClicked)
            {
                lbl.Text = btn.Text;
                arithmeticClicked = false;
            }
            else if ((txtbx.Text == "")&&(lbl.Text != "0"))
            {
                lbl.Text = btn.Text;
            }
            else
            {
                lbl.Text = lbl.Text + btn.Text;
            }
        }

        private void btndecimal_Click(object sender, EventArgs e)
        {
            if (!lbl.Text.Contains("."))
            {
                lbl.Text = lbl.Text + btndecimal.Text;
            }
        }

        private void arithmetic(object sender, EventArgs e)
        {
            Button btn1 = (Button)sender;
            num1 = Double.Parse(lbl.Text);
            arithmeticClicked = true;
            if (arithmeticClicked)
            { 
                //string last = txtbx.Text.Substring(txtbx.TextLength - 1, 1);
                //if ((last != "+")&& (last != "-")&& (last != "*") && (last != "/"))
                txtbx.Text = txtbx.Text + lbl.Text + " " + btn1.Text + " ";
                sign = btn1.Text;
            }
             
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            if (sign == btnplus.Text)
            {
                result = num1 + Double.Parse(lbl.Text);
                lbl.Text = result.ToString();
                txtbx.Text = "";
            }
            else if (sign == btnminus.Text)
            {
                result = num1 - Double.Parse(lbl.Text);
                lbl.Text = result.ToString();
                txtbx.Text = "";
            }
            else if (sign == btndivide.Text)
            {
                result = num1 / Double.Parse(lbl.Text);
                lbl.Text = result.ToString();
                txtbx.Text = "";
            }
            else if (sign == btntimes.Text)
            {
                result = num1 * Double.Parse(lbl.Text);
                lbl.Text = result.ToString();
                txtbx.Text = "";
            }
        }
    }
}
