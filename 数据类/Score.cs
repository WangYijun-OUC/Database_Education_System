using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SystemTool.数据类
{
    class ScoreInfo
    {
        //创建list存储查询的结果集
        public static ArrayList SnoList = new ArrayList();          //学生学号
        public static ArrayList SnameList = new ArrayList();        //学生姓名
        public static ArrayList CnoList = new ArrayList();          //课程号
        public static ArrayList CnameList = new ArrayList();        //课程名
        public static ArrayList GradeList = new ArrayList();        //存储成绩表的成绩
        //public static ArrayList Tname = new ArrayList();         //教师姓名
    }
}
