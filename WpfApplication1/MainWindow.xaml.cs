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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            myFrame.NavigationService.Navigate(new ToDoAddV());
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            myFrame.NavigationService.Navigate(new reviewV());
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            myFrame.NavigationService.Navigate(new ChangeV());
        }
    }
}
