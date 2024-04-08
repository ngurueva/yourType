namespace СвойТип
{
    partial class Form2
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
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            textBox7 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox6
            // 
            textBox6.Location = new Point(255, 76);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(33, 31);
            textBox6.TabIndex = 16;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(255, 39);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(33, 31);
            textBox5.TabIndex = 15;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(214, 55);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(35, 31);
            textBox4.TabIndex = 14;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(93, 76);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(36, 31);
            textBox3.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(93, 39);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(36, 31);
            textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(53, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(34, 31);
            textBox1.TabIndex = 11;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(147, 55);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(41, 31);
            textBox7.TabIndex = 17;
            // 
            // button1
            // 
            button1.Location = new Point(93, 141);
            button1.Name = "button1";
            button1.Size = new Size(156, 41);
            button1.TabIndex = 18;
            button1.Text = "Закрыть";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 194);
            Controls.Add(button1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form2";
            Text = "Сравнение";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox7;
        private Button button1;
    }
}