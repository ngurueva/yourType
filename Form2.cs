using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace СвойТип
{
    public partial class Form2 : Form
    {
        public Form2(Fraction first, Fraction second)
        {
            InitializeComponent();
            string[] numbers1 = first.Verbose().Split(' ');
            string[] numbers2 = second.Verbose().Split(' ');


            textBox1.Text = numbers1[0];
            textBox2.Text = numbers1[1];
            textBox3.Text = numbers1[2];

            textBox4.Text = numbers2[0];
            textBox5.Text = numbers2[1];
            textBox6.Text = numbers2[2];

            if (first > second)
            {
                textBox7.Text = ">";
            }
            if (first < second)
            {
                textBox7.Text = "<";
            }
            if (first == second)
            {
                textBox7.Text = "=";
            }

            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;
            textBox7.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
