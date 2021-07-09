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
        bool operationNotClicked, equalsClicked, mcClicked, mrClicked, msClicked, maddClicked, mminusClicked, negateClicked, sqrtClicked, reciprocalClicked, percentClicked = false;
        Double num1 , result, num2, store, add , memory, n = 0;
        String sign, sign1, negate, negate1, sqrt, sqrt1, recip, recip1, percent, percent1 = "";

        private void btnpercent_Click(object sender, EventArgs e)
        {
            operationNotClicked = true;
            if(txtbx.Text == "")
            {
                lbl.Text = "0";
                txtbx.Text = "0";
            }
            else if (!percentClicked)
            {
                n = Double.Parse(lbl.Text) / 100;
                percent1 = (Double.Parse(lbl.Text) * ((Double.Parse(lbl.Text)) / 100)).ToString();
                txtbx.Text = percent + percent1;
                lbl.Text = percent1;
                num2 = Double.Parse(lbl.Text);
                percentClicked = true;
            }
            else if (percentClicked)
            {
                percent1 = (Double.Parse(lbl.Text) * n).ToString();
                txtbx.Text = percent + percent1;
                lbl.Text = percent1;
                num2 = Double.Parse(lbl.Text);
            }
        }

        private void btnfraction_Click(object sender, EventArgs e)
        {
            operationNotClicked = true;
            if (!reciprocalClicked)
            {
                recip1 = "reciprocal(" + lbl.Text + ")";
                txtbx.Text = recip + recip1;
                reciprocalClicked = true;
                lbl.Text = (1/Double.Parse(lbl.Text)).ToString();
                num2 = Double.Parse(lbl.Text);
            }
            else if (reciprocalClicked)
            {
                recip1 = "reciprocal(" + recip1 + ")";
                txtbx.Text = recip + recip1;
                lbl.Text = (1 / Double.Parse(lbl.Text)).ToString();
                num2 = Double.Parse(lbl.Text);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void btnsqr_Click(object sender, EventArgs e)
        {
            operationNotClicked = true;
            if (!sqrtClicked)
            {
                sqrt1 = "sqrt(" + lbl.Text + ")";
                txtbx.Text = sqrt + sqrt1;
                sqrtClicked = true;
                lbl.Text = (Math.Sqrt(Double.Parse(lbl.Text))).ToString();
                num2 = Double.Parse(lbl.Text);
            }
            else if (sqrtClicked)
            {
                sqrt1 = "sqrt(" + sqrt1 + ")";
                txtbx.Text = sqrt + sqrt1;
                lbl.Text = (Math.Sqrt(Double.Parse(lbl.Text))).ToString();
                num2 = Double.Parse(lbl.Text);
            }
        }
            private void btnplusminus_Click(object sender, EventArgs e)
        {
            operationNotClicked = true;
            if (((lbl.Text != "0") && (txtbx.Text != "") && (!operationNotClicked)) || (txtbx.Text == ""))
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
                sign1 = txtbx.Text.Substring(txtbx.TextLength - 1, 1);
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
                num2 = Double.Parse(lbl.Text);
            }
            else if (negateClicked)
            {
                negate1 = "negate(" + negate1 + ")";
                txtbx.Text = negate + negate1;
                if (lbl.Text.Contains("-"))
                {
                    lbl.Text = lbl.Text.Remove(0, 1);
                }
                else
                {
                    lbl.Text = "-" + lbl.Text;
                }
                num2 = Double.Parse(lbl.Text);
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
            if (txtbx.Text.Contains("negate"))
            {
                txtbx.Text = negate;
            }
            negateClicked = false;
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            lbl.Text = "0";
            txtbx.Text = "";
            num1 = 0;
            num2 = 0;
            result = 0;
            negateClicked = false;
            negate1 = "";
            recip = "";
            sqrt = "";
            percent = "";
        }

        private void numbtns(object sender, EventArgs e)
        {
            sqrtClicked = false;
            negateClicked = false;
            reciprocalClicked = false;
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
            else if (equalsClicked)
            {
                operationNotClicked = true;
                lbl.Text = btn.Text;
                equalsClicked = false;
            }
            else if(percentClicked)
            {
                txtbx.Text = "";
                percentClicked = false;
                operationNotClicked = true;
                lbl.Text = btn.Text;
            }
            else if (lbl.Text == "0")
            {
                operationNotClicked = true;
                lbl.Text = btn.Text;
            }
            else if (!operationNotClicked)
            {
                sign1 = txtbx.Text.Substring(txtbx.TextLength - 1, 1);
                lbl.Text = btn.Text;
                num2 = Double.Parse(lbl.Text);
                operationNotClicked = true;
            }
            else
            {
                operationNotClicked = true;
                lbl.Text = lbl.Text + btn.Text;
            }
        }

        private void btndecimal_Click(object sender, EventArgs e)
        {
            negateClicked = false;
            if (!lbl.Text.Contains("."))
            {
                lbl.Text = lbl.Text + btndecimal.Text;
            }
        }
        private void btnequal_Click(object sender, EventArgs e)
        {
            negateClicked = false;
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
            if ((txtbx.Text.Contains("negate")) || (txtbx.Text.Contains("sqrt")) || (txtbx.Text.Contains("reciprocal")))
            {
                if (sign == btnplus.Text)
                {
                    result = num1 + num2;
                    lbl.Text = result.ToString();
                    equalsClicked = true;
                }
                else if (sign == btnminus.Text)
                {
                   result = num1 - num2; 
                   lbl.Text = result.ToString();
                    equalsClicked = true;
                }
                else if (sign == btndivide.Text)
                {
                    result = num1 / num2;
                    lbl.Text = result.ToString();
                    equalsClicked = true;
                }
                 else if (sign == btntimes.Text)
                {
                    result = num1 * num2;
                    lbl.Text = result.ToString();
                    equalsClicked = true;
                }
            }
            else
            {
                if (sign == btnplus.Text)
                {
                    result = num1 + num2;
                    lbl.Text = result.ToString();
                    equalsClicked = true;
                }
                else if (sign == btnminus.Text)
                {
                    result = num1 - num2; ;
                    lbl.Text = result.ToString();
                    equalsClicked = true;
                }
                else if (sign == btndivide.Text)
                {
                    result = num1 / num2;
                    lbl.Text = result.ToString();
                    equalsClicked = true;
                }
                else if (sign == btntimes.Text)
                {
                    result = num1 * num2;
                    lbl.Text = result.ToString();
                    equalsClicked = true;
                }
            }
            num1 = Double.Parse(lbl.Text);
            txtbx.Text = "";
        }

        private void operation(object sender, EventArgs e)
        {
            negateClicked = false;
            sqrtClicked = false;
            reciprocalClicked = false;
            Button btn01 = (Button)sender;
            negate = lbl.Text + " " + btn01.Text;
            sqrt = lbl.Text + " " + btn01.Text;
            recip = lbl.Text + " " + btn01.Text;
            percent = lbl.Text + " " + btn01.Text;
            sign = btn01.Text;
            if (num1 != 0)
            { 
                if (txtbx.Text.Contains("negate")) 
                {
                    if (!operationNotClicked)
                    {
                        string last = txtbx.Text.Substring(txtbx.TextLength - 1, 1);
                        if ((last == "+") || (last == "-") || (last == "*") || (last == "/"))
                        {
                            string text, text1;
                            text = txtbx.Text;
                            text1 = text.Remove(text.Length - 1, 1);
                            txtbx.Text = text1 + sign;
                        }
                    }
                    else
                    {
                        txtbx.Text = txtbx.Text + " " + btn01.Text;
                    }
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
                     operationNotClicked = false;
                }
                else if (operationNotClicked)
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
                else if (!operationNotClicked)
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
            memory = Convert.ToDouble(store);
            add = memory + Double.Parse(lbl.Text);
            store = add;
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
            negateClicked = false;
            mcClicked = true;
            lblm.Visible = false;
            store = 0;
            add = 0;
            memory = 0;
        }
    }
}
