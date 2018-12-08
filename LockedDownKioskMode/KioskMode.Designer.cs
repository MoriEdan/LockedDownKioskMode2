﻿using System.Windows.Forms;

namespace LockedDownKioskMode
{
    partial class KioskMode
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
            this.components = new System.ComponentModel.Container();
            this.LDBButton = new System.Windows.Forms.Button();
            this.WebAdvisorButton = new System.Windows.Forms.Button();
            this.D2LButton = new System.Windows.Forms.Button();
            this.WebMailButton = new System.Windows.Forms.Button();
            this.DSUStudentHomeButton = new System.Windows.Forms.Button();
            this.ProctorSignUpButton = new System.Windows.Forms.Button();
            this.CalcButton = new System.Windows.Forms.Button();
            this.DefaultPrinterButton = new System.Windows.Forms.Button();
            this.AdminLogOutButton = new System.Windows.Forms.Button();
            this.ScrollingAnnouncement = new System.Windows.Forms.LinkLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LDBButton
            // 
            this.LDBButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LDBButton.Location = new System.Drawing.Point(53, 116);
            this.LDBButton.Name = "LDBButton";
            this.LDBButton.Size = new System.Drawing.Size(150, 150);
            this.LDBButton.TabIndex = 0;
            this.LDBButton.UseVisualStyleBackColor = true;
            this.LDBButton.Click += new System.EventHandler(this.LDBButton_Click);
            // 
            // WebAdvisorButton
            // 
            this.WebAdvisorButton.Location = new System.Drawing.Point(481, 116);
            this.WebAdvisorButton.Name = "WebAdvisorButton";
            this.WebAdvisorButton.Size = new System.Drawing.Size(150, 150);
            this.WebAdvisorButton.TabIndex = 1;
            this.WebAdvisorButton.UseVisualStyleBackColor = true;
            this.WebAdvisorButton.Click += new System.EventHandler(this.WebAdvisorButton_Click);
            // 
            // D2LButton
            // 
            this.D2LButton.Location = new System.Drawing.Point(268, 116);
            this.D2LButton.Name = "D2LButton";
            this.D2LButton.Size = new System.Drawing.Size(150, 150);
            this.D2LButton.TabIndex = 2;
            this.D2LButton.UseVisualStyleBackColor = true;
            this.D2LButton.Click += new System.EventHandler(this.D2LButton_Click);
            // 
            // WebMailButton
            // 
            this.WebMailButton.Location = new System.Drawing.Point(686, 116);
            this.WebMailButton.Name = "WebMailButton";
            this.WebMailButton.Size = new System.Drawing.Size(150, 150);
            this.WebMailButton.TabIndex = 3;
            this.WebMailButton.UseVisualStyleBackColor = true;
            this.WebMailButton.Click += new System.EventHandler(this.WebMailButton_Click);
            // 
            // DSUStudentHomeButton
            // 
            this.DSUStudentHomeButton.Location = new System.Drawing.Point(52, 284);
            this.DSUStudentHomeButton.Name = "DSUStudentHomeButton";
            this.DSUStudentHomeButton.Size = new System.Drawing.Size(75, 75);
            this.DSUStudentHomeButton.TabIndex = 4;
            this.DSUStudentHomeButton.UseVisualStyleBackColor = true;
            this.DSUStudentHomeButton.Click += new System.EventHandler(this.DSUStudentHomeButton_Click);
            // 
            // ProctorSignUpButton
            // 
            this.ProctorSignUpButton.Location = new System.Drawing.Point(229, 284);
            this.ProctorSignUpButton.Name = "ProctorSignUpButton";
            this.ProctorSignUpButton.Size = new System.Drawing.Size(75, 75);
            this.ProctorSignUpButton.TabIndex = 5;
            this.ProctorSignUpButton.UseVisualStyleBackColor = true;
            this.ProctorSignUpButton.Click += new System.EventHandler(this.ProctorSignUpButton_Click);
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(412, 284);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(75, 75);
            this.CalcButton.TabIndex = 6;
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // DefaultPrinterButton
            // 
            this.DefaultPrinterButton.Location = new System.Drawing.Point(583, 284);
            this.DefaultPrinterButton.Name = "DefaultPrinterButton";
            this.DefaultPrinterButton.Size = new System.Drawing.Size(75, 75);
            this.DefaultPrinterButton.TabIndex = 7;
            this.DefaultPrinterButton.UseVisualStyleBackColor = true;
            this.DefaultPrinterButton.Click += new System.EventHandler(this.DefaultPrinterButton_Click);
            // 
            // AdminLogOutButton
            // 
            this.AdminLogOutButton.Location = new System.Drawing.Point(761, 284);
            this.AdminLogOutButton.Name = "AdminLogOutButton";
            this.AdminLogOutButton.Size = new System.Drawing.Size(75, 75);
            this.AdminLogOutButton.TabIndex = 8;
            this.AdminLogOutButton.UseVisualStyleBackColor = true;
            this.AdminLogOutButton.Click += new System.EventHandler(this.AdminLogOutButton_Click);
            // 
            // ScrollingAnnouncement
            // 
            this.ScrollingAnnouncement.AutoSize = true;
            this.ScrollingAnnouncement.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScrollingAnnouncement.Location = new System.Drawing.Point(47, 72);
            this.ScrollingAnnouncement.Name = "ScrollingAnnouncement";
            this.ScrollingAnnouncement.Size = new System.Drawing.Size(610, 26);
            this.ScrollingAnnouncement.TabIndex = 9;
            this.ScrollingAnnouncement.TabStop = true;
            this.ScrollingAnnouncement.Text = "Click Here for All the Latest Dakota State University Announcements!";
            this.ScrollingAnnouncement.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ScrollingAnnouncement_LinkClicked);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // KioskMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 371);
            this.Controls.Add(this.ScrollingAnnouncement);
            this.Controls.Add(this.AdminLogOutButton);
            this.Controls.Add(this.DefaultPrinterButton);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.ProctorSignUpButton);
            this.Controls.Add(this.DSUStudentHomeButton);
            this.Controls.Add(this.WebMailButton);
            this.Controls.Add(this.D2LButton);
            this.Controls.Add(this.WebAdvisorButton);
            this.Controls.Add(this.LDBButton);
            this.Name = "KioskMode";
            this.Text = "Kiosk Mode";
            this.Load += new System.EventHandler(this.KioskMode_Load);
            this.Resize += new System.EventHandler(this.KioskMode_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LDBButton;
        private System.Windows.Forms.Button WebAdvisorButton;
        private System.Windows.Forms.Button D2LButton;
        private System.Windows.Forms.Button WebMailButton;
        private System.Windows.Forms.Button DSUStudentHomeButton;
        private System.Windows.Forms.Button ProctorSignUpButton;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.Button DefaultPrinterButton;
        private System.Windows.Forms.Button AdminLogOutButton;

        private void GoFullscreen(bool fullscreen)
        {
            if (fullscreen)
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
        }

        private LinkLabel ScrollingAnnouncement;
        private Timer timer1;
    }
}

