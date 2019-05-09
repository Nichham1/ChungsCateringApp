namespace ChungsCateringApp
{
    partial class Resreports
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
            this.dtpReservation = new System.Windows.Forms.DateTimePicker();
            this.cbResStatus = new System.Windows.Forms.ComboBox();
            this.cbSeatStatus = new System.Windows.Forms.ComboBox();
            this.cbResDescription = new System.Windows.Forms.ComboBox();
            this.tbEmailAddress = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.btClearRes = new System.Windows.Forms.Button();
            this.btDeleteRes = new System.Windows.Forms.Button();
            this.btSaveRes = new System.Windows.Forms.Button();
            this.lbDateSearch = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lbReservationSearch = new System.Windows.Forms.Label();
            this.txtSearchReservation = new System.Windows.Forms.TextBox();
            this.gvUsers = new System.Windows.Forms.DataGridView();
            this.lnTableStatus = new System.Windows.Forms.Label();
            this.lbReservationDate = new System.Windows.Forms.Label();
            this.lbResStatus = new System.Windows.Forms.Label();
            this.tbCusAddress = new System.Windows.Forms.TextBox();
            this.lbCusAddress = new System.Windows.Forms.Label();
            this.lbReservation = new System.Windows.Forms.Label();
            this.tbTelephone = new System.Windows.Forms.TextBox();
            this.lbTelephone = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lbCustomerFName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpReservation
            // 
            this.dtpReservation.Location = new System.Drawing.Point(6, 153);
            this.dtpReservation.Name = "dtpReservation";
            this.dtpReservation.Size = new System.Drawing.Size(200, 20);
            this.dtpReservation.TabIndex = 80;
            // 
            // cbResStatus
            // 
            this.cbResStatus.DisplayMember = "Name";
            this.cbResStatus.FormattingEnabled = true;
            this.cbResStatus.Location = new System.Drawing.Point(157, 92);
            this.cbResStatus.Name = "cbResStatus";
            this.cbResStatus.Size = new System.Drawing.Size(121, 21);
            this.cbResStatus.TabIndex = 79;
            this.cbResStatus.ValueMember = "Id";
            // 
            // cbSeatStatus
            // 
            this.cbSeatStatus.FormattingEnabled = true;
            this.cbSeatStatus.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbSeatStatus.Location = new System.Drawing.Point(296, 92);
            this.cbSeatStatus.Name = "cbSeatStatus";
            this.cbSeatStatus.Size = new System.Drawing.Size(121, 21);
            this.cbSeatStatus.TabIndex = 78;
            // 
            // cbResDescription
            // 
            this.cbResDescription.DisplayMember = "Name";
            this.cbResDescription.FormattingEnabled = true;
            this.cbResDescription.Location = new System.Drawing.Point(10, 92);
            this.cbResDescription.Name = "cbResDescription";
            this.cbResDescription.Size = new System.Drawing.Size(121, 21);
            this.cbResDescription.TabIndex = 77;
            this.cbResDescription.ValueMember = "Id";
            // 
            // tbEmailAddress
            // 
            this.tbEmailAddress.Location = new System.Drawing.Point(607, 92);
            this.tbEmailAddress.Name = "tbEmailAddress";
            this.tbEmailAddress.Size = new System.Drawing.Size(167, 20);
            this.tbEmailAddress.TabIndex = 76;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(604, 77);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(73, 13);
            this.lbEmail.TabIndex = 75;
            this.lbEmail.Text = "Email Address";
            // 
            // btClearRes
            // 
            this.btClearRes.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClearRes.Location = new System.Drawing.Point(193, 402);
            this.btClearRes.Name = "btClearRes";
            this.btClearRes.Size = new System.Drawing.Size(122, 32);
            this.btClearRes.TabIndex = 74;
            this.btClearRes.Text = "Clear Orders";
            this.btClearRes.UseVisualStyleBackColor = true;
            // 
            // btDeleteRes
            // 
            this.btDeleteRes.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteRes.Location = new System.Drawing.Point(100, 452);
            this.btDeleteRes.Name = "btDeleteRes";
            this.btDeleteRes.Size = new System.Drawing.Size(122, 32);
            this.btDeleteRes.TabIndex = 73;
            this.btDeleteRes.Text = "Delete Orders";
            this.btDeleteRes.UseVisualStyleBackColor = true;
            // 
            // btSaveRes
            // 
            this.btSaveRes.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSaveRes.Location = new System.Drawing.Point(10, 402);
            this.btSaveRes.Name = "btSaveRes";
            this.btSaveRes.Size = new System.Drawing.Size(122, 32);
            this.btSaveRes.TabIndex = 72;
            this.btSaveRes.Text = "Save Orders";
            this.btSaveRes.UseVisualStyleBackColor = true;
            // 
            // lbDateSearch
            // 
            this.lbDateSearch.AutoSize = true;
            this.lbDateSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateSearch.Location = new System.Drawing.Point(49, 189);
            this.lbDateSearch.Name = "lbDateSearch";
            this.lbDateSearch.Size = new System.Drawing.Size(131, 25);
            this.lbDateSearch.TabIndex = 71;
            this.lbDateSearch.Text = "Date Search";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(6, 214);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 70;
            // 
            // lbReservationSearch
            // 
            this.lbReservationSearch.AutoSize = true;
            this.lbReservationSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReservationSearch.Location = new System.Drawing.Point(528, 126);
            this.lbReservationSearch.Name = "lbReservationSearch";
            this.lbReservationSearch.Size = new System.Drawing.Size(201, 25);
            this.lbReservationSearch.TabIndex = 69;
            this.lbReservationSearch.Text = "Reservation Search";
            // 
            // txtSearchReservation
            // 
            this.txtSearchReservation.Location = new System.Drawing.Point(480, 154);
            this.txtSearchReservation.Name = "txtSearchReservation";
            this.txtSearchReservation.Size = new System.Drawing.Size(293, 20);
            this.txtSearchReservation.TabIndex = 68;
            // 
            // gvUsers
            // 
            this.gvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUsers.Location = new System.Drawing.Point(339, 180);
            this.gvUsers.Name = "gvUsers";
            this.gvUsers.Size = new System.Drawing.Size(553, 392);
            this.gvUsers.TabIndex = 67;
            // 
            // lnTableStatus
            // 
            this.lnTableStatus.AutoSize = true;
            this.lnTableStatus.Location = new System.Drawing.Point(302, 79);
            this.lnTableStatus.Name = "lnTableStatus";
            this.lnTableStatus.Size = new System.Drawing.Size(62, 13);
            this.lnTableStatus.TabIndex = 66;
            this.lnTableStatus.Text = "Seat Status";
            // 
            // lbReservationDate
            // 
            this.lbReservationDate.AutoSize = true;
            this.lbReservationDate.Location = new System.Drawing.Point(7, 137);
            this.lbReservationDate.Name = "lbReservationDate";
            this.lbReservationDate.Size = new System.Drawing.Size(90, 13);
            this.lbReservationDate.TabIndex = 65;
            this.lbReservationDate.Text = "Reservation Date";
            // 
            // lbResStatus
            // 
            this.lbResStatus.AutoSize = true;
            this.lbResStatus.Location = new System.Drawing.Point(154, 79);
            this.lbResStatus.Name = "lbResStatus";
            this.lbResStatus.Size = new System.Drawing.Size(97, 13);
            this.lbResStatus.TabIndex = 64;
            this.lbResStatus.Text = "Reservation Status";
            // 
            // tbCusAddress
            // 
            this.tbCusAddress.Location = new System.Drawing.Point(607, 35);
            this.tbCusAddress.Name = "tbCusAddress";
            this.tbCusAddress.Size = new System.Drawing.Size(252, 20);
            this.tbCusAddress.TabIndex = 63;
            // 
            // lbCusAddress
            // 
            this.lbCusAddress.AutoSize = true;
            this.lbCusAddress.Location = new System.Drawing.Point(604, 19);
            this.lbCusAddress.Name = "lbCusAddress";
            this.lbCusAddress.Size = new System.Drawing.Size(92, 13);
            this.lbCusAddress.TabIndex = 62;
            this.lbCusAddress.Text = "Customer Address";
            // 
            // lbReservation
            // 
            this.lbReservation.AutoSize = true;
            this.lbReservation.Location = new System.Drawing.Point(7, 79);
            this.lbReservation.Name = "lbReservation";
            this.lbReservation.Size = new System.Drawing.Size(120, 13);
            this.lbReservation.TabIndex = 61;
            this.lbReservation.Text = "Reservation Description";
            // 
            // tbTelephone
            // 
            this.tbTelephone.Location = new System.Drawing.Point(406, 35);
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.Size = new System.Drawing.Size(167, 20);
            this.tbTelephone.TabIndex = 60;
            // 
            // lbTelephone
            // 
            this.lbTelephone.AutoSize = true;
            this.lbTelephone.Location = new System.Drawing.Point(403, 19);
            this.lbTelephone.Name = "lbTelephone";
            this.lbTelephone.Size = new System.Drawing.Size(98, 13);
            this.lbTelephone.TabIndex = 59;
            this.lbTelephone.Text = "Telephone Number";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(183, 35);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(167, 20);
            this.tbLastName.TabIndex = 58;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(10, 35);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(167, 20);
            this.tbFirstName.TabIndex = 57;
            // 
            // lbCustomerFName
            // 
            this.lbCustomerFName.AutoSize = true;
            this.lbCustomerFName.Location = new System.Drawing.Point(132, 19);
            this.lbCustomerFName.Name = "lbCustomerFName";
            this.lbCustomerFName.Size = new System.Drawing.Size(85, 13);
            this.lbCustomerFName.TabIndex = 56;
            this.lbCustomerFName.Text = "Customer Name ";
            // 
            // Resreports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 585);
            this.Controls.Add(this.dtpReservation);
            this.Controls.Add(this.cbResStatus);
            this.Controls.Add(this.cbSeatStatus);
            this.Controls.Add(this.cbResDescription);
            this.Controls.Add(this.tbEmailAddress);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.btClearRes);
            this.Controls.Add(this.btDeleteRes);
            this.Controls.Add(this.btSaveRes);
            this.Controls.Add(this.lbDateSearch);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lbReservationSearch);
            this.Controls.Add(this.txtSearchReservation);
            this.Controls.Add(this.gvUsers);
            this.Controls.Add(this.lnTableStatus);
            this.Controls.Add(this.lbReservationDate);
            this.Controls.Add(this.lbResStatus);
            this.Controls.Add(this.tbCusAddress);
            this.Controls.Add(this.lbCusAddress);
            this.Controls.Add(this.lbReservation);
            this.Controls.Add(this.tbTelephone);
            this.Controls.Add(this.lbTelephone);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lbCustomerFName);
            this.Name = "Resreports";
            this.Text = "Resreports";
            ((System.ComponentModel.ISupportInitialize)(this.gvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpReservation;
        private System.Windows.Forms.ComboBox cbResStatus;
        private System.Windows.Forms.ComboBox cbSeatStatus;
        private System.Windows.Forms.ComboBox cbResDescription;
        private System.Windows.Forms.TextBox tbEmailAddress;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Button btClearRes;
        private System.Windows.Forms.Button btDeleteRes;
        private System.Windows.Forms.Button btSaveRes;
        private System.Windows.Forms.Label lbDateSearch;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lbReservationSearch;
        private System.Windows.Forms.TextBox txtSearchReservation;
        private System.Windows.Forms.DataGridView gvUsers;
        private System.Windows.Forms.Label lnTableStatus;
        private System.Windows.Forms.Label lbReservationDate;
        private System.Windows.Forms.Label lbResStatus;
        private System.Windows.Forms.TextBox tbCusAddress;
        private System.Windows.Forms.Label lbCusAddress;
        private System.Windows.Forms.Label lbReservation;
        private System.Windows.Forms.TextBox tbTelephone;
        private System.Windows.Forms.Label lbTelephone;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lbCustomerFName;
    }
}