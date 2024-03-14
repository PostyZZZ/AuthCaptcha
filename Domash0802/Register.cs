using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Domash0802
{
    public partial class Register : Form
    {
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=54321;Database=domashhh;";

        public Register()
        {
            InitializeComponent();

            using (var dataHelper = new DataHelper(connectionString))
            {
                dataHelper.CreateTable();
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Regbutton_Click(object sender, EventArgs e)
        {

                string username = textBoxUsername.Text;
                string password = textBoxPassword.Text;

                using (var dataHelper = new DataHelper(connectionString))
                {
                    dataHelper.SaveCredentials(username, password);
                }

                MessageBox.Show("Регистрация завершена успешно!");
                this.Close();
            }
        }
    }

