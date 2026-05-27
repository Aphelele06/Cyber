using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Cyber
{
    public partial class MainWindow : Window
    {
        private BotMemory memory =
            new BotMemory();

        public MainWindow()
        {
            InitializeComponent();

            // PLAY WELCOME SOUND
            SoundManager.PlayWelcomeSound();

            // WELCOME MESSAGE
            // ASCII BOT
            string asciiBot =
            @" 
   ╔══════════════════════╗
   ║   CYBER ASCII BOT    ║
   ╚══════════════════════╝
          \   ^__^
           \  (oo)\_______
              (__)\       )\/\
                  ||----w |
                  ||     ||

   [ CYBERSECURITY GUARD ]
";

            ChatBox.AppendText(
                asciiBot + "\n");

            ChatBox.AppendText(
                "BOT: Welcome to the Cybersecurity Awareness Bot.\n");

            ChatBox.AppendText(
                "BOT: I am here to help you understand online safety and cyber threats.\n");

            ChatBox.AppendText(
                "BOT: Before we begin, please enter your name.\n\n");

            ChatScroll.ScrollToEnd();
        }
        // SEND BUTTON
        private async void SendButton_Click(
            object sender,
            RoutedEventArgs e)
        {
            string input =
                UserInputBox.Text.Trim();

            // EMPTY INPUT CHECK
            if (string.IsNullOrWhiteSpace(input))
                return;

            // USER MESSAGE
            ChatBox.AppendText(
                $"YOU: {input}\n");

            ChatScroll.ScrollToEnd();

            // CLEAR INPUT
            UserInputBox.Clear();

            // TYPING EFFECT
            ChatBox.AppendText(
                "BOT: typing...\n");

            ChatScroll.ScrollToEnd();

            await Task.Delay(700);

            // REMOVE typing...
            ChatBox.Text =
                ChatBox.Text.Replace(
                    "BOT: typing...\n",
                    "");

            // GET RESPONSE
            string response =
                BotResponse.GetResponse(
                    input,
                    memory);

            // SHOW BOT RESPONSE
            ChatBox.AppendText(
                $"BOT: {response}\n\n");

            ChatScroll.ScrollToEnd();

            // EXIT COMMAND
            if (input.ToLower() == "exit")
            {
                await Task.Delay(1200);

                Application.Current.Shutdown();
            }
        }

        // ENTER TO SEND
        private void UserInputBox_KeyDown(
            object sender,
            KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                SendButton_Click(sender, e);
            }
        }
    }
}