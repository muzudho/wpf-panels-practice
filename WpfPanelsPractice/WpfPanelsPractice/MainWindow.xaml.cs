namespace WpfPanelsPractice
{
    using System.Windows;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid1Button_Click(object sender, RoutedEventArgs e)
        {
            var window = new Grid1Window();
            window.Show();
        }

        private void Grid2Button_Click(object sender, RoutedEventArgs e)
        {
            var window = new Grid2Window();
            window.Show();
        }

        private void Grid3Button_Click(object sender, RoutedEventArgs e)
        {
            var window = new Grid3Window();
            window.Show();
        }
    }
}
