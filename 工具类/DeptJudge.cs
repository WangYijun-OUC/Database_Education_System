using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemTool.数据类;

namespace SystemTool.工具类
{
    class DeptJudge
    {
        public static void Dept_Judge(int temp)
        {
            if (temp == 0)
            {
                Public.Sdept = "计算机科学与技术学院";
            }
            else if (temp == 1)
            {
                Public.Sdept = "电子信息工程学院";
            }
            else if(temp == 2)
            {
                Public.Sdept = "物理与海技学院";
            }
            else if(temp == 3)
            {
                Public.Sdept = "光电科学与工程学院";
            }
        }
    }
}
