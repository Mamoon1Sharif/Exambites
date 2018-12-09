using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimationplayerExamBites.Classes
{
    public class Topic
    {
        private string topicName;
        private string videopath;
        private string topicImage;
        private int topicNumber;
        private string topicDescription;
       // private int chapterNumber;
        private Chapter chapter ;


        public string TopicDescription
        {
            get { return topicDescription; }
            set { topicDescription = value; }
        }
        public string TopicName
        {
            get { return topicName; }
            set { topicName = value; }
        }

        public string Videopath
        {
            get { return videopath; }
            set { videopath = value; }
        }
        public string TopicImage
        {
            get { return topicImage; }
            set { topicImage = value; }
        }
        public int TopicNumber
        {
            get { return topicNumber; }
            set { topicNumber = value; }
        }
        
        //public int ChapterNumber
        //{
        //    get { return chapterNumber; }
        //    set { chapterNumber = value; }
        //}
        public Chapter Chapter
        {
            get { return chapter; }
            set { chapter = value; }
        }


        public Topic(string tname,int tno, string timage, Chapter chapter)
        {
            this.topicName = tname;
            this.topicNumber = tno;
            this.topicImage = timage;
            this.chapter=chapter;

        }
        public Topic(string tname, int tno)
        {
            this.topicName = tname;
            this.topicNumber = tno;
            //this.topicImage = timage;


        }
        public Topic()
        {

        }

        public string GetTopic()
        {
           return this.topicName;

        }



    }
}
