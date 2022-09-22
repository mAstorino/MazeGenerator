using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Effects;

namespace MazeMigraine
{
    /// <summary>
    /// Logica di interazione per UC_MenuPage.xaml
    /// </summary>
    public partial class UC_MenuPage : UserControl
    {
        MainWindow mw;

        DropShadowEffect effect;

        public UC_MenuPage()
        {
            InitializeComponent();

            mw = (MainWindow)Application.Current.MainWindow;
        }

        private void Bt_play_Click(object sender, RoutedEventArgs e)
        {
            // Play button
            MediaPlayer mp = new MediaPlayer();
            mp.Open(new Uri(@"C:\Users\IEUser\Desktop\MazeMigraine\bin\Debug\mp3s\ButtonSound.mp3"));
            mp.Play();

            WIN_Mode wmd = new WIN_Mode();
            wmd.Show();
        }

        private void Bt_scores_Click(object sender, RoutedEventArgs e)
        {
            // Leaderboard button
            MediaPlayer mp = new MediaPlayer();
            mp.Open(new Uri(@"C:\Users\IEUser\Desktop\MazeMigraine\bin\Debug\mp3s\ButtonSound.mp3"));
            mp.Play();

            WIN_Leaderboard wlb = new WIN_Leaderboard();
            wlb.Show();
        }

        private void Bt_quit_Click(object sender, RoutedEventArgs e)
        {
            // Quit button

            MainWindow mw = (MainWindow)Application.Current.MainWindow;
            mw.Close();
        }
    }
}