using RAIAPP.Utils;
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

namespace RAIAPP.Views.Pages
{
    /// <summary>
    /// Interaction logic for pAuth.xaml
    /// </summary>
    public partial class pAuth : Page
    {
        public pAuth()
        {
            InitializeComponent();
        }
        private void ShowPasswordTextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            passwordBox.Visibility = Visibility.Collapsed;
            passwordTextBox.Visibility = Visibility.Visible;
            passwordTextBox.Text = passwordBox.Password;
        }
        private void ShowPasswordTextBlock_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            passwordBox.Visibility = Visibility.Visible;
            passwordTextBox.Visibility = Visibility.Collapsed;
        }
        private void authButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (loginTextBlock.Text=="DEMO"&&passwordBox.Password=="DEMO")
                {
                    NavigationService.Navigate(new pDemo());
                    return;
                }
                var currentUser = AppData.DB.Personals.FirstOrDefault(c=>c.PersonalLogin == loginTextBlock.Text
                && c.PersonalPassword == passwordBox.Password);
                if (currentUser != null)
                {
                    NavigationService.Navigate(new pMain());
                }
                else throw new Exception("Пользователь не найден");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Возникла непредвиденная ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
