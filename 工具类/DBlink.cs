using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using SystemTool.数据类;

namespace SystemTool.工具类
{
    class DBlink
    {
        MySqlConnection sqlCnn = new MySqlConnection(); //创建数据库连接对象
        MySqlCommand sqlCmd = new MySqlCommand();       //创建执行sql的对象
        //LoginInfo lgI = new LoginInfo();    //创建登录数据的实例
        public Boolean DBtag = false;

        //创建数据库连接
        public Boolean DBconn()
        {
            sqlCnn.ConnectionString = "server = 'localhost'; uid = 'root'; database = 'education_system';";//连接字符串
            sqlCmd.Connection = sqlCnn;
            try
            {
                sqlCnn.Open();
                DBtag = true;
                if (DBtag)
                {
                    //Console.WriteLine("数据库连接成功");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
                // Console.WriteLine(ex.Message);
                //Console.WriteLine("数据库连接失败");
            }
            finally
            {
                //textBox2.AppendText("数据库连接关闭！");

            }
            return DBtag;
        }

        //执行查询的sql
        public Boolean search(String str)
        {
            sqlCmd.CommandText = str;
            Boolean tag = false;
            MySqlDataReader rec = sqlCmd.ExecuteReader();//创建结果集
            while (rec.Read())
            {
                tag = true;
                Console.WriteLine("查询到数据");
            }
            rec.Close();
            return tag;
        }

        //执行增删改的sql
        public Boolean UpdataDeletAdd(string str)
        {
            sqlCmd.CommandText = str;
            bool i = true;
            try
            {
                int j = sqlCmd.ExecuteNonQuery();
                return j >= 0;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "error");
                return false;
            }

            //Response.Write(i.ToString());
            //return sqlCmd.ExecuteNonQuery() > 0;
        }

        //关闭数据库连接
        public void DBclose()
        {
            sqlCnn.Close();
            //Console.WriteLine("数据库连接关闭");
            //Console.ReadKey();
        }

        public Boolean GetLoginData1(string str)
        {
            sqlCmd.CommandText = str;
            MySqlDataReader rec = sqlCmd.ExecuteReader();//创建结果集
            while (rec.Read())  //查询到数据结果
            {
                LoginInfo.id = rec.GetString(0);     //将学号存放在数据实体类
                LoginInfo.username = rec.GetString(1);          //将用户名存放到数据实体类
                LoginInfo.password = rec.GetString(2);          //将密码存放在数据实体类
                LoginInfo.identity = rec.GetString(3);          //将身份标记存放到数据实体类

                Console.WriteLine("查询到的信息：用户名{0},密码{1},身份标记{2},学生学号{3}", LoginInfo.username, LoginInfo.password, LoginInfo.identity, LoginInfo.id);
                return true;    //查询到用户数据
            }
            return false;
        }

        public Boolean GetLoginData2(string str)
        {
            sqlCmd.CommandText = str;
            MySqlDataReader rec = sqlCmd.ExecuteReader();//创建结果集
            while (rec.Read())  //查询到数据结果
            {
                StudentInfo.Sno = rec.GetString(0);
                StudentInfo.Sname = rec.GetString(1);
                StudentInfo.Ssex = rec.GetString(2);
                int id = rec["Sage"].ToString().Equals("") ? 0 : Convert.ToInt32(rec["Sage"].ToString());
                StudentInfo.Sage = id;
                StudentInfo.Sdept = rec.GetString(4);

                return true;    //查询到用户数据
            }
            return false;
        }


