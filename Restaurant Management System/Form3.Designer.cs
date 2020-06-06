namespace Restaurant_Management_System
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label11 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.guests = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_advance = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.assigning_hall = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.session = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Total_textBox = new System.Windows.Forms.TextBox();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(311, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(189, 33);
            this.label11.TabIndex = 0;
            this.label11.Text = "New Booking";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel7.Controls.Add(this.button2);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.ForeColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(765, 48);
            this.panel7.TabIndex = 25;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.DarkRed;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 38);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(535, 93);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 17);
            this.label14.TabIndex = 59;
            this.label14.Text = "Total Amount :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 318);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 17);
            this.label13.TabIndex = 57;
            this.label13.Text = "City :";
            // 
            // txt_city
            // 
            this.txt_city.Location = new System.Drawing.Point(13, 338);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(100, 20);
            this.txt_city.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 203);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 17);
            this.label12.TabIndex = 55;
            this.label12.Text = "E-Mail :";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(16, 223);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(200, 20);
            this.txt_email.TabIndex = 2;
            // 
            // guests
            // 
            this.guests.FormattingEnabled = true;
            this.guests.Items.AddRange(new object[] {
            "100-200",
            "200-300",
            "300-400",
            "400-500"});
            this.guests.Location = new System.Drawing.Point(279, 342);
            this.guests.Name = "guests";
            this.guests.Size = new System.Drawing.Size(200, 21);
            this.guests.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(578, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 58);
            this.button1.TabIndex = 12;
            this.button1.Text = "Save Booking Info";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txt_advance
            // 
            this.txt_advance.Location = new System.Drawing.Point(538, 173);
            this.txt_advance.Name = "txt_advance";
            this.txt_advance.Size = new System.Drawing.Size(200, 20);
            this.txt_advance.TabIndex = 11;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(16, 280);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(200, 20);
            this.txt_address.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(535, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 17);
            this.label9.TabIndex = 48;
            this.label9.Text = "Receive Advance :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(276, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 17);
            this.label8.TabIndex = 47;
            this.label8.Text = "Estimated Guests :";
            // 
            // assigning_hall
            // 
            this.assigning_hall.FormattingEnabled = true;
            this.assigning_hall.Items.AddRange(new object[] {
            "A",
            "B"});
            this.assigning_hall.Location = new System.Drawing.Point(279, 279);
            this.assigning_hall.Name = "assigning_hall";
            this.assigning_hall.Size = new System.Drawing.Size(200, 21);
            this.assigning_hall.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(277, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 45;
            this.label7.Text = "Assign Hall : ";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(16, 173);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(200, 20);
            this.txt_phone.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(280, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "Event Type :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(276, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "Event Session :";
            // 
            // type
            // 
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "MEHANDI",
            "BARAT",
            "VALIMA",
            "BIRTHDAY",
            "MILAD"});
            this.type.Location = new System.Drawing.Point(279, 223);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(200, 21);
            this.type.TabIndex = 7;
            // 
            // date
            // 
            this.date.CustomFormat = "MM/dd/yyyy";
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(279, 113);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 20);
            this.date.TabIndex = 5;
            // 
            // session
            // 
            this.session.AutoCompleteCustomSource.AddRange(new string[] {
            "Day",
            "Night"});
            this.session.FormattingEnabled = true;
            this.session.Items.AddRange(new object[] {
            "Day",
            "Night"});
            this.session.Location = new System.Drawing.Point(279, 172);
            this.session.Name = "session";
            this.session.Size = new System.Drawing.Size(200, 21);
            this.session.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(276, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Event Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Customer Address  :";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(16, 113);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(200, 20);
            this.txt_name.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Phone Number :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = " Customer Name :";
            // 
            // Total_textBox
            // 
            this.Total_textBox.Location = new System.Drawing.Point(538, 114);
            this.Total_textBox.Name = "Total_textBox";
            this.Total_textBox.Size = new System.Drawing.Size(200, 20);
            this.Total_textBox.TabIndex = 10;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Restaurant_Management_System.Properties.Resources._1341337095;
            this.ClientSize = new System.Drawing.Size(765, 389);
            this.Controls.Add(this.Total_textBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_city);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.guests);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_advance);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.assigning_hall);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.type);
            this.Controls.Add(this.date);
            this.Controls.Add(this.session);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel7);
            this.Name = "Form3";
            this.Text = "New Booking";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.ComboBox guests;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_advance;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox assigning_hall;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.ComboBox session;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Total_textBox;
    }
}