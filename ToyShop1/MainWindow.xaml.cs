using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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
using ToyShop1.Pages;
using ToyShop1.Windows;

namespace ToyShop1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrameClass.frame = mainFrame;
            MainPage mp = new MainPage();
            mainFrame.Navigate(mp);
            WindowClass.label3 = Label3;
            WindowClass.label = Label;
            ButtonClass.btn = BtnBack;
            ButtonClass.btn2 = BtnCart;
            ButtonClass.btn3 = BtnEnter;
            ButtonClass.btn1 = BtnPersonal;
            ButtonClass.btn4 = BtnProduct;
            ButtonClass.btn5 = BtnInfo;
            ButtonClass.btn6 = BtnBack2;
            
        }
        
        private void BtnCart_Click(object sender, RoutedEventArgs e)
        {
            CartPage cartPage = new CartPage();
            mainFrame.Navigate(cartPage);
            Label.Visibility = Visibility.Hidden;
            Label2.Visibility = Visibility.Visible;
        }

        private void BtnEnter_Click(object sender, RoutedEventArgs e)
        {
            AutorizationWindow aw = new AutorizationWindow();

            aw.ShowDialog();
        }

        private void BtnProduct_Click(object sender, RoutedEventArgs e)
        {
            ProductPage pp = new ProductPage();
            mainFrame.Navigate(pp);
            BtnBack.Visibility = Visibility.Visible;
            BtnPersonal.Visibility = Visibility.Visible;
            Label.Visibility = Visibility.Visible;
            BtnEnter.Visibility = Visibility.Hidden;
        }

        private void BtnInfo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnPersonal_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            MainPage mp = new MainPage();
            mainFrame.Navigate(mp);
            Label.Visibility = Visibility.Hidden;
            BtnBack.Visibility = Visibility.Hidden;
        }

        private void BtnBack2_Click(object sender, RoutedEventArgs e)
        {
            ProductPage pp2 = new ProductPage();
            mainFrame.Navigate(pp2);
            BtnBack2.Visibility = Visibility.Hidden;
            Label3.Visibility = Visibility.Hidden;
            ButtonClass.btn1.Visibility = Visibility.Visible;
            ButtonClass.btn2.Visibility = Visibility.Visible;
            ButtonClass.btn.Visibility = Visibility.Visible;
            ButtonClass.btn5.Visibility = Visibility.Visible;
            ButtonClass.btn4.Visibility = Visibility.Visible;
            ButtonClass.btn3.Visibility = Visibility.Visible;
        }
    }
}
