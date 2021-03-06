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

namespace StopAndGoGenerator.UI.Views
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void GeneratorButton_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new GeneratorPage());
        }

        private void Szyfrator_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EncryptionPage());
        }

        private void Deszyfrator_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DecryptionPage());
        }

        private void TestsButton_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TestPage());
        }
    }
}
