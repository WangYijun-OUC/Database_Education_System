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
using Education_System.主功能;
using Microsoft.VisualBasic;

namespace Education_System.主功能
{
    public partial class Main_menu : Form
    {
        public Main_menu()
        {
            InitializeComponent();
        }

        private void MainMenuLoad(object sender, EventArgs e)
        {
            Admin_Menu.Visible = false;          //隐藏管理员菜单
            Student_Menu.Visible = false;        //隐藏学生菜单
            Teacher_Menu.Visible = false;        //隐藏教师菜单

            全部成绩区.Visible = false;          //隐藏显示成绩信息的dataGridView
            成绩区.Visible = false;              //隐藏个人成绩查询操作面板
            MaximizeBox = false;                 //关闭主菜单窗口的最大化功能
            用户列表.Visible = false;            //隐藏显示用户信息的dataGridView
            删除用户区.Visible = false;          //隐藏删除操作的面板
            修改用户区.Visible = false;
            查询及格区.Visible = false;
            教师信息表.Visible = false;
            选课信息表.Visible = false;
            查询学生.Visible = false;

            //根据登录系统的身份不同，提示不同欢迎语和显示主菜单
            if (LoginInfo.identity.Equals("s"))
            {
                this.Text = LoginInfo.username + "同学您好！欢迎使用学生成绩管理系统。";
                Student_Menu.Visible = true;     //显示学生菜单
            }
            else if (LoginInfo.identity.Equals("t"))
            {
                this.Text = LoginInfo.username + "老师您好！欢迎使用学生成绩管理系统。";
                Teacher_Menu.Visible = true;     //显示教师菜单
            }
            else if (LoginInfo.identity.Equals("a"))
            {
                this.Text = LoginInfo.username + "管理员您好！欢迎使用学生成绩管理系统。";
                Admin_Menu.Visible = true;   //显示管理员菜单
            }
        }


//--------------------------------------------------------------管理员功能---------------------------------------------
// 1、用户管理--添加用户

        private void 添加用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginInfo.isadmin = true;//将数据实体类中的管理员表示置为true，注册时判断该值执行不同sql

            Register rg = new Register();
            rg.Show();
            //显示用户ToolStripMenuItem(null, null);
        }

// 2、用户管理--查看所有用户
        private void 显示用户ToolStripMenuItem(object sender, EventArgs e)
        {
            查询学生.Visible = false;
            修改用户区.Visible = false;
            删除用户区.Visible = false;
            DBlink db = new DBlink();       //创建数据库连接实例
            if (db.DBconn())
            {              //打开数据库连接
                db.GetUserInfoData("SELECT Student.*, username, identity FROM login_info LEFT OUTER JOIN student ON(Student.Sno = login_info.id); ");
            }
            db.DBclose();//关闭数据库连接
            用户列表.Rows.Clear(); //初始化dataGridView
            for (int i = 0; i < LoginInfo.idList.Count; i++)    //循环将数据实体类的数据存放到dataGridView中
            {
                int index = this.用户列表.Rows.Add();
                //实现隔行换色
                if (i % 2 == 0)
                {
                    this.用户列表.Rows[index].DefaultCellStyle.BackColor = Color.Gainsboro;//双数行
                }
                else
                {
                    this.用户列表.Rows[index].DefaultCellStyle.BackColor = Color.GhostWhite;//单数行
                }
                this.用户列表.Rows[index].Cells[0].Value = LoginInfo.idList[i];         //填充序号
                this.用户列表.Rows[index].Cells[1].Value = StudentInfo.SnameList[i];    //填充姓名
                this.用户列表.Rows[index].Cells[2].Value = StudentInfo.SsexList[i];     //填充性别
                this.用户列表.Rows[index].Cells[3].Value = StudentInfo.SageList[i];
                this.用户列表.Rows[index].Cells[4].Value = StudentInfo.SdeptList[i];
                this.用户列表.Rows[index].Cells[5].Value = LoginInfo.usernameList[i];
                if (LoginInfo.identityList[i].Equals("s"))                               //根据SF的值填充用户身份
                {
                    this.用户列表.Rows[index].Cells[6].Value = "学生";
                }
                else if (LoginInfo.identityList[i].Equals("t"))
                {
                    this.用户列表.Rows[index].Cells[6].Value = "教师";
                }
                else
                {
                    this.用户列表.Rows[index].Cells[6].Value = "管理员";
                }
                this.用户列表.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            //控制显示用户信息数据的dataGridView出现的位置
            用户列表.Top = 25;
            用户列表.Left = 30;
            用户列表.Height = 350;
            用户列表.Visible = true;    //显示数据集
        }


//用户管理——删除用户
//点击删除按钮 这里注意删除时的外码问题
        private void 删除用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            查询学生.Visible = false;
            修改用户区.Visible = false;
            显示用户ToolStripMenuItem(null, null);
            //控制操作的出现位置，给控件赋值
            删除用户区.Top = 400;
            删除用户区.Left = 30;
            删除用户区.Visible = true;  //显示删除操作面板
        }

