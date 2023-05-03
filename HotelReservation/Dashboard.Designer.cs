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
            button_viewroom = new Button();
            label1 = new Label();
            button_logout = new Button();
            button_roomprices = new Button();
            button_viewcustomers = new Button();
            SuspendLayout();
            // 
            // button_viewroom
            // 
            button_viewroom.Location = new Point(137, 106);
            button_viewroom.Name = "button_viewroom";
            button_viewroom.Size = new Size(156, 33);
            button_viewroom.TabIndex = 0;
            button_viewroom.Text = "View Rooms";
            button_viewroom.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(114, 21);
            label1.Name = "label1";
            label1.Size = new Size(207, 28);
            label1.TabIndex = 1;
            label1.Text = "Hotel Dashboard";
            // 
            // button_logout
            // 
            button_logout.Location = new Point(327, 259);
            button_logout.Name = "button_logout";
            button_logout.Size = new Size(89, 30);
            button_logout.TabIndex = 2;
            button_logout.Text = "Logout";
            button_logout.UseVisualStyleBackColor = true;
            button_logout.Click += button_logout_Click;
            // 
            // button_roomprices
            // 
            button_roomprices.Location = new Point(137, 145);
            button_roomprices.Name = "button_roomprices";
            button_roomprices.Size = new Size(156, 33);
            button_roomprices.TabIndex = 3;
            button_roomprices.Text = "View Room Prices";
            button_roomprices.UseVisualStyleBackColor = true;
            // 
            // button_viewcustomers
            // 
            button_viewcustomers.Location = new Point(137, 184);
            button_viewcustomers.Name = "button_viewcustomers";
            button_viewcustomers.Size = new Size(156, 33);
            button_viewcustomers.TabIndex = 4;
            button_viewcustomers.Text = "View Customers";
            button_viewcustomers.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 301);
            Controls.Add(button_viewcustomers);
            Controls.Add(button_roomprices);
            Controls.Add(button_logout);
            Controls.Add(label1);
            Controls.Add(button_viewroom);
            Name = "Dashboard";
            Text = "Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_viewroom;
        private Label label1;
        private Button button_logout;
        private Button button_roomprices;
        private Button button_viewcustomers;
    }
}