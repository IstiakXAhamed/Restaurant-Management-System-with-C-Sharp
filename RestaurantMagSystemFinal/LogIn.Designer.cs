﻿namespace RestaurantMagSystemSecond
{
    partial class LogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            LogInPassTF = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            LogInNameTF = new TextBox();
            LogInBtn = new Button();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            SignUpBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LogInPassTF
            // 
            LogInPassTF.BackColor = Color.Cornsilk;
            LogInPassTF.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogInPassTF.Location = new Point(302, 381);
            LogInPassTF.Margin = new Padding(3, 4, 3, 4);
            LogInPassTF.Multiline = true;
            LogInPassTF.Name = "LogInPassTF";
            LogInPassTF.PasswordChar = '*';
            LogInPassTF.PlaceholderText = "Pass word";
            LogInPassTF.Size = new Size(221, 47);
            LogInPassTF.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(357, 69);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(274, 245);
            label1.Name = "label1";
            label1.Size = new Size(318, 25);
            label1.TabIndex = 3;
            label1.Text = "Please enter your name and password ";
            // 
            // LogInNameTF
            // 
            LogInNameTF.BackColor = Color.Cornsilk;
            LogInNameTF.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogInNameTF.Location = new Point(302, 307);
            LogInNameTF.Margin = new Padding(3, 4, 3, 4);
            LogInNameTF.Multiline = true;
            LogInNameTF.Name = "LogInNameTF";
            LogInNameTF.PlaceholderText = "User/Admin Name";
            LogInNameTF.Size = new Size(221, 47);
            LogInNameTF.TabIndex = 4;
            // 
            // LogInBtn
            // 
            LogInBtn.BackColor = SystemColors.Info;
            LogInBtn.Location = new Point(285, 451);
            LogInBtn.Margin = new Padding(3, 4, 3, 4);
            LogInBtn.Name = "LogInBtn";
            LogInBtn.Size = new Size(101, 43);
            LogInBtn.TabIndex = 5;
            LogInBtn.Text = "Log In";
            LogInBtn.UseVisualStyleBackColor = false;
            LogInBtn.Click += LogInBtn_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Location = new Point(403, 451);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(137, 43);
            button1.TabIndex = 6;
            button1.Text = "Forgot Password";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 69);
            label2.Name = "label2";
            label2.Size = new Size(293, 23);
            label2.TabIndex = 7;
            label2.Text = "Welcome to Our Official App";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(146, 524);
            label3.Name = "label3";
            label3.Size = new Size(403, 25);
            label3.TabIndex = 8;
            label3.Text = "New to our app? Create an account to get a treat";
            // 
            // SignUpBtn
            // 
            SignUpBtn.BackColor = SystemColors.Info;
            SignUpBtn.Location = new Point(571, 506);
            SignUpBtn.Margin = new Padding(3, 4, 3, 4);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.Size = new Size(101, 43);
            SignUpBtn.TabIndex = 9;
            SignUpBtn.Text = "Sign Up";
            SignUpBtn.UseVisualStyleBackColor = false;
            SignUpBtn.Click += SignUpBtn_Click;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(914, 760);
            Controls.Add(SignUpBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(LogInBtn);
            Controls.Add(LogInNameTF);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(LogInPassTF);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "LogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox LogInPassTF;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox LogInNameTF;
        private Button LogInBtn;
        private Button button1;
        private Label label2;
        private Label label3;
        private Button SignUpBtn;
    }
}
