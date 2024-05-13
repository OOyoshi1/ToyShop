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
        }

        private void BtnCart_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnEnter_Click(object sender, RoutedEventArgs e)
        {
            AutorizationWindow aw = new AutorizationWindow();

            aw.ShowDialog();
        }

        private void BtnProduct_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnInfo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnPersonal_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
