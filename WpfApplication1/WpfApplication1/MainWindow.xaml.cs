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

namespace WpfApplication1
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            heightbox.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            heightbox2.Text = "";

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double w = double.Parse(heightbox2.Text);
            double h = double.Parse(heightbox.Text)/100;
            double r = w / (h*h);
            resultext.Text = r.ToString();

        }
    }
}
