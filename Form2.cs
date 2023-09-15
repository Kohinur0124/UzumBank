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
    public partial class Form2 : Form
    {
        User user;
        public Form2(string phonenumber)
        {
            user = new User(phonenumber);
            InitializeComponent();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            if (Check.CheckedPassword(text_boxs1.Text) )
            {
                if (Check.CheckCardNumber(text_boxs2.Text) ) 
                {
                    if (text_boxs3.Text.Length > 0 ) 
                    {
                        user.id = new Guid();
                        user.FullName = text_boxs3.Text;
                        user.CardNumber = text_boxs2.Text;
                        user.Password = text_boxs1.Text;
                        user.Amount = 0;
                        user.Currency = "UZS";
                        user.Cashback = 0;

                        WriteFile wf = new WriteFile();
                        wf.AddUser(user);
                        Form3 form3 = new Form3(user);
                        form3.Show();
                        this.Hide();

                    }
                    else
                    {
                        CheckFISH.Text = "To`ldirilmagan !!!";
                    }
                }
                else
                {
                    CheckCard.Text = "Kiritishda xatolik bor !!!";
                }

            }
            else
            {
                CheckPassword.Text = "Kiritishda xatolik bor !!!";
            }

        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
