using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemTool.数据类;
using SystemTool.工具类;

namespace Education_System.主功能
{
    public partial class AddCourse : Form
    {
        public AddCourse()
        {
            InitializeComponent();

        }

        private void AddCourse_Load(object sender, EventArgs e)
        {
            if (Public.op.Equals("update"))
            {
                课程名_输入.Text = Course.Cname;
                课程号_输入.Enabled = false;
                label11.Text = "课程号无法修改";
                先修课_输入.Text = Course.Cpname;
                学分_输入.Text = Course.Ccredit.ToString();
                授课教师_输入.Text = Course.teacher_name;
                addc.Enabled = false;
            }
            else if(Public.op.Equals("add"))
            {
                课程名_输入.Text = "";
                课程号_输入.Text = "";
                先修课_输入.Text = "";
                学分_输入.Text = 0.0f.ToString();
                授课教师_输入.Text = Teacher.Tname;
                修改课程_点击.Enabled = false;
            }

        }

        private void addc_Click(object sender, EventArgs e)
        {
            if (授课教师_输入.Text == null)
            {
                授课教师_输入.Text = LoginInfo.username;
            }
            if (课程名_输入.Text == null || 课程号_输入.Text == null || 学分_输入.Text == null)
            {
                DialogResult dr = MessageBox.Show("还有未输入的空值！", "标题", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
/*              Course.Cname = 课程名_输入.Text;
                Course.Cno = 课程号_输入.Text;
                Course.Cpno = 先修课_输入.Text;*/
                try
                {
                    float val = float.Parse(学分_输入.Text);
                    //Course.Ccredit = val;
                }
                catch
                {
                    MessageBox.Show("不能转换为double");
                }
           
                Course.teacher_name = 授课教师_输入.Text;
                DBlink db = new DBlink();   //创建数据库连接对象
                if (db.DBconn())
                { //连接数据库
                    string str1 = "UPDATE Course x SET Cpno = (SELECT Cno FROM (SELECT Cno FROM course y WHERE x.Cpname = y.Cname) AS temp);";
                    string str = "INSERT INTO course(Cno, Cname, Cpname, Ccredit, Tname) VALUES ('" + 课程号_输入.Text + "','" + 课程名_输入.Text + "','" + 先修课_输入.Text + "','" + 学分_输入.Text + "','" + 授课教师_输入.Text + "');";
                    if (db.UpdataDeletAdd(str))
                    {
                        db.UpdataDeletAdd(str1);
                        DialogResult dr = MessageBox.Show("课程添加成功！", "标题", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        课程名_输入.Text = "";
                        课程号_输入.Text = "";
                        先修课_输入.Text = "";
                        学分_输入.Text = 0.0f.ToString();
                        授课教师_输入.Text = Teacher.Tname;
                    }
                    else
                    {
                        DialogResult dr = MessageBox.Show("课程添加失败！", "标题", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }

                }
            }
        }

        private void 修改课程_点击_Click(object sender, EventArgs e)
        {
            if (授课教师_输入.Text == null)
            {
                授课教师_输入.Text = LoginInfo.username;
            }
            if (课程名_输入.Text == null || 课程号_输入.Text == null || 学分_输入.Text == null)
            {
                DialogResult dr = MessageBox.Show("还有未输入的空值！", "标题", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                Course.teacher_name = 授课教师_输入.Text;
                DBlink db = new DBlink();   //创建数据库连接对象
                if (db.DBconn())
                { //连接数据库
                    string str1 = "UPDATE Course x SET Cpno = (SELECT Cno FROM (SELECT Cno FROM course y WHERE x.Cpname = y.Cname) AS temp);";
                    string str = "UPDATE Course SET Cname = '" + 课程名_输入.Text + "', Cpname = '" + 先修课_输入.Text + "', Ccredit = '" + 学分_输入.Text + "', Tname = '" + 授课教师_输入.Text + "' WHERE Cno = '" + Course.Cno + "';";
                    if (db.UpdataDeletAdd(str))
                    {
                        db.UpdataDeletAdd(str1);
                        DialogResult dr = MessageBox.Show("课程修改成功！", "标题", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        课程名_输入.Text = "";
                        课程号_输入.Text = "";
                        先修课_输入.Text = "";
                        学分_输入.Text = 0.0f.ToString();
                        授课教师_输入.Text = Teacher.Tname;
                    }
                    else
                    {
                        DialogResult dr = MessageBox.Show("课程修改失败！", "标题", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }

                }
            }
        }
    }
}
