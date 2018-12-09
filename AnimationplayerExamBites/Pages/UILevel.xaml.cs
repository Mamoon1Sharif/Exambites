using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AnimationplayerExamBites.Classes;
using Newtonsoft.Json;

namespace AnimationplayerExamBites.Pages
{
    /// <summary>
    /// Interaction logic for UILevel.xaml
    /// </summary>
    public partial class UILevel : UserControl
    {
        List<Subject> sub;
        
        

        public UILevel()
        {
            
            // string json = MetaData.mda.Serialization();
            //MetaData.mda = JsonConvert.DeserializeObject<MetaData>(json);
            sub = new List<Subject>();
            InitializeComponent();
            

        }

        private void Home_Button_Click(object sender, RoutedEventArgs e)
        {
          //  MetaData.mda.Level1.Levelname = 0;
            UILevel uILevel = new UILevel();
            Switcher.Switch(uILevel);

        }

        private void Level9_Button_Click(object sender, RoutedEventArgs e)
        {
            sub.Clear();

            sub = MetaData.Metadata.Level1[0].Subjects;
            


            UISubject uISubject = new UISubject(sub); // pasing 9th subject list to next ui
            Switcher.Switch(uISubject);
           

        }

        private void Level10_Button_Click(object sender, RoutedEventArgs e)
        {
            sub.Clear();
            sub = MetaData.Metadata.Level1[1].Subjects;
            UISubject uISubject = new UISubject(sub);
            Switcher.Switch(uISubject);

        }

        private void Search_Button_Click(object sender, RoutedEventArgs e)
        {
            string s = serachbox.Text;
            List<Topic> topics =  Utility.Search(s);
            UITopic uITopic = new UITopic(topics);
            Switcher.Switch(uITopic);


        }
    }
}
