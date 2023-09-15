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
    public partial class Form4 : Form
    {
        public User user;
        public Form4(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(user);
            form3.Show();
            this.Hide();
        }

        public string[] s;

        private void Form4_Load(object sender, EventArgs e)
        {


            label4.Text = "**** **** **** " + user.CardNumber[12] + user.CardNumber[13] + user.CardNumber[14] + user.CardNumber[15];
            label5.Text = user.Amount + " " + user.Currency;
           
        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            if (Check.CheckCardNumber(text_boxs1.Text))
            {
                WriteFile writeFile = new WriteFile();
                s = writeFile.CheckUserCardNumber(text_boxs1.Text).Split('#').ToArray();
                if (s.Length == 8)
                {
                    CheckCard.ForeColor = Color.Gray;
                    CheckCard.Text = s[1];
                    text_boxs1.ReadOnly = true;
                }
                else
                {
                    CheckCard.ForeColor = Color.Red;
                    CheckCard.Text = "Oluvchi topilmadi !!!";
                }

            }
        }

        private void button_WOC4_Click(object sender, EventArgs e)
        {
            if (text_boxs2.Text.Length > 0)
            {
                label8.Text = "Kommissiya : " + Convert.ToInt32(text_boxs2.Text) * 0.006;
                label9.Text = "Cashback : " + Convert.ToInt32(text_boxs2.Text) * 0.01;
                if (Convert.ToInt32(text_boxs2.Text) + Convert.ToInt32(text_boxs2.Text) * 0.006 > user.Amount)
                {
                    label7.Visible = true;
                    label8.Visible = false;
                    label9.Visible = false;
                    button_WOC1.Visible = false;
                }
                else
                {
                    label7.Visible = false;
                    label8.Visible = true;
                    label9.Visible = true;
                    button_WOC1.Visible = true;
                }
            }
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.RecipientCard = text_boxs1.Text;
            report.SenderCardNumber = user.CardNumber;
            report.Payment = Convert.ToInt32(text_boxs2.Text);
            WriteFile write= new WriteFile();
            write.AddReport(report);
            User newUser = new User(user.PhoneNumber);
            newUser.Password = user.Password;
            newUser.CardNumber = user.CardNumber;
            newUser.Currency =  user.Currency;
            newUser.Amount = user.Amount - Convert.ToInt32(Convert.ToInt32(text_boxs2.Text)*1.006);
            newUser.FullName = user.FullName;
            newUser.Cashback = user.Cashback+ Convert.ToInt32(report.Payment*0.01);
            newUser.id = user.id;
            write.UpdateUser(user, newUser);
            s =  write.CheckUserCardNumber(text_boxs1.Text).Split('#').ToArray(); ;
            User RecUser1 = new User(s[3]);
            User RecUser2 = new User(s[3]);
            RecUser1.Password = s[5];
            RecUser2.Password = s[5];
            RecUser1.CardNumber = s[2];
            RecUser2.CardNumber = s[2];
            RecUser1.Currency = s[6];
            RecUser2.Currency = s[6];
            RecUser1.FullName = s[1];
            RecUser2.FullName = s[1];
            RecUser1.id =Guid.Parse( s[0]);
            RecUser2.id =Guid.Parse( s[0]);
            RecUser1.Cashback = Convert.ToInt32(s[7].Remove(s[7].Length - 1));
            RecUser2.Cashback = Convert.ToInt32(s[7].Remove(s[7].Length - 1));
            RecUser1.Amount = Convert.ToInt32(s[4]);
            RecUser2.Amount = Convert.ToInt32(s[4])+report.Payment;

            write.UpdateUser(RecUser1, RecUser2);
            string message = "To`lov amalga oshirildi !\nShu sahifada qolishni xohlayszmi ?";
            string title = "To`lov";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Form4 form4 = new Form4(newUser);
                form4.Show();
                this.Close();
            }
            else
            {
                Form3 form3 = new Form3(newUser);
                form3.Show();
                this.Close();
                // Do something  
            }

        }
    }
}
