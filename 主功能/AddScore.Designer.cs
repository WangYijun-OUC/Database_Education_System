
namespace Education_System.主功能
{
    partial class AddScore
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.学号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.课程号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.课程名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.成绩 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.录入成绩 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.学号,
            this.姓名,
            this.课程号,
            this.课程名,
            this.成绩});
            this.dataGridView1.Location = new System.Drawing.Point(43, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(930, 219);
            this.dataGridView1.TabIndex = 0;
            // 
            // 学号
            // 
            this.学号.HeaderText = "学号";
            this.学号.MinimumWidth = 6;
            this.学号.Name = "学号";
            this.学号.Width = 125;
            // 
            // 姓名
            // 
            this.姓名.HeaderText = "姓名";
            this.姓名.MinimumWidth = 6;
            this.姓名.Name = "姓名";
            this.姓名.Width = 125;
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
            // 成绩
            // 
            this.成绩.HeaderText = "成绩";
            this.成绩.MinimumWidth = 6;
            this.成绩.Name = "成绩";
            this.成绩.Width = 125;
            // 
            // 录入成绩
            // 
            this.录入成绩.Location = new System.Drawing.Point(422, 344);
            this.录入成绩.Name = "录入成绩";
            this.录入成绩.Size = new System.Drawing.Size(143, 36);
            this.录入成绩.TabIndex = 1;
            this.录入成绩.Text = "录入成绩";
            this.录入成绩.UseVisualStyleBackColor = true;
            this.录入成绩.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 450);
            this.Controls.Add(this.录入成绩);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AddScore";
            this.Text = "AddScore";
            this.Load += new System.EventHandler(this.AddScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 学号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课程号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课程名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 成绩;
        private System.Windows.Forms.Button 录入成绩;
    }
}