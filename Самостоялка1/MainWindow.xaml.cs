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
using System.IO;

namespace Самостоялка1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string[] Mass = File.ReadAllLines(@"C:\Users\Nadya\Desktop\тест.txt", System.Text.Encoding.Default);
            task1.Text = Mass[0];
            task2.Text = Mass[2];
        }

        private void Button_Check(object sender, RoutedEventArgs e)
        {
            string[] Mass = File.ReadAllLines(@"C:\Users\Nadya\Desktop\тест.txt", System.Text.Encoding.Default);


            if (num1.Text == Mass[1])
                num1.Background = Brushes.LightGreen;  
            else
                num1.Background = Brushes.LightBlue;

            if (num2.Text == Mass[3])
                num2.Background = Brushes.LightGreen;
            else
                num2.Background = Brushes.LightBlue;

            if (num1.Text == Mass[1] && num2.Text == Mass[3])
            {
                Check.Content = "Bcë правильно";
                Check.Background = Brushes.Green;
            }
            else if (num1.Text == Mass[1] || num2.Text == Mass[3])
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
            Window1 Window1 = new Window1();
            this.Close();
            Window1.ShowDialog();
        }
    }
}
