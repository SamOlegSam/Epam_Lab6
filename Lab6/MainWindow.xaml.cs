using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            label5.Content = "Ведите через пробел элементы массива";
            textBox1.Height = 25;
            textBox1.Visibility = Visibility.Visible;
            textBox2.Visibility = Visibility.Visible;
            button2.Visibility = Visibility.Visible;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            label5.Content = "";
            textBox1.Text = "";
            textBox2.Text = "";

            textBox1.Visibility = Visibility.Hidden;
            textBox2.Visibility = Visibility.Hidden;
            button3.Visibility = Visibility.Hidden;
            button2.Visibility = Visibility.Hidden;

            label6.Visibility = Visibility.Hidden;
            label7.Visibility = Visibility.Hidden;
            label8.Visibility = Visibility.Hidden;
            label9.Visibility = Visibility.Hidden;
            textBox6.Visibility = Visibility.Hidden;
            textBox7.Visibility = Visibility.Hidden;
            textBox8.Visibility = Visibility.Hidden;
            textBox9.Visibility = Visibility.Hidden;
            textBox10.Visibility = Visibility.Hidden;
            button6.Visibility = Visibility.Hidden;

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            string[] str = textBox1.Text.Split();
            int[] str1 = new int[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                str1[i] = Convert.ToInt32(str[i]);
            }

            textBox2.Text = Convert.ToString(Array1.Addition(str1));
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            label5.Content = "Ведите через пробел элементы массива";
            textBox1.Height = 25;
            textBox1.Visibility = Visibility.Visible;
            textBox2.Visibility = Visibility.Visible;
            button3.Visibility = Visibility.Visible;
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            string[] str = textBox1.Text.Split();
            int[] str1 = new int[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                str1[i] = Convert.ToInt32(str[i]);
            }

            textBox2.Text = Convert.ToString(Array2.AddArray(str1));
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            label5.Content = "Введите через пробел элементы массива отделяя строки ентером";
            textBox1.Height = 100;
            textBox1.AcceptsReturn = true;
            textBox1.Visibility = Visibility.Visible;
            textBox2.Visibility = Visibility.Visible;
            button4.Visibility = Visibility.Visible;

        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            string P;
            string s = textBox1.Text;
            textBox2.Text = Array3.Poloj(s, out P);

        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            label6.Visibility = Visibility.Visible;
            label7.Visibility = Visibility.Visible;
            label8.Visibility = Visibility.Visible;
            label9.Visibility = Visibility.Visible;
            textBox6.Visibility = Visibility.Visible;
            textBox7.Visibility = Visibility.Visible;
            textBox8.Visibility = Visibility.Visible;
            textBox9.Visibility = Visibility.Visible;
            textBox10.Visibility = Visibility.Visible;
            button6.Visibility = Visibility.Visible;
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            var myTuple = Array4.Corteg(textBox6.Text, textBox7.Text, textBox8.Text, Convert.ToDouble(textBox9.Text));
            textBox10.Text = "Название: " + myTuple.Item1 + "\n" + "Вид: " + myTuple.Item2 + "\n" + "Код цветка: " + myTuple.Item3 + "\n" + "средняя цена: " + myTuple.Item4 + "\n" + "соответствует страна: " + myTuple.Item5;
        }
    }
}
