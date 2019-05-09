﻿namespace ChungsCatering
{
    partial class ReservationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationForm));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReservation = new System.Windows.Forms.Button();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.TbPhone = new System.Windows.Forms.TextBox();
            this.tbNumberofPeople = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tbEvent = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(241, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservation Form";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReservation);
            this.panel1.Controls.Add(this.flowLayoutPanel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(135, 59);
            this.panel1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 315);
            this.panel1.TabIndex = 1;
            // 
            // btnReservation
            // 
            this.btnReservation.Location = new System.Drawing.Point(274, 251);
            this.btnReservation.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(106, 25);
            this.btnReservation.TabIndex = 2;
            this.btnReservation.Text = "Make Reservation";
            this.btnReservation.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel.Controls.Add(this.tbFirstName);
            this.flowLayoutPanel.Controls.Add(this.tbLastName);
            this.flowLayoutPanel.Controls.Add(this.tbEmail);
            this.flowLayoutPanel.Controls.Add(this.TbPhone);
            this.flowLayoutPanel.Controls.Add(this.tbNumberofPeople);
            this.flowLayoutPanel.Controls.Add(this.dateTimePicker1);
            this.flowLayoutPanel.Controls.Add(this.tbEvent);
            this.flowLayoutPanel.Location = new System.Drawing.Point(127, 65);
            this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(374, 172);
            this.flowLayoutPanel.TabIndex = 1;
            // 
            // tbFirstName
            // 
            this.tbFirstName.AccessibleDescription = "";
            this.tbFirstName.AccessibleName = "";
            this.tbFirstName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbFirstName.Location = new System.Drawing.Point(1, 1);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(371, 23);
            this.tbFirstName.TabIndex = 0;
            this.tbFirstName.Tag = "";
            this.tbFirstName.Text = "First Name";
            this.tbFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbFirstName.DoubleClick += new System.EventHandler(this.TbFirstName_DoubleClick);
            // 
            // tbLastName
            // 
            this.tbLastName.AccessibleDescription = "";
            this.tbLastName.AccessibleName = "";
            this.tbLastName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbLastName.Location = new System.Drawing.Point(1, 26);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(371, 23);
            this.tbLastName.TabIndex = 0;
            this.tbLastName.Tag = "";
            this.tbLastName.Text = "Last Name";
            this.tbLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbEmail
            // 
            this.tbEmail.AccessibleDescription = "";
            this.tbEmail.AccessibleName = "";
            this.tbEmail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbEmail.Location = new System.Drawing.Point(1, 51);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(371, 23);
            this.tbEmail.TabIndex = 0;
            this.tbEmail.Tag = "";
            this.tbEmail.Text = "somoene@example.com";
            this.tbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TbPhone
            // 
            this.TbPhone.AccessibleDescription = "";
            this.TbPhone.AccessibleName = "";
            this.TbPhone.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbPhone.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TbPhone.Location = new System.Drawing.Point(1, 76);
            this.TbPhone.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.TbPhone.Name = "TbPhone";
            this.TbPhone.Size = new System.Drawing.Size(371, 23);
            this.TbPhone.TabIndex = 0;
            this.TbPhone.Tag = "";
            this.TbPhone.Text = "Phone Number (***) - (***) - (****)";
            this.TbPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbNumberofPeople
            // 
            this.tbNumberofPeople.AccessibleDescription = "";
            this.tbNumberofPeople.AccessibleName = "";
            this.tbNumberofPeople.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbNumberofPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumberofPeople.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbNumberofPeople.Location = new System.Drawing.Point(1, 101);
            this.tbNumberofPeople.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tbNumberofPeople.Name = "tbNumberofPeople";
            this.tbNumberofPeople.Size = new System.Drawing.Size(371, 23);
            this.tbNumberofPeople.TabIndex = 0;
            this.tbNumberofPeople.Tag = "";
            this.tbNumberofPeople.Text = "Number of People";
            this.tbNumberofPeople.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePicker1.Location = new System.Drawing.Point(1, 126);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(371, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Tag = "Please enter date";
            // 
            // tbEvent
            // 
            this.tbEvent.AccessibleDescription = "";
            this.tbEvent.AccessibleName = "";
            this.tbEvent.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEvent.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbEvent.Location = new System.Drawing.Point(1, 148);
            this.tbEvent.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tbEvent.Name = "tbEvent";
            this.tbEvent.Size = new System.Drawing.Size(371, 23);
            this.tbEvent.TabIndex = 0;
            this.tbEvent.Tag = "";
            this.tbEvent.Text = "Select Event";
            this.tbEvent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(827, 419);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "ReservationForm";
            this.Text = "ReservationForm";
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox TbPhone;
        private System.Windows.Forms.TextBox tbNumberofPeople;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.TextBox tbEvent;
    }
}