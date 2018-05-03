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

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double value = Math.Round(heightslider.Value, 1);
            heightnumber.Text = value.ToString();
            double v = (value / 200) * 439.2;
            Canvas.SetLeft( Height, v);

            double h = double.Parse(heightnumber.Text);
            double w = double.Parse(weightnumber.Text);
            double bmi = w / Math.Pow((h / 100), 2);
            string[] parts = bmi.ToString().Split('.');
            bminumber1.Text = parts[0];
            if(parts.Length>1)
            {
                bminumber2.Text = "." + parts[1];
            }
            else
            {
                bminumber2.Text = ".0";
            }
               
        }
    }
}
