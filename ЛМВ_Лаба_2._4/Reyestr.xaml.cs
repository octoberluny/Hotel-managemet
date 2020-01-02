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
    /// Interaction logic for Reyestr.xaml
    /// </summary>
    public partial class Reyestr : Window
    {
        int days, vart, dod;

        public Reyestr()
        {
            InitializeComponent();
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
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
           
        }

       
         private void button_Click(object sender, RoutedEventArgs e)
        {
            Пошук_номеру p = new Пошук_номеру();
            if (p.ShowDialog() == true)
            {
                textBox.Text = p.text;
                days = p.days;
                vart = p.vart;
                label8.Content = vart;
                label9.Content = dod;
                label10.Content = vart + dod;
            }
        }       
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            int sum = 0;
            int i = 0;
            foreach (CheckBox item in listBox.Items)
            {
                if (item.IsChecked == true)
                    sum += days * (int)listBox1.Items[i];
                i++;
            }
            label9.Content = sum;
            label10.Content = sum + vart;
        }

        private void button_Click_2(object sender, RoutedEventArgs e)
        {
            Пошук_номеру p = new Пошук_номеру();
            if (p.ShowDialog() == true)
            {
                textBox.Text = p.text;
                days = p.days;
                vart = p.vart;
                label8.Content = vart;
                label9.Content = dod;
                label10.Content = vart + dod;
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Main m = new Main("admin");
            m.Show();
            this.Close();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || vart == 0)
                MessageBox.Show("Не введені всі дані", "", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                MessageBox.Show("Ваше замовлення прийнято", "", MessageBoxButton.OK, MessageBoxImage.Information);
                Main m = new Main("admin");
                m.Show();
                this.Close();
            }
        }
    }
}