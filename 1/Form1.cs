using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_1;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // расчет
        private void work_Click(object sender, EventArgs e)
        {
            Summ.Clear();
            Numbers.Clear();
          
            int k,
                Sum;
            // проверка конвертации
            if (Int32.TryParse(Koll.Text, out k)==true)
            {
                // вызов функии из библиотеки
                Sum = Lib_1.RandomAmount.Go(k, Numbers);
                Summ.Text = Sum.ToString();
            }
           
            else
            {
                Koll.Clear();
                MessageBox.Show("Введите корректное значение!");
            }
        }
        // сброс
        private void reset_Click(object sender, EventArgs e)
        {
            Summ.Clear();
            Numbers.Clear();
            Koll.Clear();
        }
        // изменение входного текстбокса
        private void sourceK_TextChanged(object sender, EventArgs e)
        {
            Summ.Clear();
            Numbers.Clear();
            Koll.Clear();
        }
        // о прграмме
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Практическая работа № 1, 15-е задание\n" +
                "Найти сумму n целых, четных, случайных чисел, распределенных в диапазоне от 0 до n. Вывести на экран на одной строке сгенерированные числа, на другой строке результат. \n" +
                "Бароян Гиоргий ИСП-31");
        }
        // выход
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
