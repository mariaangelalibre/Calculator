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
        bool operationNotClicked, equalsClicked, mcClicked, mrClicked, msClicked, maddClicked, mminusClicked, negateClicked = false;
        Double num1 , result, num2, store, add , memory, n = 0;
        String sign, sign1, negate, negate1 = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnplusminus_Click(object sender, EventArgs e)
        {
            
            if (((lbl.Text != "0") && (txtbx.Text != "") && (operationNotClicked)) || (txtbx.Text == ""))
            {
                if (lbl.Text.Contains("-"))
                {
                    lbl.Text = lbl.Text.Remove(0, 1);
                }
                else
                {
                    lbl.Text = "-" + lbl.Text;
                }
            }
            else if(!negateClicked)
            {
                negate1 = "negate(" + lbl.Text + ")";
                txtbx.Text = negate + negate1;
                negateClicked = true;
                if (lbl.Text.Contains("-"))
                {
                    lbl.Text = lbl.Text.Remove(0, 1);
                }
                else
                {
                    lbl.Text = "-" + lbl.Text;
                }
            }
            else if (negateClicked)
            {
                negate1 = "negate(" + negate1 + ")";
                txtbx.Text = negate + negate1;
                negateClicked = true;
                if (lbl.Text.Contains("-"))
                {
                    lbl.Text = lbl.Text.Remove(0, 1);
                }
                else
                {
                    lbl.Text = "-" + lbl.Text;
                }
            }
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
            negate = "";
            negate1 = "";
        }

        private void numbtns(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if ((msClicked) || (mrClicked) || (mminusClicked) || (mcClicked) || (maddClicked))
            {
                mcClicked = false;
                mrClicked = false;
                msClicked = false;
                maddClicked = false;
                mminusClicked = false;
                lbl.Text = btn.Text;
            }
            else if (lbl.Text == "0")
            {
                operationNotClicked = true;
                lbl.Text = btn.Text;
            }

            else if (equalsClicked)
            {
                operationNotClicked = true;
                lbl.Text = btn.Text;
                equalsClicked = false;
            }

            else if (!operationNotClicked)
            {
                sign1 = txtbx.Text.Substring(txtbx.TextLength - 1, 1);
                lbl.Text = btn.Text;
                num2 = Double.Parse(lbl.Text);
                operationNotClicked = true;
            }
            else if (negateClicked)
            {
                num2
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
            if (equalsClicked)
            {
                if (sign == btnplus.Text)
                {
                    result += num2;
                    lbl.Text = result.ToString();
                }
                else if (sign == btnminus.Text)
                {
                    result -= num2;
                    lbl.Text = result.ToString();
                }
                else if (sign == btndivide.Text)
                {
                    result /= num2;
                    lbl.Text = result.ToString();
                }
                else if (sign == btntimes.Text)
                {
                    result *= num2;
                    lbl.Text = result.ToString();
                }
            }
            else
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
            }
            
            
            num1 = Double.Parse(lbl.Text);
            txtbx.Text = "";

        }

        private void operation(object sender, EventArgs e)
        {
            Button btn01 = (Button)sender;
            negate = lbl.Text + btn01.Text;
            sign = btn01.Text;
            if (num1 != 0)
            {
                if (operationNotClicked)
                {
                    txtbx.Text = txtbx.Text + " " + lbl.Text + " " + btn01.Text;
                    operationNotClicked = false;
                    if (sign1 == btnplus.Text)
                    {
                        result = num1 + Double.Parse(lbl.Text);
                        lbl.Text = result.ToString();
                    }
                    else if (sign1 == btnminus.Text)
                    {
                        result = num1 - Double.Parse(lbl.Text); ;
                        lbl.Text = result.ToString();
                    }
                    else if (sign1 == btndivide.Text)
                    {
                        result = num1 / Double.Parse(lbl.Text);
                        lbl.Text = result.ToString();
                    }
                    else if (sign1 == btntimes.Text)
                    {
                        result = num1 * Double.Parse(lbl.Text);
                        lbl.Text = result.ToString();
                    }
                    num1 = Double.Parse(lbl.Text);
                }
                else
                {
                    string text, text1;
                    text = txtbx.Text;
                    if (text.Length > 1)
                    {
                        text1 = text.Remove(text.Length - 1, 1);
                        txtbx.Text = text1 + sign;
                    }
                }
            }
            else
            {
                if (operationNotClicked)
                {
                    num1 = Double.Parse(lbl.Text);
                    txtbx.Text = txtbx.Text + " " + lbl.Text + " " + btn01.Text;
                    operationNotClicked = false;
                }
                else
                {
                    string text, text1;
                    text = txtbx.Text;
                    if (text.Length > 1)
                    {
                        text1 = text.Remove(text.Length - 1, 1);
                        txtbx.Text = text1 + sign;
                    }
                }
            }
        }

        private void btnms_Click(object sender, EventArgs e)
        {
            msClicked = true;
            if (lbl.Text != "0")
            {
                lblm.Visible = true;
                store = Double.Parse(lbl.Text);
            }
            else
            {
                lblm.Visible = false;
                store = 0;
            }
        }

        private void btnmplus_Click(object sender, EventArgs e)
        {
            maddClicked = true;
            if (!lblm.Visible)
            {
                btnms.PerformClick();
            }
            else if (lblm.Visible)
            {
                if (mminusClicked)
                {
                    lblm.Visible = false;
                }
            }
            else
            {
                memory = Convert.ToDouble(store);
                add = memory + Double.Parse(lbl.Text);
                store = add;
                maddClicked = true;
            }
        }

        private void btnmr_Click(object sender, EventArgs e)
        {
            mrClicked = true;
            if (lblm.Visible)
            {
                lbl.Text = store.ToString();
            }
            else
            {
                lbl.Text = "0";
            }
        } 

        private void btnmminus_Click(object sender, EventArgs e)
        {
            mminusClicked = true;
            if ((!lblm.Visible) && (lbl.Text != "0"))
            {
                lblm.Visible = true;
                store = Double.Parse("-"+lbl.Text);
            }
            else if ((lblm.Visible) && ((maddClicked) || (msClicked) || (mrClicked)))
            {
                lblm.Visible = false;
            }

            else
            {
                memory = Convert.ToDouble(store);
                add = memory - Double.Parse(lbl.Text);
                store = add;
                mminusClicked = true;
            }
            
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
