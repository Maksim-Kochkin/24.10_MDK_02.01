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

namespace Пример_2
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

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            InfoTb.DataContext = new List<object>() { "My text" };
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            InfoTb.DataContext = 123;
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            InfoTb.DataContext = new List<object>() { DependencyProperty.UnsetValue };
        }

        private void btn1_C_Click(object sender, RoutedEventArgs e)
        {
            InfoTb1.DataContext = "My text";
        }

        private void btn2_C_Click(object sender, RoutedEventArgs e)
        {
            InfoTb1.DataContext = null;
        }

        private void btn3_C_Click(object sender, RoutedEventArgs e)
        {
            InfoTb1.DataContext = 123;
        }
    }
}
