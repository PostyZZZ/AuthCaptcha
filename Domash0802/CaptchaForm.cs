using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domash0802
{
    public partial class CaptchaForm : Form
    {
        private string captchaText; 

        public CaptchaForm()
        {
            InitializeComponent();
            GenerateCaptcha(); 
        }

        private void GenerateCaptcha()
        {
            captchaText = GenerateCaptchaText(); 
            pictureBoxCaptcha.Image = GenerateCaptchaImage(captchaText); 
        }

        private string GenerateCaptchaText()
        {
            Random rnd = new Random();
            int captchaLength = 6;

            string captchaText = "";
            for (int i = 0; i < captchaLength; i++)
            {
                captchaText += (char)rnd.Next(65, 122); 
            }

            return captchaText;
        }

        private Bitmap GenerateCaptchaImage(string captchaText)
        {
            Bitmap captchaImage = new Bitmap(200, 60);
            using (Graphics g = Graphics.FromImage(captchaImage))
            {
                g.Clear(Color.White);

                g.DrawString(captchaText, new Font("Arial", 20), Brushes.Black, new PointF(10, 10));

                Random rnd = new Random();
                for (int i = 0; i < 5; i++)
                {
                    int x1 = rnd.Next(captchaImage.Width);
                    int y1 = rnd.Next(captchaImage.Height);
                    int x2 = rnd.Next(captchaImage.Width);
                    int y2 = rnd.Next(captchaImage.Height);
                    g.DrawLine(Pens.Black, x1, y1, x2, y2);
                }
            }
            return captchaImage;
        }


        private void buttonsumbit_Click(object sender, EventArgs e)
        {
            string enteredCaptcha = textBoxCaptcha.Text;

            Debug.WriteLine("Введенная капча: " + enteredCaptcha);
            Debug.WriteLine("Ожидаемая капча: " + captchaText); 

            
            if (enteredCaptcha == captchaText)
            {
                MessageBox.Show("Верная капча!");
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Неверная капча! Попробуйте еще раз.");
                GenerateCaptcha();
                textBoxCaptcha.Text = "";
            }
        }
    }
}
