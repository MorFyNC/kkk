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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LstView.ItemsSource = DBManager.Get();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var p = new Person();
            p.Id = Guid.NewGuid().ToString();
            p.Name = Name.Text;
            DBManager.Add(p);
            Name.Text = "";
            LstView.ItemsSource = DBManager.Get();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var p = LstView.SelectedItem as Person;
            if (p == null) return;
            DBManager.Remove(p);
            LstView.ItemsSource = DBManager.Get();
        }
    }
}
