using Newtonsoft.Json;
using Numeria.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AnimationplayerExamBites.Classes
{
   public class MetaData
    {
        private static bool flag = true;
        private List<Level> level1 = new List<Level>();
        private static MetaData metadata;
        public List<Level> Level1
        {
            get { return level1; }
            set { level1 = value; }
        }
        public static MetaData Metadata
        {
            get
            {
                if(metadata == null)
                {
                    metadata = new MetaData();
                    return metadata;
                }
                return metadata;

            }
           
        }

        private MetaData( )
        {
            

        }

        public void Init(string json)
        {
            if(flag)
            {
                //  metadata =   // deserilize()
                //  MetaData.metadata = JsonConvert.DeserializeObject<MetaData>(json);
               var test = JsonConvert.DeserializeObject<MetaData>(json);
               // System.Windows.MessageBox.Show(test.Level1[0].Subjects[0].Chapters.Count.ToString());
                flag = false;
            }
            else
            {
                throw new System.ArgumentException("Cannot initilize Metadata twice", "Double initilize"); ;
            }
        }





        //public string Serialization()
        //{

        //    mda.level1.Add(new Initilization().Initialize(9));
        //    mda.level1.Add(new Initilization().Initialize(9));
        //    string json = JsonConvert.SerializeObject(mda);
        //    return json;



        //}

        /*  public void Serialization(int a)
          {
              mda.Level1.Add(Initialize(9));
              string json = JsonConvert.SerializeObject(mda.level1);
            //  File.WriteAllText(@"F:\work\repos\AnimationplayerExamBites\AnimationplayerExamBites\Resources\j.json", json);
            //  File.Create(@"F:\work\repos\AnimationplayerExamBites\AnimationplayerExamBites\Resources\jEnc.exbt");
            //  EncryptFile(@"F:\work\repos\AnimationplayerExamBites\AnimationplayerExamBites\Resources\j.json", @"F:\work\repos\AnimationplayerExamBites\AnimationplayerExamBites\Resources\jEnc.exbt");

             // mda.level1.Initialize(10);
             // json = JsonConvert.SerializeObject(mda.level1);

             // File.WriteAllText(@"F:\work\repos\AnimationplayerExamBites\AnimationplayerExamBites\Resources\j1.json", json);
             // File.Create(@"F:\work\repos\AnimationplayerExamBites\AnimationplayerExamBites\Resources\jEnc2.exbt");
             // EncryptFile(@"F:\work\repos\AnimationplayerExamBites\AnimationplayerExamBites\Resources\j1.json" , @"F:\work\repos\AnimationplayerExamBites\AnimationplayerExamBites\Resources\jEnc2.exbt");

            //  File.Delete(@"F:\work\repos\AnimationplayerExamBites\AnimationplayerExamBites\Resources\j.json");
             // File.Delete(@"F:\work\repos\AnimationplayerExamBites\AnimationplayerExamBites\Resources\j1.json");

          } */

        //public string DeSerialization(int i)
        //{
        //    string abc = "";
        //    if(i==9)
        //    {
        //        DecryptFile(@"F:\work\repos\AnimationplayerExamBites\AnimationplayerExamBites\Resources\jEnc.exbt", @"F:\work\repos\AnimationplayerExamBites\AnimationplayerExamBites\Resources\j9.json");
        //        StreamReader r = new StreamReader(@"F:\work\repos\AnimationplayerExamBites\AnimationplayerExamBites\Resources\j9.json");

        //        //  string json9 = File.rea (@"F:\work\repos\AnimationplayerExamBites\AnimationplayerExamBites\Resources\j9.json");
        //        // Console.WriteLine(json9);
        //        string json9 = r.ReadToEnd();
        //        r.Close();
                
        //        MetaData.mda = JsonConvert.DeserializeObject<MetaData>(json9);
        //        File.Delete(@"F:\work\repos\AnimationplayerExamBites\AnimationplayerExamBites\Resources\j9.json");
        //        return json9;
                
        //    }
        //    else if(i==10)
        //    {
        //        DecryptFile(@"F:\work\repos\AnimationplayerExamBites\AnimationplayerExamBites\Resources\jEnc2.exbt", @"F:\work\repos\AnimationplayerExamBites\AnimationplayerExamBites\Resources\j10.json");
        //        string json10 = File.ReadAllText(@"F:\work\repos\AnimationplayerExamBites\AnimationplayerExamBites\Resources\j10.json");
        //        MetaData.mda = JsonConvert.DeserializeObject<MetaData>(json10);
        //        File.Delete(@"F:\work\repos\AnimationplayerExamBites\AnimationplayerExamBites\Resources\j10.json");
        //        return json10;
        //    }



        //    return abc;
        //}


       


       


    }




}

