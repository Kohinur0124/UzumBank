using Sqlserver.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sqlserver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public WriteFile writeFile = new WriteFile();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            text_boxs2.Visible = false;
        }

        public string[] s;
        private void button_WOC1_Click(object sender, EventArgs e)
        {
            /* User user = new User("+998939613663");
             user.FullName = "Xayriddinova Sevinch";
             user.CardNumber = "8600312912585573";
             user.Amount = 1000000;
             user.Password = "Password";

             writeFile.AddUser(user);*/
            if (text_boxs2.Visible != true) 
            {
                string phonenumber = text_boxs1.Text;
                if (Check.CheckedPhoneNumber(phonenumber))
                {
                    CheckPhone.ForeColor = Color.Gray;
                    CheckPhone.Text = "";

                    s =writeFile.CheckUser(text_boxs1.Text).Split('#').ToArray();
                    if (s.Length==8)
                    {
                        text_boxs1.ReadOnly = true;
                        label3.Visible=true;
                        text_boxs2.Visible=true;
                        button_WOC1.Text = "Kirish";
                    }
                    else
                    {
                        Form2 form2 = new Form2(phonenumber);
                        form2.Show();
                        this.Hide();
                    }

                }
                else
                {
                    CheckPhone.ForeColor = Color.Red;
                    CheckPhone.Text = "Telefon raqam noto`g`ri kiritilgan !!!";
                }
            }
            else
            {
                string s12 = text_boxs2.Text;
                // MessageBox.Show(s11);
                //s[5]=s[5].Remove(s[5].Length - 1);
                if (s12 == s[5])
                {

                    string[] s1 = s;
                    User user = new User(s1[3]);
                    user.id = Guid.Parse(s1[0]);
                    user.FullName = s1[1];
                    user.CardNumber = s1[2];
                    user.Amount = int.Parse(s1[4]);
                    user.Password = s1[5];
                    user.Currency = s1[6];
                    user.Cashback =Convert.ToInt32(s1[7]);

                    Form3 form3 = new Form3(user);
                    form3.Show();
                    this.Hide();

                }
                else
                {
                    CheckPass.ForeColor = Color.Red;
                    CheckPass.Text = "Parollar mos kelmadi !!!"; 
                }
            }
        }
    }
}
