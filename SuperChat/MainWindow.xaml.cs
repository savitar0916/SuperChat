using System.Windows;
using System.Windows.Input;

namespace SuperChat
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

        private void Border_MouseDown(object sender, MouseButtonEventArgs eventArgs)
        {
            if(eventArgs.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Button_Click_Minimize(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        private void Button_Click_WindowState(object sender, RoutedEventArgs e)
        {
            if(Application.Current.MainWindow.WindowState != WindowState.Maximized)
            {
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
            }
            else
            {
                Application.Current.MainWindow.WindowState = WindowState.Normal;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_Close(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
