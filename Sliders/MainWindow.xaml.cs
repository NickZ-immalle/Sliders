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

namespace Sliders
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Ellipse ellipse;

        public MainWindow()
        {
            InitializeComponent();

            vertSlider.Minimum = 0;
            vertSlider.Maximum = paperCanvas.Height;

            horizSlider.Minimum = 0;
            horizSlider.Maximum = paperCanvas.Width;

            vertLabel.Content = Convert.ToString(vertSlider.Value);
            horizLabel.Content = Convert.ToString(horizSlider.Value);

            CreateEllipse();
        }

        private void CreateEllipse()
        {
            ellipse = new Ellipse();
            ellipse.Width = horizSlider.Value;
            ellipse.Height = vertSlider.Value;
            ellipse.Stroke = new SolidColorBrush(Colors.RosyBrown);
            ellipse.Fill = new SolidColorBrush(Colors.RosyBrown);
            ellipse.Margin = new Thickness(0, 0, 0, 0);
            paperCanvas.Children.Add(ellipse);
        }
        private void UpdateEllipse()
        {
            ellipse.Width = horizSlider.Value;
            ellipse.Height = vertSlider.Value;
        }

        private void vertSlider_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int Vertical = Convert.ToInt32(vertSlider.Value);
            vertLabel.Content = Convert.ToString(Vertical);
            UpdateEllipse();
        }

        private void horizSlider_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int horizontal = Convert.ToInt32(horizSlider.Value);
            horizLabel.Content = Convert.ToString(horizontal);
            UpdateEllipse();
        }
    }
}