        //获取login所需要的数据
        public Boolean GetLoginData(string str)
        {
            sqlCmd.CommandText = str;
            MySqlDataReader rec = sqlCmd.ExecuteReader();//创建结果集
            while (rec.Read())  //查询到数据结果
            {
                LoginInfo.id = rec.GetString(0);     //将学号存放在数据实体类
                LoginInfo.username = rec.GetString(1);          //将用户名存放到数据实体类
                LoginInfo.password = rec.GetString(2);          //将密码存放在数据实体类
                LoginInfo.identity = rec.GetString(3);          //将身份标记存放到数据实体类
                // LoginInfo.tag = rec.GetInt32(4);      //将审核标记存放在数据实体类
                if (Public.identity.Equals("s"))
                {
                    StudentInfo.Sno = LoginInfo.id;
                    StudentInfo.Sname = rec.GetString(5);
                    StudentInfo.Ssex = rec.GetString(6);
                    int id = rec["Sage"].ToString().Equals("") ? 0 : Convert.ToInt32(rec["Sage"].ToString());
                    StudentInfo.Sage = id;
                    StudentInfo.Sdept = rec.GetString(8);
                }
                else if (Public.identity.Equals("t"))
                {
                    Teacher.Tno = LoginInfo.id;
                    Teacher.Tname = rec.GetString(5);
                    Teacher.Tsex = rec.GetString(6);
                    int id = rec["Tage"].ToString().Equals("") ? 0 : Convert.ToInt32(rec["Tage"].ToString());
                    Teacher.Tage = id;
                    Teacher.Tdept = rec.GetString(8);
                }

                Console.WriteLine("查询到的信息：用户名{0},密码{1},身份标记{2},学生学号{3}", LoginInfo.username, LoginInfo.password, LoginInfo.identity, LoginInfo.id);
                return true;    //查询到用户数据
            }
            return false;
        }

        
        //获取成绩表中的数据
        public Boolean GetScoreData(string str)
        {
            sqlCmd.CommandText = str;
            Boolean tag = false;
            MySqlDataReader rec = sqlCmd.ExecuteReader();//创建结果集
            //int aa = 0;
            int id = 0;
            //初始化数据
            ScoreInfo.SnoList.Clear();
            ScoreInfo.SnameList.Clear();
            ScoreInfo.CnameList.Clear();
            ScoreInfo.CnoList.Clear();
            ScoreInfo.GradeList.Clear();
            //ScoreInfo.name.Clear();
            while (rec.Read())  //查询到数据结果
            {
                ScoreInfo.SnoList.Add(rec.GetString(0));     
                ScoreInfo.SnameList.Add(rec.GetString(1));
                ScoreInfo.CnameList.Add(rec.GetString(3));
                ScoreInfo.CnoList.Add(rec.GetString(2));
                id = rec["Grade"].ToString().Equals("") ? 0 : Convert.ToInt32(rec["Grade"].ToString());
                ScoreInfo.GradeList.Add(id);
                //ScoreInfo.name.Add(rec.GetString(5));
                tag = true;    //查询到用户数据
                //aa++;
            }
            //Console.WriteLine("获取到"+aa+"条数据");
            return tag;
        }
        

