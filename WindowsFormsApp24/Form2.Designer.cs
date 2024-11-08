namespace WindowsFormsApp24
{
    partial class Form2
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
            this.StudentNo = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.ContactNo = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.TextBox();
            this.Middle = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Course = new System.Windows.Forms.ComboBox();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StudentNo
            // 
            this.StudentNo.Location = new System.Drawing.Point(54, 56);
            this.StudentNo.Name = "StudentNo";
            this.StudentNo.Size = new System.Drawing.Size(95, 20);
            this.StudentNo.TabIndex = 0;
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(54, 109);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(95, 20);
            this.LastName.TabIndex = 1;
            // 
            // ContactNo
            // 
            this.ContactNo.Location = new System.Drawing.Point(369, 221);
            this.ContactNo.Name = "ContactNo";
            this.ContactNo.Size = new System.Drawing.Size(95, 20);
            this.ContactNo.TabIndex = 2;
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(54, 184);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(95, 20);
            this.Age.TabIndex = 3;
            // 
            // Middle
            // 
            this.Middle.Location = new System.Drawing.Point(369, 109);
            this.Middle.Name = "Middle";
            this.Middle.Size = new System.Drawing.Size(95, 20);
            this.Middle.TabIndex = 4;
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(223, 109);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(95, 20);
            this.FirstName.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(73, 235);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(221, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // Course
            // 
            this.Course.FormattingEnabled = true;
            this.Course.Items.AddRange(new object[] {
            "IT",
            "CS",
            "TOur"});
            this.Course.Location = new System.Drawing.Point(223, 56);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(121, 21);
            this.Course.TabIndex = 7;
            // 
            // Gender
            // 
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "she",
            "him"});
            this.Gender.Location = new System.Drawing.Point(236, 183);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(121, 21);
            this.Gender.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.Course);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.Middle);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.ContactNo);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.StudentNo);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StudentNo;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox ContactNo;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.TextBox Middle;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox Course;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.Button button1;
    }
}