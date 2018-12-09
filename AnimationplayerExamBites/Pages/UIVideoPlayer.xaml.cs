using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Threading;
using AnimationplayerExamBites.Classes;
using FontAwesome.WPF;

namespace AnimationplayerExamBites.Pages
{
    /// <summary>
    /// Interaction logic for UIVideoPlayer.xaml
    /// </summary>
    public partial class UIVideoPlayer : UserControl
    {
        DispatcherTimer timer;

        public WindowStartupLocation WindowStartupLocation { get; }
        Topic top = new Topic();
        static string  ESource;
        public static string DSource;

        //public static string source;
        public UIVideoPlayer( Topic t)
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(500);
            timer.Tick += Timer_Tick; //+= and pressed tab twice
           
            //string a = timer.GetType;
            this.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            

            top = t;
            ESource = MainWindow.Dpath + t.TopicName + ".exbt";
            DSource = MainWindow.Dpath + "temp/"  + t.TopicName + ".mp4";

            TaskingVideoPlayer();
            //Utility.DecryptVideoFile(DSource, ESource);
            //Play(DSource);
        }

        async void TaskingVideoPlayer()
        {
            try
           {
               
                DecodingSpinner.Visibility = Visibility.Visible;
                DecodingSpinner.Spin = true;
                
                Boolean decryptDone = await Utility.DecryptVideoFileAsync(DSource, ESource);
                if(decryptDone)
                {
                    
                    
                   
                    Play(DSource);
                    DecodingSpinner.Spin = false;
                    DecodingSpinner.Visibility = Visibility.Hidden;
                }
                
               
            }
            catch(Exception ex)
            {
                MessageBox.Show("Can't open file");
               
            }



        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            slider_slack.Value = MyMediaElement.Position.TotalSeconds;
        }
        public  void Play(string s)
        {
            MyMediaElement.Source = new Uri(@s);
            MyMediaElement.Play();
          



        }



        private void Play_Button_Click(object sender, RoutedEventArgs e)
        {
            MyMediaElement.Play();
           
        }

        private void Pause_Button_Click(object sender, RoutedEventArgs e)
        {
            MyMediaElement.Pause();

        }

        private void Stop_Button_Click(object sender, RoutedEventArgs e)
        {
            MyMediaElement.Stop();


        }

        private void Slider_slack_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            MyMediaElement.Position = TimeSpan.FromSeconds(slider_slack.Value);

        }

        private void Slider_volume_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            MyMediaElement.Volume = (double)slider_volume.Value;

        }
       

    private void MyMediaElement_MediaOpened(object sender, RoutedEventArgs e)
        {
            TimeSpan ts = MyMediaElement.NaturalDuration.TimeSpan;
            slider_slack.Maximum = ts.TotalSeconds;
            timer.Start();
          //  MyMediaElement.Source = new Uri(@"F:\work\repos\exambites\exambites\Resources\C1 A5 Prefixes.mp4");

        }
        private void drop_win(object sender, DragEventArgs e)
        {
            string filename = (string)((DataObject)e.Data).GetFileDropList()[0];
            MyMediaElement.Source = new Uri(filename);
            MyMediaElement.LoadedBehavior = MediaState.Manual; //changing feature of mediaelement to control it from code
            MyMediaElement.UnloadedBehavior = MediaState.Manual;
            MyMediaElement.Volume = (double)slider_volume.Value;
            MyMediaElement.Play();
        }

        private void Home_Button_Click(object sender, RoutedEventArgs e)
        {
            
            UILevel uILevel = new UILevel();
            Switcher.Switch(uILevel);

            
        }

        private void MyMediaElement_MediaEnded(object sender, RoutedEventArgs e)
        {
            if (File.Exists(DSource))
            {
                File.Delete(DSource);
            }
        }
    }
}
