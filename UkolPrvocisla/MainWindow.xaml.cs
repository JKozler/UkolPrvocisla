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

namespace UkolPrvocisla
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            variants.Items.Add("Find all prime number.");
            variants.Items.Add("Find all prime numbers with 2 numbers.");
            variants.Items.Add("Find all prime numbers with 3 numbers.");
            maxNumber.Items.Add("100");
            maxNumber.Items.Add("10000");
            maxNumber.Items.Add("1000000");
            maxNumber.Items.Add("100000000");
        }

        private void findPrime_Click(object sender, RoutedEventArgs e)
        {
            if (variants.SelectedItem == null || maxNumber.SelectedItem == null)
                MessageBox.Show("You have to select every combobox.", "Error", MessageBoxButton.OK);
        }
    }
}
