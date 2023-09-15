using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sqlserver.Core
{
    public class WriteFile
    {
        public WriteFile() { }

        public void AddUser(User user)
        {
            using (StreamWriter writer = new StreamWriter("User.txt",append:true))
            {
                writer.WriteLine(user.ToString());

            }
        }
        public string CheckUser(string phonenumber)
        {
            try
            {
                string readText = File.ReadAllText("User.txt");
                string[] strings = readText.Split('\n').ToArray();


                string s1 = "";

                for (int i = 0; i < strings.Length ; i++)
                {
                    string[] strings2 = strings[i].Split('#');
                    if (strings2[3].Equals(phonenumber))
                    {

                        s1 = strings[i];
                        break;
                    }

                }
                return s1;
            }
            catch (Exception)
            {
                string s12="";
                return s12;
            }
        }
        public void UpdateUser(User oldUser, User newUser) 
        {
            string readText = File.ReadAllText("User.txt");
            string[] strings = readText.Split('\n').ToArray();

            File.Delete("User.txt");
            using (StreamWriter writer = new StreamWriter("User.txt", append: true))
            {


                for (int i = 0; i < strings.Length-1; i++)
                {
                    if (strings[i].Remove(strings[i].Length - 1) == oldUser.ToString())
                    {
                        strings[i] = newUser.ToString();
                        writer.WriteLine(strings[i]);
                    }
                    else
                    {
                        writer.WriteLine(strings[i].Remove(strings[i].Length - 1));

                    }
                }
            }



        }

        public string CheckUserCardNumber(string cardNumber)
        {
            try
            {
                string readText = File.ReadAllText("User.txt");
                string[] strings = readText.Split('\n').ToArray();


                string s1 = "";

                for (int i = 0; i < strings.Length; i++)
                {
                    string[] strings2 = strings[i].Split('#');
                    if (strings2[2].Equals(cardNumber))
                    {

                        s1 = strings[i];
                        break;
                    }

                }
                return s1;
            }
            catch (Exception)
            {
                string s12 = "";
                return s12;
            }

        }
        public void AddReport(Report report)
        {
            using (StreamWriter writer = new StreamWriter("Report.txt", append: true))
            {
                writer.WriteLine(report.ToString());

            }
        }
        public List<string> GetHistory(string cardNumber)
        {
            string readText = File.ReadAllText("Report.txt");
            string[] s = readText.Split('\n');
            List<string> s1 = new List<string> { };
            for (int i = 0; i < s.Length-1; i++)
            {
                string[] s11 = s[i].Split('#').ToArray();
                //Report report = new Report(Guid.Parse(s11[0]), s11[1], s11[2], Convert.ToInt32(s11[3].Remove(s11[3].Length-1)));
                if (s11[1] == cardNumber) 
                {

                    s1.Add("Manba : "+s11[2]  + "\tO`tkazildi : " + s11[3]);
                }
                else if (s11[2] == cardNumber)
                {
                    s1.Add("Manba : "+s11[1] + "\tQabul qilindi : " + s11[3]);

                }
            }
            return s1;


        }


    }
}
