namespace ChungsCateringApp
{
    partial class AdminLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBusername = new System.Windows.Forms.TextBox();
            this.TBpassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTlogin = new System.Windows.Forms.Button();
            this.BTreset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // TBusername
            // 
            this.TBusername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBusername.Location = new System.Drawing.Point(19, 165);
            this.TBusername.Name = "TBusername";
            this.TBusername.Size = new System.Drawing.Size(120, 20);
            this.TBusername.TabIndex = 2;
            // 
            // TBpassword
            // 
            this.TBpassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBpassword.Location = new System.Drawing.Point(176, 165);
            this.TBpassword.Name = "TBpassword";
            this.TBpassword.Size = new System.Drawing.Size(117, 20);
            this.TBpassword.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(91, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // BTlogin
            // 
            this.BTlogin.AutoSize = true;
            this.BTlogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTlogin.Location = new System.Drawing.Point(101, 209);
            this.BTlogin.Name = "BTlogin";
            this.BTlogin.Size = new System.Drawing.Size(43, 23);
            this.BTlogin.TabIndex = 5;
            this.BTlogin.Text = "Login";
            this.BTlogin.UseVisualStyleBackColor = true;
            this.BTlogin.Click += new System.EventHandler(this.BTlogin_Click);
            // 
            // BTreset
            // 
            this.BTreset.AutoSize = true;
            this.BTreset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTreset.Location = new System.Drawing.Point(150, 209);
            this.BTreset.Name = "BTreset";
            this.BTreset.Size = new System.Drawing.Size(45, 23);
            this.BTreset.TabIndex = 5;
            this.BTreset.Text = "Reset";
            this.BTreset.UseVisualStyleBackColor = true;
            // 
            // AdminLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 267);
            this.Controls.Add(this.BTreset);
            this.Controls.Add(this.BTlogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TBpassword);
            this.Controls.Add(this.TBusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminLoginForm";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBusername;
        private System.Windows.Forms.TextBox TBpassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTlogin;
        private System.Windows.Forms.Button BTreset;
    }
}