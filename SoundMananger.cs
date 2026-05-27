using System.Media;
using System.Windows;

namespace Cyber
{
    public static class SoundManager
    {
        public static void PlayWelcomeSound()
        {
            try
            {
                SoundPlayer player =
                    new SoundPlayer(
                        Cyber.Properties.Resources.Jili);

                player.Play();
            }
            catch
            {
                MessageBox.Show(
                    "Welcome to the Cybersecurity Awareness Bot!");
            }
        }
    }
}