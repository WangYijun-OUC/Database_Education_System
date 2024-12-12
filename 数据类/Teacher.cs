using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SystemTool.数据类
{
    class Teacher
    {
        public static string Tno;
        public static string Tname;
        public static string Cno;
        public static string Tsex;
        public static string Tdept;
        public static int Tage;

        //创建list存储查询的用户信息结果集
        public static ArrayList TnoList = new ArrayList();
        public static ArrayList TnameList = new ArrayList();
        public static ArrayList TsexList = new ArrayList();
        public static ArrayList TageList = new ArrayList();
        public static ArrayList TdeptList = new ArrayList();
    }
}
