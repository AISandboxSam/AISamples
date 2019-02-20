namespace AIGuessTheNextStockQuote
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxNumberRange = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRandRowPosition = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblRandStockDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRandStockQuote = new System.Windows.Forms.Label();
            this.labelAIText = new System.Windows.Forms.Label();
            this.labelAIValue = new System.Windows.Forms.Label();
            this.labelRandValue = new System.Windows.Forms.Label();
            this.labelRandValText = new System.Windows.Forms.Label();
            this.labelGuessResult = new System.Windows.Forms.Label();
            this.buttonPickastock = new System.Windows.Forms.Button();
            this.labelAIBestGuessesValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelCounter = new System.Windows.Forms.Label();
            this.textBoxMaxCounter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSuccessPct = new System.Windows.Forms.Label();
            this.labelCountDisplay = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.labelRandDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGetNextDayQuote = new System.Windows.Forms.Button();
            this.groupBoxNumberRange.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxNumberRange
            // 
            this.groupBoxNumberRange.Controls.Add(this.label6);
            this.groupBoxNumberRange.Controls.Add(this.lblRandRowPosition);
            this.groupBoxNumberRange.Controls.Add(this.label7);
            this.groupBoxNumberRange.Controls.Add(this.lblRandStockDate);
            this.groupBoxNumberRange.Controls.Add(this.label5);
            this.groupBoxNumberRange.Controls.Add(this.lblRandStockQuote);
            this.groupBoxNumberRange.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxNumberRange.Location = new System.Drawing.Point(39, 41);
            this.groupBoxNumberRange.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxNumberRange.Name = "groupBoxNumberRange";
            this.groupBoxNumberRange.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxNumberRange.Size = new System.Drawing.Size(1052, 194);
            this.groupBoxNumberRange.TabIndex = 0;
            this.groupBoxNumberRange.TabStop = false;
            this.groupBoxNumberRange.Text = "Random Stock Quote";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.NavajoWhite;
            this.label6.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(171, 123);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 22);
            this.label6.TabIndex = 16;
            this.label6.Text = "Row Position:";
            // 
            // lblRandRowPosition
            // 
            this.lblRandRowPosition.AutoSize = true;
            this.lblRandRowPosition.BackColor = System.Drawing.Color.Azure;
            this.lblRandRowPosition.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRandRowPosition.ForeColor = System.Drawing.Color.IndianRed;
            this.lblRandRowPosition.Location = new System.Drawing.Point(459, 123);
            this.lblRandRowPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRandRowPosition.Name = "lblRandRowPosition";
            this.lblRandRowPosition.Size = new System.Drawing.Size(130, 22);
            this.lblRandRowPosition.TabIndex = 17;
            this.lblRandRowPosition.Text = "Row Position";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.NavajoWhite;
            this.label7.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(187, 83);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "Stock Date:";
            // 
            // lblRandStockDate
            // 
            this.lblRandStockDate.AutoSize = true;
            this.lblRandStockDate.BackColor = System.Drawing.Color.Azure;
            this.lblRandStockDate.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRandStockDate.ForeColor = System.Drawing.Color.DarkRed;
            this.lblRandStockDate.Location = new System.Drawing.Point(459, 83);
            this.lblRandStockDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRandStockDate.Name = "lblRandStockDate";
            this.lblRandStockDate.Size = new System.Drawing.Size(110, 22);
            this.lblRandStockDate.TabIndex = 15;
            this.lblRandStockDate.Text = "Stock Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.NavajoWhite;
            this.label5.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(179, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Stock Price:";
            // 
            // lblRandStockQuote
            // 
            this.lblRandStockQuote.AutoSize = true;
            this.lblRandStockQuote.BackColor = System.Drawing.Color.Azure;
            this.lblRandStockQuote.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRandStockQuote.ForeColor = System.Drawing.Color.DarkRed;
            this.lblRandStockQuote.Location = new System.Drawing.Point(459, 40);
            this.lblRandStockQuote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRandStockQuote.Name = "lblRandStockQuote";
            this.lblRandStockQuote.Size = new System.Drawing.Size(120, 22);
            this.lblRandStockQuote.TabIndex = 13;
            this.lblRandStockQuote.Text = "Stock Quote";
            // 
            // labelAIText
            // 
            this.labelAIText.AutoSize = true;
            this.labelAIText.BackColor = System.Drawing.Color.NavajoWhite;
            this.labelAIText.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAIText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelAIText.Location = new System.Drawing.Point(107, 52);
            this.labelAIText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAIText.Name = "labelAIText";
            this.labelAIText.Size = new System.Drawing.Size(220, 22);
            this.labelAIText.TabIndex = 2;
            this.labelAIText.Text = "AI Next Value Guess: ";
            // 
            // labelAIValue
            // 
            this.labelAIValue.AutoSize = true;
            this.labelAIValue.BackColor = System.Drawing.Color.Azure;
            this.labelAIValue.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAIValue.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelAIValue.Location = new System.Drawing.Point(459, 52);
            this.labelAIValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAIValue.Name = "labelAIValue";
            this.labelAIValue.Size = new System.Drawing.Size(90, 22);
            this.labelAIValue.TabIndex = 3;
            this.labelAIValue.Text = "AI Value";
            // 
            // labelRandValue
            // 
            this.labelRandValue.AutoSize = true;
            this.labelRandValue.BackColor = System.Drawing.Color.Azure;
            this.labelRandValue.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRandValue.ForeColor = System.Drawing.Color.Navy;
            this.labelRandValue.Location = new System.Drawing.Point(460, 38);
            this.labelRandValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRandValue.Name = "labelRandValue";
            this.labelRandValue.Size = new System.Drawing.Size(120, 22);
            this.labelRandValue.TabIndex = 5;
            this.labelRandValue.Text = "Stock Price";
            // 
            // labelRandValText
            // 
            this.labelRandValText.AutoSize = true;
            this.labelRandValText.BackColor = System.Drawing.Color.NavajoWhite;
            this.labelRandValText.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRandValText.Location = new System.Drawing.Point(139, 38);
            this.labelRandValText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRandValText.Name = "labelRandValText";
            this.labelRandValText.Size = new System.Drawing.Size(180, 22);
            this.labelRandValText.TabIndex = 4;
            this.labelRandValText.Text = "Next Stock Price:";
            // 
            // labelGuessResult
            // 
            this.labelGuessResult.AutoSize = true;
            this.labelGuessResult.BackColor = System.Drawing.Color.Azure;
            this.labelGuessResult.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGuessResult.ForeColor = System.Drawing.Color.Navy;
            this.labelGuessResult.Location = new System.Drawing.Point(459, 100);
            this.labelGuessResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGuessResult.Name = "labelGuessResult";
            this.labelGuessResult.Size = new System.Drawing.Size(130, 22);
            this.labelGuessResult.TabIndex = 7;
            this.labelGuessResult.Text = "Guess Result";
            // 
            // buttonPickastock
            // 
            this.buttonPickastock.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonPickastock.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPickastock.Location = new System.Drawing.Point(646, 707);
            this.buttonPickastock.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPickastock.Name = "buttonPickastock";
            this.buttonPickastock.Size = new System.Drawing.Size(205, 55);
            this.buttonPickastock.TabIndex = 9;
            this.buttonPickastock.Text = "Pick a Stock Quote";
            this.buttonPickastock.UseVisualStyleBackColor = false;
            this.buttonPickastock.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelAIBestGuessesValue
            // 
            this.labelAIBestGuessesValue.AutoSize = true;
            this.labelAIBestGuessesValue.BackColor = System.Drawing.Color.Azure;
            this.labelAIBestGuessesValue.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAIBestGuessesValue.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelAIBestGuessesValue.Location = new System.Drawing.Point(459, 89);
            this.labelAIBestGuessesValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAIBestGuessesValue.Name = "labelAIBestGuessesValue";
            this.labelAIBestGuessesValue.Size = new System.Drawing.Size(160, 22);
            this.labelAIBestGuessesValue.TabIndex = 11;
            this.labelAIBestGuessesValue.Text = "AI Best Guesses";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.NavajoWhite;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(155, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "AI Best Guesses";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.NavajoWhite;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(39, 706);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 55);
            this.button1.TabIndex = 12;
            this.button1.Text = "Start Multiple";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // labelCounter
            // 
            this.labelCounter.AutoSize = true;
            this.labelCounter.BackColor = System.Drawing.Color.Azure;
            this.labelCounter.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCounter.Location = new System.Drawing.Point(305, 707);
            this.labelCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCounter.Name = "labelCounter";
            this.labelCounter.Size = new System.Drawing.Size(80, 22);
            this.labelCounter.TabIndex = 13;
            this.labelCounter.Text = "Counter";
            // 
            // textBoxMaxCounter
            // 
            this.textBoxMaxCounter.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaxCounter.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxMaxCounter.Location = new System.Drawing.Point(463, 26);
            this.textBoxMaxCounter.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMaxCounter.Name = "textBoxMaxCounter";
            this.textBoxMaxCounter.Size = new System.Drawing.Size(124, 29);
            this.textBoxMaxCounter.TabIndex = 14;
            this.textBoxMaxCounter.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.NavajoWhite;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Run Count";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.NavajoWhite;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Success Pct Last Run: ";
            // 
            // labelSuccessPct
            // 
            this.labelSuccessPct.AutoSize = true;
            this.labelSuccessPct.BackColor = System.Drawing.Color.Azure;
            this.labelSuccessPct.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuccessPct.Location = new System.Drawing.Point(792, 67);
            this.labelSuccessPct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSuccessPct.Name = "labelSuccessPct";
            this.labelSuccessPct.Size = new System.Drawing.Size(20, 22);
            this.labelSuccessPct.TabIndex = 17;
            this.labelSuccessPct.Text = "%";
            // 
            // labelCountDisplay
            // 
            this.labelCountDisplay.AutoSize = true;
            this.labelCountDisplay.BackColor = System.Drawing.Color.Azure;
            this.labelCountDisplay.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountDisplay.Location = new System.Drawing.Point(458, 67);
            this.labelCountDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCountDisplay.Name = "labelCountDisplay";
            this.labelCountDisplay.Size = new System.Drawing.Size(70, 22);
            this.labelCountDisplay.TabIndex = 18;
            this.labelCountDisplay.Text = "0 of 0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelAIBestGuessesValue);
            this.groupBox1.Controls.Add(this.labelAIText);
            this.groupBox1.Controls.Add(this.labelAIValue);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 243);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1052, 129);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AI Output";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.labelRandDate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.labelRandValue);
            this.groupBox2.Controls.Add(this.labelRandValText);
            this.groupBox2.Controls.Add(this.labelGuessResult);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(39, 389);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1052, 142);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AI Output Validation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.NavajoWhite;
            this.label8.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(147, 71);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 22);
            this.label8.TabIndex = 18;
            this.label8.Text = "Next Stock Date:";
            // 
            // labelRandDate
            // 
            this.labelRandDate.AutoSize = true;
            this.labelRandDate.BackColor = System.Drawing.Color.Azure;
            this.labelRandDate.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRandDate.ForeColor = System.Drawing.Color.Navy;
            this.labelRandDate.Location = new System.Drawing.Point(460, 71);
            this.labelRandDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRandDate.Name = "labelRandDate";
            this.labelRandDate.Size = new System.Drawing.Size(110, 22);
            this.labelRandDate.TabIndex = 19;
            this.labelRandDate.Text = "Stock Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.NavajoWhite;
            this.label4.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(144, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "AI Guess Result:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelSuccessPct);
            this.groupBox3.Controls.Add(this.labelCountDisplay);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBoxMaxCounter);
            this.groupBox3.Enabled = false;
            this.groupBox3.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DarkGray;
            this.groupBox3.Location = new System.Drawing.Point(39, 553);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1052, 119);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Run Stats";
            // 
            // btnGetNextDayQuote
            // 
            this.btnGetNextDayQuote.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnGetNextDayQuote.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetNextDayQuote.Location = new System.Drawing.Point(886, 706);
            this.btnGetNextDayQuote.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetNextDayQuote.Name = "btnGetNextDayQuote";
            this.btnGetNextDayQuote.Size = new System.Drawing.Size(205, 55);
            this.btnGetNextDayQuote.TabIndex = 14;
            this.btnGetNextDayQuote.Text = "AI Get Next Day Quote..";
            this.btnGetNextDayQuote.UseVisualStyleBackColor = false;
            this.btnGetNextDayQuote.Click += new System.EventHandler(this.btnGetNextDayQuote_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1166, 774);
            this.Controls.Add(this.btnGetNextDayQuote);
            this.Controls.Add(this.labelCounter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonPickastock);
            this.Controls.Add(this.groupBoxNumberRange);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "AI Guess The Next Stock Price";
            this.groupBoxNumberRange.ResumeLayout(false);
            this.groupBoxNumberRange.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxNumberRange;
        private System.Windows.Forms.Label labelAIText;
        private System.Windows.Forms.Label labelAIValue;
        private System.Windows.Forms.Label labelRandValue;
        private System.Windows.Forms.Label labelRandValText;
        private System.Windows.Forms.Label labelGuessResult;
        private System.Windows.Forms.Button buttonPickastock;
        private System.Windows.Forms.Label labelAIBestGuessesValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelCounter;
        private System.Windows.Forms.TextBox textBoxMaxCounter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSuccessPct;
        private System.Windows.Forms.Label labelCountDisplay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblRandStockDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRandStockQuote;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRandRowPosition;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelRandDate;
        private System.Windows.Forms.Button btnGetNextDayQuote;
    }
}

