using System;
using System.Collections.Generic;
using System.Globalization;
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
using ToyShop1.DB;
using ToyShop1.Classes;

namespace ToyShop1.Windows
{
    /// <summary>
    /// Логика взаимодействия для AutorizationWindow.xaml
    /// </summary>
    public partial class AutorizationWindow : Window
    {
        public AutorizationWindow()
        {
            InitializeComponent();
        }

        private void tbLogin_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tbLogin.Text == "Логин")
            {
                tbLogin.Text = string.Empty;
                tbLogin.Foreground = Brushes.Black;
            }
        }

        private void tbLogin_LostFocus(object sender, RoutedEventArgs e)
        {
            if (tbLogin.Text == "")
            {
                tbLogin.Foreground = Brushes.Gray;
                tbLogin.Text = "Логин";
            }
        }

        private void tbPass_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tbPass.Text == "Пароль")
            {
                tbPass.Text = string.Empty;
                tbPass.Foreground = Brushes.Black;
            }
        }

        private void tbPass_LostFocus(object sender, RoutedEventArgs e)
        {
            if (tbPass.Text == "")
            {
                tbPass.Foreground = Brushes.Gray;
                tbPass.Text = "Пароль";
            }
        }

        private void BtnEnter_Click(object sender, RoutedEventArgs e)
        {
            var Auth = EFClass.context.User.Where(x => x.Login == tbLogin.Text && x.Password == tbPass.Text).FirstOrDefault();
            if (Auth != null)
            {
                MessageBox.Show("ОК!");
                MainWindow main = new MainWindow();
                main.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Пользователь не существует", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.Show();
            this.Close();
        }
    }
}
