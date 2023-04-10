using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a, b;
            a = textBox1.Text;
            b = textBox2.Text;
            switch (comboBox1.Text)
            {
                case "да":
                    textBox3.Text = string.Format("{0}, вы ввели число {1}.", b, a);
                    ;
                    break;
                case "нет":
                    textBox3.Text = string.Format("Ну и ладно, хотя там {0}.", a);
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(textBox1.Text);
            if (radioButton1.Checked == true)
                textBox4.Text = Convert.ToString(a * a);
            else if (radioButton2.Checked == true)
                textBox4.Text = Convert.ToString(a * a * a);
            else if (radioButton3.Checked == true)
                textBox4.Text = Convert.ToString(a);
            else
                MessageBox.Show("Выберите, в какую степень возводить!");



        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                string stroka = "полученный ответ" + textBox1.Text + "В квадрате" + textBox4.Text + Environment.NewLine;
                System.IO.File.AppendAllText(@"G:\9076\тест\text.txt", stroka);
            }
            else if (radioButton2.Checked == true)
            {
                string stroka = "полученный ответ" + textBox1.Text + "В кубе" + textBox4.Text + Environment.NewLine;
                System.IO.File.AppendAllText(@"G:\9076\тест\text.txt", stroka);
            }
            else 
            {
                string stroka = "полученный ответ" + textBox1.Text + "В степень не возводили" + textBox4.Text + Environment.NewLine;
                System.IO.File.AppendAllText(@"G:\9076\тест\text.txt", stroka);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Тогда введите данные еще раз!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
