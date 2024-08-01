namespace HRMS
{
    partial class RegisterForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.signup_btn = new System.Windows.Forms.Button();
            this.signup_showPass = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.signup_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.signup_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.signup_loginBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(698, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // signup_btn
            // 
            this.signup_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.signup_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signup_btn.Location = new System.Drawing.Point(401, 474);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(167, 47);
            this.signup_btn.TabIndex = 16;
            this.signup_btn.Text = "SIGN UP";
            this.signup_btn.UseVisualStyleBackColor = false;
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            // 
            // signup_showPass
            // 
            this.signup_showPass.AutoSize = true;
            this.signup_showPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_showPass.Location = new System.Drawing.Point(521, 421);
            this.signup_showPass.Name = "signup_showPass";
            this.signup_showPass.Size = new System.Drawing.Size(141, 24);
            this.signup_showPass.TabIndex = 15;
            this.signup_showPass.Text = "Show Password";
            this.signup_showPass.UseVisualStyleBackColor = true;
            this.signup_showPass.CheckedChanged += new System.EventHandler(this.signup_showPass_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(351, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 39);
            this.label3.TabIndex = 14;
            this.label3.Text = "Register Account";
            // 
            // signup_password
            // 
            this.signup_password.Location = new System.Drawing.Point(323, 360);
            this.signup_password.Multiline = true;
            this.signup_password.Name = "signup_password";
            this.signup_password.PasswordChar = '*';
            this.signup_password.Size = new System.Drawing.Size(339, 36);
            this.signup_password.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 33);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password:";
            // 
            // signup_username
            // 
            this.signup_username.Location = new System.Drawing.Point(323, 223);
            this.signup_username.Multiline = true;
            this.signup_username.Name = "signup_username";
            this.signup_username.Size = new System.Drawing.Size(339, 36);
            this.signup_username.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "User Name:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.signup_loginBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 579);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HRMS.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(42, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(12, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(273, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Employee Management System";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 474);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Login Your Account";
            // 
            // signup_loginBtn
            // 
            this.signup_loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.signup_loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_loginBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signup_loginBtn.Location = new System.Drawing.Point(42, 530);
            this.signup_loginBtn.Name = "signup_loginBtn";
            this.signup_loginBtn.Size = new System.Drawing.Size(207, 47);
            this.signup_loginBtn.TabIndex = 9;
            this.signup_loginBtn.Text = "Sign In";
            this.signup_loginBtn.UseVisualStyleBackColor = false;
            this.signup_loginBtn.Click += new System.EventHandler(this.signup_loginBtn_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 579);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.signup_btn);
            this.Controls.Add(this.signup_showPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.signup_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.signup_username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button signup_btn;
        private System.Windows.Forms.CheckBox signup_showPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox signup_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox signup_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button signup_loginBtn;
    }
}