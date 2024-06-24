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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Add.xaml
    /// </summary>
    public partial class Add : Window
    {
        public Add(Person person)
        {
            InitializeComponent();
            Name.Text = person.Name;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Name.Text != null)
            {
                DialogResult = true;
                Close();
            }
            
        }
    }
}
