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

        }

        private void tbLogin_LostFocus(object sender, RoutedEventArgs e)
        {

        }

        private void tbPass_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void tbPass_LostFocus(object sender, RoutedEventArgs e)
        {

        }

        private void BtnEnter_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow rw = new RegistrationWindow();
            rw.ShowDialog();
        }
    }
}
