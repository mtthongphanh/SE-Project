﻿namespace FinalSprintProject
{
    partial class suspensions
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
            this.Suspensionslabel = new System.Windows.Forms.Label();
            this.PatronIDLabel = new System.Windows.Forms.Label();
            this.IncidentReporLlabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.SearchPatronID = new System.Windows.Forms.TextBox();
            this.body_txt = new System.Windows.Forms.RichTextBox();
            this.GenerateEmailButton = new System.Windows.Forms.Button();
            this.ReturntoMainMenuButton = new System.Windows.Forms.Button();
            this.PatronProfileView = new System.Windows.Forms.DataGridView();
            this.LoadTalbe_txt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.From_txt = new System.Windows.Forms.TextBox();
            this.to_txt = new System.Windows.Forms.TextBox();
            this.Subject_txt = new System.Windows.Forms.TextBox();
            this.SmtpServer_txt = new System.Windows.Forms.TextBox();
            this.UserName_txt = new System.Windows.Forms.TextBox();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.updateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PatronProfileView)).BeginInit();
            this.SuspendLayout();
            // 
            // Suspensionslabel
            // 
            this.Suspensionslabel.AutoSize = true;
            this.Suspensionslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Suspensionslabel.Location = new System.Drawing.Point(33, 32);
            this.Suspensionslabel.Name = "Suspensionslabel";
            this.Suspensionslabel.Size = new System.Drawing.Size(163, 29);
            this.Suspensionslabel.TabIndex = 0;
            this.Suspensionslabel.Text = "Suspensions";
            // 
            // PatronIDLabel
            // 
            this.PatronIDLabel.AutoSize = true;
            this.PatronIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatronIDLabel.Location = new System.Drawing.Point(34, 81);
            this.PatronIDLabel.Name = "PatronIDLabel";
            this.PatronIDLabel.Size = new System.Drawing.Size(154, 20);
            this.PatronIDLabel.TabIndex = 1;
            this.PatronIDLabel.Text = "Search Patron ID";
            // 
            // IncidentReporLlabel
            // 
            this.IncidentReporLlabel.AutoSize = true;
            this.IncidentReporLlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncidentReporLlabel.Location = new System.Drawing.Point(50, 209);
            this.IncidentReporLlabel.Name = "IncidentReporLlabel";
            this.IncidentReporLlabel.Size = new System.Drawing.Size(0, 20);
            this.IncidentReporLlabel.TabIndex = 2;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(834, 115);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(56, 20);
            this.EmailLabel.TabIndex = 3;
            this.EmailLabel.Text = "Email";
            // 
            // SearchPatronID
            // 
            this.SearchPatronID.Location = new System.Drawing.Point(214, 79);
            this.SearchPatronID.Name = "SearchPatronID";
            this.SearchPatronID.Size = new System.Drawing.Size(163, 22);
            this.SearchPatronID.TabIndex = 4;
            this.SearchPatronID.TextChanged += new System.EventHandler(this.SearchPatronID_TextChanged);
            // 
            // body_txt
            // 
            this.body_txt.Location = new System.Drawing.Point(896, 115);
            this.body_txt.Name = "body_txt";
            this.body_txt.Size = new System.Drawing.Size(351, 214);
            this.body_txt.TabIndex = 6;
            this.body_txt.Text = "";
            // 
            // GenerateEmailButton
            // 
            this.GenerateEmailButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateEmailButton.Location = new System.Drawing.Point(993, 471);
            this.GenerateEmailButton.Name = "GenerateEmailButton";
            this.GenerateEmailButton.Size = new System.Drawing.Size(254, 42);
            this.GenerateEmailButton.TabIndex = 7;
            this.GenerateEmailButton.Text = "Generate Email";
            this.GenerateEmailButton.UseVisualStyleBackColor = true;
            this.GenerateEmailButton.Click += new System.EventHandler(this.GenerateEmailButton_Click);
            // 
            // ReturntoMainMenuButton
            // 
            this.ReturntoMainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturntoMainMenuButton.Location = new System.Drawing.Point(105, 432);
            this.ReturntoMainMenuButton.Name = "ReturntoMainMenuButton";
            this.ReturntoMainMenuButton.Size = new System.Drawing.Size(218, 62);
            this.ReturntoMainMenuButton.TabIndex = 8;
            this.ReturntoMainMenuButton.Text = "Return to Main Menu";
            this.ReturntoMainMenuButton.UseVisualStyleBackColor = true;
            this.ReturntoMainMenuButton.Click += new System.EventHandler(this.ReturntoMainMenuButton_Click);
            // 
            // PatronProfileView
            // 
            this.PatronProfileView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatronProfileView.Location = new System.Drawing.Point(38, 115);
            this.PatronProfileView.Name = "PatronProfileView";
            this.PatronProfileView.RowTemplate.Height = 24;
            this.PatronProfileView.Size = new System.Drawing.Size(555, 281);
            this.PatronProfileView.TabIndex = 9;
            this.PatronProfileView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatronProfileView_CellContentClick);
            // 
            // LoadTalbe_txt
            // 
            this.LoadTalbe_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadTalbe_txt.Location = new System.Drawing.Point(410, 73);
            this.LoadTalbe_txt.Name = "LoadTalbe_txt";
            this.LoadTalbe_txt.Size = new System.Drawing.Size(135, 36);
            this.LoadTalbe_txt.TabIndex = 10;
            this.LoadTalbe_txt.Text = "Load Table";
            this.LoadTalbe_txt.UseVisualStyleBackColor = true;
            this.LoadTalbe_txt.Click += new System.EventHandler(this.LoadTalbe_txt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(834, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(834, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "To";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(834, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Subject";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(834, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "UserName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(834, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Smtp Server";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(834, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Password";
            // 
            // From_txt
            // 
            this.From_txt.Location = new System.Drawing.Point(993, 20);
            this.From_txt.Name = "From_txt";
            this.From_txt.Size = new System.Drawing.Size(238, 22);
            this.From_txt.TabIndex = 17;
            this.From_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // to_txt
            // 
            this.to_txt.Location = new System.Drawing.Point(993, 48);
            this.to_txt.Name = "to_txt";
            this.to_txt.Size = new System.Drawing.Size(238, 22);
            this.to_txt.TabIndex = 18;
            // 
            // Subject_txt
            // 
            this.Subject_txt.Location = new System.Drawing.Point(993, 81);
            this.Subject_txt.Name = "Subject_txt";
            this.Subject_txt.Size = new System.Drawing.Size(238, 22);
            this.Subject_txt.TabIndex = 19;
            // 
            // SmtpServer_txt
            // 
            this.SmtpServer_txt.Location = new System.Drawing.Point(1009, 342);
            this.SmtpServer_txt.Name = "SmtpServer_txt";
            this.SmtpServer_txt.Size = new System.Drawing.Size(238, 22);
            this.SmtpServer_txt.TabIndex = 20;
            // 
            // UserName_txt
            // 
            this.UserName_txt.Location = new System.Drawing.Point(1009, 374);
            this.UserName_txt.Name = "UserName_txt";
            this.UserName_txt.Size = new System.Drawing.Size(238, 22);
            this.UserName_txt.TabIndex = 21;
            // 
            // Password_txt
            // 
            this.Password_txt.Location = new System.Drawing.Point(1009, 411);
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.Size = new System.Drawing.Size(238, 22);
            this.Password_txt.TabIndex = 22;
            this.Password_txt.TextChanged += new System.EventHandler(this.Password_txt_TextChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(633, 179);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(120, 24);
            this.radioButton1.TabIndex = 23;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "suspended";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(633, 209);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(140, 24);
            this.radioButton2.TabIndex = 24;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "unsuspended";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(633, 259);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(140, 43);
            this.updateButton.TabIndex = 25;
            this.updateButton.Text = "update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.upadateButton_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 568);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.Password_txt);
            this.Controls.Add(this.UserName_txt);
            this.Controls.Add(this.SmtpServer_txt);
            this.Controls.Add(this.Subject_txt);
            this.Controls.Add(this.to_txt);
            this.Controls.Add(this.From_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoadTalbe_txt);
            this.Controls.Add(this.PatronProfileView);
            this.Controls.Add(this.ReturntoMainMenuButton);
            this.Controls.Add(this.GenerateEmailButton);
            this.Controls.Add(this.body_txt);
            this.Controls.Add(this.SearchPatronID);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.IncidentReporLlabel);
            this.Controls.Add(this.PatronIDLabel);
            this.Controls.Add(this.Suspensionslabel);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.LoadTalbe_txt_Click);
            ((System.ComponentModel.ISupportInitialize)(this.PatronProfileView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Suspensionslabel;
        private System.Windows.Forms.Label PatronIDLabel;
        private System.Windows.Forms.Label IncidentReporLlabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox SearchPatronID;
        private System.Windows.Forms.RichTextBox body_txt;
        private System.Windows.Forms.Button GenerateEmailButton;
        private System.Windows.Forms.Button ReturntoMainMenuButton;
        private System.Windows.Forms.DataGridView PatronProfileView;
        private System.Windows.Forms.Button LoadTalbe_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox From_txt;
        private System.Windows.Forms.TextBox to_txt;
        private System.Windows.Forms.TextBox Subject_txt;
        private System.Windows.Forms.TextBox SmtpServer_txt;
        private System.Windows.Forms.TextBox UserName_txt;
        private System.Windows.Forms.TextBox Password_txt;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button updateButton;
    }
}