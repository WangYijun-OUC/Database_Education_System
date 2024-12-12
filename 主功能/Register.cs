using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using SystemTool.工具类;
using SystemTool.数据类;
using Education_System.主功能;

namespace Education_System.主功能
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            //MaximizeBox = false;        //关闭注册窗口的最大化功能
            RegistIdentity.SelectedIndex = 2;//设置下拉菜单的默认选项
            //将所有提示信息的lable置空
            label0.Text = "*必填";
            label14.Text = "*必填";
            label8.Text = "*必填";
            label3.Text = "*必填";
            label11.Text = "*必填";
            label12.Text = "";
            label4.Text = "";
            label5.Text = "";
            //label14.Text = "*必填";
            button1.Enabled = false; //用户未输入注册信息时，默认注册按钮不可点击
            //PuanDuanSF.panduanshenfen(RegistIdentity.SelectedIndex);//根据用户选择的值判断用户身份

            this.Text = "注册";
            //Verification_Code.Text = YanZhenMa.Code(); //加载验证码


        }

        private void 用户名_输入_Leave(object sender, EventArgs e)
        {
            DBlink db = new DBlink();   //创建数据库连接对象
            if (db.DBconn())
            {          //创建数据库连接
                
                string str = "select * from login_info where identity = '" + Public.identity + "'and username = '" + 用户名_输入.Text + "'";
                if (db.GetLoginData1(str))//执行sql检测该用户是否已经被注册
                {
                    label0.Text = "该用户已经存在!";
                    button1.Enabled = false;
                }
                else
                {
                    label0.Text = "恭喜，可以注册!";
                }
            }
            db.DBclose();   //关闭数据库连接
        }

        private void 确认密码_输入_KeyUp(object sender, KeyEventArgs e)
        {
            if (!确认密码_输入.Text.Equals(密码_输入.Text))
            {
                label8.Text = "密码不一致！";
                button1.Enabled = false;
            }
            else
            {
                label8.Text = "";
            }
        }

        private void code_KeyUp(object sender, KeyEventArgs e)
        {
            if (!code.Text.Equals(Verification_Code.Text))
            {
                label12.Text = "验证码错误！";
                button1.Enabled = false;
            }
            else
            {
                label12.Text = "";
                button1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBlink db = new DBlink();   //创建数据库连接对象
            if (db.DBconn())
            { //连接数据库
                string str = "insert into login_info(id, username, password, identity) values('" + 学号_输入.Text + "','" + 用户名_输入.Text + "','" + 密码_输入.Text + "','" + Public.identity + "');";
                Console.WriteLine(str);
                //string info = "注册成功，请等待管理员审核！";
                if (db.UpdataDeletAdd(str))
                {
                    SsexJudge.Ssex_Judge(性别_输入.SelectedIndex);
                    DeptJudge.Dept_Judge(院系_输入.SelectedIndex);

                    string str1 = "";
                    if (Public.identity.Equals("s"))
                    {
                        str1 = "insert into student(Sno, Sname, Ssex, Sage, Sdept) values('" + 学号_输入.Text + "','" + 姓名_输入.Text + "','" + Public.Ssex + "','" + 年龄_输入.Text + "','" + Public.Sdept + "');";
                    }
                    else if (Public.identity.Equals("t"))
                    {
                        str1 = "insert into teacher(Tno, Tname, Tsex, Tage, Tdept) values('" + 学号_输入.Text + "','" + 姓名_输入.Text + "','" + Public.Ssex + "','" + 年龄_输入.Text + "','" + Public.Sdept + "');";
                    }

                    
                    Console.WriteLine(str1);
                    if (db.UpdataDeletAdd(str1))
                    {
                        DialogResult dr = MessageBox.Show("添加用户成功！", "标题", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        if (dr == DialogResult.OK)
                        {
                            this.Visible = false;//隐藏当前窗口
                        }
                    }
                    else
                    {
                        MessageBox.Show("添加用户失败！", "标题");
                    }
                        
                }
            }

            db.DBclose();//关闭数据连接
        }

        private void 学号_输入_Leave(object sender, EventArgs e)
        {
            DBlink db = new DBlink();   //创建数据库连接对象
            if (db.DBconn())
            {          //创建数据库连接
                string str = "select * from login_info where identity = '" + Public.identity + "'and id = '" + 学号_输入.Text + "'";
                if (db.GetLoginData1(str))//执行sql检测该用户是否已经被注册
                {
                    label11.Text = "该编号已存在!";
                    button1.Enabled = false;
                }
                else
                {
                    label11.Text = "恭喜，可以注册!";
                }
            }
            db.DBclose();   //关闭数据库连接
        }

        private void RegistIdentity_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdentityJudge.Identity_Judge(RegistIdentity.SelectedIndex);//根据用户选择的值判断用户身份
            if (Public.identity.Equals("s"))
            {
                学号.Text = "学生学号：";
            }
            else if (Public.identity.Equals("t"))
            {
                学号.Text = "教师编号：";
            }
        }
    }
}
