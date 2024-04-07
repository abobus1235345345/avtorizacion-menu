using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            if (CheckAuthorization()) 
            {
                Form3 Form3 = new Form3();
                Form3.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }

        private bool CheckAuthorization()
        {
            
            string username = "admin";
            string password = "password";

            string inputUsername = txtUsername.Text;
            string inputPassword = txtPassword.Text;

            if (inputUsername == username && inputPassword == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
             Close();
        }
    }
    
}