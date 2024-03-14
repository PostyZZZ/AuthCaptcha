namespace Domash0802
{
    partial class Register
    {

        private System.ComponentModel.IContainer components = null;


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

        private void InitializeComponent()
        {
            label2 = new Label();
            label1 = new Label();
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
            Regbutton = new Button();
            cancelbutton = new Button();
            label3 = new Label();
            SuspendLayout();

            label2.AutoSize = true;
            label2.Location = new Point(77, 86);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 11;
            label2.Text = "Пароль";

            label1.AutoSize = true;
            label1.Location = new Point(85, 57);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 10;
            label1.Text = "Логин";

            textBoxPassword.Location = new Point(132, 83);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(132, 23);
            textBoxPassword.TabIndex = 9;
            textBoxPassword.TextChanged += textBox2_TextChanged;

            textBoxUsername.Location = new Point(132, 54);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(132, 23);
            textBoxUsername.TabIndex = 8;
            textBoxUsername.TextChanged += textBox1_TextChanged;

            Regbutton.Location = new Point(97, 121);
            Regbutton.Name = "Regbutton";
            Regbutton.Size = new Size(94, 40);
            Regbutton.TabIndex = 13;
            Regbutton.Text = "Создать";
            Regbutton.Click += Regbutton_Click;

            cancelbutton.Location = new Point(197, 121);
            cancelbutton.Name = "cancelbutton";
            cancelbutton.Size = new Size(94, 40);
            cancelbutton.TabIndex = 6;
            cancelbutton.Text = "Отмена";
            cancelbutton.UseVisualStyleBackColor = true;
            cancelbutton.Click += cancelbutton_Click;

            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(124, 9);
            label3.Name = "label3";
            label3.Size = new Size(140, 30);
            label3.TabIndex = 12;
            label3.Text = "Регистрация ";
  
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 216);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(Regbutton);
            Controls.Add(cancelbutton);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
        private Button Regbutton;
        private Button cancelbutton;
        private Label label3;
    }
}