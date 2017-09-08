namespace SarangaBatteryWorks
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
            this.btn_reg_register = new System.Windows.Forms.Button();
            this.lbl_Register = new System.Windows.Forms.Label();
            this.lbl_register_un = new System.Windows.Forms.Label();
            this.lbl_Register_pw = new System.Windows.Forms.Label();
            this.lbl_register_pwReenter = new System.Windows.Forms.Label();
            this.txtbx_reg_un = new System.Windows.Forms.TextBox();
            this.txtbx_reg_pw = new System.Windows.Forms.TextBox();
            this.txtbx_reg_repw = new System.Windows.Forms.TextBox();
            this.lbl_reg_Usertype = new System.Windows.Forms.Label();
            this.cmbx_register_type = new System.Windows.Forms.ComboBox();
            this.lbl_reg_notmatched = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_reg_register
            // 
            this.btn_reg_register.Location = new System.Drawing.Point(113, 202);
            this.btn_reg_register.Name = "btn_reg_register";
            this.btn_reg_register.Size = new System.Drawing.Size(101, 23);
            this.btn_reg_register.TabIndex = 0;
            this.btn_reg_register.Text = "REGISTER";
            this.btn_reg_register.UseVisualStyleBackColor = true;
            this.btn_reg_register.Click += new System.EventHandler(this.btn_reg_register_Click);
            // 
            // lbl_Register
            // 
            this.lbl_Register.AutoSize = true;
            this.lbl_Register.Location = new System.Drawing.Point(118, 9);
            this.lbl_Register.Name = "lbl_Register";
            this.lbl_Register.Size = new System.Drawing.Size(62, 13);
            this.lbl_Register.TabIndex = 1;
            this.lbl_Register.Text = "REGISTER";
            // 
            // lbl_register_un
            // 
            this.lbl_register_un.AutoSize = true;
            this.lbl_register_un.Location = new System.Drawing.Point(49, 47);
            this.lbl_register_un.Name = "lbl_register_un";
            this.lbl_register_un.Size = new System.Drawing.Size(57, 13);
            this.lbl_register_un.TabIndex = 2;
            this.lbl_register_un.Text = "UserName";
            // 
            // lbl_Register_pw
            // 
            this.lbl_Register_pw.AutoSize = true;
            this.lbl_Register_pw.Location = new System.Drawing.Point(53, 83);
            this.lbl_Register_pw.Name = "lbl_Register_pw";
            this.lbl_Register_pw.Size = new System.Drawing.Size(53, 13);
            this.lbl_Register_pw.TabIndex = 3;
            this.lbl_Register_pw.Text = "Password";
            // 
            // lbl_register_pwReenter
            // 
            this.lbl_register_pwReenter.AutoSize = true;
            this.lbl_register_pwReenter.Location = new System.Drawing.Point(9, 119);
            this.lbl_register_pwReenter.Name = "lbl_register_pwReenter";
            this.lbl_register_pwReenter.Size = new System.Drawing.Size(97, 13);
            this.lbl_register_pwReenter.TabIndex = 4;
            this.lbl_register_pwReenter.Text = "Re-enter Password";
            // 
            // txtbx_reg_un
            // 
            this.txtbx_reg_un.Location = new System.Drawing.Point(113, 39);
            this.txtbx_reg_un.Name = "txtbx_reg_un";
            this.txtbx_reg_un.Size = new System.Drawing.Size(100, 20);
            this.txtbx_reg_un.TabIndex = 5;
            // 
            // txtbx_reg_pw
            // 
            this.txtbx_reg_pw.Location = new System.Drawing.Point(112, 76);
            this.txtbx_reg_pw.Name = "txtbx_reg_pw";
            this.txtbx_reg_pw.PasswordChar = '*';
            this.txtbx_reg_pw.Size = new System.Drawing.Size(100, 20);
            this.txtbx_reg_pw.TabIndex = 6;
            // 
            // txtbx_reg_repw
            // 
            this.txtbx_reg_repw.Location = new System.Drawing.Point(113, 112);
            this.txtbx_reg_repw.Name = "txtbx_reg_repw";
            this.txtbx_reg_repw.PasswordChar = '*';
            this.txtbx_reg_repw.Size = new System.Drawing.Size(100, 20);
            this.txtbx_reg_repw.TabIndex = 7;
            this.txtbx_reg_repw.TextChanged += new System.EventHandler(this.txtbx_reg_repw_TextChanged);
            this.txtbx_reg_repw.Leave += new System.EventHandler(this.txtbx_reg_repw_Leave);
            // 
            // lbl_reg_Usertype
            // 
            this.lbl_reg_Usertype.AutoSize = true;
            this.lbl_reg_Usertype.Location = new System.Drawing.Point(49, 152);
            this.lbl_reg_Usertype.Name = "lbl_reg_Usertype";
            this.lbl_reg_Usertype.Size = new System.Drawing.Size(56, 13);
            this.lbl_reg_Usertype.TabIndex = 8;
            this.lbl_reg_Usertype.Text = "User Type";
            // 
            // cmbx_register_type
            // 
            this.cmbx_register_type.FormattingEnabled = true;
            this.cmbx_register_type.Items.AddRange(new object[] {
            "Admin",
            "Cashier"});
            this.cmbx_register_type.Location = new System.Drawing.Point(111, 149);
            this.cmbx_register_type.Name = "cmbx_register_type";
            this.cmbx_register_type.Size = new System.Drawing.Size(101, 21);
            this.cmbx_register_type.TabIndex = 9;
            // 
            // lbl_reg_notmatched
            // 
            this.lbl_reg_notmatched.AutoSize = true;
            this.lbl_reg_notmatched.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reg_notmatched.ForeColor = System.Drawing.Color.Red;
            this.lbl_reg_notmatched.Location = new System.Drawing.Point(122, 133);
            this.lbl_reg_notmatched.Name = "lbl_reg_notmatched";
            this.lbl_reg_notmatched.Size = new System.Drawing.Size(150, 13);
            this.lbl_reg_notmatched.TabIndex = 10;
            this.lbl_reg_notmatched.Text = "Password Not Matched!!!";
            this.lbl_reg_notmatched.Visible = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbl_reg_notmatched);
            this.Controls.Add(this.cmbx_register_type);
            this.Controls.Add(this.lbl_reg_Usertype);
            this.Controls.Add(this.txtbx_reg_repw);
            this.Controls.Add(this.txtbx_reg_pw);
            this.Controls.Add(this.txtbx_reg_un);
            this.Controls.Add(this.lbl_register_pwReenter);
            this.Controls.Add(this.lbl_Register_pw);
            this.Controls.Add(this.lbl_register_un);
            this.Controls.Add(this.lbl_Register);
            this.Controls.Add(this.btn_reg_register);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_reg_register;
        private System.Windows.Forms.Label lbl_Register;
        private System.Windows.Forms.Label lbl_register_un;
        private System.Windows.Forms.Label lbl_Register_pw;
        private System.Windows.Forms.Label lbl_register_pwReenter;
        private System.Windows.Forms.TextBox txtbx_reg_un;
        private System.Windows.Forms.TextBox txtbx_reg_pw;
        private System.Windows.Forms.TextBox txtbx_reg_repw;
        private System.Windows.Forms.Label lbl_reg_Usertype;
        private System.Windows.Forms.ComboBox cmbx_register_type;
        private System.Windows.Forms.Label lbl_reg_notmatched;
    }
}