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

namespace VMSURUSH
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
        int s = 0;
        private void desyat_Click(object sender, RoutedEventArgs e)
        {
            s = s + 10;
            string s1 = s.ToString();
            string s2 = s1;
            s2 = "Credit " + s2;
            textBox.Text = s2;
        }


        private void pyatdesyat_Click_1(object sender, RoutedEventArgs e)
        {
            s = s + 50;
            string s1 = s.ToString();
            string s2 = s1;
            s2 = "Credit " + s2;
            textBox.Text = s2;
        }

        private void sto_Click(object sender, RoutedEventArgs e)
        {
            s = s + 100;
            string s1 = s.ToString();
            string s2 = s1;
            s2 = "Credit " + s2;
            textBox.Text = s2;
        }

        private void pyatsot_Click(object sender, RoutedEventArgs e)
        {
            s = s + 500;
            string s1 = s.ToString();
            string s2 = s1;
            s2 = "Credit " + s2;
            textBox.Text = s2;
        }

        private void kosar_Click(object sender, RoutedEventArgs e)
        {
            s = s + 1000;
            string s1 = s.ToString();
            string s2 = s1;
            s2 = "Credit " + s2;
            textBox.Text = s2;
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string s1 = s.ToString();
            string s2 = s1;
            s2 = "Credit " + s2;
            textBox.Text = s2;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            s = s + 1;
            string s1 = s.ToString();
            string s2 = s1;
            s2 = "Credit " + s2;
            textBox.Text = s2;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            s = s + 2;
            string s1 = s.ToString();
            string s2 = s1;
            s2 = "Credit " + s2;
            textBox.Text = s2;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            s = s + 5;
            string s1 = s.ToString();
            string s2 = s1;
            s2 = "Credit " + s2;
            textBox.Text = s2;
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {

        }
    }

}
