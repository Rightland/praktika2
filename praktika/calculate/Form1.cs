using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonALL_Click(object sender, EventArgs e)
        {
            double one = Convert.ToDouble(textBox2.Text);
            switch (((Button)sender).Name)
            {
                case "button1":
                    double two = Convert.ToDouble(textBox3.Text);
                    ITwoArgumentsCalculator calculator1 = TwoArgumentsFactory.Creator("Plus");
                    double result1 = calculator1.Calculate(one, two);
                    textBox1.Text = Convert.ToString(result1);
                    break;
                case "button4":
                    double three = Convert.ToDouble(textBox3.Text);
                    ITwoArgumentsCalculator calculator4 = TwoArgumentsFactory.Creator("Multi");
                    double result4 = calculator4.Calculate(one, three);
                   
                    textBox1.Text = Convert.ToString(result4);
                    break;
                case "button3":
                    try
                    {
                        double four  = Convert.ToDouble(textBox3.Text);
                        ITwoArgumentsCalculator calculator3= TwoArgumentsFactory.Creator("Div");
                        double result3 = calculator3.Calculate(one, four);
                        if (four == 0)
                        {
                            MessageBox.Show("На ноль делить нельзя.");
                            return;
                        }
                        textBox1.Text = Convert.ToString(result3);

                    }
                    catch (System.FormatException)
                    {
                        textBox2.Clear();
                        textBox3.Clear();
                    }

                    break;
                case "button2":
                    double five = Convert.ToDouble(textBox3.Text);
                    ITwoArgumentsCalculator calculator2 = TwoArgumentsFactory.Creator("minus");
                    double result2 = calculator2.Calculate(one, five);
                    textBox1.Text = Convert.ToString(result2);
                    break;
                case "button5":
                    try
                    {
                        double six  = Convert.ToDouble(textBox3.Text);
                        ITwoArgumentsCalculator calculator5 = TwoArgumentsFactory.Creator("Remainder");
                        double result5 = calculator5.Calculate(one, six);
                        textBox1.Text = Convert.ToString(result5);
                        if (six == 0)
                        {
                            MessageBox.Show("На ноль делить нельзя.");
                            return;
                        }
                        textBox1.Text = Convert.ToString(result5);
                    }
                    catch (System.FormatException)
                    {
                        textBox2.Clear();
                        textBox3.Clear();
                    }
                    break;
                case "button6":
                    textBox3.Text = "0";
                    double seven = Convert.ToDouble(textBox3.Text);
                    ITwoArgumentsCalculator calculator6 = TwoArgumentsFactory.Creator("Sinus");
                    double result6 = calculator6.Calculate(one, seven);
                    textBox1.Text = Convert.ToString(result6);
                    break;
                    
                case "button7":
                    textBox3.Text = "0";
                    double eight = Convert.ToDouble(textBox3.Text);
                    ITwoArgumentsCalculator calculator7 = TwoArgumentsFactory.Creator("Square");
                    double result7 = calculator7.Calculate(one, eight);
                    textBox1.Text = Convert.ToString(result7);
                    break;
                case "button8":
                    double nine = Convert.ToDouble(textBox3.Text);
                    ITwoArgumentsCalculator calculator8 = TwoArgumentsFactory.Creator("average");
                    double result8 = calculator8.Calculate(one, nine);
                    textBox1.Text = Convert.ToString(result8);
                    break;
                default:
                    throw new Exception("Неизвестная операция");
            }

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textBox3.Text))
                return;

            try
            {
                double s = Convert.ToDouble(textBox3.Text);
            }
            catch (System.FormatException)
            {
                textBox3.Clear();
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox2.Text))
                return;
            
            try
            {
                double s = Convert.ToDouble(textBox2.Text);
            }
            catch (System.FormatException)
            {
                textBox2.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}


