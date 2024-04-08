namespace СвойТип
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate()
        {
            try
            {
                // считали значения с полей для ввода и сконвертили в числа
                var firstWhoreNum = int.Parse(textBox1.Text);
                var firstNum = int.Parse(textBox2.Text);
                var firstDenom = int.Parse(textBox3.Text);
                var secondWhoreNum = int.Parse(textBox4.Text);
                var secondNum = int.Parse(textBox5.Text);
                var secondDenom = int.Parse(textBox6.Text);

                // на основании значений создали экземпляры нашего класса Length 
                var firstFraction = new Fraction(firstWhoreNum, firstNum, firstDenom);
                var secondFraction = new Fraction(secondWhoreNum, secondNum, secondDenom);

                var sumLength = firstFraction;

                switch (comboBox1.Text)
                {
                    case "+":
                        sumLength = firstFraction + secondFraction;
                        break;
                    case "-":
                        // если минус, то вычитаем
                        sumLength = firstFraction - secondFraction;
                        break;
                    case "*":
                        // если минус, то вычитаем
                        sumLength = firstFraction * secondFraction;
                        break;
                    case "/":
                        // если минус, то вычитаем
                        sumLength = firstFraction / secondFraction;
                        break;
                    default:
                        sumLength = firstFraction + secondFraction;
                        break;
                }


                // сложили две длины

                string sumAsString = sumLength.Verbose();
                string[] numbers = sumAsString.Split(' ');


                textBox7.Text = numbers[0];
                textBox8.Text = numbers[1];
                textBox9.Text = numbers[2];

            }
            catch (FormatException)
            {
                // если тип преобразовать не смогли
            }
        }


        private void changed(object sender, EventArgs e)
        {
            Calculate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // считали значения с полей для ввода и сконвертили в числа
            var firstWhoreNum = int.Parse(textBox1.Text);
            var firstNum = int.Parse(textBox2.Text);
            var firstDenom = int.Parse(textBox3.Text);
            var secondWhoreNum = int.Parse(textBox4.Text);
            var secondNum = int.Parse(textBox5.Text);
            var secondDenom = int.Parse(textBox6.Text);


            // на основании значений создали экземпляры нашего класса Length 
            var firstFraction = new Fraction(firstWhoreNum, firstNum, firstDenom);
            var secondFraction = new Fraction(secondWhoreNum, secondNum, secondDenom);

            var first = firstFraction.Verbose();
            var second = firstFraction.Verbose();

            Form2 frm2 = new Form2(firstFraction, secondFraction); //где Form2 - название вашей формы
            frm2.Show();



        }
    }
}
