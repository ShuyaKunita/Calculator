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
        private double num1;
        private double num2;
        private int num;
        public Form1()
        {
            InitializeComponent();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            numberBox1.Text = null;
            numberBox2.Text = null;
            resultLabel.Text = "結果";
        }
        private void IntoXButton_Click(object sender, EventArgs e)
        {
            numberBox1.Text = resultLabel.Text;
        }

        private void IntoYButton_Click(object sender, EventArgs e)
        {
            numberBox2.Text = resultLabel.Text;
        }

        private void AdditionButton_Click(object sender, EventArgs e)
        {
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


        private void FactrialButton_Click(object sender, EventArgs e)
        {
            bool success = int.TryParse(numberBox1.Text, out num);
            if (success && num < 11)
            {
                int fac = 1;
                int dNumber = num;
                for (int i = 0; i < num; i++)
                {
                    fac *= dNumber;
                    dNumber--;
                }
                resultLabel.Text = fac.ToString();
            }
            else
            {
                MessageBox.Show("11以上または数字以外が入力されています");
            }
        }

        private void SquareRoot_Click(object sender, EventArgs e)
        {
            bool success = double.TryParse(numberBox1.Text, out num1);
            if (success)
            {
                resultLabel.Text = Math.Sqrt(num1).ToString();
            }
            else
            {
                MessageBox.Show("数字以外が入力されています");
            }
        }

        private void PowButton_Click(object sender, EventArgs e)
        {
            bool success1 = double.TryParse(numberBox1.Text, out num1);
            bool success2 = double.TryParse(numberBox2.Text, out num2);

            if (success1 && success2)
            {
                resultLabel.Text = Math.Pow(num1, num2).ToString();
            }
            else
            {
                MessageBox.Show("数字以外が入力されています");
            }
        }

        private void YRootButton_Click(object sender, EventArgs e)
        {
            bool success1 = double.TryParse(numberBox1.Text, out num1);
            bool success2 = double.TryParse(numberBox2.Text, out num2);

            if (success1 && success2)
            {
                resultLabel.Text = Math.Pow(num1, 1.0 / num2).ToString();
            }
            else
            {
                MessageBox.Show("数字以外が入力されています");
            }
        }

        private void Log10Button_Click(object sender, EventArgs e)
        {
            bool success = double.TryParse(numberBox1.Text, out num1);
            if (success)
            {
                resultLabel.Text = Math.Log10(num1).ToString();
            }
            else
            {
                MessageBox.Show("数字以外が入力されています");
            }
        }

        private void SinButton_Click(object sender, EventArgs e)
        {
            bool success = double.TryParse(numberBox1.Text, out num1);
            if (success)
            {
                resultLabel.Text = Math.Sign(num1).ToString();
            }
            else
            {
                MessageBox.Show("数字以外が入力されています");
            }
        }

        private void CosButton_Click(object sender, EventArgs e)
        {
            bool success = double.TryParse(numberBox1.Text, out num1);
            if (success)
            {
                resultLabel.Text = Math.Cos(num1).ToString();
            }
            else
            {
                MessageBox.Show("数字以外が入力されています");
            }
        }

        private void TanButton_Click(object sender, EventArgs e)
        {
            bool success = double.TryParse(numberBox1.Text, out num1);
            if (success)
            {
                resultLabel.Text = Math.Tan(num1).ToString();
            }
            else
            {
                MessageBox.Show("数字以外が入力されています");
            }
        }

        private void MPlusButton_Click(object sender, EventArgs e)
        {
            bool success = double.TryParse(numberBox1.Text, out num1);
            if (success)
            {
                var result = double.Parse(MemoryLabel.Text) + double.Parse(numberBox1.Text);
                MemoryLabel.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("数字以外が入力されています");
            }
        }

        private void MMInusButton_Click(object sender, EventArgs e)
        {
            bool success = double.TryParse(numberBox1.Text, out num1);
            if (success)
            {
                var result = double.Parse(MemoryLabel.Text) - double.Parse(numberBox1.Text);
                MemoryLabel.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("数字以外が入力されています");
            }
        }

        private void MCButton_Click(object sender, EventArgs e)
        {
            MemoryLabel.Text = 0.ToString();
        }
    }
}
