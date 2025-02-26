namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.numberBox1 = new System.Windows.Forms.TextBox();
            this.numberBox2 = new System.Windows.Forms.TextBox();
            this.AdditionButton = new System.Windows.Forms.Button();
            this.SubtractionButton = new System.Windows.Forms.Button();
            this.DivisionButton = new System.Windows.Forms.Button();
            this.MultiplicationButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FactrialButton = new System.Windows.Forms.Button();
            this.SquareRoot = new System.Windows.Forms.Button();
            this.PowButton = new System.Windows.Forms.Button();
            this.YRootButton = new System.Windows.Forms.Button();
            this.SinButton = new System.Windows.Forms.Button();
            this.CosButton = new System.Windows.Forms.Button();
            this.TanButton = new System.Windows.Forms.Button();
            this.Log10Button = new System.Windows.Forms.Button();
            this.Log2Button = new System.Windows.Forms.Button();
            this.IntoXButton = new System.Windows.Forms.Button();
            this.IntoYButton = new System.Windows.Forms.Button();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.MPlusButton = new System.Windows.Forms.Button();
            this.MMInusButton = new System.Windows.Forms.Button();
            this.MRButton = new System.Windows.Forms.Button();
            this.MCButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numberBox1
            // 
            this.numberBox1.Location = new System.Drawing.Point(90, 37);
            this.numberBox1.Name = "numberBox1";
            this.numberBox1.Size = new System.Drawing.Size(155, 22);
            this.numberBox1.TabIndex = 0;
            // 
            // numberBox2
            // 
            this.numberBox2.Location = new System.Drawing.Point(90, 103);
            this.numberBox2.Name = "numberBox2";
            this.numberBox2.Size = new System.Drawing.Size(152, 22);
            this.numberBox2.TabIndex = 1;
            // 
            // AdditionButton
            // 
            this.AdditionButton.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.AdditionButton.Location = new System.Drawing.Point(72, 206);
            this.AdditionButton.Name = "AdditionButton";
            this.AdditionButton.Size = new System.Drawing.Size(45, 30);
            this.AdditionButton.TabIndex = 2;
            this.AdditionButton.Text = "+";
            this.AdditionButton.UseVisualStyleBackColor = true;
            this.AdditionButton.Click += new System.EventHandler(this.AdditionButton_Click);
            // 
            // SubtractionButton
            // 
            this.SubtractionButton.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.SubtractionButton.Location = new System.Drawing.Point(72, 259);
            this.SubtractionButton.Name = "SubtractionButton";
            this.SubtractionButton.Size = new System.Drawing.Size(45, 30);
            this.SubtractionButton.TabIndex = 3;
            this.SubtractionButton.Text = "-";
            this.SubtractionButton.UseVisualStyleBackColor = true;
            this.SubtractionButton.Click += new System.EventHandler(this.SubtractionButton_Click);
            // 
            // DivisionButton
            // 
            this.DivisionButton.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.DivisionButton.Location = new System.Drawing.Point(72, 309);
            this.DivisionButton.Name = "DivisionButton";
            this.DivisionButton.Size = new System.Drawing.Size(45, 30);
            this.DivisionButton.TabIndex = 4;
            this.DivisionButton.Text = "÷";
            this.DivisionButton.UseVisualStyleBackColor = true;
            this.DivisionButton.Click += new System.EventHandler(this.DivisionButton_Click);
            // 
            // MultiplicationButton
            // 
            this.MultiplicationButton.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.MultiplicationButton.Location = new System.Drawing.Point(72, 362);
            this.MultiplicationButton.Name = "MultiplicationButton";
            this.MultiplicationButton.Size = new System.Drawing.Size(45, 30);
            this.MultiplicationButton.TabIndex = 5;
            this.MultiplicationButton.Text = "×";
            this.MultiplicationButton.UseVisualStyleBackColor = true;
            this.MultiplicationButton.Click += new System.EventHandler(this.MultiplicationButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(546, 376);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(79, 29);
            this.ResetButton.TabIndex = 6;
            this.ResetButton.Text = "リセット";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.resultLabel.Location = new System.Drawing.Point(343, 40);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(89, 20);
            this.resultLabel.TabIndex = 7;
            this.resultLabel.Text = "計算結果";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.label1.Location = new System.Drawing.Point(52, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(52, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Y";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FactrialButton
            // 
            this.FactrialButton.Location = new System.Drawing.Point(145, 206);
            this.FactrialButton.Name = "FactrialButton";
            this.FactrialButton.Size = new System.Drawing.Size(45, 30);
            this.FactrialButton.TabIndex = 10;
            this.FactrialButton.Text = "X!";
            this.FactrialButton.UseVisualStyleBackColor = true;
            this.FactrialButton.Click += new System.EventHandler(this.FactrialButton_Click);
            // 
            // SquareRoot
            // 
            this.SquareRoot.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.SquareRoot.Location = new System.Drawing.Point(145, 259);
            this.SquareRoot.Name = "SquareRoot";
            this.SquareRoot.Size = new System.Drawing.Size(45, 30);
            this.SquareRoot.TabIndex = 11;
            this.SquareRoot.Text = "√";
            this.SquareRoot.UseVisualStyleBackColor = true;
            this.SquareRoot.Click += new System.EventHandler(this.SquareRoot_Click);
            // 
            // PowButton
            // 
            this.PowButton.Location = new System.Drawing.Point(148, 309);
            this.PowButton.Name = "PowButton";
            this.PowButton.Size = new System.Drawing.Size(75, 30);
            this.PowButton.TabIndex = 12;
            this.PowButton.Text = "XのY乗";
            this.PowButton.UseVisualStyleBackColor = true;
            this.PowButton.Click += new System.EventHandler(this.PowButton_Click);
            // 
            // YRootButton
            // 
            this.YRootButton.Location = new System.Drawing.Point(148, 362);
            this.YRootButton.Name = "YRootButton";
            this.YRootButton.Size = new System.Drawing.Size(94, 30);
            this.YRootButton.TabIndex = 13;
            this.YRootButton.Text = "XのY乗根";
            this.YRootButton.UseVisualStyleBackColor = true;
            this.YRootButton.Click += new System.EventHandler(this.YRootButton_Click);
            // 
            // SinButton
            // 
            this.SinButton.Location = new System.Drawing.Point(284, 202);
            this.SinButton.Name = "SinButton";
            this.SinButton.Size = new System.Drawing.Size(76, 33);
            this.SinButton.TabIndex = 14;
            this.SinButton.Text = "sin";
            this.SinButton.UseVisualStyleBackColor = true;
            this.SinButton.Click += new System.EventHandler(this.SinButton_Click);
            // 
            // CosButton
            // 
            this.CosButton.Location = new System.Drawing.Point(286, 258);
            this.CosButton.Name = "CosButton";
            this.CosButton.Size = new System.Drawing.Size(73, 30);
            this.CosButton.TabIndex = 15;
            this.CosButton.Text = "cos";
            this.CosButton.UseVisualStyleBackColor = true;
            this.CosButton.Click += new System.EventHandler(this.CosButton_Click);
            // 
            // TanButton
            // 
            this.TanButton.Location = new System.Drawing.Point(286, 312);
            this.TanButton.Name = "TanButton";
            this.TanButton.Size = new System.Drawing.Size(74, 27);
            this.TanButton.TabIndex = 16;
            this.TanButton.Text = "tan";
            this.TanButton.UseVisualStyleBackColor = true;
            this.TanButton.Click += new System.EventHandler(this.TanButton_Click);
            // 
            // Log10Button
            // 
            this.Log10Button.Location = new System.Drawing.Point(395, 202);
            this.Log10Button.Name = "Log10Button";
            this.Log10Button.Size = new System.Drawing.Size(75, 33);
            this.Log10Button.TabIndex = 17;
            this.Log10Button.Text = "log10";
            this.Log10Button.UseVisualStyleBackColor = true;
            this.Log10Button.Click += new System.EventHandler(this.Log10Button_Click);
            // 
            // Log2Button
            // 
            this.Log2Button.Location = new System.Drawing.Point(395, 256);
            this.Log2Button.Name = "Log2Button";
            this.Log2Button.Size = new System.Drawing.Size(75, 33);
            this.Log2Button.TabIndex = 18;
            this.Log2Button.Text = "log2";
            this.Log2Button.UseVisualStyleBackColor = true;
            // 
            // IntoXButton
            // 
            this.IntoXButton.Location = new System.Drawing.Point(72, 149);
            this.IntoXButton.Name = "IntoXButton";
            this.IntoXButton.Size = new System.Drawing.Size(92, 23);
            this.IntoXButton.TabIndex = 19;
            this.IntoXButton.Text = "結果をXへ";
            this.IntoXButton.UseVisualStyleBackColor = true;
            this.IntoXButton.Click += new System.EventHandler(this.IntoXButton_Click);
            // 
            // IntoYButton
            // 
            this.IntoYButton.Location = new System.Drawing.Point(170, 149);
            this.IntoYButton.Name = "IntoYButton";
            this.IntoYButton.Size = new System.Drawing.Size(92, 23);
            this.IntoYButton.TabIndex = 20;
            this.IntoYButton.Text = "結果をYへ";
            this.IntoYButton.UseVisualStyleBackColor = true;
            this.IntoYButton.Click += new System.EventHandler(this.IntoYButton_Click);
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.Location = new System.Drawing.Point(557, 45);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(57, 15);
            this.MemoryLabel.TabIndex = 21;
            this.MemoryLabel.Text = "Memory";
            // 
            // MPlusButton
            // 
            this.MPlusButton.Location = new System.Drawing.Point(546, 202);
            this.MPlusButton.Name = "MPlusButton";
            this.MPlusButton.Size = new System.Drawing.Size(52, 45);
            this.MPlusButton.TabIndex = 22;
            this.MPlusButton.Text = "M+";
            this.MPlusButton.UseVisualStyleBackColor = true;
            this.MPlusButton.Click += new System.EventHandler(this.MPlusButton_Click);
            // 
            // MMInusButton
            // 
            this.MMInusButton.Location = new System.Drawing.Point(641, 203);
            this.MMInusButton.Name = "MMInusButton";
            this.MMInusButton.Size = new System.Drawing.Size(49, 43);
            this.MMInusButton.TabIndex = 23;
            this.MMInusButton.Text = "M-";
            this.MMInusButton.UseVisualStyleBackColor = true;
            // 
            // MRButton
            // 
            this.MRButton.Location = new System.Drawing.Point(546, 279);
            this.MRButton.Name = "MRButton";
            this.MRButton.Size = new System.Drawing.Size(52, 46);
            this.MRButton.TabIndex = 24;
            this.MRButton.Text = "MR";
            this.MRButton.UseVisualStyleBackColor = true;
            // 
            // MCButton
            // 
            this.MCButton.Location = new System.Drawing.Point(646, 279);
            this.MCButton.Name = "MCButton";
            this.MCButton.Size = new System.Drawing.Size(43, 45);
            this.MCButton.TabIndex = 25;
            this.MCButton.Text = "MC";
            this.MCButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MCButton);
            this.Controls.Add(this.MRButton);
            this.Controls.Add(this.MMInusButton);
            this.Controls.Add(this.MPlusButton);
            this.Controls.Add(this.MemoryLabel);
            this.Controls.Add(this.IntoYButton);
            this.Controls.Add(this.IntoXButton);
            this.Controls.Add(this.Log2Button);
            this.Controls.Add(this.Log10Button);
            this.Controls.Add(this.TanButton);
            this.Controls.Add(this.CosButton);
            this.Controls.Add(this.SinButton);
            this.Controls.Add(this.YRootButton);
            this.Controls.Add(this.PowButton);
            this.Controls.Add(this.SquareRoot);
            this.Controls.Add(this.FactrialButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.MultiplicationButton);
            this.Controls.Add(this.DivisionButton);
            this.Controls.Add(this.SubtractionButton);
            this.Controls.Add(this.AdditionButton);
            this.Controls.Add(this.numberBox2);
            this.Controls.Add(this.numberBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numberBox1;
        private System.Windows.Forms.TextBox numberBox2;
        private System.Windows.Forms.Button AdditionButton;
        private System.Windows.Forms.Button SubtractionButton;
        private System.Windows.Forms.Button DivisionButton;
        private System.Windows.Forms.Button MultiplicationButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button FactrialButton;
        private System.Windows.Forms.Button SquareRoot;
        private System.Windows.Forms.Button PowButton;
        private System.Windows.Forms.Button YRootButton;
        private System.Windows.Forms.Button SinButton;
        private System.Windows.Forms.Button CosButton;
        private System.Windows.Forms.Button TanButton;
        private System.Windows.Forms.Button Log10Button;
        private System.Windows.Forms.Button Log2Button;
        private System.Windows.Forms.Button IntoXButton;
        private System.Windows.Forms.Button IntoYButton;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Button MPlusButton;
        private System.Windows.Forms.Button MMInusButton;
        private System.Windows.Forms.Button MRButton;
        private System.Windows.Forms.Button MCButton;
    }
}

