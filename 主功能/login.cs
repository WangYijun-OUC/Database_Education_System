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

namespace Education_System
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            label6.Text = "";
            identity.SelectedIndex = 0; //登录系统的身份默认是学生
            MaximizeBox = false;        //关闭登录窗口的最大化功能
            //Verification_Code.Text = YanZhenMa.Code();                     //动态生成验证码
            DoLogin.Enabled = false;    //默认在不输入验证码时无法点击登录按钮
        }

        private void DoLogin_Click(object sender, EventArgs e)
        {
            DBlink db = new DBlink();//创建数据库连接对象
            IdentityJudge.Identity_Judge(identity.SelectedIndex);//根据用户选择的值判断用户身份
            if (db.DBconn())
            {
                //数据库连接成功
                string login1 = "";
                if (Public.identity.Equals("s"))
                    login1 = "SELECT login_info.*, Sname, Ssex, Sage, Sdept FROM login_info, student WHERE login_info.id = student.Sno AND login_info.username = '" + Username_Input.Text + "' AND login_info.`password` = '" + password_Input.Text + "'and identity = '" + Public.identity + "'";
                else if (Public.identity.Equals("t"))
                    login1 = "SELECT login_info.*, Tname, Tsex, Tage, Tdept FROM login_info, Teacher WHERE login_info.id = Teacher.Tno AND login_info.username = '" + Username_Input.Text + "' AND login_info.`password` = '" + password_Input.Text + "'";
                else if (Public.identity.Equals("a"))
                    login1 = "select * from login_info where identity = '" + Public.identity + "'and username = '" + Username_Input.Text + "' and password = '" + password_Input.Text + "'";
                if (db.GetLoginData(login1))
                {
                    if (password_Input.Text.Equals(LoginInfo.password))//登录成功
                    {
                        MessageBox.Show("登录成功！", "系统消息");
                        /*Thread.Sleep(1000);*/
                        Main_menu mainmenu = new Main_menu();
                        mainmenu.Show(this);        //显示主菜单界面
                        //db.DBclose();
                    }
                    else
                    {  //密码错误
                        MessageBox.Show("信息有误！请重新检查！","系统消息");
                    }
                }
                else
                {
                    MessageBox.Show("登录失败，用户名或密码错误！", "系统消息"); 
                }
            }
            db.DBclose();//关闭数据库连接
        }
            
        

        private void DoRegist_Click(object sender, EventArgs e)
        {
            Register RG = new Register();
            RG.Show(this);
        }

        private void DoNo_Click(object sender, EventArgs e)
        {
            Username_Input.Text = "";//将用户输入的信息置空
            password_Input.Text = "";
            identity.SelectedIndex = 0; //登录系统的身份默认是学生
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Verification_Code_in_KeyUp(object sender, EventArgs e)
        {
            if (Verification_Code_in.Text != Verification_Code.Text)
            {
                label6.Text = "验证码错误！";
            }
            else
            {
                label6.Text = "";
                DoLogin.Enabled = true;
            }
        }

    }
}
