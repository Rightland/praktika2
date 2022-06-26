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
            double two = Convert.ToDouble(textBox3.Text);
            var mathALL = new mathOperation();
            switch (((Button)sender).Name)
            {
                case "button1":
                    textBox1.Text = Convert.ToString(mathALL.Plusik(one, two));
                    break;
                case "button4":
                    textBox1.Text = Convert.ToString(mathALL.Multiplication(one, two));
                    break;
                case "button3":
                    textBox1.Text = Convert.ToString(mathALL.Division(one, two));
                    break;
                case "button2":
                    textBox1.Text = Convert.ToString(mathALL.Minus(one, two));
                    break;
                default:
                    throw new Exception("Неизвестная операция");
            }

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}


