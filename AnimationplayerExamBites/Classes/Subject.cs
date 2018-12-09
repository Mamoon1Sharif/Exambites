using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimationplayerExamBites.Classes
{
    public class Subject
    {
        private string subjectName;
        private Level level ;
        public List<Chapter> chapters;

        public string SubjectName {
            get { return subjectName; }
            set { subjectName = value; }
        }

        public Level Level
        {
            get { return level; }
            set { level = value; }
        }

        public List<Chapter> Chapters
        {
            get {return chapters; }
            set {chapters = value; }
        }


        public Subject(string s, Level level)
        {
            this.subjectName = s;
            this.level = level;
            chapters = new List<Chapter>();
        }


        public Subject()
        {
            

        }


        public List<Chapter> GetChapters()
        {
            return this.chapters;
        }

        
    }
}