        //获取用户信息表中的数据
        public Boolean GetUserInfoData(string str)
        {
            sqlCmd.CommandText = str;
            Boolean tag = false;
            MySqlDataReader rec = sqlCmd.ExecuteReader();//创建结果集

            //初始化数据
            LoginInfo.idList.Clear();
            LoginInfo.usernameList.Clear();
            LoginInfo.passwordList.Clear();
            StudentInfo.SnameList.Clear();
            StudentInfo.SsexList.Clear();
            StudentInfo.SageList.Clear();
            StudentInfo.SdeptList.Clear();
            while (rec.Read())  //查询到数据结果
            {
                if (Public.identity.Equals("s") || Public.identity.Equals("a"))
                {
                    string id = rec["Sno"].ToString().Equals("") ? "" : rec["Sno"].ToString();
                    if (id == "")
                        continue;
                    LoginInfo.idList.Add(rec.GetString(0));         //将查询到的id存储到数据实体类

                    StudentInfo.SnameList.Add(rec.GetString(1));
                    StudentInfo.SsexList.Add(rec.GetString(2));
                    StudentInfo.SageList.Add(rec.GetInt32(3));
                    StudentInfo.SdeptList.Add(rec.GetString(4));
                }
                else if (Public.identity.Equals("t"))
                {
                    string id = rec["Tno"].ToString().Equals("") ? "" : rec["Tno"].ToString();
                    if (id == "")
                        continue;
                    LoginInfo.idList.Add(rec.GetString(0));         //将查询到的id存储到数据实体类

                    Teacher.TnameList.Add(rec.GetString(1));
                    int id1 = rec["Cno"].ToString().Equals("") ? 0 : Convert.ToInt32(rec["Cno"].ToString());
                    Teacher.Cno = id1.ToString();
                    Teacher.TsexList.Add(rec.GetString(3));
                    Teacher.TageList.Add(rec.GetInt32(5));
                    Teacher.TdeptList.Add(rec.GetString(4));
                }
                LoginInfo.usernameList.Add(rec.GetString(5));
                LoginInfo.identityList.Add(rec.GetString(6));
                tag = true;    //查询到用户数据
            }

            return tag;
        }

        
        //查询课程
        public Boolean GetCourseInfo(string str)
        {
            int id;
            sqlCmd.CommandText = str;
            Boolean tag = false;
            MySqlDataReader rec = sqlCmd.ExecuteReader();//创建结果集
            Course.CnoList.Clear();
            Course.CnameList.Clear();
            Course.CpnoList.Clear();
            Course.CcreditList.Clear();
            Course.teacher_nameList.Clear();
            Course.CpnameList.Clear();
            while (rec.Read())  //查询到数据结果
            {
                Course.CnoList.Add(rec.GetString(0));
                Course.CnameList.Add(rec.GetString(1));
                id = rec["Cpno"].ToString().Equals("") ? 0 : Convert.ToInt32(rec["Cpno"].ToString());
                Course.CpnoList.Add(id);
                string id1 = rec["Cpname"].ToString().Equals("") ? "" : rec["Cpname"].ToString();
                Course.CpnameList.Add(id1);
                string id2 = rec["Ccredit"].ToString().Equals("") ? "" : rec["Ccredit"].ToString();
                Course.CcreditList.Add(id2);
                Course.teacher_nameList.Add(rec.GetString(5));

                tag = true;
            }
            return tag;

        }

        public Boolean GetOneCourseInfo(string str)
        {
            sqlCmd.CommandText = str;
            Boolean tag = false;
            MySqlDataReader rec = sqlCmd.ExecuteReader();//创建结果集
            Course.Cno = null;
            Course.Cname = null;
            Course.Cpno = null;
            Course.Ccredit = 0.0f;
            Course.Cpname = null;
            Course.teacher_name = null;
            if (rec.Read())  //查询到数据结果
            {
                Course.Cno = rec.GetString(0);
                Course.Cname = rec.GetString(1);
                string id1 = rec["Cpno"].ToString().Equals("") ? "" : rec["Cpno"].ToString();
                Course.Cpno = id1;
                id1 = rec["Cpname"].ToString().Equals("") ? "" : rec["Cpname"].ToString();
                Course.Cpname = id1;
                Course.Ccredit = rec.GetFloat(4);
                Course.teacher_name = rec.GetString(5);
                tag = true;
            }
            return tag;
        }
        
        public Boolean GetCount(string str)
        {
            sqlCmd.CommandText = str;
            Boolean tag = false;
            MySqlDataReader rec = sqlCmd.ExecuteReader();//创建结果集
            if (rec.Read())
            {
                Public.count = rec.GetInt32(0);
                tag = true;
            }
            return tag;
        }
        
        public string GetTeacherCourse(string id)
        {
            string sql = "select Cname from Course where Cno = '" + id + "'";
            sqlCmd.CommandText = sql;
            MySqlDataReader rec = sqlCmd.ExecuteReader();//创建结果集
            string result = "";
            if (rec.Read())
            {
                result = rec.GetString(0).ToString();
            }
            return result;
        }
    }
}
