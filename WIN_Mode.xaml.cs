using System.Windows;

namespace MazeMigraine
{
    /// <summary>
    /// Logica di interazione per WIN_Mode.xaml
    /// </summary>
    public partial class WIN_Mode : Window
    {
        MainWindow mw;

        public WIN_Mode()
        {
            InitializeComponent();

            mw = (MainWindow)Application.Current.MainWindow;

            this.Title = "LEVEL SELECTION";
        }

        private void Bt_easy_Click(object sender, RoutedEventArgs e)
        {
            WIN_LevelSelection wls = new WIN_LevelSelection("Easy");
            wls.Show();
            this.Close();
        }

        private void Bt_normal_Click(object sender, RoutedEventArgs e)
        {
            WIN_LevelSelection wls = new WIN_LevelSelection("Normal");
            wls.Show();
            this.Close();
        }

        private void Bt_difficult_Click(object sender, RoutedEventArgs e)
        {
            WIN_LevelSelection wls = new WIN_LevelSelection("Difficult");
            wls.Show();
            this.Close();
        }

        private void Bt_migraine_Click(object sender, RoutedEventArgs e)
        {
            WIN_LevelSelection wls = new WIN_LevelSelection("Migraine");
            wls.Show();
            this.Close();
        }

        private void Bt_back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = (MainWindow)Application.Current.MainWindow;
            if (!mw.IsVisible)
                mw.Show();
            this.Close();
        }
    }
}
