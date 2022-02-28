namespace VotingApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.MiddeName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.allVoters = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.female = new System.Windows.Forms.PictureBox();
            this.gender = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.male = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.female)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.male)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 108);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(218, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "INEC REGISTERATION";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(160, 159);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(210, 20);
            this.FirstName.TabIndex = 1;
            this.FirstName.TextChanged += new System.EventHandler(this.FirstName_TextChanged);
            // 
            // MiddeName
            // 
            this.MiddeName.Location = new System.Drawing.Point(160, 236);
            this.MiddeName.Name = "MiddeName";
            this.MiddeName.Size = new System.Drawing.Size(210, 20);
            this.MiddeName.TabIndex = 3;
            this.MiddeName.TextChanged += new System.EventHandler(this.MiddeName_TextChanged);
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(160, 198);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(210, 20);
            this.LastName.TabIndex = 4;
            this.LastName.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Middle Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Last Name";
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.Location = new System.Drawing.Point(160, 284);
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.DateOfBirth.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(160, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // allVoters
            // 
            this.allVoters.Enabled = false;
            this.allVoters.Location = new System.Drawing.Point(595, 284);
            this.allVoters.Multiline = true;
            this.allVoters.Name = "allVoters";
            this.allVoters.Size = new System.Drawing.Size(193, 111);
            this.allVoters.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(649, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "All Voters";
            // 
            // female
            // 
            this.female.Image = ((System.Drawing.Image)(resources.GetObject("female.Image")));
            this.female.Location = new System.Drawing.Point(629, 130);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(116, 104);
            this.female.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.female.TabIndex = 13;
            this.female.TabStop = false;
            this.female.Visible = false;
            // 
            // gender
            // 
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender.Location = new System.Drawing.Point(160, 324);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(121, 21);
            this.gender.TabIndex = 14;
            this.gender.SelectedIndexChanged += new System.EventHandler(this.gender_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Gender";
            // 
            // male
            // 
            this.male.Image = ((System.Drawing.Image)(resources.GetObject("male.Image")));
            this.male.Location = new System.Drawing.Point(629, 130);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(116, 104);
            this.male.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.male.TabIndex = 16;
            this.male.TabStop = false;
            this.male.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.male);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.female);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.allVoters);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DateOfBirth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.MiddeName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.female)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.male)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox MiddeName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DateOfBirth;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox allVoters;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox female;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox male;
    }
}

