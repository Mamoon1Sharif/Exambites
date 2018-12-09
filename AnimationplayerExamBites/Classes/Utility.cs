using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;



namespace AnimationplayerExamBites.Classes
{
   public class Utility
    {

        //private static List<Tuple<string, Object>> populatedList;
        private static Dictionary<string, Topic> dict = new Dictionary<string, Topic>();
        public static List<Topic> resultantlist = new List<Topic>();




        // public static MainWindow UtilityHandle= new MainWindow();
        public static string Serialization()
        {
            MetaData.Metadata.Level1.Add(new Initilization().Initialize(9));
            MetaData.Metadata.Level1.Add(new Initilization().Initialize(10));
            string json = JsonConvert.SerializeObject(MetaData.Metadata , new JsonSerializerSettings()
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                Formatting = Formatting.Indented
            });
            return json;
        }


        public static void encryptionStatus(string output , string input )
        {

            try
            {
                string password = @"myKey123"; // Your Key Here
                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(password);


                //creating new file in USB
                StreamWriter file = new StreamWriter(input);
                file.Close();
                string cryptFile = input;
                
                FileStream fsCrypt = new FileStream(cryptFile, FileMode.Create);

                RijndaelManaged RMCrypto = new RijndaelManaged();

                CryptoStream cs = new CryptoStream(fsCrypt,
                            RMCrypto.CreateEncryptor(key, key),
                            CryptoStreamMode.Write);

                FileStream fsIn = new FileStream(output, FileMode.Open);

                int data;
                while ((data = fsIn.ReadByte()) != -1)
                    cs.WriteByte((byte)data);


                fsIn.Close();
                cs.Close();
                fsCrypt.Close();

                


            }
            catch (Exception r)
            {
                System.Windows.MessageBox.Show(r.Message,"Encryption failed!" );
            }


        }


        public static void decryptStatus(string output , string input)
        {

            try
            {
                string password = @"myKey123"; // Your Key Here

                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(password);


                FileStream fsCrypt = new FileStream(output, FileMode.Open);
                //System.Windows.MessageBox.Show(output);
                RijndaelManaged RMCrypto = new RijndaelManaged();

                CryptoStream cs = new CryptoStream(fsCrypt,
                RMCrypto.CreateDecryptor(key, key),
                CryptoStreamMode.Read);

                FileStream fsOut = new FileStream(input, FileMode.Create);

                int data;
                while ((data = cs.ReadByte()) != -1)
                    fsOut.WriteByte((byte)data);

                fsOut.Close();
                cs.Close();
                fsCrypt.Close();
                


            }

            catch (Exception a)
            {
                System.Windows.MessageBox.Show("Status file decryption failed! ", a.Message);
            }
        }

        public void EncryptVideoFile(string inputFile, string output)
        {
            try
            {

                string password = @"myKey123"; // Your Key Here
                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(password);

                string cryptFile = output;
                FileStream fsCrypt = new FileStream(cryptFile, FileMode.Create);


                System.Security.Cryptography.RijndaelManaged RMCrypto = new RijndaelManaged();

                CryptoStream cs = new CryptoStream(fsCrypt, RMCrypto.CreateEncryptor(key, key), CryptoStreamMode.Write);

                FileStream fsIn = new FileStream(inputFile, FileMode.Open);

                int data;
                while ((data = fsIn.ReadByte()) != -1)
                    cs.WriteByte((byte)data);


                fsIn.Close();
                cs.Close();
                fsCrypt.Close();
               // Console.WriteLine("Edone");

            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message, "Erorrrr");
                


            }
        }

        //anonymus decryption method for async tasks
        public static Task<Boolean> DecryptVideoFileAsync(string output, string input)
        {
            return Task.Run<Boolean>(() =>
            {
                return DecryptVideoFile(output,input);
            });


        }



        //decryption of Video 
        public static  Boolean DecryptVideoFile(string output, string input) // input = encrypted //output = videofile format
        {
            try
            {
                
                    string password = @"myKey123"; // Your Key Here

                    UnicodeEncoding UE = new UnicodeEncoding();
                    byte[] key = UE.GetBytes(password);

                    FileStream fsCrypt = new FileStream(input, FileMode.Open);

                    RijndaelManaged RMCrypto = new RijndaelManaged();

                   // RMCrypto.Padding = PaddingMode.None;

                    CryptoStream cs = new CryptoStream(fsCrypt,
                        RMCrypto.CreateDecryptor(key, key),
                        CryptoStreamMode.Read);

                    FileStream fsOut = new FileStream(output, FileMode.Create);

                    int data;
                    while ((data = cs.ReadByte()) != -1)
                        fsOut.WriteByte((byte)data);

                    fsOut.Close();
                    cs.Close();
                    fsCrypt.Close();
                    return true;
                   
                
            }
            catch (Exception exp)
            {
                System.Windows.MessageBox.Show(exp.ToString());
            }

            return true;
        }


        public static void PopulateList()
        {
            for (int h = 0; h < MetaData.Metadata.Level1.Count; h++)
            {
                for (int i = 0; i < MetaData.Metadata.Level1[h].Subjects.Count; i++)
                {
                    for (int j = 0; j < MetaData.Metadata.Level1[h].Subjects[i].Chapters.Count; j++)
                    {
                        for (int k = 0; k < MetaData.Metadata.Level1[h].Subjects[i].Chapters[j].Topics.Count; k++)
                        {
                           // MessageBox.Show(MetaData.Metadata.Level1[h].Subjects[i].Chapters[j].Topics[k].TopicName);
                            string s = MetaData.Metadata.Level1[h].Subjects[i].Chapters[j].Topics[k].TopicName + MetaData.Metadata.Level1[h].Subjects[i].Chapters[j].Topics[k].TopicDescription;

                            Topic t = new Topic();
                            t = MetaData.Metadata.Level1[h].Subjects[i].Chapters[j].Topics[k];
                            
                            Utility.dict.Add(s,t); // new List<Tuple<string, Topic>>();
                        }



                    }
                }

            }

            //MessageBox.Show(populatedList.ToString());

        }


        public static bool DetectClockManipulation(DateTime thresholdTime)
        {
            DateTime adjustedThresholdTime = new DateTime(thresholdTime.Year, thresholdTime.Month, thresholdTime.Day, 23, 59, 59);
           // MessageBox.Show(adjustedThresholdTime.ToLongDateString());
            EventLog eventLog = new System.Diagnostics.EventLog("system");
            if(eventLog == null)
            {
                MessageBox.Show("null");
                
            }
            foreach (EventLogEntry entry in eventLog.Entries)
            {
                //MessageBox.Show(entry.TimeWritten.ToLongDateString());

                if (entry.TimeWritten > adjustedThresholdTime)
                {

                    return true;
                }
            }
            return false;
        }


        public static List<Topic> Search(string s)
        {
            int count = 0;

           
            if( Utility.dict.Count != 0 )
            {
                for(int i = 0; i < Utility.dict.Count; i++)
                {
                   if(Utility.dict.ElementAt(i).Key.Contains(s))
                    {
                        resultantlist[count] = Utility.dict.ElementAt(i).Value;
                        count++;
                    }



                }
                return resultantlist;
            }
            

            return resultantlist;
        }







    }
}
