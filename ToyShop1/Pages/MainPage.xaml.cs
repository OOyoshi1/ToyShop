﻿using System;
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

namespace ToyShop1.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            
        }

        private void BtnProduct_Click(object sender, RoutedEventArgs e)
        {
            ProductPage pp = new ProductPage();
            FrameClass.frame.Navigate(pp);
            ButtonClass.btn.Visibility = Visibility.Visible;
        }
    }
}
