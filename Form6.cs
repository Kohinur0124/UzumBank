using Sqlserver.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sqlserver
{
    public partial class Form6 : Form
    {
        public User user;
        public Form6(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Form6_Load(object sender, EventArgs e)
        {

            label4.Text = "**** **** **** " + user.CardNumber[12] + user.CardNumber[13] + user.CardNumber[14] + user.CardNumber[15];
            label5.Text = user.Amount + " " + user.Currency;
        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            if (Check.CheckedPhoneNumber(text_boxs1.Text))
            {
               CheckCard.Visible = false;

            }
            else
            {
                CheckCard.Visible=true;
                CheckCard.ForeColor = Color.Red;
                CheckCard.Text = "Telefon raqamni to`gri kiriting !!!";
            }
        }

        private void button_WOC4_Click(object sender, EventArgs e)
        {
            if (text_boxs2.Text.Length > 0)
            {
                label9.Text = "Cashback : " + Convert.ToInt32(text_boxs2.Text) * 0.01;
                if (Convert.ToInt32(text_boxs2.Text) + Convert.ToInt32(text_boxs2.Text) * 0.006 > user.Amount)
                {
                    label7.Visible = true;
                    label9.Visible = false;
                    button_WOC1.Visible = false;
                }
                else
                {
                    label7.Visible = false;
                    label9.Visible = true;
                    button_WOC1.Visible = true;
                }
            }
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            if (label7.Visible == false && CheckCard.Visible == false && Check.CheckedPhoneNumber(text_boxs1.Text))
            {

                WriteFile write = new WriteFile();
                User newUser = new User(user.PhoneNumber);
                newUser.Password = user.Password;
                newUser.CardNumber = user.CardNumber;
                newUser.Currency = user.Currency;
                newUser.Amount = user.Amount - Convert.ToInt32(Convert.ToInt32(text_boxs2.Text) * 1.006);
                newUser.FullName = user.FullName;
                newUser.Cashback = user.Cashback + Convert.ToInt32(Convert.ToInt32(text_boxs2.Text) * 0.01);
                newUser.id = user.id;
                write.UpdateUser(user, newUser);

                Report report = new Report();
                report.SenderCardNumber = user.CardNumber;
                report.RecipientCard = text_boxs1.Text;
                report.Payment = Convert.ToInt32(text_boxs2.Text);
                write.AddReport(report);

                string message = "To`lov amalga oshirildi !\nShu sahifada qolishni xohlayszmi ?";
                string title = "To`lov";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    Form6 form6 = new Form6(newUser);
                    form6.Show();
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
            else
            {
                CheckCard.Visible = true;
                CheckCard.ForeColor = Color.Red;
                CheckCard.Text = "Telefon raqamni to`gri kiriting !!!";
            }
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(user);
            form3.Show();
            this.Close();
        }
        
    }
}
