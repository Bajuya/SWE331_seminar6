namespace Seminar6
{
    partial class login_frm
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
            this.name_lbl = new System.Windows.Forms.Label();
            this.password_lbl = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Location = new System.Drawing.Point(91, 72);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(92, 16);
            this.name_lbl.TabIndex = 0;
            this.name_lbl.Text = "Нэвтрэх нэр:";
            this.name_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Location = new System.Drawing.Point(91, 111);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(60, 16);
            this.password_lbl.TabIndex = 1;
            this.password_lbl.Text = "Нууц үг:";
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(176, 160);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(108, 23);
            this.login_btn.TabIndex = 2;
            this.login_btn.Text = "Нэвтрэх";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(217, 65);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(174, 22);
            this.username.TabIndex = 3;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(217, 111);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(174, 22);
            this.password.TabIndex = 4;
            // 
            // login_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 236);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.name_lbl);
            this.Name = "login_frm";
            this.Text = "Нэвтрэх цонх";
            this.Load += new System.EventHandler(this.login_frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
    }
}

