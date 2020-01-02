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
    /// Interaction logic for Brone.xaml
    /// </summary>
    public partial class Brone : Window
    {
        int tsina;
        int days;
        int vart;

        public Brone()
        {
            InitializeComponent();
        }

        private void radioButton_Checked(object sender, RoutedEventArgs e)
        {
            listBox.Items.Clear();
            listBox.Items.Add(new ListBoxItem() { Content = "101" });
            tsina = 400;
        }

        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {
            listBox.Items.Clear();
            listBox.Items.Add(new ListBoxItem() { Content = "111" });
            tsina = 600;
        }

        private void radioButton2_Checked(object sender, RoutedEventArgs e)
        {
            listBox.Items.Clear();
            listBox.Items.Add(new ListBoxItem() { Content = "121" });
            tsina = 900;
        }

        private void radioButton3_Checked(object sender, RoutedEventArgs e)
        {
            listBox.Items.Clear();
            listBox.Items.Add(new ListBoxItem() { Content = "131" });
            tsina = 1200;
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listBox.SelectedIndex == -1)
            {
                textBox.Text = "";
                label2.Content = "";
                button.IsEnabled = false;
                button2.IsEnabled = false;
            }
            else
            {
                button.IsEnabled = true;
                button2.IsEnabled = true;
                
                if (radioButton.IsChecked == true)
                {
                    label2.Content = "400 грн";
                    textBox.Text = "Затишна кімната (11 кв.м) з односпальним ліжком, зручні сучасні меблі, ванна кімната, обладнана душем або ванною.";
                }
                if (radioButton1.IsChecked == true)
                {
                    label2.Content = "600 грн";
                    textBox.Text = "Однокімнатний номер, загальною площею 20-25 кв.м. В номері: зручні меблі, велике двоспальне або два односпальних ліжка, ванна кімната з сучасним обладнанням.";
                }
                if (radioButton2.IsChecked == true)
                {
                    label2.Content = "900 грн";
                    textBox.Text = "Просторий двокімнатний номер загальною площею 40-50 кв.м. Номер складається з великої вітальні з м’яким куточком та затишної спальні.";
                }
                if (radioButton3.IsChecked == true)
                {
                    label2.Content = "1200 грн";
                    textBox.Text = "Трикімнатний номер з панорамним видом на Майдан Незалежності загальною площею більше 50 кв.м. В номері: спальня з ліжком „king size”, кабінет з робочим столом та кріслом, затишна вітальня.";
                }
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (radioButton.IsChecked == true)

                tsina = 400;
            else
                if (radioButton1.IsChecked == true)
                tsina = 600;
            else
                if (radioButton2.IsChecked == true)
                tsina = 900;
            else
                if (radioButton3.IsChecked == true)
                tsina = 1200;
            try
            {
                DateTime d1 = DateTime.Parse(data1.Text);
                DateTime d2 = DateTime.Parse(data2.Text);
                days = (d2 - d1).Days;
                if (days <= 0)
                    throw new Exception();
                vart = days * tsina;
                label3.Content = vart + " грн";
            }
            catch
            {
                MessageBox.Show("Неправильно вказано дату!", "", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Main m = new Main("user");
            Autorization a = new Autorization();
            a.Close();
            m.Show();
            this.Close();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DateTime d1 = DateTime.Parse(data1.Text);
                DateTime d2 = DateTime.Parse(data2.Text);
                days = (d2 - d1).Days;
                if (days <= 0)
                    throw new Exception();
                vart = days * tsina;
                Послуги m = new Послуги(days, vart);
                m.Show();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Неправильно вказано дату!", "", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
        }
    }
}