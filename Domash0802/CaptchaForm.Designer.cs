namespace Domash0802
{
    partial class CaptchaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBoxCaptcha = new PictureBox();
            textBoxCaptcha = new TextBox();
            buttonsumbit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCaptcha).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxCaptcha
            // 
            pictureBoxCaptcha.Location = new Point(118, 12);
            pictureBoxCaptcha.Name = "pictureBoxCaptcha";
            pictureBoxCaptcha.Size = new Size(216, 120);
            pictureBoxCaptcha.TabIndex = 0;
            pictureBoxCaptcha.TabStop = false;
            // 
            // textBoxCaptcha
            // 
            textBoxCaptcha.Location = new Point(12, 12);
            textBoxCaptcha.Name = "textBoxCaptcha";
            textBoxCaptcha.Size = new Size(100, 23);
            textBoxCaptcha.TabIndex = 1;
            // 
            // buttonsumbit
            // 
            buttonsumbit.Location = new Point(24, 54);
            buttonsumbit.Name = "buttonsumbit";
            buttonsumbit.Size = new Size(75, 23);
            buttonsumbit.TabIndex = 2;
            buttonsumbit.Text = "button1";
            buttonsumbit.UseVisualStyleBackColor = true;
            buttonsumbit.Click += buttonsumbit_Click;
            // 
            // CaptchaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 143);
            Controls.Add(buttonsumbit);
            Controls.Add(textBoxCaptcha);
            Controls.Add(pictureBoxCaptcha);
            Name = "CaptchaForm";
            Text = "CaptchaForm";
            ((System.ComponentModel.ISupportInitialize)pictureBoxCaptcha).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxCaptcha;
        private TextBox textBoxCaptcha;
        private Button buttonsumbit;
    }
}