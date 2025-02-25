using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AdditionButton_Click(object sender, EventArgs e)
        {
            double num1;
            double num2;
            bool success1 = double.TryParse(numberBox1.Text, out num1);
            bool success2 = double.TryParse(numberBox2.Text, out num2);

            if (success1 && success2)
            {
                double sum = num1 + num2;
                resultLabel.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("数字以外が入力されています");
            }
        }

        private void SubtractionButton_Click(object sender, EventArgs e)
        {
            double num1;
            double num2;
            bool success1 = double.TryParse(numberBox1.Text, out num1);
            bool success2 = double.TryParse(numberBox2.Text, out num2);

            if (success1 && success2)
            {
                double sub = num1 - num2;
                resultLabel.Text = sub.ToString();
            }
            else
            {
                MessageBox.Show("数字以外が入力されています");
            }

        }

        private void DivisionButton_Click(object sender, EventArgs e)
        {
            double num1;
            double num2;
            bool success1 = double.TryParse(numberBox1.Text, out num1);
            bool success2 = double.TryParse(numberBox2.Text, out num2);

            if (success1 && success2)
            {
                double div = num1 / num2;
                resultLabel.Text = div.ToString();
            }
            else
            {
                MessageBox.Show("数字以外が入力されています");
            }
        }

        private void MultiplicationButton_Click(object sender, EventArgs e)
        {
            double num1;
            double num2;
            bool success1 = double.TryParse(numberBox1.Text, out num1);
            bool success2 = double.TryParse(numberBox2.Text, out num2);

            if (success1 && success2)
            {
                double mul = num1 * num2;
                resultLabel.Text = mul.ToString();
            }
            else
            {
                MessageBox.Show("数字以外が入力されています");
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            numberBox1.Text = null;
            numberBox2.Text = null;
            resultLabel.Text = "結果";
        }

        private void numberBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
