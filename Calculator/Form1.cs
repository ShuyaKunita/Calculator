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
    public partial class MainForm : Form
    {
        private double num1;
        private double num2;
        private int num;
        private int count;
        private bool isGamePressed = false;
        private int score = 0;

        public MainForm()
        {
            InitializeComponent();
            //this.KeyDown += Test;
        }

        //private void Test(object sender, KeyEventArgs e)
        //{
        //    MessageBox.Show("ooo");
        //}

        private void ResetButton_Click(object sender, EventArgs e)
        {
            numberBox1.Text = "";
            numberBox2.Text = "";
            count = 0;
            resultLabel.Text = "結果";
            isGamePressed = false;
        }
        private void IntoXButton_Click(object sender, EventArgs e)
        {
            numberBox1.Text = resultLabel.Text;
        }

        private void IntoYButton_Click(object sender, EventArgs e)
        {
            numberBox2.Text = resultLabel.Text;
        }
        // 足し算
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
        // 引き算
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
        // 割り算
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
        // 掛け算
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

        // 階乗
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
        // ルート計算
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
        // XのY乗計算
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
        // 指定値のルート計算
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
        // log10底
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
        // sin計算
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
        // cos計算
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
        // tan計算
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
        // M+ボタン
        private void MPlusButton_Click(object sender, EventArgs e)
        {
            bool success = double.TryParse(numberBox1.Text, out num1);
            if (success)
            {
                var result = double.Parse(MemoryLabel.Text) + double.Parse(numberBox1.Text);
                MemoryLabel.Text = result.ToString();
                numberBox1.Text = "";
                count++;
                CountLabel.Text = count.ToString();
            }
            else
            {
                MessageBox.Show("数字以外が入力されています");
            }
        }
        // M-ボタン
        private void MMinusButton_Click(object sender, EventArgs e)
        {
            bool success = double.TryParse(numberBox1.Text, out num1);
            if (success)
            {
                var result = double.Parse(MemoryLabel.Text) - double.Parse(numberBox1.Text);
                MemoryLabel.Text = result.ToString();
                numberBox1.Text = "";
                count++;
                CountLabel.Text = count.ToString();
            }
            else
            {
                MessageBox.Show("数字以外が入力されています");
            }
        }
        // MCボタン
        private void MCButton_Click(object sender, EventArgs e)
        {
            MemoryLabel.Text = "0";
        }
        // MRボタン
        private void MRButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = MemoryLabel.Text;
        }
        // 平均値計算
        private void MeanButton_Click(object sender, EventArgs e)
        {
            var result = double.Parse(MemoryLabel.Text) / count;
            resultLabel.Text = result.ToString();
        }
        // XのY割引表示（小数点以下切り捨て）Yはパーセントで入力すること
        private void PercentButton_Click(object sender, EventArgs e)
        {
            bool success1 = double.TryParse(numberBox1.Text, out num1);
            bool success2 = double.TryParse(numberBox2.Text, out num2);

            if (success1 && success2)
            {
                resultLabel.Text = ((int)(num1 * (100 - num2) / 100)).ToString();
            }
            else
            {
                MessageBox.Show("数字以外が入力されています");
            }
        }

        private void GameChangeButton_Click(object sender, EventArgs e)
        {
            isGamePressed = true;
            numberBox1.Text = "0";
            GameBox.Text = "";
            timer1.Start();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && isGamePressed)
            {
                var x = int.Parse(numberBox1.Text);
                x += 1;
                if (x > 9) { x = 0; }
                numberBox1.Text = x.ToString();

            }
            else if (e.KeyCode == Keys.Down && isGamePressed)
            {
                var x = int.Parse(numberBox1.Text);
                x -= 1;
                if (x < 0) { x = 9; }
                numberBox1.Text = x.ToString();
            }

            else if (e.KeyCode == Keys.S && isGamePressed)
            {
                string str = GameBox.Text;
                if(numberBox1.Text)
                str.Replace(numberBox1.Text, "");
                score += 10;
                timer1.Interval -= 50;

            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 3000;
            Random rnd = new Random();
            GameBox.Text += (rnd.Next(10).ToString());

            if (GameBox.Text.Length == 10)
            {
                isGameOver();
            }
        }

        private void isGameOver()
        {
            isGamePressed = false;
            timer1.Stop();
            timer2.Stop();
            MessageBox.Show("ゲームオーバー");
        }
    }
}
