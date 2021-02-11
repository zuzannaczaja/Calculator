using System;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Globalization;

namespace Calculator
{
    public partial class Calculator : Form
    {
        SpeechSynthesizer speech = new SpeechSynthesizer();
        public Calculator()
        {
            InitializeComponent();
            this.Text = "Calculator";
            textBoxResult.Text = "0";

            speech.SetOutputToDefaultAudioDevice();
            speech.SelectVoiceByHints(VoiceGender.Neutral, VoiceAge.NotSet, 0, CultureInfo.GetCultureInfo("en-en"));
        }

        private string value = "0";
        private double result = 0;
        private string selectedOperation;
        private bool isNegative = false;

        private void btnPlus_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
            selectedOperation = "+";
            result = result + double.Parse(value);
            value = "0";
            speech.SpeakAsync("Plus");
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
            selectedOperation = "-";
            if (double.Parse(value) < 0 || result < 0)
            {
                result = result - double.Parse(value);
                if(isNegative == true)
                {
                    result = result * -1;
                }
            }
            else if (double.Parse(value) > 0 || double.Parse(value) == 0)
            {
                result = result + double.Parse(value);
            }
            value = "0";
            speech.SpeakAsync("Subtract");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
            selectedOperation = "*";

            if(result == 0)
            {
                result = double.Parse(value);
            } else if (double.Parse(value) != 0)
            {
                result = result * double.Parse(value);
            } 
            value = "0";
            speech.SpeakAsync("Multiply");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            selectedOperation = "/";

            if (result == 0 && double.Parse(value) != 0)
            {
                result = double.Parse(value);
            } else if (result != 0 && double.Parse(value) != 0)
            {
                result = result / double.Parse(value);
            } else if (result == 0 && double.Parse(value) == 0)
            {
                DialogResult result = MessageBox.Show("You cannot divide by 0 !", "Error", MessageBoxButtons.OK);
            }

            value = "0";

