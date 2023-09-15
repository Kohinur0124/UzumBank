using Converter;
using Sqlserver.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sqlserver
{
    public partial class Form8 : Form
    {
        public User user;
        public Form8(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        public delegate void del(string s);
        public del Del;
        private void Form8_Load(object sender, EventArgs e)
        {

            label4.Text = "**** **** **** " + user.CardNumber[12] + user.CardNumber[13] + user.CardNumber[14] + user.CardNumber[15];
            label5.Text = user.Amount + " " + user.Currency;
            if (user.Currency == Enums.UZS.ToString())
            {
                WOOK1(Convert.ToString(UZS.ToEUR(user.Amount*1.0)));
                WOOK2(Convert.ToString(UZS.ToUSD(user.Amount*1.0)));
                WOOK3(Convert.ToString(UZS.ToRUB(user.Amount*1.0)));
                
            }
            else if (user.Currency == Enums.USD.ToString())
            {
                WOOK1(Convert.ToString(USD.ToEUR(user.Amount * 1.0)));
                WOOK2(Convert.ToString(USD.ToUZS(user.Amount * 1.0)));
                WOOK3(Convert.ToString(USD.ToRUB(user.Amount * 1.0)));

            }
            else if (user.Currency == Enums.EUR.ToString())
            {
                WOOK1(Convert.ToString(EUR.ToUZS(user.Amount * 1.0)));
                WOOK2(Convert.ToString(EUR.ToUSD(user.Amount * 1.0)));
                WOOK3(Convert.ToString(EUR.ToRUB(user.Amount * 1.0)));

            }
            else if (user.Currency == Enums.RUB.ToString())
            {
                WOOK1(Convert.ToString(RUB.ToEUR(user.Amount * 1.0)));
                WOOK2(Convert.ToString(RUB.ToUSD(user.Amount * 1.0)));
                WOOK3(Convert.ToString(RUB.ToUZS(user.Amount * 1.0)));

            }
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(user);
            form3.Show();
            this.Hide();

        }

        public void  WOOK1 (string s)
        {
            button_WOC1 .Text = s;
        }
        public void WOOK2(string s)
        {
            button_WOC3.Text = s;
        }
        public void WOOK3(string s)
        {
            button_WOC4.Text = s;
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            WriteFile write = new WriteFile();
            User newUser = new User(user.PhoneNumber);
            newUser.Password = user.Password;
            newUser.CardNumber = user.CardNumber;
            newUser.Currency = button_WOC1.Text.Split().ToArray().ToArray()[1];
            label3.Text = button_WOC1.Text;
            newUser.Amount = Convert.ToInt32(button_WOC1.Text.Split(' ')[0].Split(',')[0]);
            newUser.FullName = user.FullName;
            newUser.Cashback = user.Cashback;
            newUser.id = user.id;
            write.UpdateUser(user, newUser);

            string message = "Valyuta almashtirildi !\nShu sahifada qolishni xohlayszmi ?";
            string title = "To`lov";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Form8 form8 = new Form8(newUser);
                form8.Show();
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
