using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
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
        bool con = false;
        int ind = 0;
        public event PropertyChangedEventHandler PropertyChanged;
        static CancellationTokenSource cts;
        CancellationToken ct;
        public MainWindow()
        {
            InitializeComponent();
            maxNumber.Items.Add("100");
            maxNumber.Items.Add("10000");
            maxNumber.Items.Add("1000000");
            maxNumber.Items.Add("100000000");
        }
        private async Task LoadAnimAsync()
        {
            await Task.Run(() => {
                while (ct.IsCancellationRequested == false)
                {
                    load.Content = "-";
                    Thread.Sleep(500);
                    load.Content = "\\";
                    Thread.Sleep(500);
                    load.Content = "|";
                    Thread.Sleep(500);
                    load.Content = "/";
                    Thread.Sleep(500);
                }
            });
        }

        private async void showLoad_Click(object sender, RoutedEventArgs e)
        {
            await LoadAnimAsync();
        }

        private async void allPrimeNumbers_Click(object sender, RoutedEventArgs e)
        {
            if (maxNumber.SelectedItem == null) {
                MessageBox.Show("You have to select every combobox.", "Error", MessageBoxButton.OK);
                return;
            }

            int number = Convert.ToInt32(maxNumber.SelectedItem);
            string text = "";
            cts = new CancellationTokenSource();
            ct = cts.Token;
            await Task.Run(() =>
            {
                for (int i = 1; i < number; i++)
                {
                    if (i <= 1) continue;
                    if (i == 2)
                    {
                        text += i + ", ";
                        continue;
                    }
                    if (i % 2 == 0) continue;

                    var boundary = (int)Math.Floor(Math.Sqrt(i));

                    for (int y = 3; y <= boundary; y += 2)
                        if (i % y == 0)
                            con = true;

                    if (con)
                    {
                        con = false;
                        continue;
                    }

                    text += i + ", ";
                }
                cts.Cancel();
            });
            tbWriteNumbers.Text = text;

        }

        private async void allPrimeNumbersEndThree_Click(object sender, RoutedEventArgs e)
        {
            if (maxNumber.SelectedItem == null)
            {
                MessageBox.Show("You have to select every combobox.", "Error", MessageBoxButton.OK);
                return;
            }

            int number = Convert.ToInt32(maxNumber.SelectedItem);
            string text = "";
            cts = new CancellationTokenSource();
            ct = cts.Token;
            await Task.Run(() =>
            {
                for (int i = 1; i < number; i++)
                {
                    if (i <= 1) continue;
                    if (i == 2)
                    {
                        if (i % (10) == 3)
                            text += i + ", ";
                        continue;
                    }
                    if (i % 2 == 0) continue;

                    var boundary = (int)Math.Floor(Math.Sqrt(i));

                    for (int y = 3; y <= boundary; y += 2)
                        if (i % y == 0)
                            con = true;

                    if (con)
                    {
                        con = false;
                        continue;
                    }

                    if (i % (10) == 3)
                        text += i + ", ";
                }
                cts.Cancel();
            });
            tbWriteNumbersTwo.Text = text;
        }

        private async void allPrimeNumbersEndSeven_Click(object sender, RoutedEventArgs e)
        {
            if (maxNumber.SelectedItem == null)
            {
                MessageBox.Show("You have to select every combobox.", "Error", MessageBoxButton.OK);
                return;
            }

            int number = Convert.ToInt32(maxNumber.SelectedItem);
            string text = "";
            cts = new CancellationTokenSource();
            ct = cts.Token;
            await Task.Run(() =>
            {
                for (int i = 1; i < number; i++)
                {
                    if (i <= 1) continue;
                    if (i == 2)
                    {
                        if (i % (10) == 7)
                            text += i + ", ";
                        continue;
                    }
                    if (i % 2 == 0) continue;

                    var boundary = (int)Math.Floor(Math.Sqrt(i));

                    for (int y = 3; y <= boundary; y += 2)
                        if (i % y == 0)
                            con = true;

                    if (con)
                    {
                        con = false;
                        continue;
                    }

                    if (i % (10) == 7)
                        text += i + ", ";
                }
                cts.Cancel();
            });
            tbWriteNumbersThree.Text = text;
        }
    }
}