        private void 删除用户_点击_Click(object sender, EventArgs e)
        {
            string[] Sno1 = new string[用户列表.Rows.Count];
            for (int i = 0; i < 用户列表.Rows.Count; i++)
            {
                if (用户列表.Rows[i].Selected == true)
                {
                    Sno1[i] = 用户列表.Rows[i].Cells[0].Value.ToString();
                }
            }
            String Sno = null;
            for (int j = 0; j < Sno1.Count(); j++)
            {
                Sno = Sno + Sno1[j];
            }
            if (Sno == null)
            {
                DialogResult dr = MessageBox.Show("请先选择一条数据！", "标题", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                string find = "SELECT * FROM Student, sc, Course where student.Sno = sc.Sno and course.Cno = sc.Cno and Student.Sno = '" + Sno + "';";

                string str = "delete from login_info where id = '" + Sno + "' and identity = 's'";
                string str1 = "delete from student where Sno = '" + Sno + "'";
                DBlink db = new DBlink();
                if (db.DBconn())
                {
                    try
                    {
                        if (db.search(find))
                        {
                            DialogResult dr = MessageBox.Show("用户" + Sno + "存在选课信息！无法删除！", "标题", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                        else
                        {
                            if (db.UpdataDeletAdd(str1) && db.UpdataDeletAdd(str))
                            //先删除在user_info中的信息, 再删除在学生表中的信息
                            {
                                DialogResult dr = MessageBox.Show("用户" + Sno + "删除成功！", "标题", MessageBoxButtons.OK, MessageBoxIcon.Question);
                                删除用户ToolStripMenuItem_Click(null, null);//重新加载数据
                                                                        //将用户输入的内容和提示信息文本置空
                            }
                        }
                            
                        

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("删除失败" + ex.Message, "系统消息");
                    }
                    finally
                    {
                        if (db != null)
                        {
                            //关闭数据库连接
                            db.DBclose();
                        }
                    }
                }
            }
            
            
        }

//用户管理——修改用户
        private void 修改用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            删除用户区.Visible = false;
            显示用户ToolStripMenuItem(null, null);
            修改用户区.Visible = true;
            修改用户区.Top = 400;
            修改用户区.Left = 300;
        }

        private void 修改用户_点击_Click(object sender, EventArgs e)
        {
            string[] Sno1 = new string[用户列表.Rows.Count];
            for (int i = 0; i < 用户列表.Rows.Count; i++)
            {
                if (用户列表.Rows[i].Selected == true)
                {
                    Sno1[i] = 用户列表.Rows[i].Cells[0].Value.ToString();
                }
            }
            String Sno = null;
            for (int j = 0; j < Sno1.Count(); j++)
            {
                Sno = Sno + Sno1[j];
            }
            if (Sno == null)
            {
                DialogResult dr = MessageBox.Show("请先选择一条数据！", "标题", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                string update = "update student set Sname = '" + 修改用户_输入用户名.Text + "', Sage = '" + 修改年龄_输入.Text + "' where Sno ='" + Sno + "'";
                DBlink db = new DBlink();
                if (db.DBconn())
                {
                    try
                    {
                        if(修改用户_输入用户名.Text.Equals("") || 修改年龄_输入.Text.Equals(""))
                        {
                            MessageBox.Show("请输入信息！", "系统消息");
                        }
                        else if (db.UpdataDeletAdd(update))
                        {
                            DialogResult dr = MessageBox.Show("用户" + Sno + "修改成功！", "标题", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            显示用户ToolStripMenuItem(null, null);//重新加载数据
                                                                //将用户输入的内容和提示信息文本置空
                            修改用户_输入用户名.Text = "";
                            修改年龄_输入.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("修改失败！", "系统消息");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("修改失败！" + ex.Message, "系统消息");
                    }
                    finally
                    {
                        if (db != null)
                        {
                            //关闭数据库连接
                            db.DBclose();
                        }
                    }
                }
            }
            
        }

//3、退出系统
        private void 退出登录ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            login log = new login();
            log.Show(this);
        }


//--------------------------------------------------------------教师功能---------------------------------------------
//一、成绩查询
//1.查询所有成绩
        private void init()
        {
            成绩区.Visible = false;
            查询及格区.Visible = false;
        }

        private void 查询所有成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            init();
            //控制显示学生成绩的控件的初始位置
            全部成绩区.Top = 25;
            全部成绩区.Left = 30;
            全部成绩区.Height = 350;
            全部成绩区.Rows.Clear(); //初始化dataGridView
            全部成绩区.Visible = true;   //显示控件
            个人信息查询ToolStripMenuItem.Visible = false;
            DBlink db = new DBlink();       //创建数据库连接实例
            if (db.DBconn())                //连接数据库
            {
                db.GetScoreData("SELECT Student.Sno, Sname, course.Cno, Cname, Grade FROM Student, sc, course WHERE Student.Sno = sc.Sno AND SC.Cno = course.Cno AND Grade IS NOT NULL; "); //执行sql
            }
            db.DBclose();                   //关闭数据库连接

            for (int i = 0; i < ScoreInfo.SnoList.Count; i++)    //循环将数据实体类的数据存放到dataGridView中
            {
                int index = this.全部成绩区.Rows.Add();
                //实现隔行换色
                if (i % 2 == 0)
                {
                    this.全部成绩区.Rows[index].DefaultCellStyle.BackColor = Color.Gainsboro;//双数行
                }
                else
                {
                    this.全部成绩区.Rows[index].DefaultCellStyle.BackColor = Color.GhostWhite;//单数行
                }
                
                this.全部成绩区.Rows[index].Cells[0].Value = ScoreInfo.SnoList[i];        
                this.全部成绩区.Rows[index].Cells[1].Value = ScoreInfo.SnameList[i];    
                this.全部成绩区.Rows[index].Cells[2].Value = ScoreInfo.CnoList[i];     
                this.全部成绩区.Rows[index].Cells[3].Value = ScoreInfo.CnameList[i];   
                this.全部成绩区.Rows[index].Cells[4].Value = ScoreInfo.GradeList[i];   
                //this.全部成绩区.Rows[index].Cells[5].Value = ScoreInfo.name[i];      
            }
        }

//2.查询个人成绩
        private void 个人成绩查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            init();
            //设置全部成绩区的属性
            全部成绩区.Top = 25;
            全部成绩区.Left = 30;
            全部成绩区.Height = 350;
            全部成绩区.Rows.Clear(); //初始化dataGridView
            全部成绩区.Visible = true;   //显示控件
            //初始化个人成绩查询出现的面板
            成绩区.Top = 400;
            成绩区.Left = 30;
            成绩区.Visible = true;  //显示个人成绩查询的操作面板
        }

        private void 个人成绩查询_Click(object sender, EventArgs e)
        {
            string find = "SELECT Student.Sno, Sname, course.Cno, Cname, Grade FROM Student, sc, course WHERE Student.Sno = sc.Sno AND SC.Cno = course.Cno and sc.Sno = '" + 查看成绩_输入.Text + "' AND Grade IS NOT NULL";
            DBlink db = new DBlink();
            if (db.DBconn())
            {
                try
                {
                    if (查看成绩_输入.Text.Equals(""))
                        MessageBox.Show("请输入学生学号！", "系统消息");
                    else
                    {
                        if (db.GetScoreData(find))
                        {

                            for (int i = 0; i < ScoreInfo.SnoList.Count; i++)    //循环将数据实体类的数据存放到dataGridView中
                            {
                                int index = this.全部成绩区.Rows.Add();
                                //实现隔行换色
                                if (i % 2 == 0)
                                {
                                    this.全部成绩区.Rows[index].DefaultCellStyle.BackColor = Color.Gainsboro;//双数行
                                }
                                else
                                {
                                    this.全部成绩区.Rows[index].DefaultCellStyle.BackColor = Color.GhostWhite;//单数行
                                }

                                this.全部成绩区.Rows[index].Cells[0].Value = ScoreInfo.SnoList[i];
                                this.全部成绩区.Rows[index].Cells[1].Value = ScoreInfo.SnameList[i];
                                this.全部成绩区.Rows[index].Cells[2].Value = ScoreInfo.CnoList[i];
                                this.全部成绩区.Rows[index].Cells[3].Value = ScoreInfo.CnameList[i];
                                this.全部成绩区.Rows[index].Cells[4].Value = ScoreInfo.GradeList[i];
                                //this.全部成绩区.Rows[index].Cells[5].Value = ScoreInfo.name[i];
                                
                            }
                            DialogResult dr = MessageBox.Show("查询成功！");
                            查看成绩_输入.Text = "";

                        }
                        else
                        {
                            MessageBox.Show("查无此人", "系统消息");
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("查询失败" + ex.Message, "系统消息");
                }
                finally
                {
                    if (db != null)
                    {
                        //关闭数据库连接
                        db.DBclose();
                    }
                }
            }
        }

//3.录入个人成绩
        private void 录入学生成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddScore adscore = new AddScore();
            adscore.Show();
        }

//4.统计及格
        private void 统计及格ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            init();
            string find = "SELECT Student.Sno, Sname, course.Cno, Cname, Grade FROM Student, sc, course WHERE Student.Sno = sc.Sno AND SC.Cno = course.Cno AND Grade >= 60;";
            //string cal = "SELECT COUNT(Student.Sno) FROM Student, sc, course WHERE Student.Sno = sc.Sno AND SC.Cno = course.Cno AND Grade >= 60 AND Cname = '思想道德修养和法律基础';";
            //控制显示学生成绩的控件的初始位置
            全部成绩区.Top = 25;
            全部成绩区.Left = 30;
            全部成绩区.Height = 350;
            全部成绩区.Rows.Clear(); //初始化dataGridView
            全部成绩区.Visible = true;   //显示控件
            个人信息查询ToolStripMenuItem.Visible = false;
            查询及格区.Visible = true;
            查询及格区.Top = 400;
            查询及格区.Left = 30;
            显示对应课程_Label.Text = "";
            显示及格人数_Label.Text = "";
            DBlink db = new DBlink();       //创建数据库连接实例
            if (db.DBconn())                //连接数据库
            {
                db.GetScoreData(find); //执行sql
            }
            db.DBclose();                   //关闭数据库连接

            for (int i = 0; i < ScoreInfo.SnoList.Count; i++)    //循环将数据实体类的数据存放到dataGridView中
            {
                int index = this.全部成绩区.Rows.Add();
                //实现隔行换色
                if (i % 2 == 0)
                {
                    this.全部成绩区.Rows[index].DefaultCellStyle.BackColor = Color.Gainsboro;//双数行
                }
                else
                {
                    this.全部成绩区.Rows[index].DefaultCellStyle.BackColor = Color.GhostWhite;//单数行
                }

                this.全部成绩区.Rows[index].Cells[0].Value = ScoreInfo.SnoList[i];
                this.全部成绩区.Rows[index].Cells[1].Value = ScoreInfo.SnameList[i];
                this.全部成绩区.Rows[index].Cells[2].Value = ScoreInfo.CnoList[i];
                this.全部成绩区.Rows[index].Cells[3].Value = ScoreInfo.CnameList[i];
                this.全部成绩区.Rows[index].Cells[4].Value = ScoreInfo.GradeList[i];
                //this.全部成绩区.Rows[index].Cells[5].Value = ScoreInfo.name[i];      
            }
        }

        private void 查询及格_点击_Click(object sender, EventArgs e)
        {
            个人信息查询ToolStripMenuItem.Visible = false;
            
            string[] str = new string[全部成绩区.Rows.Count];
            string[] str1 = new string[全部成绩区.Rows.Count];
            for (int i = 0; i < 全部成绩区.Rows.Count; i++)
            {
                if (全部成绩区.Rows[i].Selected == true)
                {
                    str[i] = 全部成绩区.Rows[i].Cells[2].Value.ToString();
                    str1[i] = 全部成绩区.Rows[i].Cells[3].Value.ToString();
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
                //控制显示学生成绩的控件的初始位置
                全部成绩区.Top = 25;
                全部成绩区.Left = 30;
                全部成绩区.Height = 350;
                全部成绩区.Rows.Clear(); //初始化dataGridView
                全部成绩区.Visible = true;   //显示控件

                DBlink db = new DBlink();       //创建数据库连接实例
                string find = "SELECT Student.Sno, Sname, course.Cno, Cname, Grade FROM Student, sc, course WHERE Student.Sno = sc.Sno AND SC.Cno = course.Cno AND Grade >= 60 AND sc.Cno = '" + Cno + "';";
                string cal = "SELECT COUNT(Student.Sno) FROM Student, sc, course WHERE Student.Sno = sc.Sno AND SC.Cno = course.Cno AND Grade >= 60 AND sc.Cno = '" + Cno + "';";

                if (db.DBconn())                //连接数据库
                {
                    if (db.GetScoreData(find))
                        MessageBox.Show("查询成功！", "系统消息");//执行sql
                    else
                    {
                        MessageBox.Show("查询失败！", "系统消息");
                        return;
                    }

                }
                db.DBclose();                   //关闭数据库连接

                for (int i = 0; i < ScoreInfo.SnoList.Count; i++)    //循环将数据实体类的数据存放到dataGridView中
                {
                    int index = this.全部成绩区.Rows.Add();
                    //实现隔行换色
                    if (i % 2 == 0)
                    {
                        this.全部成绩区.Rows[index].DefaultCellStyle.BackColor = Color.Gainsboro;//双数行
                    }
                    else
                    {
                        this.全部成绩区.Rows[index].DefaultCellStyle.BackColor = Color.GhostWhite;//单数行
                    }

                    this.全部成绩区.Rows[index].Cells[0].Value = ScoreInfo.SnoList[i];
                    this.全部成绩区.Rows[index].Cells[1].Value = ScoreInfo.SnameList[i];
                    this.全部成绩区.Rows[index].Cells[2].Value = ScoreInfo.CnoList[i];
                    this.全部成绩区.Rows[index].Cells[3].Value = ScoreInfo.CnameList[i];
                    this.全部成绩区.Rows[index].Cells[4].Value = ScoreInfo.GradeList[i];
                    //this.全部成绩区.Rows[index].Cells[5].Value = ScoreInfo.name[i];      
                }

                显示对应课程_Label.Text = Cname;
                DBlink db1 = new DBlink();
                db.DBconn();
                db.GetCount(cal);
                显示及格人数_Label.Text = Public.count.ToString();
                db1.DBclose();
                //db.GetCount(stri);
                //DialogResult dr = MessageBox.Show("有" + quanju.count + "人及格！", "标题", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }


        }

//2、个人信息修改
//1、修改密码
        private void 修改密码ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int id;
            string password = Interaction.InputBox("请输入原始密码！", "输入密码", "", 500, 300);
            id = password.ToString().Equals("") ? 0 : Convert.ToInt32(password.ToString());
            if(id != 0 && password == LoginInfo.password)
            {
                string st = Interaction.InputBox("请输入新密码", "修改密码", "", 500, 300);
                int id1 = st.ToString().Equals("") ? 0 : Convert.ToInt32(st.ToString());
                DBlink db = new DBlink();
                string stri = "update login_info set password = '" + st + "' where id ='" + LoginInfo.id + "'";
                if (db.DBconn())
                {
                    if (id1 != 0 && db.UpdataDeletAdd(stri))//修改当前用户的tag标志
                    {
                        DialogResult dr = MessageBox.Show("密码修改成功！", "标题", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        //删除用户ToolStripMenuItem_Click(null, null);//重新加载数据
                        //panel1.Visible = false;
                    }
                    else
                    {
                        DialogResult dr = MessageBox.Show("密码修改失败！", "标题", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }

                }
            }else
                MessageBox.Show("输入错误！", "系统消息");

        }

//2、个人信息查询
        private void 个人信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBlink db = new DBlink();       //创建数据库连接实例
            if (db.DBconn())
            {              //打开数据库连接
                db.GetUserInfoData("SELECT teacher.*, username, identity FROM login_info, teacher where login_info.id = teacher.Tno AND login_info.id = '" + LoginInfo.id + "';");
            }
            db.DBclose();//关闭数据库连接
            教师信息表.Rows.Clear(); //初始化dataGridView
            for (int i = 0; i < LoginInfo.idList.Count; i++)    //循环将数据实体类的数据存放到dataGridView中
            {
                int index = this.教师信息表.Rows.Add();
                //实现隔行换色
                if (i % 2 == 0)
                {
                    this.教师信息表.Rows[index].DefaultCellStyle.BackColor = Color.Gainsboro;//双数行
                }
                else
                {
                    this.教师信息表.Rows[index].DefaultCellStyle.BackColor = Color.GhostWhite;//单数行
                }
                this.教师信息表.Rows[index].Cells[0].Value = LoginInfo.idList[i];         //填充序号
                this.教师信息表.Rows[index].Cells[1].Value = Teacher.TnameList[i];    //填充姓名
                DBlink db1 = new DBlink();       //创建数据库连接实例
                if (db.DBconn())
                    this.教师信息表.Rows[index].Cells[2].Value = db.GetTeacherCourse(Teacher.Cno);    //填充授课信息
                db1.DBclose();//关闭数据库连接
                this.教师信息表.Rows[index].Cells[3].Value = Teacher.TsexList[i];     //填充性别
                this.教师信息表.Rows[index].Cells[4].Value = Teacher.TageList[i];
                this.教师信息表.Rows[index].Cells[5].Value = Teacher.TdeptList[i];
                this.教师信息表.Rows[index].Cells[6].Value = LoginInfo.username;
                this.教师信息表.Rows[index].Cells[7].Value = "教师";
                this.教师信息表.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            //控制显示用户信息数据的dataGridView出现的位置
            教师信息表.Top = 25;
            教师信息表.Left = 30;
            教师信息表.Height = 350;
            教师信息表.Visible = true;    //显示数据集
        }

//3、课程信息修改
//1、添加课程信息
        private void 添加课程信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourse ad = new AddCourse();
            Public.op = "add";
            ad.Show(this);
        }

//2、查询课程信息
        private void 查询课程信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseInfo cs = new CourseInfo();
            cs.Show(this);
        }

//3、退出
        private void 退出登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

//--------------------------------------------------------------学生功能---------------------------------------------
//一、选课
        private void 选课ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CourseInfo ci = new CourseInfo();
            ci.Show();
        }

        private void 查看选课信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string find = "SELECT Student.Sno, Sname, course.Cno, Cname, Grade FROM Student, sc, course WHERE Student.Sno = sc.Sno AND SC.Cno = course.Cno and Student.Sno = '" + LoginInfo.id + "';";
            //string cal = "SELECT COUNT(Student.Sno) FROM Student, sc, course WHERE Student.Sno = sc.Sno AND SC.Cno = course.Cno AND Grade >= 60 AND Cname = '思想道德修养和法律基础';";
            //控制显示学生成绩的控件的初始位置
            选课信息表.Top = 25;
            选课信息表.Left = 30;
            选课信息表.Height = 350;
            选课信息表.Rows.Clear(); //初始化dataGridView
            选课信息表.Visible = true;   //显示控件

            DBlink db = new DBlink();       //创建数据库连接实例
            if (db.DBconn())                //连接数据库
            {
                db.GetScoreData(find); //执行sql
            }
            db.DBclose();                   //关闭数据库连接

            for (int i = 0; i < ScoreInfo.SnoList.Count; i++)    //循环将数据实体类的数据存放到dataGridView中
            {
                int index = this.选课信息表.Rows.Add();
                //实现隔行换色
                if (i % 2 == 0)
                {
                    this.选课信息表.Rows[index].DefaultCellStyle.BackColor = Color.Gainsboro;//双数行
                }
                else
                {
                    this.选课信息表.Rows[index].DefaultCellStyle.BackColor = Color.GhostWhite;//单数行
                }

                this.选课信息表.Rows[index].Cells[0].Value = ScoreInfo.SnoList[i];
                this.选课信息表.Rows[index].Cells[1].Value = ScoreInfo.SnameList[i];
                this.选课信息表.Rows[index].Cells[2].Value = ScoreInfo.CnoList[i];
                this.选课信息表.Rows[index].Cells[3].Value = ScoreInfo.CnameList[i];
                //this.全部成绩区.Rows[index].Cells[5].Value = ScoreInfo.name[i];      
            }
        }

        //二、个人成绩查询
        private void 个人成绩查询ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            全部成绩区.Top = 25;
            全部成绩区.Left = 30;
            全部成绩区.Height = 350;
            全部成绩区.Rows.Clear(); //初始化dataGridView
            全部成绩区.Visible = true;   //显示控件
            选课信息表.Visible = false;

            string find = "SELECT Student.Sno, Sname, course.Cno, Cname, Grade FROM Student, sc, course WHERE Student.Sno = sc.Sno AND SC.Cno = course.Cno and sc.Sno = '" + LoginInfo.id + "' AND Grade IS NOT NULL";
            DBlink db = new DBlink();
            if (db.DBconn())
            {
                try
                {
                    if (db.GetScoreData(find))
                    {

                        for (int i = 0; i < ScoreInfo.SnoList.Count; i++)    //循环将数据实体类的数据存放到dataGridView中
                        {
                            int index = this.全部成绩区.Rows.Add();
                            //实现隔行换色
                            if (i % 2 == 0)
                            {
                                this.全部成绩区.Rows[index].DefaultCellStyle.BackColor = Color.Gainsboro;//双数行
                            }
                            else
                            {
                                this.全部成绩区.Rows[index].DefaultCellStyle.BackColor = Color.GhostWhite;//单数行
                            }

                            this.全部成绩区.Rows[index].Cells[0].Value = ScoreInfo.SnoList[i];
                            this.全部成绩区.Rows[index].Cells[1].Value = ScoreInfo.SnameList[i];
                            this.全部成绩区.Rows[index].Cells[2].Value = ScoreInfo.CnoList[i];
                            this.全部成绩区.Rows[index].Cells[3].Value = ScoreInfo.CnameList[i];
                            this.全部成绩区.Rows[index].Cells[4].Value = ScoreInfo.GradeList[i];
                            //this.全部成绩区.Rows[index].Cells[5].Value = ScoreInfo.name[i];

                        }
                    }
                   

                }
                catch (Exception ex)
                {
                    MessageBox.Show("查询失败" + ex.Message, "系统消息");
                }
                finally
                {
                    if (db != null)
                    {
                        //关闭数据库连接
                        db.DBclose();
                    }
                }
            }
        }

//三、账号管理
//1、修改密码
        private void 修改密码ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int id;
            string password = Interaction.InputBox("请输入原始密码！", "输入密码", "", 500, 300);
            id = password.ToString().Equals("") ? 0 : Convert.ToInt32(password.ToString());
            if (id != 0 && password == LoginInfo.password)
            {
                string st = Interaction.InputBox("请输入新密码", "修改密码", "", 500, 300);
                DBlink db = new DBlink();
                string stri = "update login_info set password = '" + st + "' where id ='" + LoginInfo.id + "'";
                if (db.DBconn())
                {
                    if (db.UpdataDeletAdd(stri))//修改当前用户的tag标志
                    {
                        DialogResult dr = MessageBox.Show("密码修改成功！", "标题", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        //删除用户ToolStripMenuItem_Click(null, null);//重新加载数据
                        //panel1.Visible = false;
                    }
                    else
                    {
                        DialogResult dr = MessageBox.Show("密码修改失败！", "标题", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }

                }
            }
            else
                MessageBox.Show("输入错误！", "系统消息");
        }


//2、修改个人信息
        private void 查询个人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBlink db = new DBlink();       //创建数据库连接实例
            if (db.DBconn())
            {              //打开数据库连接
                db.GetUserInfoData("SELECT Student.*, username, identity FROM login_info, student where login_info.id = student.Sno AND login_info.id = '" + LoginInfo.id + "';");
            }
            db.DBclose();//关闭数据库连接
            用户列表.Rows.Clear(); //初始化dataGridView
            for (int i = 0; i < LoginInfo.idList.Count; i++)    //循环将数据实体类的数据存放到dataGridView中
            {
                int index = this.用户列表.Rows.Add();
                //实现隔行换色
                if (i % 2 == 0)
                {
                    this.用户列表.Rows[index].DefaultCellStyle.BackColor = Color.Gainsboro;//双数行
                }
                else
                {
                    this.用户列表.Rows[index].DefaultCellStyle.BackColor = Color.GhostWhite;//单数行
                }
                this.用户列表.Rows[index].Cells[0].Value = LoginInfo.idList[i];         //填充序号
                this.用户列表.Rows[index].Cells[1].Value = StudentInfo.SnameList[i];    //填充姓名
                this.用户列表.Rows[index].Cells[2].Value = StudentInfo.SsexList[i];     //填充性别
                this.用户列表.Rows[index].Cells[3].Value = StudentInfo.SageList[i];
                this.用户列表.Rows[index].Cells[4].Value = StudentInfo.SdeptList[i];
                this.用户列表.Rows[index].Cells[5].Value = LoginInfo.usernameList[i];
                if (LoginInfo.identityList[i].Equals("s"))                               //根据SF的值填充用户身份
                {
                    this.用户列表.Rows[index].Cells[6].Value = "学生";
                }
                else if (LoginInfo.identityList[i].Equals("t"))
                {
                    this.用户列表.Rows[index].Cells[6].Value = "教师";
                }
                else
                {
                    this.用户列表.Rows[index].Cells[6].Value = "管理员";
                }
                this.用户列表.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            //控制显示用户信息数据的dataGridView出现的位置
            用户列表.Top = 25;
            用户列表.Left = 30;
            用户列表.Height = 350;
            用户列表.Visible = true;    //显示数据集
        }

//四、退出登录
        private void 退出登录ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 添加课程信息ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddCourse ad = new AddCourse();
            Public.op = "add";
            ad.Show(this);
        }

