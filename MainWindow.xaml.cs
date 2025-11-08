using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GitCollab
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginBox.Text;
            string password = PasswordBox.Password;

            // БАГ: неправильная проверка логина и пароля
            if (login == "admin" && password == "12345") // Должно быть && вместо ||
            {
                MessageBox.Show("Авторизация успешна!", "Успех",
                               MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка",
                               MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            WindowReg windowReg = new WindowReg();
            windowReg.Show();
        }
    }
}