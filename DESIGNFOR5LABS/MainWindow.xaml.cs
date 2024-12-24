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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MyFrame.Content = new Menu1();
            this.Width = 900;
            this.Height = 800;

            // Запрещаем изменение размера окна
            this.ResizeMode = ResizeMode.NoResize;
        }
        private void MyFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