        private void 查询课程信息ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CourseInfo cs = new CourseInfo();
            cs.Show(this);
        }

        private void 查询用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            修改用户区.Visible = false;
            删除用户区.Visible = false;
            显示用户ToolStripMenuItem(null, null);
            查询学生.Top = 400;
            查询学生.Left = 50;
            查询学生.Visible = true;  //显示删除操作面板
        }

        private void 查询用户_Click(object sender, EventArgs e)
        {
            string find1 = "";
            string find2 = "";
            string find3 = "";
            string find4 = "";
            string find5 = "";
            string find = "SELECT Student.*, username, identity FROM login_info, student where Student.Sno = login_info.id";

            if (学号查询_输入.Text != "")
            {
                find1 = " and student.Sno LIKE '%" + 学号查询_输入.Text + "%'";
                find = find + find1;
            }
                

            if(姓名查询_输入.Text != "")
            {
                find2 = " and student.Sname LIKE '%" + 姓名查询_输入.Text + "%'";
                find = find + find2;
            }
                

            if(年龄查询_输入.Text != "")
            {
                find3 = " and student.Sage = '" + 年龄查询_输入.Text + "'";
                find = find + find3;
            }
                

            
            if (性别查询_输入.SelectedIndex == 0 || 性别查询_输入.SelectedIndex == 1)
            {
                SsexJudge.Ssex_Judge(性别查询_输入.SelectedIndex);
                find4 = " and student.Ssex = '" + Public.Ssex + "'";
                find = find + find4;
            }
                

            
            if (院系查询_输入.SelectedIndex == 0 || 院系查询_输入.SelectedIndex == 1 || 院系查询_输入.SelectedIndex == 2 || 院系查询_输入.SelectedIndex == 3)
            {
                DeptJudge.Dept_Judge(院系查询_输入.SelectedIndex);
                find5 = " and student.Sdept = '" + Public.Sdept + "'";
                find = find + find5;
            }
                


            //string find = "SELECT Student.*, username, identity FROM login_info, student where Student.Sno = login_info.id and student.Sno LIKE '" + 学号查询_输入.Text + "%'";
            DBlink db = new DBlink();
            if (db.DBconn())
            {
                try
                {
                    if (db.GetUserInfoData(find))
                    {
                        DialogResult dr = MessageBox.Show("查询成功！", "标题");
                        用户列表.Rows.Clear(); //初始化dataGridView
                        for (int i = 0; i < LoginInfo.idList.Count; i++)    //循环将数据实体类的数据存放到dataGridView中
                        {
                            int index = this.用户列表.Rows.Add();
                            //实现隔行换色
                            if (i % 2 == 0)
                            {
                                this.用户列表.Rows[index].DefaultCellStyle.BackColor = Color.Gainsboro;//双数行
                            }
                            else
                            {
                                this.用户列表.Rows[index].DefaultCellStyle.BackColor = Color.GhostWhite;//单数行
                            }
                            this.用户列表.Rows[index].Cells[0].Value = LoginInfo.idList[i];         //填充序号
                            this.用户列表.Rows[index].Cells[1].Value = StudentInfo.SnameList[i];    //填充姓名
                            this.用户列表.Rows[index].Cells[2].Value = StudentInfo.SsexList[i];     //填充性别
                            this.用户列表.Rows[index].Cells[3].Value = StudentInfo.SageList[i];
                            this.用户列表.Rows[index].Cells[4].Value = StudentInfo.SdeptList[i];
                            this.用户列表.Rows[index].Cells[5].Value = LoginInfo.usernameList[i];
                            if (LoginInfo.identityList[i].Equals("s"))                               //根据SF的值填充用户身份
                            {
                                this.用户列表.Rows[index].Cells[6].Value = "学生";
                            }
                            else if (LoginInfo.identityList[i].Equals("t"))
                            {
                                this.用户列表.Rows[index].Cells[6].Value = "教师";
                            }
                            else
                            {
                                this.用户列表.Rows[index].Cells[6].Value = "管理员";
                            }
                            this.用户列表.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        }
                    }
                    else
                    {
                        MessageBox.Show("查询失败！不存在该用户！", "系统消息");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("查询失败！" + ex.Message, "系统消息");
                }
                finally
                {
                    if (db != null)
                    {
                        //关闭数据库连接
                        db.DBclose();
                    }
                }
            }
            
        }
            


    }
}
