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
    public partial class Form3 : Form
    {
        public User user;
        public Form3(User user)
        {
            InitializeComponent();
            this.user = user;
            

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            WriteFile writeFile = new WriteFile();
            string[] k = writeFile.CheckUser(user.PhoneNumber).Split('#').ToArray();
            Lblamunt.Text = k[4] + " " + k[6];
            CardNumLbl.Text = "**** **** **** " + k[2][12] + k[2][13] + k[2][14] + k[2][15];
            AmountLbl.Text = k[7].Remove(k[7].Length-1) + k[6];
        }

        private void sPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {

        }

        private void button_WOC5_Click(object sender, EventArgs e)
        {

        }

        private void sPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            WriteFile writeFile = new WriteFile();
            string[] k =writeFile.CheckUser(user.PhoneNumber).Split('#').ToArray();
            Lblamunt.Text = k[4]+ " " + k[6];
            CardNumLbl.Text ="**** **** **** "+ k[2][12] + k[2][13] + k[2][14] + k[2][15];
        }

        private void OtkazmaBtn_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(user);
            form4.Show();
            this.Hide();
        }

        private void TarixBtn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(user);
            form3.Show();
            this.Hide();
        }

        private void TolovBtn_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(user);
            form5.Show();
            this.Hide();
        }

        private void AmountLbl_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(user); 
            form6.Show();
            this.Hide();
        }

        private void sPanel4_Paint(object sender, PaintEventArgs e)
        {
           /* Form7 form7 = new Form7(user);
            form7.Show();
            this.Hide();*/

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8(user);  
            form8.Show();
            this.Hide();
        }
    }
}
