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

namespace WpfApp1.задание_1
{
    /// <summary>
    /// Логика взаимодействия для Loginn.xaml
    /// </summary>
    public partial class Loginn : Window
    {
        public Loginn()
        {
            InitializeComponent();
        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTb.Text == "admin")
            {
                if (PasswordTb.Password == "123")
                {
                    
                    MessageBox.Show("вы авторизовались!");

                }
                else
                {
                    MessageBox.Show("неправильно введен пароль!!!");
                }
            }
            else
            {
                MessageBox.Show("пользователь с данными данными не найден!! !");
            }
        }
    }
}
