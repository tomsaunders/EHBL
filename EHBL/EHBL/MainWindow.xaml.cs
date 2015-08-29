using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EHBL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            helpLabel.Visibility = Visibility.Hidden;
            optionsLabel.Visibility = Visibility.Hidden;
            gamesLabel.Visibility = Visibility.Hidden;
        }   

        private void Games_Click(object sender, RoutedEventArgs e)
        {
            helpLabel.Visibility = Visibility.Hidden;
            optionsLabel.Visibility = Visibility.Hidden;
            gamesLabel.Visibility = Visibility.Visible;
        }

        private void Options_Click(object sender, RoutedEventArgs e)
        {
            helpLabel.Visibility = Visibility.Hidden;
            optionsLabel.Visibility = Visibility.Visible;
            gamesLabel.Visibility = Visibility.Hidden;
        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {
            helpLabel.Visibility = Visibility.Visible;
            optionsLabel.Visibility = Visibility.Hidden;
            gamesLabel.Visibility = Visibility.Hidden;
        }
    }
}
