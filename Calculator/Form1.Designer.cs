namespace Calculator
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
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
            this.memoryLabel = new System.Windows.Forms.Label();
            this.MPlusButton = new System.Windows.Forms.Button();
            this.MMInusButton = new System.Windows.Forms.Button();
            this.MRButton = new System.Windows.Forms.Button();
            this.MCButton = new System.Windows.Forms.Button();
            this.MeanButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.percentOffButton = new System.Windows.Forms.Button();
            this.GameChangeButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GameBox = new System.Windows.Forms.TextBox();
            this.percentButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.yButton = new System.Windows.Forms.Button();
            this.xButton = new System.Windows.Forms.Button();
            this.hiScoreLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numberBox1
            // 
            this.numberBox1.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.numberBox1.Location = new System.Drawing.Point(112, 58);
            this.numberBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numberBox1.Name = "numberBox1";
            this.numberBox1.Size = new System.Drawing.Size(193, 27);
            this.numberBox1.TabIndex = 0;
            // 
            // numberBox2
            // 
            this.numberBox2.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.numberBox2.Location = new System.Drawing.Point(112, 124);
            this.numberBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numberBox2.Name = "numberBox2";
            this.numberBox2.Size = new System.Drawing.Size(193, 27);
            this.numberBox2.TabIndex = 1;
            // 
            // AdditionButton
            // 
            this.AdditionButton.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.AdditionButton.Location = new System.Drawing.Point(90, 247);
            this.AdditionButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AdditionButton.Name = "AdditionButton";
            this.AdditionButton.Size = new System.Drawing.Size(62, 36);
            this.AdditionButton.TabIndex = 2;
            this.AdditionButton.Text = "+";
            this.AdditionButton.UseVisualStyleBackColor = true;
            this.AdditionButton.Click += new System.EventHandler(this.AdditionButton_Click);
            // 
            // SubtractionButton
            // 
            this.SubtractionButton.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.SubtractionButton.Location = new System.Drawing.Point(90, 311);
            this.SubtractionButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SubtractionButton.Name = "SubtractionButton";
            this.SubtractionButton.Size = new System.Drawing.Size(62, 36);
            this.SubtractionButton.TabIndex = 3;
            this.SubtractionButton.Text = "-";
            this.SubtractionButton.UseVisualStyleBackColor = true;
            this.SubtractionButton.Click += new System.EventHandler(this.SubtractionButton_Click);
            // 
            // DivisionButton
            // 
            this.DivisionButton.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.DivisionButton.Location = new System.Drawing.Point(90, 371);
            this.DivisionButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DivisionButton.Name = "DivisionButton";
            this.DivisionButton.Size = new System.Drawing.Size(62, 36);
            this.DivisionButton.TabIndex = 4;
            this.DivisionButton.Text = "÷";
            this.DivisionButton.UseVisualStyleBackColor = true;
            this.DivisionButton.Click += new System.EventHandler(this.DivisionButton_Click);
            // 
            // MultiplicationButton
            // 
            this.MultiplicationButton.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.MultiplicationButton.Location = new System.Drawing.Point(90, 434);
            this.MultiplicationButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MultiplicationButton.Name = "MultiplicationButton";
            this.MultiplicationButton.Size = new System.Drawing.Size(62, 36);
            this.MultiplicationButton.TabIndex = 5;
            this.MultiplicationButton.Text = "×";
            this.MultiplicationButton.UseVisualStyleBackColor = true;
            this.MultiplicationButton.Click += new System.EventHandler(this.MultiplicationButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ResetButton.Location = new System.Drawing.Point(716, 434);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(125, 54);
            this.ResetButton.TabIndex = 6;
            this.ResetButton.Text = "リセット";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.resultLabel.Location = new System.Drawing.Point(361, 88);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(116, 26);
            this.resultLabel.TabIndex = 7;
            this.resultLabel.Text = "計算結果";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.label1.Location = new System.Drawing.Point(71, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(71, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Y";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FactrialButton
            // 
            this.FactrialButton.Location = new System.Drawing.Point(181, 247);
            this.FactrialButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FactrialButton.Name = "FactrialButton";
            this.FactrialButton.Size = new System.Drawing.Size(62, 36);
            this.FactrialButton.TabIndex = 10;
            this.FactrialButton.Text = "X!";
            this.FactrialButton.UseVisualStyleBackColor = true;
            this.FactrialButton.Click += new System.EventHandler(this.FactrialButton_Click);
            // 
            // SquareRoot
            // 
            this.SquareRoot.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.SquareRoot.Location = new System.Drawing.Point(181, 311);
            this.SquareRoot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SquareRoot.Name = "SquareRoot";
            this.SquareRoot.Size = new System.Drawing.Size(62, 36);
            this.SquareRoot.TabIndex = 11;
            this.SquareRoot.Text = "√";
            this.SquareRoot.UseVisualStyleBackColor = true;
            this.SquareRoot.Click += new System.EventHandler(this.SquareRoot_Click);
            // 
            // PowButton
            // 
            this.PowButton.Location = new System.Drawing.Point(274, 372);
            this.PowButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PowButton.Name = "PowButton";
            this.PowButton.Size = new System.Drawing.Size(94, 36);
            this.PowButton.TabIndex = 12;
            this.PowButton.Text = "XのY乗";
            this.PowButton.UseVisualStyleBackColor = true;
            this.PowButton.Click += new System.EventHandler(this.PowButton_Click);
            // 
            // YRootButton
            // 
            this.YRootButton.Location = new System.Drawing.Point(274, 433);
            this.YRootButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.YRootButton.Name = "YRootButton";
            this.YRootButton.Size = new System.Drawing.Size(106, 36);
            this.YRootButton.TabIndex = 13;
            this.YRootButton.Text = "XのY乗根";
            this.YRootButton.UseVisualStyleBackColor = true;
            this.YRootButton.Click += new System.EventHandler(this.YRootButton_Click);
            // 
            // SinButton
            // 
            this.SinButton.Location = new System.Drawing.Point(181, 372);
            this.SinButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SinButton.Name = "SinButton";
            this.SinButton.Size = new System.Drawing.Size(62, 36);
            this.SinButton.TabIndex = 14;
            this.SinButton.Text = "sin";
            this.SinButton.UseVisualStyleBackColor = true;
            this.SinButton.Click += new System.EventHandler(this.SinButton_Click);
            // 
            // CosButton
            // 
            this.CosButton.Location = new System.Drawing.Point(181, 433);
            this.CosButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CosButton.Name = "CosButton";
            this.CosButton.Size = new System.Drawing.Size(62, 36);
            this.CosButton.TabIndex = 15;
            this.CosButton.Text = "cos";
            this.CosButton.UseVisualStyleBackColor = true;
            this.CosButton.Click += new System.EventHandler(this.CosButton_Click);
            // 
            // TanButton
            // 
            this.TanButton.Location = new System.Drawing.Point(181, 488);
            this.TanButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TanButton.Name = "TanButton";
            this.TanButton.Size = new System.Drawing.Size(62, 36);
            this.TanButton.TabIndex = 16;
            this.TanButton.Text = "tan";
            this.TanButton.UseVisualStyleBackColor = true;
            this.TanButton.Click += new System.EventHandler(this.TanButton_Click);
            // 
            // Log10Button
            // 
            this.Log10Button.Location = new System.Drawing.Point(274, 247);
            this.Log10Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Log10Button.Name = "Log10Button";
            this.Log10Button.Size = new System.Drawing.Size(88, 36);
            this.Log10Button.TabIndex = 17;
            this.Log10Button.Text = "log10";
            this.Log10Button.UseVisualStyleBackColor = true;
            this.Log10Button.Click += new System.EventHandler(this.Log10Button_Click);
            // 
            // Log2Button
            // 
            this.Log2Button.Location = new System.Drawing.Point(274, 311);
            this.Log2Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Log2Button.Name = "Log2Button";
            this.Log2Button.Size = new System.Drawing.Size(88, 36);
            this.Log2Button.TabIndex = 18;
            this.Log2Button.Text = "log2";
            this.Log2Button.UseVisualStyleBackColor = true;
            // 
            // IntoXButton
            // 
            this.IntoXButton.Location = new System.Drawing.Point(90, 179);
            this.IntoXButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IntoXButton.Name = "IntoXButton";
            this.IntoXButton.Size = new System.Drawing.Size(112, 36);
            this.IntoXButton.TabIndex = 19;
            this.IntoXButton.Text = "結果をXへ";
            this.IntoXButton.UseVisualStyleBackColor = true;
            this.IntoXButton.Click += new System.EventHandler(this.IntoXButton_Click);
            // 
            // IntoYButton
            // 
            this.IntoYButton.Location = new System.Drawing.Point(212, 179);
            this.IntoYButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IntoYButton.Name = "IntoYButton";
            this.IntoYButton.Size = new System.Drawing.Size(112, 36);
            this.IntoYButton.TabIndex = 20;
            this.IntoYButton.Text = "結果をYへ";
            this.IntoYButton.UseVisualStyleBackColor = true;
            this.IntoYButton.Click += new System.EventHandler(this.IntoYButton_Click);
            // 
            // memoryLabel
            // 
            this.memoryLabel.AutoSize = true;
            this.memoryLabel.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.memoryLabel.Location = new System.Drawing.Point(778, 96);
            this.memoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.memoryLabel.Name = "memoryLabel";
            this.memoryLabel.Size = new System.Drawing.Size(19, 20);
            this.memoryLabel.TabIndex = 21;
            this.memoryLabel.Text = "0";
            // 
            // MPlusButton
            // 
            this.MPlusButton.Location = new System.Drawing.Point(639, 247);
            this.MPlusButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MPlusButton.Name = "MPlusButton";
            this.MPlusButton.Size = new System.Drawing.Size(62, 54);
            this.MPlusButton.TabIndex = 22;
            this.MPlusButton.Text = "M+";
            this.MPlusButton.UseVisualStyleBackColor = true;
            this.MPlusButton.Click += new System.EventHandler(this.MPlusButton_Click);
            // 
            // MMInusButton
            // 
            this.MMInusButton.Location = new System.Drawing.Point(709, 247);
            this.MMInusButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MMInusButton.Name = "MMInusButton";
            this.MMInusButton.Size = new System.Drawing.Size(62, 54);
            this.MMInusButton.TabIndex = 23;
            this.MMInusButton.Text = "M-";
            this.MMInusButton.UseVisualStyleBackColor = true;
            this.MMInusButton.Click += new System.EventHandler(this.MMinusButton_Click);
            // 
            // MRButton
            // 
            this.MRButton.Location = new System.Drawing.Point(779, 247);
            this.MRButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MRButton.Name = "MRButton";
            this.MRButton.Size = new System.Drawing.Size(62, 54);
            this.MRButton.TabIndex = 24;
            this.MRButton.Text = "MR";
            this.MRButton.UseVisualStyleBackColor = true;
            this.MRButton.Click += new System.EventHandler(this.MRButton_Click);
            // 
            // MCButton
            // 
            this.MCButton.Location = new System.Drawing.Point(849, 247);
            this.MCButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MCButton.Name = "MCButton";
            this.MCButton.Size = new System.Drawing.Size(62, 54);
            this.MCButton.TabIndex = 25;
            this.MCButton.Text = "MC";
            this.MCButton.UseVisualStyleBackColor = true;
            this.MCButton.Click += new System.EventHandler(this.MCButton_Click);
            // 
            // MeanButton
            // 
            this.MeanButton.Location = new System.Drawing.Point(639, 341);
            this.MeanButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MeanButton.Name = "MeanButton";
            this.MeanButton.Size = new System.Drawing.Size(88, 36);
            this.MeanButton.TabIndex = 26;
            this.MeanButton.Text = "mean";
            this.MeanButton.UseVisualStyleBackColor = true;
            this.MeanButton.Click += new System.EventHandler(this.MeanButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(682, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "入力数";
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.countLabel.Location = new System.Drawing.Point(778, 138);
            this.countLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(19, 20);
            this.countLabel.TabIndex = 28;
            this.countLabel.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(684, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 29;
            this.label5.Text = "メモリー値";
            // 
            // percentOffButton
            // 
            this.percentOffButton.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.percentOffButton.Location = new System.Drawing.Point(280, 490);
            this.percentOffButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.percentOffButton.Name = "percentOffButton";
            this.percentOffButton.Size = new System.Drawing.Size(62, 36);
            this.percentOffButton.TabIndex = 30;
            this.percentOffButton.Text = "%off";
            this.percentOffButton.UseVisualStyleBackColor = true;
            this.percentOffButton.Click += new System.EventHandler(this.PercentOffButton_Click);
            // 
            // GameChangeButton
            // 
            this.GameChangeButton.Location = new System.Drawing.Point(86, 11);
            this.GameChangeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GameChangeButton.Name = "GameChangeButton";
            this.GameChangeButton.Size = new System.Drawing.Size(88, 30);
            this.GameChangeButton.TabIndex = 32;
            this.GameChangeButton.Text = "GAME";
            this.GameChangeButton.UseVisualStyleBackColor = true;
            this.GameChangeButton.Click += new System.EventHandler(this.GameChangeButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // GameBox
            // 
            this.GameBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GameBox.Location = new System.Drawing.Point(181, 12);
            this.GameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GameBox.Name = "GameBox";
            this.GameBox.ReadOnly = true;
            this.GameBox.Size = new System.Drawing.Size(124, 25);
            this.GameBox.TabIndex = 33;
            this.GameBox.Text = "GAME表示";
            // 
            // percentButton
            // 
            this.percentButton.Location = new System.Drawing.Point(90, 490);
            this.percentButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.percentButton.Name = "percentButton";
            this.percentButton.Size = new System.Drawing.Size(62, 36);
            this.percentButton.TabIndex = 34;
            this.percentButton.Text = "%";
            this.percentButton.UseVisualStyleBackColor = true;
            this.percentButton.Click += new System.EventHandler(this.PercentButton_Click);
            // 
            // oneButton
            // 
            this.oneButton.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.oneButton.Location = new System.Drawing.Point(0, 100);
            this.oneButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(38, 36);
            this.oneButton.TabIndex = 35;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // twoButton
            // 
            this.twoButton.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.twoButton.Location = new System.Drawing.Point(52, 100);
            this.twoButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(38, 36);
            this.twoButton.TabIndex = 36;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = true;
            this.twoButton.Click += new System.EventHandler(this.TwoButton_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.ThreeButton.Location = new System.Drawing.Point(105, 100);
            this.ThreeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(38, 36);
            this.ThreeButton.TabIndex = 37;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = true;
            this.ThreeButton.Click += new System.EventHandler(this.ThreeButton_Click);
            // 
            // fourButton
            // 
            this.fourButton.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.fourButton.Location = new System.Drawing.Point(0, 50);
            this.fourButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(38, 36);
            this.fourButton.TabIndex = 38;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = true;
            this.fourButton.Click += new System.EventHandler(this.FourButton_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.fiveButton.Location = new System.Drawing.Point(52, 50);
            this.fiveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(38, 36);
            this.fiveButton.TabIndex = 39;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = true;
            this.fiveButton.Click += new System.EventHandler(this.FiveButton_Click);
            // 
            // sixButton
            // 
            this.sixButton.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.sixButton.Location = new System.Drawing.Point(105, 50);
            this.sixButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(38, 36);
            this.sixButton.TabIndex = 40;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = true;
            this.sixButton.Click += new System.EventHandler(this.SixButton_Click);
            // 
            // sevenButton
            // 
            this.sevenButton.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.sevenButton.Location = new System.Drawing.Point(0, 0);
            this.sevenButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(38, 36);
            this.sevenButton.TabIndex = 41;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = true;
            this.sevenButton.Click += new System.EventHandler(this.SevenButton_Click);
            // 
            // eightButton
            // 
            this.eightButton.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.eightButton.Location = new System.Drawing.Point(52, 0);
            this.eightButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(38, 36);
            this.eightButton.TabIndex = 42;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = true;
            this.eightButton.Click += new System.EventHandler(this.EightButton_Click);
            // 
            // nineButton
            // 
            this.nineButton.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.nineButton.Location = new System.Drawing.Point(105, 0);
            this.nineButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(38, 36);
            this.nineButton.TabIndex = 43;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = true;
            this.nineButton.Click += new System.EventHandler(this.NineButton_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.zeroButton.Location = new System.Drawing.Point(52, 150);
            this.zeroButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(38, 36);
            this.zeroButton.TabIndex = 44;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.ZeroButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.yButton);
            this.panel1.Controls.Add(this.zeroButton);
            this.panel1.Controls.Add(this.xButton);
            this.panel1.Controls.Add(this.nineButton);
            this.panel1.Controls.Add(this.ThreeButton);
            this.panel1.Controls.Add(this.sixButton);
            this.panel1.Controls.Add(this.twoButton);
            this.panel1.Controls.Add(this.fiveButton);
            this.panel1.Controls.Add(this.oneButton);
            this.panel1.Controls.Add(this.sevenButton);
            this.panel1.Controls.Add(this.eightButton);
            this.panel1.Controls.Add(this.fourButton);
            this.panel1.Location = new System.Drawing.Point(442, 247);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 192);
            this.panel1.TabIndex = 46;
            // 
            // yButton
            // 
            this.yButton.Location = new System.Drawing.Point(106, 150);
            this.yButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yButton.Name = "yButton";
            this.yButton.Size = new System.Drawing.Size(38, 36);
            this.yButton.TabIndex = 48;
            this.yButton.Text = "Y";
            this.yButton.UseVisualStyleBackColor = true;
            this.yButton.Click += new System.EventHandler(this.yButton_Click);
            // 
            // xButton
            // 
            this.xButton.Location = new System.Drawing.Point(0, 150);
            this.xButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.xButton.Name = "xButton";
            this.xButton.Size = new System.Drawing.Size(38, 36);
            this.xButton.TabIndex = 47;
            this.xButton.Text = "X";
            this.xButton.UseVisualStyleBackColor = true;
            this.xButton.Click += new System.EventHandler(this.xButton_Click);
            // 
            // hiScoreLabel
            // 
            this.hiScoreLabel.AutoSize = true;
            this.hiScoreLabel.Location = new System.Drawing.Point(310, 17);
            this.hiScoreLabel.Name = "hiScoreLabel";
            this.hiScoreLabel.Size = new System.Drawing.Size(17, 18);
            this.hiScoreLabel.TabIndex = 47;
            this.hiScoreLabel.Text = "0";
            this.hiScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.hiScoreLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.percentButton);
            this.Controls.Add(this.GameBox);
            this.Controls.Add(this.GameChangeButton);
            this.Controls.Add(this.percentOffButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MeanButton);
            this.Controls.Add(this.MCButton);
            this.Controls.Add(this.MRButton);
            this.Controls.Add(this.MMInusButton);
            this.Controls.Add(this.MPlusButton);
            this.Controls.Add(this.memoryLabel);
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
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.ZeroButton_Click);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Label memoryLabel;
        private System.Windows.Forms.Button MPlusButton;
        private System.Windows.Forms.Button MMInusButton;
        private System.Windows.Forms.Button MRButton;
        private System.Windows.Forms.Button MCButton;
        private System.Windows.Forms.Button MeanButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button percentOffButton;
        private System.Windows.Forms.Button GameChangeButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox GameBox;
        private System.Windows.Forms.Button percentButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button yButton;
        private System.Windows.Forms.Button xButton;
        private System.Windows.Forms.Label hiScoreLabel;
    }
}

