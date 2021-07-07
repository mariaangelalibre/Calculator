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
        Double num1 , result, num2, store, add , memory = 0;
        String sign = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnarrow_Click(object sender, EventArgs e)
        {
            string l, l1;
            l = lbl.Text;
            if(l.Length >1)
            {
                l1 = l.Remove(l.Length - 1, 1);
                lbl.Text = l1;
            }
            else
            {
                lbl.Text = "0";
            }
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
            if (sign == btnplus.Text)
            {
                result = num1 + Double.Parse(lbl.Text);
                lbl.Text = result.ToString();
                equalsClicked = true;
            }
            else if (sign == btnminus.Text)
            {
                result = num1 - Double.Parse(lbl.Text); ;
                lbl.Text = result.ToString();
                equalsClicked = true;
            }
            else if (sign == btndivide.Text)
            {
                result = num1 / Double.Parse(lbl.Text);
                lbl.Text = result.ToString();
                equalsClicked = true;
            }
            else if (sign == btntimes.Text)
            {
                result = num1 * Double.Parse(lbl.Text);
                lbl.Text = result.ToString();
                equalsClicked = true;
            }
            num1 = Double.Parse(lbl.Text);
            txtbx.Text = "";

        }

        private void operation(object sender, EventArgs e)
        {
            Button btn01 = (Button)sender;
            sign = btn01.Text;
            if (num1 != 0)
            {
                if (operationNotClicked)
                {
                    txtbx.Text = txtbx.Text + " " + lbl.Text + " " + btn01.Text + " ";
                    operationNotClicked = false;
                    if (sign == btnplus.Text)
                    {
                        result = num1 + Double.Parse(lbl.Text);
                        lbl.Text = result.ToString();
                        equalsClicked = true;
                    }
                    else if (sign == btnminus.Text)
                    {
                        result = num1 - Double.Parse(lbl.Text); ;
                        lbl.Text = result.ToString();
                        equalsClicked = true;
                    }
                    else if (sign == btndivide.Text)
                    {
                        result = num1 / Double.Parse(lbl.Text);
                        lbl.Text = result.ToString();
                        equalsClicked = true;
                    }
                    else if (sign == btntimes.Text)
                    {
                        result = num1 * Double.Parse(lbl.Text);
                        lbl.Text = result.ToString();
                        equalsClicked = true;
                    }
                    num1 = Double.Parse(lbl.Text);
                }
                else
                {
                    string text, text1;
                    text = txtbx.Text;
                    text1 = text.Remove(text.Length -2,1);
                    txtbx.Text = text1 + " " + sign;
                }
            }
            else
            {
                if (operationNotClicked)
                {
                    num1 = Double.Parse(lbl.Text);
                    txtbx.Text = txtbx.Text + " " + lbl.Text + " " + btn01.Text + " ";
                    operationNotClicked = false;
                }
                else
                {
                    string text, text1;
                    text = txtbx.Text;
                    text1 = text.Remove(text.Length-2,1);
                    txtbx.Text = text1 + " " + sign;
                }
            }
       //     if (lbl.Text != "0")
       //     {
      ////          txtbx.Text = lbl.Text + " " + btn01.Text + " ";
      //          if (operationNotClicked)
       //         {
       //             operationNotClicked = false;
        //        }
         //   }
         //   else if (lbl.Text == "0")
           // {
            //    txtbx.Text = lbl.Text + " " + btn01.Text + " ";
             //   if (operationNotClicked)
            //    {
            //        operationNotClicked = false;
             //   }
            //}
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
