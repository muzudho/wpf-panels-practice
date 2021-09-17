namespace WpfPanelsPractice
{
    using System.Windows;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindowView : Window
    {
        public MainWindowView()
        {
            InitializeComponent();
        }

        private void Grid1Button_Click(object sender, RoutedEventArgs e)
        {
            var window = new Grid1WindowView();
            window.Show();
        }

        private void Grid2Button_Click(object sender, RoutedEventArgs e)
        {
            var window = new Grid2WindowView();
            window.Show();
        }

        private void Grid3Button_Click(object sender, RoutedEventArgs e)
        {
            var window = new Grid3WindowView();
            window.Show();
        }

        private void Grid4Button_Click(object sender, RoutedEventArgs e)
        {
            var window = new Grid4WindowView();
            window.Show();
        }
    }
}
