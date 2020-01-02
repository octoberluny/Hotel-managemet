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

namespace ЛМВ_Лаба_2._4
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Main(string login)
        {
            InitializeComponent();
            if (login == "admin")
            {
                label1.Content += "Адміністратор";
                button.Content = "Зареєструвати клієнта";
                button.Click += Reyestr;
            }
            if (login == "user")
            {
                label1.Content += "Клієнт";
                button.Content = "Бронювати номер";
                button.Click += Brone;
            }
        }
        void Brone(object sender, RoutedEventArgs e)
        {
            ЛМВ_Лаба_2._4.Brone b = new Brone();
            b.Show();
            this.Close();
            
        }

        void Reyestr(object sender, RoutedEventArgs e)
        {
            ЛМВ_Лаба_2._4.Reyestr r = new Reyestr();
            r.Show();
            this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button3_Click(object sender, RoutedEventArgs e)

        {
            ЛМВ_Лаба_2._4.Autorization au = new Autorization();
            au.Show();
            this.Close();
           
        }
    }
}
