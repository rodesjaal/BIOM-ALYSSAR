﻿namespace BIOM_ALYSSAR
{
    partial class Home
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
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enrollFingerprintsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.attendanceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.attendanceTimeOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tasksToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(738, 33);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tasksToolStripMenuItem
            // 
            this.tasksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enrollFingerprintsToolStripMenuItem1,
            this.attendanceToolStripMenuItem1,
            this.attendanceTimeOutToolStripMenuItem});
            this.tasksToolStripMenuItem.Name = "tasksToolStripMenuItem";
            this.tasksToolStripMenuItem.Size = new System.Drawing.Size(67, 29);
            this.tasksToolStripMenuItem.Text = "Tasks";
            // 
            // enrollFingerprintsToolStripMenuItem1
            // 
            this.enrollFingerprintsToolStripMenuItem1.Name = "enrollFingerprintsToolStripMenuItem1";
            this.enrollFingerprintsToolStripMenuItem1.Size = new System.Drawing.Size(264, 30);
            this.enrollFingerprintsToolStripMenuItem1.Text = "Enroll Fingerprints";
            this.enrollFingerprintsToolStripMenuItem1.Click += new System.EventHandler(this.enrollFingerprintsToolStripMenuItem1_Click);
            // 
            // attendanceToolStripMenuItem1
            // 
            this.attendanceToolStripMenuItem1.Name = "attendanceToolStripMenuItem1";
            this.attendanceToolStripMenuItem1.Size = new System.Drawing.Size(264, 30);
            this.attendanceToolStripMenuItem1.Text = "Attendance Time In";
            this.attendanceToolStripMenuItem1.Click += new System.EventHandler(this.attendanceToolStripMenuItem1_Click);
            // 
            // attendanceTimeOutToolStripMenuItem
            // 
            this.attendanceTimeOutToolStripMenuItem.Name = "attendanceTimeOutToolStripMenuItem";
            this.attendanceTimeOutToolStripMenuItem.Size = new System.Drawing.Size(264, 30);
            this.attendanceTimeOutToolStripMenuItem.Text = "Attendance Time Out";
            this.attendanceTimeOutToolStripMenuItem.Click += new System.EventHandler(this.attendanceTimeOutToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.Name = "Home";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enrollFingerprintsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem attendanceToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem attendanceTimeOutToolStripMenuItem;
    }
}