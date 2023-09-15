using Sqlserver.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sqlserver
{
    public partial class Form5 : Form
    {
        public User User;
        public Form5(User user)
        {
            InitializeComponent();
            User = user;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            WriteFile writeFile = new WriteFile();
            List<string> list = writeFile.GetHistory(User.CardNumber);
            foreach (string i in list)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(User);
            form3.Show();
            this.Hide();
        }
    }
}
