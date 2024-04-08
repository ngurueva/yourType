namespace СвойТип
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            comboBox1 = new ComboBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(70, 126);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(34, 31);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += changed;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(110, 110);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(36, 31);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += changed;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(110, 147);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(36, 31);
            textBox3.TabIndex = 2;
            textBox3.TextChanged += changed;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(233, 126);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(35, 31);
            textBox4.TabIndex = 3;
            textBox4.TextChanged += changed;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(274, 110);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(33, 31);
            textBox5.TabIndex = 4;
            textBox5.TextChanged += changed;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(274, 147);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(33, 31);
            textBox6.TabIndex = 5;
            textBox6.TextChanged += changed;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "+", "-", "*", "/" });
            comboBox1.Location = new Point(166, 126);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(51, 33);
            comboBox1.TabIndex = 6;
            comboBox1.Text = "+";
            comboBox1.SelectedIndexChanged += changed;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(372, 126);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(35, 31);
            textBox7.TabIndex = 7;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(413, 110);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(35, 31);
            textBox8.TabIndex = 8;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(413, 147);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(35, 31);
            textBox9.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(331, 132);
            label1.Name = "label1";
            label1.Size = new Size(24, 25);
            label1.TabIndex = 10;
            label1.Text = "=";
            // 
            // button1
            // 
            button1.BackColor = Color.AliceBlue;
            button1.Location = new Point(114, 209);
            button1.Name = "button1";
            button1.Size = new Size(154, 50);
            button1.TabIndex = 11;
            button1.Text = "Сравнить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 70);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 12;
            label2.Text = "Дробь 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(233, 70);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 13;
            label3.Text = "Дробь 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(372, 70);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 14;
            label4.Text = "Ответ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(516, 315);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(comboBox1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Калькулятор дробей";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private ComboBox comboBox1;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
