using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Domash0802
{
    public partial class Form1 : Form
    {
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=54321;Database=domashhh;";
        private int loginAttempts;

        public Form1()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            DataHelper dbManager = new DataHelper(connectionString);
            dbManager.CreateTable();
            Console.WriteLine("Table created successfully!");
        }
        private void Addenter_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (CheckLogin(username, password))
            {
                Resultat resultatForm = new Resultat();
                resultatForm.Show();
            }
            else
            {
                loginAttempts++;

                if (loginAttempts >= 3)
                {
                    CaptchaForm captchaForm = new CaptchaForm();
                    if (captchaForm.ShowDialog() == DialogResult.OK)
                    {
                        loginAttempts = 0;
                    }
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
            }
        }
        private bool CheckLogin(string username, string password)
        {
            using (var dbManager = new DataHelper(connectionString))
            {
                return dbManager.CheckCredentials(username, password);
            }
        }

        private void Addreg_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
