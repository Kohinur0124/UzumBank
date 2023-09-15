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
    public partial class Form7 : Form
    {
        public User user;
        public Form7(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Form7_Load(object sender, EventArgs e)
        {

            label4.Text = "**** **** **** " + user.CardNumber[12] + user.CardNumber[13] + user.CardNumber[14] + user.CardNumber[15];
            label5.Text = user.Amount + " " + user.Currency;
            text_boxs2.Text = Convert.ToString(user.Cashback);
        }

        private void button_WOC4_Click(object sender, EventArgs e)
        {
            if (user.Cashback <1000)
            {
                label7.Visible = true;
                label8.Visible = false;
            }
            else
            {
                label7.Visible = false;
                label8.Visible = true;
                label8.Text = "Komissiya : "+Convert.ToString(user.Cashback*0.01);
                button_WOC1.Visible = true;
            }
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            WriteFile write = new WriteFile();
            User newUser = new User(user.PhoneNumber);
            newUser.Password = user.Password;
            newUser.CardNumber = user.CardNumber;
            newUser.Currency = user.Currency;
            newUser.Amount = user.Amount + Convert.ToInt32( user.Cashback * 0.99);
            newUser.FullName = user.FullName;
            newUser.Cashback = 0;
            newUser.id = user.id;
            write.UpdateUser(user, newUser);


            Report report = new Report();
            report.SenderCardNumber = "Cashback";
            report.RecipientCard = user.CardNumber;
            report.Payment = Convert.ToInt32(text_boxs2.Text);
            write.AddReport(report);

            string message = Convert.ToString(Convert.ToInt32(user.Cashback*0.99))+" UZS Cashback qaytarildi !\nShu sahifada qolishni xohlayszmi ?";
            string title = "To`lov";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Form7 form7 = new Form7(newUser);
                form7.Show();
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

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(user);
            form3.Show();
            this.Hide();
        }
    }
}
