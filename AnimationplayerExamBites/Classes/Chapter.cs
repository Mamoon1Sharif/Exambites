using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace AnimationplayerExamBites.Classes
{
   public class Chapter
    {
        private string chapterName;
        private int chapterNumber;
        private string chapterImage;
        private Subject subject;
        public List<Topic> topics;

             
        public string ChapterName
        {
            get {return chapterName; }
            set { chapterName = value; }
        }

        public Subject Subject
        {
            get { return subject; }
            set { subject = value; }
        }

        public int ChapterNumber
        {
            get { return chapterNumber; }
            set { chapterNumber = value; }

        }

        public List<Topic> Topics
        {
            get {return topics; }
            set {topics = value; }
        }

        
        public string ChapterImage
        {
            get {return chapterImage; }
            set { chapterImage = value; }
        }




        public Chapter(int chpNo , string chpName, string chpImage, Subject subject)
        {
            this.chapterName = chpName;
            this.chapterNumber = chpNo;
            this.chapterImage = chpImage;
            this.subject = subject;
            this.topics = new List<Topic>();


        }

        public Chapter()
        {
        }

        public List<Topic> GetTopics()
        {
            return this.topics;

        }


    }
}
