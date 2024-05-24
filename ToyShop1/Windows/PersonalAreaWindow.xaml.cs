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
using ToyShop1.Classes;
using ToyShop1.DB;

namespace ToyShop1.Windows
{
    /// <summary>
    /// Логика взаимодействия для PersonalAreaWindow.xaml
    /// </summary>
    public partial class PersonalAreaWindow : Window
    {
        public PersonalAreaWindow()
        {
            InitializeComponent();
            List<Product> products = new List<Product>();
            products = EFClass.context.Product.ToList();
            lvProduct.ItemsSource = products;
           
            tbFIO.Text = CurrentUserClass.client.LastName + " " + CurrentUserClass.client.FirstName + " " + CurrentUserClass.client.Patronymic;
            tbPhone.Text = CurrentUserClass.client.Phone;
            tbAdres.Text = CurrentUserClass.client.Order.FirstOrDefault().Address;

        }

        private void BtnChange_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnChange_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnMore_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
