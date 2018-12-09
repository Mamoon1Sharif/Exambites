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
    /// Interaction logic for UISubject.xaml
    /// </summary>
    public partial class UISubject : UserControl
    {
         List<Subject> subjlist ;

      //  List<Int32> copy = new List<Int32>(original)
        List<Chapter> chaplist ;
 
        public UISubject( List<Subject> subjects)
        {
            

            InitializeComponent();
            //subjlist.Clear();
            subjlist = new List<Subject>(subjects);
            


            try
            {
                PhysicsButton.ToolTip = subjlist[0].SubjectName;
                chemistryButton.ToolTip = subjlist[1].SubjectName;
                BiologyButton.ToolTip = subjlist[2].SubjectName;
                MathsButton.ToolTip = subjlist[3].SubjectName;
                
                

            } 
            catch(Exception exp)
            {
                MessageBox.Show(exp.ToString());

            }






        }
        public UISubject()
        {
            //InitializeComponent();
            
        }

        private void Home_Button_Click(object sender, RoutedEventArgs e)
        {
           // MetaData.mda.Level1.Levelname = 0;
            UILevel uILevel = new UILevel();
            Switcher.Switch(uILevel);

        }

        private void Bio_Button_Click(object sender, RoutedEventArgs e)

        {
            // chaplist.Clear();

            //Subject sub = MetaData.mda.level.subjects[2];
            // List<Chapter> chaps =  subjlist[2].chapters;

            chaplist = new List<Chapter>(subjlist[2].Chapters);
            // chaplist.AddRange(subjlist[2].chapters);
           // MessageBox.Show(chaplist.Count().ToString());
            // MessageBox.Show();


            UIChapter uIChapter = new UIChapter(chaplist);
            Switcher.Switch(uIChapter);

        }

        private void Chemistry_Button_Click(object sender, RoutedEventArgs e)
        {
            //chaplist.Clear();
            //  List<Chapter> chaps = subjlist[1].chapters;
            chaplist = new List<Chapter>(subjlist[1].Chapters);
            //chaplist.AddRange(subjlist[1].chapters);
            UIChapter uIChapter = new UIChapter(chaplist);
            Switcher.Switch(uIChapter);

        }

        private void Physics_Button_Click(object sender, RoutedEventArgs e)
        {
            //chaplist.Clear();
            // List<Chapter> chaps = subjlist[0].chapters;
            // chaplist.AddRange(subjlist[0].chapters);

            chaplist = new List<Chapter>(subjlist[0].Chapters);
            UIChapter uIChapter = new UIChapter(chaplist);
            Switcher.Switch(uIChapter);
        }

        private void Maths_Button_Click(object sender, RoutedEventArgs e)
        {
            // chaplist.Clear();
            // List<Chapter> chaps = subjlist[3].chapters;
            // chaplist.AddRange(subjlist[3].chapters);

            chaplist = new List<Chapter>(subjlist[3].Chapters);
            UIChapter uIChapter = new UIChapter(chaplist);
            Switcher.Switch(uIChapter);
        }
    }
}
