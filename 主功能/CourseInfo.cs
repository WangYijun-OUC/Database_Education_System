using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemTool.工具类;
using SystemTool.数据类;
using Microsoft.VisualBasic;

namespace Education_System.主功能
{
    public partial class CourseInfo : Form
    {
        public CourseInfo()
        {
            InitializeComponent();
        }

        private void CourseInfo_Load(object sender, EventArgs e)
        {
            DBlink db = new DBlink();       //创建数据库连接实例
            if (db.DBconn())
            {              //打开数据库连接
                db.GetCourseInfo("select * from course");
            }
            db.DBclose();//关闭数据库连接
            课程信息表.Rows.Clear(); //初始化dataGridView

            for (int i = 0; i < Course.CnoList.Count; i++)    //循环将数据实体类的数据存放到课程信息表中
            {
                int index = this.课程信息表.Rows.Add();
                //实现隔行换色
                if (i % 2 == 0)
                {
                    this.课程信息表.Rows[index].DefaultCellStyle.BackColor = Color.Gainsboro;//双数行
                }
                else
                {
                    this.课程信息表.Rows[index].DefaultCellStyle.BackColor = Color.GhostWhite;//单数行
                }
                this.课程信息表.Rows[index].Cells[0].Value = Course.CnoList[i];//课程名称
                this.课程信息表.Rows[index].Cells[1].Value = Course.CnameList[i];//绩点
                this.课程信息表.Rows[index].Cells[2].Value = Course.CpnameList[i];//课程信息
                this.课程信息表.Rows[index].Cells[3].Value = Course.CcreditList[i];//上课地点
                this.课程信息表.Rows[index].Cells[4].Value = Course.teacher_nameList[i];//教师姓名
            }
            //控制显示用户信息数据的dataGridView出现的位置
            课程信息表.Top = 3;
            课程信息表.Width = 752;
            课程信息表.Left = 3;
            课程信息表.Height = 350;
            课程信息表.Visible = true;//显示数据集

            if (Public.identity.Equals("s"))
            {
                教师区域.Visible = false;
                学生区域.Top = 370;
                学生区域.Left = 60;
            }
            else
            {
                学生区域.Visible = false;
                教师区域.Top = 370;
                教师区域.Left = 60;
            }
        }

        private void 删除课程_点击_Click(object sender, EventArgs e)
        {
            string[] str = new string[课程信息表.Rows.Count];
            string[] str1 = new string[课程信息表.Rows.Count];
            for (int i = 0; i < 课程信息表.Rows.Count; i++)
            {
                if (课程信息表.Rows[i].Selected == true)
                {
                    str[i] = 课程信息表.Rows[i].Cells[0].Value.ToString();
                    str1[i] = 课程信息表.Rows[i].Cells[1].Value.ToString();
                }
            }
            String Cno = null;
            String Cname = null;
            for (int j = 0; j < str.Count(); j++)
            {
                Cno = Cno + str[j];
                Cname = Cname + str1[j];
            }
            if (Cno == null)
            {
                DialogResult dr = MessageBox.Show("请先选择一条数据！", "标题", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                DBlink db = new DBlink();
                string stri = "delete from course where Cno = '" + Cno + "'";
                string str2 = "DELETE FROM SC WHERE Cno = '" + Cno + "'";
                if (db.DBconn())
                {
                    if (db.UpdataDeletAdd(str2) && db.UpdataDeletAdd(stri))//修改当前用户的tag标志
                    {
                        DialogResult dr = MessageBox.Show("课程：" + Cname + "删除成功！", "标题", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        CourseInfo_Load(null, null);
                    }
                    else
                    {
                        DialogResult dr = MessageBox.Show("课程" + Cname + "删除失败！有先修课限制！", "标题", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
            }
        }

        private void 更新_点击_Click(object sender, EventArgs e)
        {
            CourseInfo_Load(null, null);
        }

        private void 修改课程_点击_Click(object sender, EventArgs e)
        {
            string[] str = new string[课程信息表.Rows.Count];
            for (int i = 0; i < 课程信息表.Rows.Count; i++)
            {
                if (课程信息表.Rows[i].Selected == true)
                {
                    str[i] = 课程信息表.Rows[i].Cells[0].Value.ToString();
                }
            }
            String re = null;
            for (int j = 0; j < str.Count(); j++)
            {
                re = re + str[j];
            }
            if (re == null)
            {
                MessageBox.Show("请先选择一条数据！", "标题", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                DBlink db = new DBlink();
                string stri = "select * from course where Cno = '" + re + "'";
                if (db.DBconn())
                {
                    if (db.GetOneCourseInfo(stri))
                    {
                        
                        AddCourse adc = new AddCourse();
                        Public.op = "update";
                        adc.Show();
                    }
                }
            }
        }

        private void 选课_点击_Click(object sender, EventArgs e)
        {
            string[] str = new string[课程信息表.Rows.Count];
            for (int i = 0; i < 课程信息表.Rows.Count; i++)
            {
                if (课程信息表.Rows[i].Selected == true)
                {
                    str[i] = 课程信息表.Rows[i].Cells[0].Value.ToString();
                }
            }
            String re = null;
            for (int j = 0; j < str.Count(); j++)
            {
                re = re + str[j];
            }
            if (re == null)
            {
                MessageBox.Show("请先选择一条数据！", "标题", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                //string semester = Interaction.InputBox("请输入学期！", "输入学期", "", 500, 300);
                string stri = "insert into sc(Sno, Cno) values('" + LoginInfo.id + "','" + re + "')";
                DBlink db = new DBlink();   //创建数据库连接对象
                db.DBconn();//连接数据库
                if (db.UpdataDeletAdd(stri))
                {
                    DialogResult dr = MessageBox.Show("选课成功！", "标题", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    DialogResult dr = MessageBox.Show("选课失败！", "标题", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }

            }
        }
    }
}
