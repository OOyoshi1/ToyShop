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
    public partial class PersonalAreaSellerWindow : Window
    {
        public PersonalAreaSellerWindow(Seller seller)
        {
            InitializeComponent();
            List<Product> products = new List<Product>();
            products = EFClass.context.Product.ToList();
            lvProduct.ItemsSource = products;
            tbFIO.Text = seller.LastName + " " + seller.FirstName + " " + seller.Patronymic;
            tbINN.Text = Convert.ToString(seller.INN);
            tbSellerName.Text = seller.SellerName;

        }

        private void BtnChange_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnChange_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            ButtonClass.btn3.Visibility = Visibility.Visible;
            ButtonClass.btn1.Visibility = Visibility.Hidden;
        }

        private void BtnMore_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnMore_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
