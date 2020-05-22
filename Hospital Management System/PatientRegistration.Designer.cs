namespace Hospital_Management_System
{
    partial class PatientRegistration
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Mcheck = new System.Windows.Forms.CheckBox();
            this.Fcheck = new System.Windows.Forms.CheckBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.ContactBox = new System.Windows.Forms.TextBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.AgeBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.DiseaseLabel = new System.Windows.Forms.Label();
            this.DiseaseBox = new System.Windows.Forms.TextBox();
            this.BuildingNoLabel = new System.Windows.Forms.Label();
            this.BuildingNoBox = new System.Windows.Forms.TextBox();
            this.RoomNoBox = new System.Windows.Forms.TextBox();
            this.RoomNoLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameLabel.Location = new System.Drawing.Point(12, 23);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(89, 29);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name:";
            this.nameLabel.Click += new System.EventHandler(this.NameLabel_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(127, 30);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(281, 22);
            this.nameBox.TabIndex = 9;
            this.nameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.GenderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GenderLabel.Location = new System.Drawing.Point(6, 79);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(107, 29);
            this.GenderLabel.TabIndex = 14;
            this.GenderLabel.Text = "Gender:";
            this.GenderLabel.Click += new System.EventHandler(this.GenderLabel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Mcheck);
            this.panel1.Controls.Add(this.Fcheck);
            this.panel1.Location = new System.Drawing.Point(127, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 56);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // Mcheck
            // 
            this.Mcheck.AutoSize = true;
            this.Mcheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mcheck.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Mcheck.Location = new System.Drawing.Point(13, 16);
            this.Mcheck.Name = "Mcheck";
            this.Mcheck.Size = new System.Drawing.Size(81, 29);
            this.Mcheck.TabIndex = 0;
            this.Mcheck.Text = "Male";
            this.Mcheck.UseVisualStyleBackColor = true;
            // 
            // Fcheck
            // 
            this.Fcheck.AutoSize = true;
            this.Fcheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fcheck.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Fcheck.Location = new System.Drawing.Point(153, 16);
            this.Fcheck.Name = "Fcheck";
            this.Fcheck.Size = new System.Drawing.Size(105, 29);
            this.Fcheck.TabIndex = 15;
            this.Fcheck.Text = "Female";
            this.Fcheck.UseVisualStyleBackColor = true;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PhoneLabel.Location = new System.Drawing.Point(6, 274);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(108, 29);
            this.PhoneLabel.TabIndex = 18;
            this.PhoneLabel.Text = "Contact:";
            this.PhoneLabel.Click += new System.EventHandler(this.PhoneLabel_Click);
            // 
            // ContactBox
            // 
            this.ContactBox.Location = new System.Drawing.Point(127, 281);
            this.ContactBox.Name = "ContactBox";
            this.ContactBox.Size = new System.Drawing.Size(281, 22);
            this.ContactBox.TabIndex = 21;
            this.ContactBox.TextChanged += new System.EventHandler(this.ContactBox_TextChanged);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DateLabel.Location = new System.Drawing.Point(12, 222);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(74, 29);
            this.DateLabel.TabIndex = 22;
            this.DateLabel.Text = "Date:";
            this.DateLabel.Click += new System.EventHandler(this.DateLabel_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM-dd-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(127, 222);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(281, 22);
            this.dateTimePicker1.TabIndex = 23;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.AgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AgeLabel.Location = new System.Drawing.Point(16, 154);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(66, 29);
            this.AgeLabel.TabIndex = 24;
            this.AgeLabel.Text = "Age:";
            this.AgeLabel.Click += new System.EventHandler(this.AgeLabel_Click);
            // 
            // AgeBox
            // 
            this.AgeBox.Location = new System.Drawing.Point(127, 161);
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(281, 22);
            this.AgeBox.TabIndex = 25;
            this.AgeBox.TextChanged += new System.EventHandler(this.AgeBox_TextChanged);
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddressLabel.Location = new System.Drawing.Point(6, 332);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(116, 29);
            this.AddressLabel.TabIndex = 26;
            this.AddressLabel.Text = "Address:";
            this.AddressLabel.Click += new System.EventHandler(this.AddressLabel_Click);
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(128, 332);
            this.AddressBox.Multiline = true;
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(281, 77);
            this.AddressBox.TabIndex = 27;
            this.AddressBox.TextChanged += new System.EventHandler(this.AddressBox_TextChanged);
            // 
            // DiseaseLabel
            // 
            this.DiseaseLabel.AutoSize = true;
            this.DiseaseLabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DiseaseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiseaseLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DiseaseLabel.Location = new System.Drawing.Point(555, 161);
            this.DiseaseLabel.Name = "DiseaseLabel";
            this.DiseaseLabel.Size = new System.Drawing.Size(115, 29);
            this.DiseaseLabel.TabIndex = 28;
            this.DiseaseLabel.Text = "Disease:";
            // 
            // DiseaseBox
            // 
            this.DiseaseBox.Location = new System.Drawing.Point(737, 168);
            this.DiseaseBox.Name = "DiseaseBox";
            this.DiseaseBox.Size = new System.Drawing.Size(281, 22);
            this.DiseaseBox.TabIndex = 29;
            // 
            // BuildingNoLabel
            // 
            this.BuildingNoLabel.AutoSize = true;
            this.BuildingNoLabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BuildingNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuildingNoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BuildingNoLabel.Location = new System.Drawing.Point(540, 30);
            this.BuildingNoLabel.Name = "BuildingNoLabel";
            this.BuildingNoLabel.Size = new System.Drawing.Size(157, 29);
            this.BuildingNoLabel.TabIndex = 30;
            this.BuildingNoLabel.Text = "Building No:";
            // 
            // BuildingNoBox
            // 
            this.BuildingNoBox.Location = new System.Drawing.Point(737, 37);
            this.BuildingNoBox.Name = "BuildingNoBox";
            this.BuildingNoBox.Size = new System.Drawing.Size(281, 22);
            this.BuildingNoBox.TabIndex = 31;
            // 
            // RoomNoBox
            // 
            this.RoomNoBox.Location = new System.Drawing.Point(737, 100);
            this.RoomNoBox.Name = "RoomNoBox";
            this.RoomNoBox.Size = new System.Drawing.Size(281, 22);
            this.RoomNoBox.TabIndex = 33;
            // 
            // RoomNoLabel
            // 
            this.RoomNoLabel.AutoSize = true;
            this.RoomNoLabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.RoomNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RoomNoLabel.Location = new System.Drawing.Point(540, 93);
            this.RoomNoLabel.Name = "RoomNoLabel";
            this.RoomNoLabel.Size = new System.Drawing.Size(130, 29);
            this.RoomNoLabel.TabIndex = 32;
            this.RoomNoLabel.Text = "Room No:";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PriceLabel.Location = new System.Drawing.Point(589, 228);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(81, 29);
            this.PriceLabel.TabIndex = 34;
            this.PriceLabel.Text = "Price:";
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(737, 235);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(281, 22);
            this.PriceBox.TabIndex = 35;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Magenta;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add.Location = new System.Drawing.Point(859, 332);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(192, 54);
            this.add.TabIndex = 36;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.Add_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.Orange;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancel.Location = new System.Drawing.Point(611, 332);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(192, 54);
            this.cancel.TabIndex = 37;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // PatientRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1063, 428);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.add);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.RoomNoBox);
            this.Controls.Add(this.RoomNoLabel);
            this.Controls.Add(this.BuildingNoBox);
            this.Controls.Add(this.BuildingNoLabel);
            this.Controls.Add(this.DiseaseBox);
            this.Controls.Add(this.DiseaseLabel);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.AgeBox);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.ContactBox);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.nameLabel);
            this.Name = "PatientRegistration";
            this.Text = "Patient Registration";
            this.Load += new System.EventHandler(this.PatientRegistration_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox Mcheck;
        private System.Windows.Forms.CheckBox Fcheck;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.TextBox ContactBox;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.TextBox AgeBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.Label DiseaseLabel;
        private System.Windows.Forms.TextBox DiseaseBox;
        private System.Windows.Forms.Label BuildingNoLabel;
        private System.Windows.Forms.TextBox BuildingNoBox;
        private System.Windows.Forms.TextBox RoomNoBox;
        private System.Windows.Forms.Label RoomNoLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button cancel;
    }
}