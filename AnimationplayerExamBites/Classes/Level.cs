using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimationplayerExamBites.Classes
{
    public class Level
    {

        private int levelname;
        private List<Subject> subjects = new List<Subject>();

        public int Levelname {
            get {return levelname; }
            set { levelname = value; }
        }


        public List<Subject> Subjects
        {
            get { return subjects; }
            set { subjects = value; }
        }



        public Level(int i)
        {
                this.levelname = i;
               
        }

        public Level()
        {


        }


        public List<Subject> GetSubjects()
        {
            return this.subjects;
        }



       

           

        
    }
}
