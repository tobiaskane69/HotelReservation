namespace HotelReservation
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_username = new TextBox();
            txt_password = new TextBox();
            button_login = new Button();
            button_exit = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(43, 100);
            label1.Name = "label1";
            label1.Size = new Size(68, 22);
            label1.TabIndex = 0;
            label1.Text = "Log in";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(43, 136);
            label2.Name = "label2";
            label2.Size = new Size(66, 16);
            label2.TabIndex = 1;
            label2.Text = "Username";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(45, 191);
            label3.Name = "label3";
            label3.Size = new Size(64, 16);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // txt_username
            // 
            txt_username.BackColor = SystemColors.InactiveCaption;
            txt_username.Location = new Point(45, 155);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(271, 23);
            txt_username.TabIndex = 3;
            // 
            // txt_password
            // 
            txt_password.BackColor = SystemColors.InactiveCaption;
            txt_password.Location = new Point(45, 210);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(271, 23);
            txt_password.TabIndex = 4;
            // 
            // button_login
            // 
            button_login.BackColor = SystemColors.MenuHighlight;
            button_login.Location = new Point(241, 258);
            button_login.Name = "button_login";
            button_login.Size = new Size(75, 31);
            button_login.TabIndex = 5;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = false;
            button_login.Click += button_login_Click;
            // 
            // button_exit
            // 
            button_exit.BackColor = SystemColors.MenuHighlight;
            button_exit.Location = new Point(160, 258);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(75, 32);
            button_exit.TabIndex = 7;
            button_exit.Text = "Exit";
            button_exit.UseVisualStyleBackColor = false;
            button_exit.Click += button_exit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(72, 20);
            label4.Name = "label4";
            label4.Size = new Size(221, 22);
            label4.TabIndex = 8;
            label4.Text = "HOTEL RESERVATION";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 249);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(373, 64);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Location = new Point(0, 361);
            panel2.Name = "panel2";
            panel2.Size = new Size(373, 43);
            panel2.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 395);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(button_exit);
            Controls.Add(button_login);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_username;
        private TextBox txt_password;
        private Button button_login;
        private Button button_exit;
        private Label label4;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
    }
}