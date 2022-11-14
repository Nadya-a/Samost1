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
using System.Windows.Shapes;
using System.IO;


namespace Самостоялка1
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            string[] Mass = File.ReadAllLines(@"C:\Users\Nadya\Desktop\тест.txt", Encoding.Default);
            task1.Text = Mass[4];
            task2.Text = Mass[6];
        }

        private void Button_Check(object sender, RoutedEventArgs e)
        {
            string[] Mass = File.ReadAllLines(@"C:\Users\Nadya\Desktop\тест.txt", System.Text.Encoding.Default);

            if (num1.Text == Mass[5])
                num1.Background = Brushes.LightGreen;
            else
                num1.Background = Brushes.LightBlue;

            if (num2.Text == Mass[7])
                num2.Background = Brushes.LightGreen;
            else
                num2.Background = Brushes.LightBlue;

            if (num1.Text == Mass[5] && num2.Text == Mass[7])
            {
                Check.Content = "Bcë правильно";
                Check.Background = Brushes.Green;
            }
            else if (num1.Text == Mass[5] || num2.Text == Mass[7])
            {
                Check.Content = "Где-то ошибка";
                Check.Background = Brushes.Yellow;
            }
            else
            {
                Check.Content = "Неправильно";
                Check.Background = Brushes.Red;
            }
        }

        private void Button_Next(object sender, RoutedEventArgs e)
        {
            Window2 Window2 = new Window2();
            this.Close();
            Window2.ShowDialog();
        }
    }
}
