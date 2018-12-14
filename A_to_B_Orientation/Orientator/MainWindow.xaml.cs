
using System.Windows;

namespace Orientator
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
            Point a = new Point();
            Point b = new Point();
            try
            {
                a.Height = double.Parse(A_Latitude.Text);
                a.Width = double.Parse(A_Longitude.Text);
                b.Height = double.Parse(B_Latitude.Text);
                b.Width = double.Parse(B_Longitude.Text);

                Result.Text = Point.GetAngle(a, b);
            }
            catch
            {
                Result.Text = "Սխալ մուտք.";
            }
        }
    }
}
