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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Duration duration = new(TimeSpan.FromSeconds(0.2));
        public MainWindow()
        {
            InitializeComponent();
        }
        private void OpenDropdown(object sender, RoutedEventArgs e)
        {
            DoubleAnimation animation = new(56, duration);
            border.BeginAnimation(WidthProperty, animation);
        }

        private void CloseDropdown(object sender, RoutedEventArgs e)
        {
            DoubleAnimation animation = new(200, duration);
            border.BeginAnimation(WidthProperty, animation);
        }

        private void opendropdown2(object sender, RoutedEventArgs e)
        {
            DoubleAnimation animation = new(56, duration);
            border2.BeginAnimation(WidthProperty, animation);
        }

        private void CloseDropdown2(object sender, RoutedEventArgs e)
        {
            DoubleAnimation animation = new(200, duration);
            border2.BeginAnimation(WidthProperty, animation);
        }
    }
}