            speech.SpeakAsync("Divide by");
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if(selectedOperation != null)
            {             
                if (selectedOperation.Equals("+"))
                {
                    result = result + double.Parse(value);
                    textBoxResult.Text = result.ToString();
                }
                else if (selectedOperation.Equals("-"))
                {
                    if (double.Parse(value) < 0 )
                    {
                        result = result + double.Parse(value);

                    } else if (double.Parse(value) > 0 || double.Parse(value) == 0 || result < 0)
                    {
                        result = result - double.Parse(value);
                    }
                    textBoxResult.Text = result.ToString();
                }
                else if (selectedOperation.Equals("*"))
                {
                    result = result * double.Parse(value);
                    textBoxResult.Text = result.ToString();
                }
                else if (selectedOperation.Equals("/"))
                {
                    if (double.Parse(value) != 0)
                    {
                        result = Math.Round(result / double.Parse(value) , 10);
                    } 
                    textBoxResult.Text = result.ToString();
                }

                if(double.Parse(textBoxResult.Text) < 0)
                {
                    textBoxResult.Text = textBoxResult.Text.Replace("-", "");
                    textBoxResult.Text = textBoxResult.Text.Insert(textBoxResult.Text.Length, "-");
                }

                value = Convert.ToString("0");
                isNegative = false;
                speech.SpeakAsync("The result is " + textBoxResult.Text);
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "0")
            {
                textBoxResult.Text = "1";
            }
            else
            {
                textBoxResult.Text = textBoxResult.Text + "1";
            }
            value = value + "1";
            speech.SpeakAsync("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBoxResult.Text == "0")
            {
                textBoxResult.Text = "2";
            } else
            {
                textBoxResult.Text = textBoxResult.Text + "2";
            }
            value = value + "2";
            speech.SpeakAsync("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "0")
            {
                textBoxResult.Text = "3";
            }
            else
            {
                textBoxResult.Text = textBoxResult.Text + "3";
            }
            value = value + "3";
            speech.SpeakAsync("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "0")
            {
                textBoxResult.Text = "4";
            }
            else
            {
                textBoxResult.Text = textBoxResult.Text + "4";
            }
            value = value + "4";
            speech.SpeakAsync("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "0")
            {
                textBoxResult.Text = "5";
            }
            else
            {
                textBoxResult.Text = textBoxResult.Text + "5";
            }
            value = value + "5";
            speech.SpeakAsync("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "0")
            {
                textBoxResult.Text = "6";
            }
            else
            {
                textBoxResult.Text = textBoxResult.Text + "6";
            }
            value = value + "6";
            speech.SpeakAsync("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "0")
            {
                textBoxResult.Text = "7";
            }
            else
            {
                textBoxResult.Text = textBoxResult.Text + "7";
            }
            value = value + "7";
            speech.SpeakAsync("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "0")
            {
                textBoxResult.Text = "8";
            }
            else
            {
                textBoxResult.Text = textBoxResult.Text + "8";
            }
            value = value + "8";
            speech.SpeakAsync("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "0")
            {
                textBoxResult.Text = "9";
            }
            else
            {
                textBoxResult.Text = textBoxResult.Text + "9";
            }
            value = value + "9";
            speech.SpeakAsync("9");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "0")
            {
                textBoxResult.Text = "0";
            }
            else
            {
                textBoxResult.Text = textBoxResult.Text + "0";
            }
            value = value + "0";
            speech.SpeakAsync("0");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            isNegative = false;
            value = "0";
            textBoxResult.Text = "0";
            result = 0;
            speech.SpeakAsync("Clear");
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            if(double.Parse(value) != 0)
            {
                result = 1 / double.Parse(value);
            } else
            {
                result = 1 / result;
            }
            
            textBoxResult.Text = result.ToString();
            speech.SpeakAsync("The reverse of the number is " + textBoxResult.Text);
        }

        private void btnIsNegative_Click(object sender, EventArgs e)
        {
            if(isNegative == false)
            {
                if (value != "0")
                {
                    value = Convert.ToString(double.Parse(value) * (-1));
                    textBoxResult.Text = textBoxResult.Text.Insert(textBoxResult.Text.Length, "-");
                    isNegative = true;
                }
                if (result != 0)
                {
                    if (textBoxResult.Text.Contains("-"))
                    {
                        value = value.Replace("-", "");
                        result = result * -1;
                        textBoxResult.Text = textBoxResult.Text.Replace("-", "");
                        isNegative = false;
                    }
                    if (!textBoxResult.Text.Contains("-"))
                    {
                        result = result * -1;
                        textBoxResult.Text = textBoxResult.Text.Insert(textBoxResult.Text.Length, "-");
                        isNegative = true;
                    }
                }
            } else
            {
                value = value.Replace("-", "");
                textBoxResult.Text = textBoxResult.Text.Replace("-", "");
                isNegative = false;
            }
            speech.SpeakAsync("Reverse sign");
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            if(double.Parse(textBoxResult.Text) != 0)
            {
                speech.SpeakAsync(textBoxResult.Text + " squared is");
                textBoxResult.Text = Convert.ToString(double.Parse(textBoxResult.Text) * double.Parse(textBoxResult.Text));
                result = double.Parse(textBoxResult.Text);
                speech.SpeakAsync(textBoxResult.Text);
            }
        }

        private void btnRoot_Click(object sender, EventArgs e)
        {
            if (double.Parse(textBoxResult.Text) != 0)
            {
                speech.SpeakAsync("the square root of " + textBoxResult.Text+" is");
                textBoxResult.Text = Convert.ToString(Math.Round(Math.Sqrt(double.Parse(textBoxResult.Text)), 10));
                result = double.Parse(textBoxResult.Text);
                speech.SpeakAsync(textBoxResult.Text);
            }
        }

        private void btnClearLastDigit_Click(object sender, EventArgs e)
        {
            if(double.Parse(textBoxResult.Text) != 0)
            {
                textBoxResult.Text = textBoxResult.Text.Substring(0,textBoxResult.Text.Length - 1);
                value = value.Substring(0,value.Length - 1);
                speech.SpeakAsync("Clear last digit");
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            if (double.Parse(textBoxResult.Text) != 0)
            {
                textBoxResult.Text = "0";
                value = "0";
                speech.SpeakAsync("Clear the last number");
            }
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            if(result == 0)
            {
                textBoxResult.Text = "0";
                value = "0";
            } else
            {
                if (selectedOperation != null)
                {
                    if (selectedOperation.Equals("+"))
                    {
                        result = result + (Math.Round((double)(result * (double.Parse(value)/100)), 10));
                        textBoxResult.Text = result.ToString();
                    }
                    else if (selectedOperation.Equals("-"))
                    {
                        if (result < 0)
                        {
                            result = result + (Math.Round((double)(result * (double.Parse(value) / 100)), 10));
                        }
                        else if (result > 0 || result == 0)
                        {
                            result = result - (Math.Round((double)(result * (double.Parse(value) / 100)), 10));
                            result = result * -1;
                        }
                        textBoxResult.Text = result.ToString();
                    }
                    else if (selectedOperation.Equals("*"))
                    {
                        if (double.Parse(value) != 0)
                        {
                            result = (Math.Round((double)(result * (double.Parse(value) / 100)), 10));
                        }
                        textBoxResult.Text = result.ToString();
                    }
                    else if (selectedOperation.Equals("/"))
                    {
                        if (double.Parse(value) != 0)
                        {
                            result = (Math.Round((double)(result / (double.Parse(value) / 100)), 10));
                        }
                        textBoxResult.Text = result.ToString();
                    }
                    if (double.Parse(textBoxResult.Text) < 0)
                    {
                        textBoxResult.Text = textBoxResult.Text.Replace("-", "");
                        textBoxResult.Text = textBoxResult.Text.Insert(textBoxResult.Text.Length, "-");
                    }
                    isNegative = false;
                    selectedOperation = "%";
                    speech.SpeakAsync("The result is " + textBoxResult.Text);
                }
            }
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            if (!textBoxResult.Text.Contains(","))
            {
                textBoxResult.Text = textBoxResult.Text + ",";
                value = value + ",";
                speech.SpeakAsync("comma");
            }
        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
