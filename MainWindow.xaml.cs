﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Projekt_Algorytmy
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FSzescienna fSzescienna = new FSzescienna();
            fSzescienna.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Wielomian wielomian = new Wielomian();
            wielomian.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MonteCarlo monteCarlo = new MonteCarlo();
            monteCarlo.Show();
        }
    }
}