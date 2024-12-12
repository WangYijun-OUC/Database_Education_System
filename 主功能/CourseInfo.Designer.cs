
namespace Education_System.主功能
{
    partial class CourseInfo
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
            this.课程信息表 = new System.Windows.Forms.DataGridView();
            this.课程号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.课程名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.先修课 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.学分 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.授课老师 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.教师区域 = new System.Windows.Forms.Panel();
            this.更新_点击 = new System.Windows.Forms.Button();
            this.修改课程_点击 = new System.Windows.Forms.Button();
            this.删除课程_点击 = new System.Windows.Forms.Button();
            this.学生区域 = new System.Windows.Forms.Panel();
            this.选课_点击 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.课程信息表)).BeginInit();
            this.教师区域.SuspendLayout();
            this.学生区域.SuspendLayout();
            this.SuspendLayout();
            // 
            // 课程信息表
            // 
            this.课程信息表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.课程信息表.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.课程号,
            this.课程名,
            this.先修课,
            this.学分,
            this.授课老师});
            this.课程信息表.Location = new System.Drawing.Point(80, 47);
            this.课程信息表.Name = "课程信息表";
            this.课程信息表.RowHeadersWidth = 51;
            this.课程信息表.Size = new System.Drawing.Size(752, 253);
            this.课程信息表.TabIndex = 0;
            // 
            // 课程号
            // 
            this.课程号.HeaderText = "课程号";
            this.课程号.MinimumWidth = 6;
            this.课程号.Name = "课程号";
            this.课程号.Width = 125;
            // 
            // 课程名
            // 
            this.课程名.HeaderText = "课程名";
            this.课程名.MinimumWidth = 6;
            this.课程名.Name = "课程名";
            this.课程名.Width = 125;
            // 
            // 先修课
            // 
            this.先修课.HeaderText = "先修课";
            this.先修课.MinimumWidth = 6;
            this.先修课.Name = "先修课";
            this.先修课.Width = 125;
            // 
            // 学分
            // 
            this.学分.HeaderText = "学分";
            this.学分.MinimumWidth = 6;
            this.学分.Name = "学分";
            this.学分.Width = 125;
            // 
            // 授课老师
            // 
            this.授课老师.HeaderText = "授课老师";
            this.授课老师.MinimumWidth = 6;
            this.授课老师.Name = "授课老师";
            this.授课老师.Width = 125;
            // 
            // 教师区域
            // 
            this.教师区域.Controls.Add(this.更新_点击);
            this.教师区域.Controls.Add(this.修改课程_点击);
            this.教师区域.Controls.Add(this.删除课程_点击);
            this.教师区域.Location = new System.Drawing.Point(80, 489);
            this.教师区域.Name = "教师区域";
            this.教师区域.Size = new System.Drawing.Size(752, 120);
            this.教师区域.TabIndex = 1;
            // 
            // 更新_点击
            // 
            this.更新_点击.Location = new System.Drawing.Point(547, 36);
            this.更新_点击.Name = "更新_点击";
            this.更新_点击.Size = new System.Drawing.Size(110, 39);
            this.更新_点击.TabIndex = 2;
            this.更新_点击.Text = "更新";
            this.更新_点击.UseVisualStyleBackColor = true;
            this.更新_点击.Click += new System.EventHandler(this.更新_点击_Click);
            // 
            // 修改课程_点击
            // 
            this.修改课程_点击.Location = new System.Drawing.Point(314, 36);
            this.修改课程_点击.Name = "修改课程_点击";
            this.修改课程_点击.Size = new System.Drawing.Size(110, 39);
            this.修改课程_点击.TabIndex = 1;
            this.修改课程_点击.Text = "修改课程";
            this.修改课程_点击.UseVisualStyleBackColor = true;
            this.修改课程_点击.Click += new System.EventHandler(this.修改课程_点击_Click);
            // 
            // 删除课程_点击
            // 
            this.删除课程_点击.Location = new System.Drawing.Point(95, 36);
            this.删除课程_点击.Name = "删除课程_点击";
            this.删除课程_点击.Size = new System.Drawing.Size(122, 39);
            this.删除课程_点击.TabIndex = 0;
            this.删除课程_点击.Text = "删除课程";
            this.删除课程_点击.UseVisualStyleBackColor = true;
            this.删除课程_点击.Click += new System.EventHandler(this.删除课程_点击_Click);
            // 
            // 学生区域
            // 
            this.学生区域.Controls.Add(this.选课_点击);
            this.学生区域.Location = new System.Drawing.Point(77, 380);
            this.学生区域.Name = "学生区域";
            this.学生区域.Size = new System.Drawing.Size(755, 103);
            this.学生区域.TabIndex = 2;
            // 
            // 选课_点击
            // 
            this.选课_点击.Location = new System.Drawing.Point(314, 40);
            this.选课_点击.Name = "选课_点击";
            this.选课_点击.Size = new System.Drawing.Size(110, 39);
            this.选课_点击.TabIndex = 3;
            this.选课_点击.Text = "选课";
            this.选课_点击.UseVisualStyleBackColor = true;
            this.选课_点击.Click += new System.EventHandler(this.选课_点击_Click);
            // 
            // CourseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 627);
            this.Controls.Add(this.教师区域);
            this.Controls.Add(this.学生区域);
            this.Controls.Add(this.课程信息表);
            this.Name = "CourseInfo";
            this.Text = "CourseInfo";
            this.Load += new System.EventHandler(this.CourseInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.课程信息表)).EndInit();
            this.教师区域.ResumeLayout(false);
            this.学生区域.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView 课程信息表;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课程号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课程名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 先修课;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学分;
        private System.Windows.Forms.DataGridViewTextBoxColumn 授课老师;
        private System.Windows.Forms.Panel 教师区域;
        private System.Windows.Forms.Button 删除课程_点击;
        private System.Windows.Forms.Button 更新_点击;
        private System.Windows.Forms.Button 修改课程_点击;
        private System.Windows.Forms.Panel 学生区域;
        private System.Windows.Forms.Button 选课_点击;
    }
}