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

namespace DESIGNFOR5LABS
{
    /// <summary>
    /// Логика взаимодействия для FordFulkerson.xaml
    /// </summary>
    public partial class FordFulkerson : Page
    {
        public FordFulkerson()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyFRame2.Navigate(new Uri("Menu1.xaml", UriKind.Relative));

        }
    }
}
