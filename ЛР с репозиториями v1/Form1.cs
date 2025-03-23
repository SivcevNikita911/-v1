using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛР_с_репозиториями_v1
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Конструктор формы.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        float a, b;
        int count;
        bool znak = true;

        /// <summary>
        /// Обработчик события нажатия кнопки "0".
        /// </summary>
        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }
        /// <summary>
        /// Обработчик события нажатия кнопки "1".
        /// </summary>
        private void one_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        /// <summary>
        /// Обработчик события нажатия кнопки "2".
        /// </summary>
        private void two_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        /// <summary>
        /// Обработчик события нажатия кнопки "3".
        /// </summary>
        private void there_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        /// <summary>
        /// Обработчик события нажатия кнопки "4".
        /// </summary>
        private void chetiri_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        /// <summary>
        /// Обработчик события нажатия кнопки "5".
        /// </summary>
        private void five_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        /// <summary>
        /// Обработчик события нажатия кнопки "6".
        /// </summary>
        private void six_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        /// <summary>
        /// Обработчик события нажатия кнопки "7".
        /// </summary>
        private void seven_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        /// <summary>
        /// Обработчик события нажатия кнопки "8".
        /// </summary>
        private void eght_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        /// <summary>
        /// Обработчик события нажатия кнопки "9".
        /// </summary>
        private void nine_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }


        /// <summary>
        /// Обработчик события нажатия кнопки удаления последнего символа.
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }
        /// <summary>
        /// Выполняет вычисление в зависимости от выбранной операции.
        /// </summary>
        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Обработчик события нажатия кнопки сложения.
        /// </summary>
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                a = float.Parse(textBox1.Text);
                textBox1.Clear();
                count = 1;
                label1.Text = a.ToString() + "+";
                znak = true;
            }
            catch
            {
                MessageBox.Show("введите значение");
            }
        }

        /// <summary>
        /// Обработчик события нажатия кнопки вычитания.
        /// </summary>
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                a = float.Parse(textBox1.Text);
                textBox1.Clear();
                count = 2;
                label1.Text = a.ToString() + "-";
                znak = true;
            }
            catch
            {
                MessageBox.Show("введите значение");
            }
        }

        /// <summary>
        /// Обработчик события нажатия кнопки умножения.
        /// </summary>
        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                a = float.Parse(textBox1.Text);
                textBox1.Clear();
                count = 3;
                label1.Text = a.ToString() + "*";
                znak = true;
            }
            catch
            {
                MessageBox.Show("введите значение");
            }
        }

        /// <summary>
        /// Обработчик события нажатия кнопки деления.
        /// </summary>
        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                a = float.Parse(textBox1.Text);
                textBox1.Clear();
                count = 4;
                label1.Text = a.ToString() + "/";
                znak = true;
            }
            catch
            {
                MessageBox.Show("введите значение");
            }
        }

        /// <summary>
        /// Обработчик события нажатия кнопки равенства.
        /// </summary>
        private void rovno_Click(object sender, EventArgs e)
        {
            calculate();
            label1.Text = "";
        }

        /// <summary>
        /// Обработчик события нажатия кнопки добавления запятой.
        /// </summary>
        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        /// <summary>
        /// Обработчик события нажатия кнопки изменения знака.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            if (znak == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                znak = false;
            }
            else if (znak == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                znak = true;
            }
        }

        /// <summary>
        /// Обработчик события нажатия кнопки очистки текстового поля.
        /// </summary>
        private void clirTextBox_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

    }
}
