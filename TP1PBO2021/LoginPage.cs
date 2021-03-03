using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1PBO2021
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginBt_Click(object sender, EventArgs e)
        {
            
            if (String.Equals(Convert.ToString(passwordTb.Text), "pbo123") && Convert.ToString(usernameTb.Text) != "")
            {
                MenuUtama Menut = new MenuUtama();
                Menut.Show();
                //this.Hide();
                
            }
            else
            {
                MessageBox.Show("Username Yang anda masukkan tidak tepat atau username salah!");
            }
            
        }
    }
}
