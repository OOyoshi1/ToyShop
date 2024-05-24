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
    /// Логика взаимодействия для ProductPage.xaml
    /// </summary>
    public partial class ProductPage : Page
    {
        public ProductPage()
        {
            InitializeComponent();
            List <Product> products = new List<Product>();
            products = EFClass.context.Product.ToList();
            lvProduct.ItemsSource = products;
            WindowClass.label.Visibility = Visibility.Visible;
            ButtonClass.btn3.Visibility = Visibility.Visible;
        }

        private void BtnInfo_Click(object sender, RoutedEventArgs e)
        {
            Product product = new Product();
            product = (Product)((Button)sender).DataContext;
            ProductInfoPage pi = new ProductInfoPage(product);
            FrameClass.frame.Navigate(pi);
            
        }

        private void BtnBuy_Click(object sender, RoutedEventArgs e)
        {
            Product product = new Product();
            product = (Product)((Button)sender).DataContext;
            ProductClass.products.Add(product);
        }
    }
}
