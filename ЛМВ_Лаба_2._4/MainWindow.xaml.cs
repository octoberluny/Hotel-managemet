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

namespace ЛМВ_Лаба_2._4
{
    /// <summary>
    /// Interaction logic for Autorization.xaml
    /// </summary>
    public partial class Autorization : Window
    {
        class Account
        {
            public string login { get; set; }
            public string pass { get; set; }

            public Account(string l, string p)
            {
                login = l;
                pass = p;
            }
        }

        Account[] Users = new Account[] { new Account("admin", "1111"), new Account("user", "1111") };

        public Autorization()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string login = textBox.Text;
            string pass = textBox1.Text;
            bool yes = false;
            foreach (var item in Users)
            {
                if (item.login == login && item.pass == pass)
                {
                    yes = true;
                    login = item.login;
                    pass = item.pass;
                    break;
                }
            }
            if (yes)
            {

                Main main = new Main(login);
                main.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Невірний логін або пароль", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                textBox1.Text = "";
            }
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}