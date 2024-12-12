
namespace Education_System
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.DoLogin = new System.Windows.Forms.Button();
            this.DoNo = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.Username_Input = new System.Windows.Forms.TextBox();
            this.identity = new System.Windows.Forms.ComboBox();
            this.choose_identity = new System.Windows.Forms.Label();
            this.Verification_Code = new System.Windows.Forms.TextBox();
            this.Verification_Code_in = new System.Windows.Forms.TextBox();
            this.ver_code = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DoRegist = new System.Windows.Forms.Button();
            this.password_Input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DoLogin
            // 
            this.DoLogin.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DoLogin.Location = new System.Drawing.Point(173, 291);
            this.DoLogin.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.DoLogin.Name = "DoLogin";
            this.DoLogin.Size = new System.Drawing.Size(132, 37);
            this.DoLogin.TabIndex = 0;
            this.DoLogin.Text = "登录";
            this.DoLogin.UseVisualStyleBackColor = true;
            this.DoLogin.Click += new System.EventHandler(this.DoLogin_Click);
            // 
            // DoNo
            // 
            this.DoNo.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DoNo.Location = new System.Drawing.Point(520, 291);
            this.DoNo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.DoNo.Name = "DoNo";
            this.DoNo.Size = new System.Drawing.Size(132, 37);
            this.DoNo.TabIndex = 1;
            this.DoNo.Text = "重置";
            this.DoNo.UseVisualStyleBackColor = true;
            this.DoNo.Click += new System.EventHandler(this.DoNo_Click);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.BackColor = System.Drawing.Color.Transparent;
            this.Username.Font = new System.Drawing.Font("华文新魏", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Username.ForeColor = System.Drawing.SystemColors.Window;
            this.Username.Location = new System.Drawing.Point(239, 77);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(94, 21);
            this.Username.TabIndex = 2;
            this.Username.Text = "用户名：";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.Color.Transparent;
            this.password.Font = new System.Drawing.Font("华文新魏", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.password.ForeColor = System.Drawing.SystemColors.Window;
            this.password.Location = new System.Drawing.Point(260, 127);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(73, 21);
            this.password.TabIndex = 3;
            this.password.Text = "密码：";
            // 
            // Username_Input
            // 
            this.Username_Input.Font = new System.Drawing.Font("华文新魏", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Username_Input.Location = new System.Drawing.Point(348, 75);
            this.Username_Input.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Username_Input.Name = "Username_Input";
            this.Username_Input.Size = new System.Drawing.Size(165, 23);
            this.Username_Input.TabIndex = 4;
            // 
            // identity
            // 
            this.identity.Font = new System.Drawing.Font("华文新魏", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.identity.FormattingEnabled = true;
            this.identity.Items.AddRange(new object[] {
            "学生",
            "教师",
            "管理员"});
            this.identity.Location = new System.Drawing.Point(348, 180);
            this.identity.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.identity.Name = "identity";
            this.identity.Size = new System.Drawing.Size(165, 24);
            this.identity.TabIndex = 7;
            // 
            // choose_identity
            // 
            this.choose_identity.AutoSize = true;
            this.choose_identity.BackColor = System.Drawing.Color.Transparent;
            this.choose_identity.Font = new System.Drawing.Font("华文新魏", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.choose_identity.ForeColor = System.Drawing.SystemColors.Window;
            this.choose_identity.Location = new System.Drawing.Point(218, 179);
            this.choose_identity.Name = "choose_identity";
            this.choose_identity.Size = new System.Drawing.Size(115, 21);
            this.choose_identity.TabIndex = 8;
            this.choose_identity.Text = "选择身份：";
            // 
            // Verification_Code
            // 
            this.Verification_Code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Verification_Code.Font = new System.Drawing.Font("华文新魏", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Verification_Code.ForeColor = System.Drawing.Color.White;
            this.Verification_Code.Location = new System.Drawing.Point(538, 227);
            this.Verification_Code.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Verification_Code.Name = "Verification_Code";
            this.Verification_Code.ReadOnly = true;
            this.Verification_Code.Size = new System.Drawing.Size(126, 23);
            this.Verification_Code.TabIndex = 11;
            this.Verification_Code.Text = "6666";
            this.Verification_Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Verification_Code_in
            // 
            this.Verification_Code_in.Location = new System.Drawing.Point(348, 225);
            this.Verification_Code_in.Margin = new System.Windows.Forms.Padding(4);
            this.Verification_Code_in.Name = "Verification_Code_in";
            this.Verification_Code_in.Size = new System.Drawing.Size(165, 25);
            this.Verification_Code_in.TabIndex = 10;
            this.Verification_Code_in.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Verification_Code_in_KeyUp);
            // 
            // ver_code
            // 
            this.ver_code.AutoSize = true;
            this.ver_code.BackColor = System.Drawing.Color.Transparent;
            this.ver_code.Font = new System.Drawing.Font("华文新魏", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ver_code.ForeColor = System.Drawing.SystemColors.Window;
            this.ver_code.Location = new System.Drawing.Point(239, 229);
            this.ver_code.Name = "ver_code";
            this.ver_code.Size = new System.Drawing.Size(94, 21);
            this.ver_code.TabIndex = 9;
            this.ver_code.Text = "验证码：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(534, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "label6";
            // 
            // DoRegist
            // 
            this.DoRegist.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DoRegist.Location = new System.Drawing.Point(348, 291);
            this.DoRegist.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.DoRegist.Name = "DoRegist";
            this.DoRegist.Size = new System.Drawing.Size(132, 37);
            this.DoRegist.TabIndex = 13;
            this.DoRegist.Text = "注册";
            this.DoRegist.UseVisualStyleBackColor = true;
            this.DoRegist.Click += new System.EventHandler(this.DoRegist_Click);
            // 
            // password_Input
            // 
            this.password_Input.Location = new System.Drawing.Point(348, 127);
            this.password_Input.Margin = new System.Windows.Forms.Padding(4);
            this.password_Input.Name = "password_Input";
            this.password_Input.PasswordChar = '*';
            this.password_Input.Size = new System.Drawing.Size(165, 25);
            this.password_Input.TabIndex = 5;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(845, 416);
            this.Controls.Add(this.password_Input);
            this.Controls.Add(this.DoRegist);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Verification_Code);
            this.Controls.Add(this.Verification_Code_in);
            this.Controls.Add(this.ver_code);
            this.Controls.Add(this.choose_identity);
            this.Controls.Add(this.identity);
            this.Controls.Add(this.Username_Input);
            this.Controls.Add(this.password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.DoNo);
            this.Controls.Add(this.DoLogin);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DoLogin;
        private System.Windows.Forms.Button DoNo;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label password;
        public System.Windows.Forms.TextBox Username_Input;
        //public System.Windows.Forms.TextBox password_Input;
        public System.Windows.Forms.ComboBox identity;
        private System.Windows.Forms.Label choose_identity;
        private System.Windows.Forms.TextBox Verification_Code;
        private System.Windows.Forms.TextBox Verification_Code_in;
        private System.Windows.Forms.Label ver_code;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button DoRegist;
        private System.Windows.Forms.TextBox password_Input;
    }
}