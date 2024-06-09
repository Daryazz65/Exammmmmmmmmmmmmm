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

namespace WpfApp1.задание_2
{
    /// <summary>
    /// Логика взаимодействия для Oknoo.xaml
    /// </summary>
    public partial class Oknoo : Window
    {
        public Oknoo()
        {
            InitializeComponent();
            MainFrame.Navigate(new Oknoo());
        }

        private void OpenListBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Oknoo());

        }

        private void AddItemBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Oknoo());

        }
    }
}
