namespace HotelReservation
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            button_viewroom = new Button();
            label1 = new Label();
            button_logout = new Button();
            button_viewcustomers = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button_viewroom
            // 
            button_viewroom.Location = new Point(157, 151);
            button_viewroom.Margin = new Padding(3, 4, 3, 4);
            button_viewroom.Name = "button_viewroom";
            button_viewroom.Size = new Size(178, 44);
            button_viewroom.TabIndex = 0;
            button_viewroom.Text = "View Rooms";
            button_viewroom.UseVisualStyleBackColor = true;
            button_viewroom.Click += button_viewroom_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(127, 24);
            label1.Name = "label1";
            label1.Size = new Size(238, 36);
            label1.TabIndex = 1;
            label1.Text = "Hotel Dashboard";
            // 
            // button_logout
            // 
            button_logout.BackColor = Color.Transparent;
            button_logout.Location = new Point(394, 4);
            button_logout.Margin = new Padding(3, 4, 3, 4);
            button_logout.Name = "button_logout";
            button_logout.Size = new Size(93, 40);
            button_logout.TabIndex = 2;
            button_logout.Text = "Logout";
            button_logout.UseVisualStyleBackColor = false;
            button_logout.Click += button_logout_Click;
            // 
            // button_viewcustomers
            // 
            button_viewcustomers.Location = new Point(157, 215);
            button_viewcustomers.Margin = new Padding(3, 4, 3, 4);
            button_viewcustomers.Name = "button_viewcustomers";
            button_viewcustomers.Size = new Size(178, 44);
            button_viewcustomers.TabIndex = 4;
            button_viewcustomers.Text = "Add New Guests";
            button_viewcustomers.UseVisualStyleBackColor = true;
            button_viewcustomers.Click += button_viewcustomers_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(490, 83);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(button_logout);
            panel2.Location = new Point(0, 353);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(490, 51);
            panel2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 151);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 401);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button_viewcustomers);
            Controls.Add(button_viewroom);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button_viewroom;
        private Label label1;
        private Button button_logout;
        private Button button_viewcustomers;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}