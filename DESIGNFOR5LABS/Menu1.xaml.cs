﻿using System;
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
    /// Логика взаимодействия для Menu1.xaml
    /// </summary>
    public partial class Menu1 : Page
    {
        public Menu1()
        {
            InitializeComponent();
        }
        private void MyFrame1_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyFrame1.Navigate(new Uri("DfsAndBfs.xaml", UriKind.Relative));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MyFrame1.Navigate(new Uri("Prima.xaml", UriKind.Relative));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MyFrame1.Navigate(new Uri("Diijksta.xaml", UriKind.Relative));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MyFrame1.Navigate(new Uri("FordFulkerson.xaml", UriKind.Relative));
        }
    }
}
