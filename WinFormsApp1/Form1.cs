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
        bool operationNotClicked, equalsClicked, mcClicked, mrClicked, msClicked, maddClicked, mminusClicked = false;
        Double num1 , result, num2, store, add , memory;
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
            num1 = 0;
            num2 = 0;
            result = 0;
        }

        private void numbtns(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (lbl.Text == "0")
            {
                operationNotClicked = true;
                lbl.Text = btn.Text;
            }
            else if (!operationNotClicked)
            {
                lbl.Text = btn.Text;
                operationNotClicked = true;
            }
            else if (equalsClicked)
            {
                operationNotClicked = true;
                lbl.Text = btn.Text;
                equalsClicked = false;
            }
            else if ((msClicked) || (mrClicked) || (mminusClicked) || (mcClicked) || (maddClicked))
            {
                lbl.Text = btn.Text;
                mcClicked = false;
                mrClicked = false; 
                msClicked = false; 
                maddClicked = false; 
                mminusClicked = false;
            }

            else
            {
                operationNotClicked = true;
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


        private void btnequal_Click(object sender, EventArgs e)
        {
         // if (equalsClicked)
          //{
         ///    if (sign == btnplus.Text)
         //     {
          //        num2 = result - num1;
           //       result += num2;
         //         lbl.Text = result.ToString();
          //        txtbx.Text = "";
          //    }
          //    else if (sign == btnminus.Text)
           //   {
           ////   result -= num2;
           ///      lbl.Text = result.ToString();
           //       txtbx.Text = "";
             // }
             // else if (sign == btndivide.Text)
              //{
           //       result /= num2;
           //       lbl.Text = result.ToString();
            //      txtbx.Text = "";
              //}
           //   else if (sign == btntimes.Text)
             // {
        //          result *= num2;
          //        lbl.Text = result.ToString();
            //      txtbx.Text = "";
              //}
         // }
            if (sign == btnplus.Text)
            {
                num2 = Double.Parse(lbl.Text);
                result = num1 + num2;
                lbl.Text = result.ToString();
                txtbx.Text = "";
                equalsClicked = true;
            }
            else if (sign == btnminus.Text)
            {
                num2 = Double.Parse(lbl.Text);
                result = num1 - num2;
                lbl.Text = result.ToString();
                txtbx.Text = "";
                equalsClicked = true;
            }
            else if (sign == btndivide.Text)
            {
                num2 = Double.Parse(lbl.Text);
                result = num1 / num2;
                lbl.Text = result.ToString();
                txtbx.Text = "";
                equalsClicked = true;
            }
            else if (sign == btntimes.Text)
            {
                num2 = Double.Parse(lbl.Text);
                result = num1 * num2;
                lbl.Text = result.ToString();
                txtbx.Text = "";
                equalsClicked = true;
            }

        }

        private void operation(object sender, EventArgs e)
        {
            Button btn01 = (Button)sender;
            num1 = Double.Parse(lbl.Text);
            sign = btn01.Text;
            //else if ((txtbx.Text.Substring(txtbx.TextLength - 1, 1) == "+" || (txtbx.Text.Substring(txtbx.TextLength - 1, 1) == "-" || (txtbx.Text.Substring(txtbx.TextLength - 1, 1) == "/" || (txtbx.Text.Substring(txtbx.TextLength - 1, 1) == "*")))))
            //{
            //string text = txtbx.Text;
            //string last = text.Remove(txtbx.TextLength -1, 1);
            //}
            

            if (lbl.Text != "0")
            {
                if((num1 != 0) && (num1 != 0))
                {
                    txtbx.Text = txtbx.Text + " " + lbl.Text + " " + btn01.Text + " ";
                }

                txtbx.Text = txtbx.Text + " " + lbl.Text + " " + btn01.Text + " ";
                if (operationNotClicked)
                {
                    operationNotClicked = false;
                }
            }
            else if (lbl.Text == "0")
            {
                txtbx.Text = txtbx.Text + " " + lbl.Text + " " + btn01.Text + " ";
                if (operationNotClicked)
                {
                    operationNotClicked = false;
                }
            }
            
            


            }

        private void btnms_Click(object sender, EventArgs e)
        {
            if (lbl.Text != "0")
            {
                lblm.Visible = true;
                store = Double.Parse(lbl.Text);
            }
        }
        private void btnmplus_Click(object sender, EventArgs e)
        {
            memory = Convert.ToDouble(store);
            add = memory + Double.Parse(lbl.Text);
            store = add;
            maddClicked = true;
        }

        private void btnmr_Click(object sender, EventArgs e)
        {
            lbl.Text = store.ToString();
            mrClicked = true;
        } 

        private void btnmminus_Click(object sender, EventArgs e)
        {
            memory = Convert.ToDouble(store);
            add = memory - Double.Parse(lbl.Text);
            store = add;
            mminusClicked = true;
        }

        private void btnmc_Click(object sender, EventArgs e)
        {
            mcClicked = true;
            lblm.Visible = false;
            store = 0;
            add = 0;
            memory = 0;
        }
    }
}
