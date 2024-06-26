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
using System.Windows.Shapes;

namespace ToyShop1.Windows
{
    /// <summary>
    /// Логика взаимодействия для OrderWindow.xaml
    /// </summary>
    public partial class OrderWindow : Window
    {
        public OrderWindow()
        {
            InitializeComponent();
        }

        private void BtnBuy_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Заказ успешно оформлен!");
            this.Close();
        }

        private void tbEmail_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tbEmail.Text == "Электронная почта")
            {
                tbEmail.Text = string.Empty;
                tbEmail.Foreground = Brushes.Gray;
            }
        }

        private void tbEmail_LostFocus(object sender, RoutedEventArgs e)
        {
            if (tbEmail.Text == "")
            {
                tbEmail.Text = "Электронная почта";
                tbEmail.Foreground = Brushes.Gray;
            }
        }

        private void tbAdres_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tbEmail.Text == "Адрес")
            {
                tbEmail.Text = string.Empty;
                tbEmail.Foreground = Brushes.Gray;
            }
        }

        private void tbAdres_LostFocus(object sender, RoutedEventArgs e)
        {
            if (tbEmail.Text == "")
            {
                tbEmail.Text = "Адрес";
                tbEmail.Foreground = Brushes.Gray;
            }
        }

        private void tbPhone_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tbEmail.Text == "Номер телефона")
            {
                tbEmail.Text = string.Empty;
                tbEmail.Foreground = Brushes.Gray;
            }
        }

        private void tbPhone_LostFocus(object sender, RoutedEventArgs e)
        {
            if (tbEmail.Text == "")
            {
                tbEmail.Text = "Номер телефона";
                tbEmail.Foreground = Brushes.Gray;
            }
        }
    }
}
