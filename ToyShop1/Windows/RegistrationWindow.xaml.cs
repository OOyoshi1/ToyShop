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
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
            cbGen.ItemsSource = EFClass.context.Gender.ToList();
            cbGen.SelectedIndex = 1;
            cbGen.DisplayMemberPath = "NameOfGender";
            cbRole.ItemsSource = EFClass.context.UserRole.Where(x => x.NameOfRole != "Администратор" && x.NameOfRole != "Техническая поддержка").ToList();
            cbRole.SelectedIndex = 2;
            cbRole.DisplayMemberPath = "NameOfRole";
        }

        private void tbPass_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tbPass.Text == "Пароль")
            {
                tbPass.Text = string.Empty;
                tbPass.Foreground = Brushes.Gray;
            }
        }

        private void tbPass_LostFocus(object sender, RoutedEventArgs e)
        {
            if (tbPass.Text == "")
            {
                tbPass.Foreground = Brushes.Gray;
                tbPass.Text = "Пароль";
            }
        }

        private void tbLName_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tbLName.Text == "Фамилия")
            {
                tbLName.Foreground = Brushes.Gray;
                tbLName.Text = "";
            }
        }

        private void tbLName_LostFocus(object sender, RoutedEventArgs e)
        {
            if (tbLName.Text == "")
            {
                tbLName.Foreground = Brushes.Gray;
                tbLName.Text = "Фамилия";
            }
        }

        private void tbFName_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tbFName.Text == "Имя")
            {
                tbFName.Foreground = Brushes.Gray;
                tbFName.Text = "";
            }

        }

        private void tbFName_LostFocus(object sender, RoutedEventArgs e)
        {
            if (tbFName.Text == "")
            {
                tbFName.Foreground = Brushes.Gray;
                tbFName.Text = "Имя";
            }
        }

        private void tbPatronymic_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tbPatronymic.Text == "Отчество")
            {
                tbPatronymic.Foreground = Brushes.Gray;
                tbPatronymic.Text = "";
            }
        }

        private void tbPatronymic_LostFocus(object sender, RoutedEventArgs e)
        {
            if (tbPatronymic.Text == "")
            {
                tbPatronymic.Foreground = Brushes.Gray;
                tbPatronymic.Text = "Отчество";
            }
        }

        private void tbPhone_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tbPhone.Text == "Номер телефона")
            {
                tbPhone.Foreground = Brushes.Gray;
                tbPhone.Text = "";
            }
        }

        private void tbPhone_LostFocus(object sender, RoutedEventArgs e)
        {
            if (tbPhone.Text == "")
            {
                tbPhone.Foreground = Brushes.Gray;
                tbPhone.Text = "Номер телефона";
            }
        }

        private void BtnEnter_Click(object sender, RoutedEventArgs e)
        {
            AutorizationWindow autorizationWindow = new AutorizationWindow();
            autorizationWindow.Show();
            this.Close();
        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            User u = new User() {
                Login = tbLogin.Text,
                Password = tbPass.Text,
                IdUserRole = (cbRole.SelectedItem as UserRole).IdUserRole,
            };

            EFClass.context.User.Add(u);
            EFClass.context.SaveChanges();
            EFClass.context.Client.Add(
                new Client
                {
                    IdUser = u.IdUser,
                    FirstName = tbFName.Text,
                    LastName = tbFName.Text,
                    Patronymic = tbPatronymic.Text,
                    Birthday = Convert.ToDateTime(tbBirthday.Text),
                    Email = tbEmail.Text,
                    IdGender = (cbGen.SelectedItem as Gender).IdGender,
                    Phone = tbPhone.Text

                });
            EFClass.context.SaveChanges();
            MessageBox.Show("Регистрация прошла успешно", "Успех");
            this.Close();

        }

        private void tbLogin_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tbLogin.Text == "Логин")
            {
                tbLogin.Text = string.Empty;
                tbLogin.Foreground = Brushes.Gray;
            }
        }

        private void tbLogin_LostFocus(object sender, RoutedEventArgs e)
        {
            if (tbLogin.Text == "")
            {
                tbLogin.Foreground = Brushes.Gray;
                tbLogin.Text = "Логин";
            }
        }

        private void tbBirthday_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tbBirthday.Text == "Дата рождения")
            {
                tbBirthday.Foreground = Brushes.Gray;
                tbBirthday.Text = "";
            }
        }

        private void tbEmail_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tbEmail.Text == "Электронная почта")
            {
                tbEmail.Foreground = Brushes.Gray;
                tbEmail.Text = "";
            }
        }

        private void tbSel_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tbSel.Text == "Название огранизации")
            {
                tbSel.Foreground = Brushes.Gray;
                tbSel.Text = "";
            }
        }

        private void tbInn_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tbInn.Text == "ИНН")
            {
                tbInn.Foreground = Brushes.Gray;
                tbInn.Text = "";
            }
        }

        private void tbBirthday_LostFocus(object sender, RoutedEventArgs e)
        {
            if (tbBirthday.Text == "")
            {
                tbBirthday.Foreground = Brushes.Gray;
                tbBirthday.Text = "Дата рождения";
            }
        }

        private void tbSel_LostFocus(object sender, RoutedEventArgs e)
        {
            if (tbSel.Text == "")
            {
                tbSel.Foreground = Brushes.Gray;
                tbSel.Text = "Название огранизации";
            }
        }

        private void tbInn_LostFocus(object sender, RoutedEventArgs e)
        {
            if (tbInn.Text == "")
            {
                tbInn.Foreground = Brushes.Gray;
                tbInn.Text = "ИНН";
            }
        }

        private void tbEmail_LostFocus(object sender, RoutedEventArgs e)
        {
            if (tbEmail.Text == "")
            {
                tbEmail.Foreground = Brushes.Gray;
                tbEmail.Text = "Электронная почта";
            }
        }
    }
}
