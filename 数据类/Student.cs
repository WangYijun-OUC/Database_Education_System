using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SystemTool.数据类
{
    class StudentInfo
    {
        //保存所有学生信息
        public static string Sno;           //学号
        public static string Sname;         //用户名
        public static string Ssex;          //性别
        public static int Sage;          //年龄
        public static string Sdept;      //管理员标记
        public static string username;  //用户名

        //创建list存储查询的用户信息结果集
        public static ArrayList SnoList = new ArrayList();
        public static ArrayList SnameList = new ArrayList();
        public static ArrayList SsexList = new ArrayList();
        public static ArrayList SageList = new ArrayList();
        public static ArrayList SdeptList = new ArrayList();
    }
}
