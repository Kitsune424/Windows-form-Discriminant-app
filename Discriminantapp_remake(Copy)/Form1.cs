using System;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public class Equation
        {
            #region Constructor
            private double A_coef;
            private double B_coef;
            private double C_coef;

            public double A
            {
                get { return A_coef; }
                set { A_coef = value; }
            }

            public double B
            {
                get { return B_coef; }
                set { B_coef = value; }
            }

            public double C
            {
                get { return C_coef; }
                set { C_coef = value; }
            }

            public Equation(double A_coef, double B_coef, double C_coef)
            {
                A = A_coef;
                B = B_coef;
                C = C_coef;
            }
            #endregion

            public double Discriminant()
            {
                double D = B * B - 4 * A * C;
                return D;
            }

            public string Solveequation()
            {
                if (A == 0 & B == 0 & C == 0)
                {
                    return "Корни уравнения могут быть любые";
                }

                else if (A == 0 & B != 0 & C == 0)
                {
                    return "x = 0";
                }

                else
                {
                    if (Discriminant() > 0)
                    {
                        double x1 = (-B + Math.Sqrt(Discriminant())) / (2 * A);
                        double x2 = (-B - Math.Sqrt(Discriminant())) / (2 * A);
                        string x1_a = Math.Round(x1, 2).ToString();
                        string x2_a = Math.Round(x2, 2).ToString();
                        return $"Корни уравнения X = {x1_a} и X = {x2_a}";
                    }

                    if (Discriminant() == 0)
                    {
                        double x = -B / (2 * A);
                        string x_a = Math.Round(x, 2).ToString();
                        return $"Корень уравнения X = {x_a}";
                    }

                    if (Discriminant() < 0)
                    {
                        return "Нет действительных корней";
                    }

                    return "Ну я даже не знаю че ты наделал";
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            ///я не знаю почему, но тут оно не работает, а во второй функции работает
            ///мб с конфигом траблы
        }

        private void Button_Click_1(object sender, EventArgs e)
        {
            try
            {
                #region проверка вводимых данных
                double a = 0;
                double b = 0;
                double c = 0;

                ///Проверка на соответствие числовому формату
                ///используя параметры введенные в форму
                bool a_true = double.TryParse(KoefA.Text, out a);
                bool b_true = double.TryParse(KoefB.Text, out b);
                bool c_true = double.TryParse(KoefC.Text, out c);
                #endregion

                if (a_true & b_true & c_true)
                {
                    Equation eq = new Equation(a, b, c);
                    string answer = eq.Solveequation();
                    x1label.Text = answer;
                }
                else
                {
                    x1label.Text = " ";

                    MessageBox.Show("Какие то из введенных вами значений не соответствуют" +
                        " типу допустимого значения." + " \nВозможно вы ввели текст вместо чисел" +
                        "или не ввели значение.", "Что-то пошло не так....",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {
            }
        }
    }
}


