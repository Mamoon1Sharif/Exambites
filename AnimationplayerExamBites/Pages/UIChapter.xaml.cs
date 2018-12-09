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
    /// Interaction logic for UIChapter.xaml
    /// </summary>
    public partial class UIChapter : UserControl


    {
         List<Chapter> chaplist ;
         List<Topic> topiclist ;


        public UIChapter()
        {
            InitializeComponent();
             chaptersList.SelectionChanged += ChaptersList_SelectionChanged;

        }
        public UIChapter(List<Chapter> chaps)
        {
            
            InitializeComponent();
            //chaplist.Clear();
           // MessageBox.Show(chaps.Count().ToString());
            chaplist = new List<Chapter>(chaps);
            chaptersList.SelectionChanged += ChaptersList_SelectionChanged;
            
            //  MessageBox.Show(chaplist[0].ChapterName.ToString());

            
            chaptersList.ItemsSource = chaplist;


        }

        private void ChaptersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //topiclist.Clear();
            var chp = chaptersList.SelectedItem as Chapter;

            topiclist = new List<Topic>(chp.Topics);
           // topiclist.AddRange(chp.Topics);
            UITopic uITopic = new UITopic(topiclist);
            Switcher.Switch(uITopic);
        }































































        
        private void Home_Button_Click(object sender, RoutedEventArgs e)
        {
           // MetaData.mda.Level1.Levelname = 0;
            UILevel uILevel = new UILevel();
            Switcher.Switch(uILevel);
            
            

        }

        /*private void Topic_Button_Click(object sender, RoutedEventArgs e)
        {
           
            UITopic uITopic = new UITopic();
            Switcher.Switch(uITopic);

        }
        */
    }
    /*public class Img
    {
        public string ChapImage;

        public Img(string path)
        {
            this.ChapImage = path;

        }


    }*/


}
