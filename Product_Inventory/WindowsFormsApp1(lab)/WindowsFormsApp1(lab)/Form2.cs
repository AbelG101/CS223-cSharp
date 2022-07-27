using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_lab_
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtBox_name.Text.ToLower();
            string passwd = txtBox_passwd.Text.ToLower();
            if ( name == "admin" && passwd == "admin")
            {
                Form1 form1 = new Form1(name);
                form1.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Incorrect name or password");
        }
    }
}
