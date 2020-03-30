using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double memory = 0;
        ArrayList numAndOperatorsEntered = new ArrayList();
        // when true, display will be cleared before any first digit is pressed
        bool newEntryFlag = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void num0_Click(object sender, EventArgs e)
        {
            if (newEntryFlag)
            {
                textBoxDisplay.Clear();
                newEntryFlag = false;
            }
            textBoxDisplay.Text += 0;
            
        }

        private void num1_Click(object sender, EventArgs e)
        {
            if (newEntryFlag)
            {
                textBoxDisplay.Clear();
                newEntryFlag = false;
            }
            textBoxDisplay.Text += 1;
        }

        private void num2_Click(object sender, EventArgs e)
        {
            if (newEntryFlag)
            {
                textBoxDisplay.Clear();
                newEntryFlag = false;
            }
            textBoxDisplay.Text += 2;
        }

        private void num3_Click(object sender, EventArgs e)
        {
            if (newEntryFlag)
            {
                textBoxDisplay.Clear();
                newEntryFlag = false;
            }
            textBoxDisplay.Text += 3;
        }

        private void num4_Click(object sender, EventArgs e)
        {
            if (newEntryFlag)
            {
                textBoxDisplay.Clear();
                newEntryFlag = false;
            }
            textBoxDisplay.Text += 4;
        }

        private void num5_Click(object sender, EventArgs e)
        {
            if (newEntryFlag)
            {
                textBoxDisplay.Clear();
                newEntryFlag = false;
            }
            textBoxDisplay.Text += 5;
        }

        private void num6_Click(object sender, EventArgs e)
        {
            if (newEntryFlag)
            {
                textBoxDisplay.Clear();
                newEntryFlag = false;
            }
            textBoxDisplay.Text += 6;
        }

        private void num7_Click(object sender, EventArgs e)
        {
            if (newEntryFlag)
            {
                textBoxDisplay.Clear();
                newEntryFlag = false;
            }
            textBoxDisplay.Text += 7;
        }

        private void num8_Click(object sender, EventArgs e)
        {
            if (newEntryFlag)
            {
                textBoxDisplay.Clear();
                newEntryFlag = false;
            }
            textBoxDisplay.Text += 8;
        }

        private void num9_Click(object sender, EventArgs e)
        {
            if (newEntryFlag)
            {
                textBoxDisplay.Clear();
                newEntryFlag = false;
            }
            textBoxDisplay.Text += 9;
        }

        private void changeSign_Click(object sender, EventArgs e)
        {

            try
            {
                double num = Convert.ToDouble(textBoxDisplay.Text);
                num *= -1;
                textBoxDisplay.Text = num.ToString();
            }
            catch (Exception)
            {
                return;
            }

        }

        private void clearEntry_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Clear();
            newEntryFlag = true;
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            String s = textBoxDisplay.Text;
            if (s.Length > 1)
            {
                s = s.Substring(0, s.Length - 1);
                textBoxDisplay.Text = s;
            }
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            try
            {
                double d = Convert.ToDouble(textBoxDisplay.Text);
                d = Math.Sqrt(d);
                textBoxDisplay.Text = d.ToString();
                newEntryFlag = true;
            }
            catch (Exception)
            {
                return;
            }
        }

        private void flip_Click(object sender, EventArgs e)
        {
            try
            {
                double d = Convert.ToDouble(textBoxDisplay.Text);
                d = Math.Pow(d, -1);
                textBoxDisplay.Text = d.ToString();
                newEntryFlag = true;
            }
            catch (Exception)
            {
                return;
            }
        }

        private void dot_Click(object sender, EventArgs e)
        {
            try
            {
                String patternPositiveNum = "^[0-9]*$";
                String patternNegativeNum = "^-[0-9]*$";
                String data = textBoxDisplay.Text;
                Match m1 = Regex.Match(data, patternPositiveNum, RegexOptions.None);
                Match m2 = Regex.Match(data, patternNegativeNum, RegexOptions.None);
                if (m1.Success || m2.Success)
                {
                    data += ",";
                }

                textBoxDisplay.Text = data;
            }
            catch (Exception)
            {
                return;
            }
        }

        private void memRecall_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = memory.ToString();
            newEntryFlag = true;
        }

        private void memClear_Click(object sender, EventArgs e)
        {
            memory = 0;
            textBoxMemory.Clear();
        }

        private void memSet_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(textBoxDisplay.Text))
            {
                try
                {
                    memory = Convert.ToDouble(textBoxDisplay.Text);
                    checkMemoryIndicator();
                    newEntryFlag = true;
                }
                catch (Exception)
                {
                    Debug.WriteLine("cannot set memory");
                } 
            }
        }

        private void checkMemoryIndicator()
        {
            if (memory == 0)
            {
                textBoxMemory.Clear();
            } else
            {
                textBoxMemory.Text = "M";
            }
        }

        private void memAdd_Click(object sender, EventArgs e)
        {
            try
            {
                memory += Convert.ToDouble(textBoxDisplay.Text);
                checkMemoryIndicator();
                newEntryFlag = true;
            }
            catch (Exception)
            {
                Debug.WriteLine("cannot add to the memory");
            }
        }

        private void sum_Click(object sender, EventArgs e)
        {
            try
            {
                Double d = Convert.ToDouble(textBoxDisplay.Text);
                numAndOperatorsEntered.Add(d);
                numAndOperatorsEntered.Add("sum");
                newEntryFlag = true;
            }
            catch (Exception)
            {
                Debug.WriteLine("cannot procceed sum button");
            }
        }

        private void sub_Click(object sender, EventArgs e)
        {
            try
            {
                Double d = Convert.ToDouble(textBoxDisplay.Text);
                numAndOperatorsEntered.Add(d);
                numAndOperatorsEntered.Add("sub");
                newEntryFlag = true;
            }
            catch (Exception)
            {
                Debug.WriteLine("cannot procceed substraction button");
            }
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            try
            {
                Double d = Convert.ToDouble(textBoxDisplay.Text);
                numAndOperatorsEntered.Add(d);
                numAndOperatorsEntered.Add("mul");
                newEntryFlag = true;
            }
            catch (Exception)
            {
                Debug.WriteLine("cannot procceed multiply button");
            }
        }

        private void div_Click(object sender, EventArgs e)
        {
            try
            {
                Double d = Convert.ToDouble(textBoxDisplay.Text);
                numAndOperatorsEntered.Add(d);
                numAndOperatorsEntered.Add("div");
                newEntryFlag = true;
            }
            catch (Exception)
            {
                Debug.WriteLine("cannot procceed division button");
            }
        }

        private void res_Click(object sender, EventArgs e)
        {
            try
            {
                Double double1 = 0;
                String operatorCalc = "";
                bool foundDouble1Flag = false;
                bool foundOperatorFlag = false;
                // search for the first double
                for (int i = numAndOperatorsEntered.Count - 1; i >= 0; i--)
                {
                    if (numAndOperatorsEntered[i] is Double)
                    {
                        double1 = (Double)numAndOperatorsEntered[i];
                        foundDouble1Flag = true;
                        // search for the operator
                        // operator should be AFTER first double
                        for (int j = i + 1; j <= numAndOperatorsEntered.Count; j++)
                        {
                            if (numAndOperatorsEntered[j] is String)
                            {
                                operatorCalc = (String)numAndOperatorsEntered[j];
                                foundOperatorFlag = true;
                                break;
                            }
                        }
                        break;
                    }
                }
                if (foundDouble1Flag && foundOperatorFlag)
                {
                    Double double2 = Convert.ToDouble(textBoxDisplay.Text);
                    double res;
                    switch (operatorCalc)
                    {
                        case "sum":
                            res = double1 + double2;
                            break;
                        case "sub":
                            res = double1 - double2;
                            break;
                        case "mul":
                            res = double1 * double2;
                            break;
                        case "div":
                            res = double1 / double2;
                            break;
                        default:
                            return;
                    }
                    textBoxDisplay.Text = res.ToString();
                    newEntryFlag = true;
                }
                
                
            }
            catch (Exception)
            {
                Debug.WriteLine("cannot procceed result button");
            }
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            numAndOperatorsEntered.Clear();
            textBoxDisplay.Clear();
            newEntryFlag = true;
        }

        private void percent_Click(object sender, EventArgs e)
        {
            try
            {
                Double d = 0;
                bool foundDoubleFlag = false;
                // search for the double
                for (int i = numAndOperatorsEntered.Count - 1; i >= 0; i--)
                {
                    if (numAndOperatorsEntered[i] is Double)
                    {
                        d = (Double)numAndOperatorsEntered[i];
                        foundDoubleFlag = true;
                        break;
                    }
                }
                if (foundDoubleFlag)
                {
                    double percent = Convert.ToDouble(textBoxDisplay.Text);
                    double percentage = d * (percent / 100);
                    textBoxDisplay.Text = percentage.ToString();
                    newEntryFlag = true;
                }

            }
            catch (Exception)
            {
                Debug.WriteLine("cannot procceed percent button");
            }
        }
    }
}
