using System;
using System.Collections.Generic;
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
using AnimationplayerExamBites.Classes;
namespace AnimationplayerExamBites.Pages
{
    /// <summary>
    /// Interaction logic for UITopic.xaml
    /// </summary>
    public partial class UITopic : UserControl
    {
        List<Topic> topiclist = new List<Topic>();
       public UITopic()
        {
            InitializeComponent();
            TopicListView.SelectionChanged += TopicListView_SelectionChanged;
                
            List<Topic> topicslist = new List<Topic>();
            

            TopicListView.ItemsSource = topicslist;
        }


        public UITopic(List<Topic> topics)
        {
            topiclist.Clear();
            InitializeComponent();
            TopicListView.SelectionChanged += TopicListView_SelectionChanged;

            topiclist.AddRange(topics);

            TopicListView.ItemsSource = topiclist;
        }

         private void TopicListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var top = TopicListView.SelectedItem as Topic;
           // string url = top.Videopath;
            UIVideoPlayer uIVideoPlayer = new UIVideoPlayer(top);
            Switcher.Switch(uIVideoPlayer);
            

        }

        private void Home_Button_Click(object sender, RoutedEventArgs e)
        {
           // MetaData.mda.Level1.Levelname = 0;
            UILevel uILevel = new UILevel();
            Switcher.Switch(uILevel);
        }

       

        
    }
}
