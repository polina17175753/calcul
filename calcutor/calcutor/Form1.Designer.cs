namespace calcutor
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.NUM4 = new System.Windows.Forms.Button();
            this.CalculatorDisplay = new System.Windows.Forms.Label();
            this.NUM7 = new System.Windows.Forms.Button();
            this.NUM0 = new System.Windows.Forms.Button();
            this.NUM5 = new System.Windows.Forms.Button();
            this.NUM8 = new System.Windows.Forms.Button();
            this.NUM6 = new System.Windows.Forms.Button();
            this.NUM9 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NUM3 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.NUM2 = new System.Windows.Forms.Button();
            this.NUM1 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NUM4
            // 
            this.NUM4.Location = new System.Drawing.Point(11, 242);
            this.NUM4.Name = "NUM4";
            this.NUM4.Size = new System.Drawing.Size(75, 50);
            this.NUM4.TabIndex = 0;
            this.NUM4.Text = "4";
            this.NUM4.UseVisualStyleBackColor = true;
            this.NUM4.Click += new System.EventHandler(this.button1_Click);
            // 
            // CalculatorDisplay
            // 
            this.CalculatorDisplay.AutoSize = true;
            this.CalculatorDisplay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CalculatorDisplay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CalculatorDisplay.Location = new System.Drawing.Point(463, 36);
            this.CalculatorDisplay.Name = "CalculatorDisplay";
            this.CalculatorDisplay.Size = new System.Drawing.Size(0, 13);
            this.CalculatorDisplay.TabIndex = 1;
            this.CalculatorDisplay.Click += new System.EventHandler(this.CalculatorDisplay_Click);
            // 
            // NUM7
            // 
            this.NUM7.Location = new System.Drawing.Point(11, 298);
            this.NUM7.Name = "NUM7";
            this.NUM7.Size = new System.Drawing.Size(75, 44);
            this.NUM7.TabIndex = 2;
            this.NUM7.Text = "7";
            this.NUM7.UseVisualStyleBackColor = true;
            this.NUM7.Click += new System.EventHandler(this.NUM7_Click);
            // 
            // NUM0
            // 
            this.NUM0.Location = new System.Drawing.Point(11, 348);
            this.NUM0.Name = "NUM0";
            this.NUM0.Size = new System.Drawing.Size(157, 47);
            this.NUM0.TabIndex = 3;
            this.NUM0.Text = "0";
            this.NUM0.UseVisualStyleBackColor = true;
            this.NUM0.Click += new System.EventHandler(this.NUM0_Click);
            // 
            // NUM5
            // 
            this.NUM5.Location = new System.Drawing.Point(93, 241);
            this.NUM5.Name = "NUM5";
            this.NUM5.Size = new System.Drawing.Size(75, 50);
            this.NUM5.TabIndex = 4;
            this.NUM5.Text = "5";
            this.NUM5.UseVisualStyleBackColor = true;
            this.NUM5.Click += new System.EventHandler(this.NUM5_Click);
            // 
            // NUM8
            // 
            this.NUM8.Location = new System.Drawing.Point(92, 297);
            this.NUM8.Name = "NUM8";
            this.NUM8.Size = new System.Drawing.Size(75, 45);
            this.NUM8.TabIndex = 5;
            this.NUM8.Text = "8";
            this.NUM8.UseVisualStyleBackColor = true;
            this.NUM8.Click += new System.EventHandler(this.NUM8_Click);
            // 
            // NUM6
            // 
            this.NUM6.Location = new System.Drawing.Point(173, 241);
            this.NUM6.Name = "NUM6";
            this.NUM6.Size = new System.Drawing.Size(75, 51);
            this.NUM6.TabIndex = 7;
            this.NUM6.Text = "6";
            this.NUM6.UseVisualStyleBackColor = true;
            this.NUM6.Click += new System.EventHandler(this.NUM6_Click);
            // 
            // NUM9
            // 
            this.NUM9.Location = new System.Drawing.Point(173, 297);
            this.NUM9.Name = "NUM9";
            this.NUM9.Size = new System.Drawing.Size(75, 45);
            this.NUM9.TabIndex = 8;
            this.NUM9.Text = "9";
            this.NUM9.UseVisualStyleBackColor = true;
            this.NUM9.Click += new System.EventHandler(this.NUM9_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(173, 348);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 47);
            this.button9.TabIndex = 9;
            this.button9.Text = ".";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(255, 348);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 47);
            this.button10.TabIndex = 10;
            this.button10.Text = "=";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 80);
            this.label1.TabIndex = 15;
            this.label1.Text = "\r\n\r\n\r\n0                                                                          " +
    " ";
            // 
            // NUM3
            // 
            this.NUM3.Location = new System.Drawing.Point(174, 185);
            this.NUM3.Name = "NUM3";
            this.NUM3.Size = new System.Drawing.Size(75, 50);
            this.NUM3.TabIndex = 16;
            this.NUM3.Text = "3";
            this.NUM3.UseVisualStyleBackColor = true;
            this.NUM3.Click += new System.EventHandler(this.NUM3_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(255, 129);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 50);
            this.button13.TabIndex = 17;
            this.button13.Text = "/";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(254, 185);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 50);
            this.button14.TabIndex = 18;
            this.button14.Text = "*";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(12, 129);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(236, 50);
            this.button15.TabIndex = 19;
            this.button15.Text = "AC";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // NUM2
            // 
            this.NUM2.Location = new System.Drawing.Point(92, 185);
            this.NUM2.Name = "NUM2";
            this.NUM2.Size = new System.Drawing.Size(75, 50);
            this.NUM2.TabIndex = 20;
            this.NUM2.Text = "2";
            this.NUM2.UseVisualStyleBackColor = true;
            this.NUM2.Click += new System.EventHandler(this.button16_Click);
            // 
            // NUM1
            // 
            this.NUM1.Location = new System.Drawing.Point(12, 186);
            this.NUM1.Name = "NUM1";
            this.NUM1.Size = new System.Drawing.Size(75, 50);
            this.NUM1.TabIndex = 22;
            this.NUM1.Text = "1";
            this.NUM1.UseVisualStyleBackColor = true;
            this.NUM1.Click += new System.EventHandler(this.button18_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(254, 297);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(75, 45);
            this.button20.TabIndex = 24;
            this.button20.Text = "-";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(254, 244);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(75, 45);
            this.button21.TabIndex = 25;
            this.button21.Text = "+";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 434);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.NUM1);
            this.Controls.Add(this.NUM2);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.NUM3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.NUM9);
            this.Controls.Add(this.NUM6);
            this.Controls.Add(this.NUM8);
            this.Controls.Add(this.NUM5);
            this.Controls.Add(this.NUM0);
            this.Controls.Add(this.NUM7);
            this.Controls.Add(this.CalculatorDisplay);
            this.Controls.Add(this.NUM4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NUM4;
        private System.Windows.Forms.Label CalculatorDisplay;
        private System.Windows.Forms.Button NUM7;
        private System.Windows.Forms.Button NUM0;
        private System.Windows.Forms.Button NUM5;
        private System.Windows.Forms.Button NUM8;
        private System.Windows.Forms.Button NUM6;
        private System.Windows.Forms.Button NUM9;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NUM3;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button NUM2;
        private System.Windows.Forms.Button NUM1;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
    }
}

