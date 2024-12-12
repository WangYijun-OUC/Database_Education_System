
namespace Education_System.主功能
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.label1 = new System.Windows.Forms.Label();
            this.RegistIdentity = new System.Windows.Forms.ComboBox();
            this.用户名 = new System.Windows.Forms.Label();
            this.密码 = new System.Windows.Forms.Label();
            this.确认密码 = new System.Windows.Forms.Label();
            this.学号 = new System.Windows.Forms.Label();
            this.性别 = new System.Windows.Forms.Label();
            this.用户名_输入 = new System.Windows.Forms.TextBox();
            this.密码_输入 = new System.Windows.Forms.TextBox();
            this.确认密码_输入 = new System.Windows.Forms.TextBox();
            this.学号_输入 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.院系_输入 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.院系 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.年龄 = new System.Windows.Forms.Label();
            this.年龄_输入 = new System.Windows.Forms.TextBox();
            this.性别_输入 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.姓名 = new System.Windows.Forms.Label();
            this.姓名_输入 = new System.Windows.Forms.TextBox();
            this.code = new System.Windows.Forms.TextBox();
            this.Verification_Code = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label0 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "请选择身份：";
            // 
            // RegistIdentity
            // 
            this.RegistIdentity.FormattingEnabled = true;
            this.RegistIdentity.Items.AddRange(new object[] {
            "学生",
            "教师",
            "请选择您的身份"});
            this.RegistIdentity.Location = new System.Drawing.Point(195, 80);
            this.RegistIdentity.Margin = new System.Windows.Forms.Padding(4);
            this.RegistIdentity.Name = "RegistIdentity";
            this.RegistIdentity.Size = new System.Drawing.Size(160, 23);
            this.RegistIdentity.TabIndex = 1;
            this.RegistIdentity.SelectedIndexChanged += new System.EventHandler(this.RegistIdentity_SelectedIndexChanged);
            // 
            // 用户名
            // 
            this.用户名.AutoSize = true;
            this.用户名.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.用户名.ForeColor = System.Drawing.Color.White;
            this.用户名.Location = new System.Drawing.Point(72, 166);
            this.用户名.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.用户名.Name = "用户名";
            this.用户名.Size = new System.Drawing.Size(93, 20);
            this.用户名.TabIndex = 3;
            this.用户名.Text = "用户名：";
            // 
            // 密码
            // 
            this.密码.AutoSize = true;
            this.密码.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.密码.ForeColor = System.Drawing.Color.White;
            this.密码.Location = new System.Drawing.Point(93, 219);
            this.密码.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.密码.Name = "密码";
            this.密码.Size = new System.Drawing.Size(72, 20);
            this.密码.TabIndex = 4;
            this.密码.Text = "密码：";
            // 
            // 确认密码
            // 
            this.确认密码.AutoSize = true;
            this.确认密码.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.确认密码.ForeColor = System.Drawing.Color.White;
            this.确认密码.Location = new System.Drawing.Point(59, 275);
            this.确认密码.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.确认密码.Name = "确认密码";
            this.确认密码.Size = new System.Drawing.Size(114, 20);
            this.确认密码.TabIndex = 5;
            this.确认密码.Text = "确认密码：";
            // 
            // 学号
            // 
            this.学号.AutoSize = true;
            this.学号.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.学号.ForeColor = System.Drawing.Color.White;
            this.学号.Location = new System.Drawing.Point(51, 333);
            this.学号.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.学号.Name = "学号";
            this.学号.Size = new System.Drawing.Size(114, 20);
            this.学号.TabIndex = 6;
            this.学号.Text = "学生学号：";
            // 
            // 性别
            // 
            this.性别.AutoSize = true;
            this.性别.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.性别.ForeColor = System.Drawing.Color.White;
            this.性别.Location = new System.Drawing.Point(101, 452);
            this.性别.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.性别.Name = "性别";
            this.性别.Size = new System.Drawing.Size(72, 20);
            this.性别.TabIndex = 7;
            this.性别.Text = "性别：";
            // 
            // 用户名_输入
            // 
            this.用户名_输入.Location = new System.Drawing.Point(196, 161);
            this.用户名_输入.Margin = new System.Windows.Forms.Padding(4);
            this.用户名_输入.Name = "用户名_输入";
            this.用户名_输入.Size = new System.Drawing.Size(159, 25);
            this.用户名_输入.TabIndex = 8;
            this.用户名_输入.Leave += new System.EventHandler(this.用户名_输入_Leave);
            // 
            // 密码_输入
            // 
            this.密码_输入.Location = new System.Drawing.Point(196, 218);
            this.密码_输入.Margin = new System.Windows.Forms.Padding(4);
            this.密码_输入.Name = "密码_输入";
            this.密码_输入.PasswordChar = '*';
            this.密码_输入.Size = new System.Drawing.Size(159, 25);
            this.密码_输入.TabIndex = 9;
            // 
            // 确认密码_输入
            // 
            this.确认密码_输入.Location = new System.Drawing.Point(194, 275);
            this.确认密码_输入.Margin = new System.Windows.Forms.Padding(4);
            this.确认密码_输入.Name = "确认密码_输入";
            this.确认密码_输入.PasswordChar = '*';
            this.确认密码_输入.Size = new System.Drawing.Size(161, 25);
            this.确认密码_输入.TabIndex = 10;
            this.确认密码_输入.KeyUp += new System.Windows.Forms.KeyEventHandler(this.确认密码_输入_KeyUp);
            // 
            // 学号_输入
            // 
            this.学号_输入.Location = new System.Drawing.Point(194, 333);
            this.学号_输入.Margin = new System.Windows.Forms.Padding(4);
            this.学号_输入.Name = "学号_输入";
            this.学号_输入.Size = new System.Drawing.Size(161, 25);
            this.学号_输入.TabIndex = 11;
            this.学号_输入.Leave += new System.EventHandler(this.学号_输入_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(224, 697);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "注册";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(363, 278);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "label8";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.院系_输入);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.院系);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.年龄);
            this.panel1.Controls.Add(this.年龄_输入);
            this.panel1.Controls.Add(this.性别_输入);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.姓名);
            this.panel1.Controls.Add(this.姓名_输入);
            this.panel1.Controls.Add(this.code);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.RegistIdentity);
            this.panel1.Controls.Add(this.Verification_Code);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.密码_输入);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label0);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.用户名);
            this.panel1.Controls.Add(this.密码);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.确认密码);
            this.panel1.Controls.Add(this.学号);
            this.panel1.Controls.Add(this.学号_输入);
            this.panel1.Controls.Add(this.性别);
            this.panel1.Controls.Add(this.确认密码_输入);
            this.panel1.Controls.Add(this.用户名_输入);
            this.panel1.Location = new System.Drawing.Point(7, -5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 773);
            this.panel1.TabIndex = 16;
            // 
            // 院系_输入
            // 
            this.院系_输入.FormattingEnabled = true;
            this.院系_输入.Items.AddRange(new object[] {
            "计算系科学与技术学院",
            "电子信息工程学院",
            "物理与海技学院",
            "光电科学与工程学院"});
            this.院系_输入.Location = new System.Drawing.Point(193, 561);
            this.院系_输入.Name = "院系_输入";
            this.院系_输入.Size = new System.Drawing.Size(164, 23);
            this.院系_输入.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(365, 563);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "label5";
            // 
            // 院系
            // 
            this.院系.AutoSize = true;
            this.院系.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.院系.ForeColor = System.Drawing.Color.White;
            this.院系.Location = new System.Drawing.Point(98, 560);
            this.院系.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.院系.Name = "院系";
            this.院系.Size = new System.Drawing.Size(72, 20);
            this.院系.TabIndex = 26;
            this.院系.Text = "院系：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(365, 504);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "label4";
            // 
            // 年龄
            // 
            this.年龄.AutoSize = true;
            this.年龄.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.年龄.ForeColor = System.Drawing.Color.White;
            this.年龄.Location = new System.Drawing.Point(98, 501);
            this.年龄.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.年龄.Name = "年龄";
            this.年龄.Size = new System.Drawing.Size(72, 20);
            this.年龄.TabIndex = 23;
            this.年龄.Text = "年龄：";
            // 
            // 年龄_输入
            // 
            this.年龄_输入.Location = new System.Drawing.Point(193, 502);
            this.年龄_输入.Margin = new System.Windows.Forms.Padding(4);
            this.年龄_输入.Name = "年龄_输入";
            this.年龄_输入.Size = new System.Drawing.Size(162, 25);
            this.年龄_输入.TabIndex = 24;
            // 
            // 性别_输入
            // 
            this.性别_输入.FormattingEnabled = true;
            this.性别_输入.Items.AddRange(new object[] {
            "男",
            "女"});
            this.性别_输入.Location = new System.Drawing.Point(194, 447);
            this.性别_输入.Name = "性别_输入";
            this.性别_输入.Size = new System.Drawing.Size(161, 23);
            this.性别_输入.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(364, 392);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "label3";
            // 
            // 姓名
            // 
            this.姓名.AutoSize = true;
            this.姓名.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.姓名.ForeColor = System.Drawing.Color.White;
            this.姓名.Location = new System.Drawing.Point(98, 389);
            this.姓名.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.姓名.Name = "姓名";
            this.姓名.Size = new System.Drawing.Size(72, 20);
            this.姓名.TabIndex = 19;
            this.姓名.Text = "姓名：";
            // 
            // 姓名_输入
            // 
            this.姓名_输入.Location = new System.Drawing.Point(193, 390);
            this.姓名_输入.Margin = new System.Windows.Forms.Padding(4);
            this.姓名_输入.Name = "姓名_输入";
            this.姓名_输入.Size = new System.Drawing.Size(162, 25);
            this.姓名_输入.TabIndex = 20;
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(193, 625);
            this.code.Margin = new System.Windows.Forms.Padding(4);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(159, 25);
            this.code.TabIndex = 18;
            this.code.KeyUp += new System.Windows.Forms.KeyEventHandler(this.code_KeyUp);
            // 
            // Verification_Code
            // 
            this.Verification_Code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Verification_Code.ForeColor = System.Drawing.Color.White;
            this.Verification_Code.Location = new System.Drawing.Point(366, 628);
            this.Verification_Code.Margin = new System.Windows.Forms.Padding(4);
            this.Verification_Code.Name = "Verification_Code";
            this.Verification_Code.ReadOnly = true;
            this.Verification_Code.Size = new System.Drawing.Size(93, 25);
            this.Verification_Code.TabIndex = 17;
            this.Verification_Code.Text = "6666";
            this.Verification_Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(84, 625);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "验证码：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(380, 672);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 15);
            this.label12.TabIndex = 15;
            this.label12.Text = "labe12";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(363, 335);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 15);
            this.label11.TabIndex = 15;
            this.label11.Text = "label11";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(365, 222);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 15);
            this.label14.TabIndex = 15;
            this.label14.Text = "labe114";
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.ForeColor = System.Drawing.Color.White;
            this.label0.Location = new System.Drawing.Point(363, 164);
            this.label0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(55, 15);
            this.label0.TabIndex = 15;
            this.label0.Text = "label0";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(533, 751);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox RegistIdentity;
        private System.Windows.Forms.Label 用户名;
        private System.Windows.Forms.Label 密码;
        private System.Windows.Forms.Label 确认密码;
        private System.Windows.Forms.Label 学号;
        private System.Windows.Forms.Label 性别;
        private System.Windows.Forms.TextBox 用户名_输入;
        private System.Windows.Forms.TextBox 密码_输入;
        private System.Windows.Forms.TextBox 确认密码_输入;
        private System.Windows.Forms.TextBox 学号_输入;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.TextBox Verification_Code;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label 姓名;
        private System.Windows.Forms.TextBox 姓名_输入;
        private System.Windows.Forms.ComboBox 性别_输入;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label 院系;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label 年龄;
        private System.Windows.Forms.TextBox 年龄_输入;
        private System.Windows.Forms.ComboBox 院系_输入;

    }

    
}
