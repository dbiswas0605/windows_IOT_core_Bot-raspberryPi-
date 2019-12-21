using BOT;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Bot
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        MyBot mybot;

        public MainPage()
        {
            this.InitializeComponent();
            mybot = new MyBot();
        }

        private async void ButtonUP_Click(object sender, RoutedEventArgs e)
        {
            Direction.Text = "UP";
            mybot.moveForward();
            await Task.Delay(TimeSpan.FromSeconds(5));
            mybot.stop();
        }

        private async void ButtonRight_Click(object sender, RoutedEventArgs e)
        {
            Direction.Text = "RIGHT";
            mybot.turnRight();
            await Task.Delay(TimeSpan.FromSeconds(5));
            mybot.stop();
        }

        private async void ButtonDown_Click(object sender, RoutedEventArgs e)
        {
            Direction.Text = "DOWN";
            mybot.moveBackward ();
            await Task.Delay(TimeSpan.FromSeconds(5));
            mybot.stop();
        }

        private async void ButtonLeft_Click(object sender, RoutedEventArgs e)
        {
            Direction.Text = "LEFT";
            mybot.turnLeft();
            await Task.Delay(TimeSpan.FromSeconds(5));
            mybot.stop();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Direction.Text = "stop";
            mybot.stop();
        }
    }
}
