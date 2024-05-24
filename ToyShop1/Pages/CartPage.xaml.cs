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
using ToyShop1.Classes;
using ToyShop1.DB;

namespace ToyShop1.Pages
{
    /// <summary>
    /// Логика взаимодействия для CartPage.xaml
    /// </summary>
    public partial class CartPage : Page
    {
        decimal orderprice;
        public CartPage()
        {
            InitializeComponent();
            lvCart.ItemsSource = ProductClass.products;
            if (ProductClass.products != null)
            {
                foreach (Product p in ProductClass.products)
                {

                    p.Price = p.Quantity * p.Price;
                    orderprice += p.Price;



                }
            }
            tb_Sum.Text = orderprice.ToString();
        }

        private void BtnBuy_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnInfo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnOrder_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
