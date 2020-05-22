namespace Hospital_Management_System
{
    partial class Sections
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
            this.patientsLabel = new System.Windows.Forms.Label();
            this.nursesLabel = new System.Windows.Forms.Label();
            this.doctorsLabel = new System.Windows.Forms.Label();
            this.roomsLabel = new System.Windows.Forms.Label();
            this.roomsButton = new System.Windows.Forms.Button();
            this.doctorButton = new System.Windows.Forms.Button();
            this.nurseButton = new System.Windows.Forms.Button();
            this.patientButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // patientsLabel
            // 
            this.patientsLabel.AutoSize = true;
            this.patientsLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.patientsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.patientsLabel.Location = new System.Drawing.Point(52, 6);
            this.patientsLabel.Name = "patientsLabel";
            this.patientsLabel.Size = new System.Drawing.Size(143, 38);
            this.patientsLabel.TabIndex = 1;
            this.patientsLabel.Text = "Patients";
            // 
            // nursesLabel
            // 
            this.nursesLabel.AutoSize = true;
            this.nursesLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nursesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nursesLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nursesLabel.Location = new System.Drawing.Point(515, 5);
            this.nursesLabel.Name = "nursesLabel";
            this.nursesLabel.Size = new System.Drawing.Size(128, 38);
            this.nursesLabel.TabIndex = 5;
            this.nursesLabel.Text = "Nurses";
            this.nursesLabel.Click += new System.EventHandler(this.Label2_Click);
            // 
            // doctorsLabel
            // 
            this.doctorsLabel.AutoSize = true;
            this.doctorsLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.doctorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.doctorsLabel.Location = new System.Drawing.Point(904, 6);
            this.doctorsLabel.Name = "doctorsLabel";
            this.doctorsLabel.Size = new System.Drawing.Size(138, 38);
            this.doctorsLabel.TabIndex = 6;
            this.doctorsLabel.Text = "Doctors";
            // 
            // roomsLabel
            // 
            this.roomsLabel.AutoSize = true;
            this.roomsLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.roomsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.roomsLabel.Location = new System.Drawing.Point(1179, 6);
            this.roomsLabel.Name = "roomsLabel";
            this.roomsLabel.Size = new System.Drawing.Size(286, 38);
            this.roomsLabel.TabIndex = 7;
            this.roomsLabel.Text = "Rooms_Buildings";
            // 
            // roomsButton
            // 
            this.roomsButton.BackgroundImage = global::Hospital_Management_System.Properties.Resources.Roooms;
            this.roomsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roomsButton.Location = new System.Drawing.Point(1162, 47);
            this.roomsButton.Name = "roomsButton";
            this.roomsButton.Size = new System.Drawing.Size(321, 624);
            this.roomsButton.TabIndex = 4;
            this.roomsButton.UseVisualStyleBackColor = true;
            this.roomsButton.Click += new System.EventHandler(this.RoomsButton_Click);
            // 
            // doctorButton
            // 
            this.doctorButton.BackgroundImage = global::Hospital_Management_System.Properties.Resources.Doc_Sections;
            this.doctorButton.Location = new System.Drawing.Point(818, 44);
            this.doctorButton.Name = "doctorButton";
            this.doctorButton.Size = new System.Drawing.Size(298, 627);
            this.doctorButton.TabIndex = 3;
            this.doctorButton.UseVisualStyleBackColor = true;
            this.doctorButton.Click += new System.EventHandler(this.DoctorButton_Click);
            // 
            // nurseButton
            // 
            this.nurseButton.Image = global::Hospital_Management_System.Properties.Resources.nurse_sections1;
            this.nurseButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.nurseButton.Location = new System.Drawing.Point(368, 46);
            this.nurseButton.Name = "nurseButton";
            this.nurseButton.Size = new System.Drawing.Size(407, 627);
            this.nurseButton.TabIndex = 2;
            this.nurseButton.UseVisualStyleBackColor = true;
            this.nurseButton.Click += new System.EventHandler(this.NurseButton_Click);
            // 
            // patientButton
            // 
            this.patientButton.BackgroundImage = global::Hospital_Management_System.Properties.Resources.patient1;
            this.patientButton.Location = new System.Drawing.Point(31, 44);
            this.patientButton.Name = "patientButton";
            this.patientButton.Size = new System.Drawing.Size(295, 627);
            this.patientButton.TabIndex = 0;
            this.patientButton.UseVisualStyleBackColor = true;
            this.patientButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkViolet;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(47, 582);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 79);
            this.button1.TabIndex = 8;
            this.button1.Text = "LOG OUT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // Sections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.BackgroundImage = global::Hospital_Management_System.Properties.Resources.rooms1;
            this.ClientSize = new System.Drawing.Size(1515, 673);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.roomsLabel);
            this.Controls.Add(this.doctorsLabel);
            this.Controls.Add(this.nursesLabel);
            this.Controls.Add(this.roomsButton);
            this.Controls.Add(this.doctorButton);
            this.Controls.Add(this.nurseButton);
            this.Controls.Add(this.patientsLabel);
            this.Controls.Add(this.patientButton);
            this.Name = "Sections";
            this.Text = "Sections";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button patientButton;
        private System.Windows.Forms.Label patientsLabel;
        private System.Windows.Forms.Button nurseButton;
        private System.Windows.Forms.Button doctorButton;
        private System.Windows.Forms.Button roomsButton;
        private System.Windows.Forms.Label nursesLabel;
        private System.Windows.Forms.Label doctorsLabel;
        private System.Windows.Forms.Label roomsLabel;
        private System.Windows.Forms.Button button1;
    }
}