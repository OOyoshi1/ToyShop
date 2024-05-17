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
    /// Логика взаимодействия для ProductInfoPage.xaml
    /// </summary>
    public partial class ProductInfoPage : Page
    {
        public ProductInfoPage(Product product)
        {
            InitializeComponent();
            Seller seller = new Seller();
            seller = EFClass.context.Seller.Where(x => x.IdSeller == product.IdSeller).FirstOrDefault();
            tb1.Text = product.NameOfProduct;
            tb2.Text = product.Description;
            tb3.Text = seller.LastName + " " + seller.FirstName + " " + seller.Patronymic;
            tb4.Text= seller.SellerName;
            BtnPrice.Content = Convert.ToString(product.Price);
            WindowClass.label3.Visibility = Visibility.Visible;
            WindowClass.label.Visibility = Visibility.Hidden;
            ButtonClass.btn1.Visibility = Visibility.Hidden;
            ButtonClass.btn2.Visibility = Visibility.Hidden;
            ButtonClass.btn.Visibility = Visibility.Hidden;
            ButtonClass.btn5.Visibility = Visibility.Hidden;
            ButtonClass.btn4.Visibility = Visibility.Hidden;
            ButtonClass.btn3.Visibility = Visibility.Hidden;
            ButtonClass.btn6.Visibility = Visibility.Visible;
        }

        private void BtnBuy_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
