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
    /// Interaction logic for Послуги.xaml
    /// </summary>
    public partial class Послуги : Window
    {
        int days, vart;

        public Послуги(int days, int vart)
        {
            InitializeComponent();
            this.days = days;
            this.vart = vart;
            List<object> items = new List<object>();
            items.Add(new CheckBox() { Content = "Надання сніданків" });
            items.Add(new CheckBox() { Content = "Міні-бар в номері" });
            items.Add(new CheckBox() { Content = "Паркування автотранспорту" });
            items.Add(new CheckBox() { Content = "SPA-послуги" });
            items.Add(new CheckBox() { Content = "Тренажерний зал" });
            items.Add(new CheckBox() { Content = "Прання, прасування, хімчистка" });
            listBox.ItemsSource = items;
            List<int> items2 = new List<int>() { 50, 250, 50, 150, 70, 100 };
            listBox1.ItemsSource = items2;
            label2.Content = vart;
            label3.Content = 0;
            label4.Content = vart;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int sum = 0;
            int i = 0;
            foreach (CheckBox item in listBox.Items)
            {
                if (item.IsChecked == true)
                    sum += days * (int)listBox1.Items[i];
                i++;
            }
            label3.Content = sum;
            label4.Content = sum + vart;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Main m = new Main("user");
            m.Show();
            this.Close();
        }

        private void listBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ваше замовлення прийнято", "", MessageBoxButton.OK, MessageBoxImage.Information);
            Main m = new Main("user");
            m.Show();
            this.Close();
        }
    }
}