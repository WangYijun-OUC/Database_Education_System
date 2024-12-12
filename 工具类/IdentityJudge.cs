using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemTool.数据类;

namespace SystemTool.工具类
{
    class IdentityJudge
    {
        //创建判断用户身份的工具类
        public static void Identity_Judge(int temp)
        {
            if (temp == 0)
            {
                Public.identity = "s";
            }
            else if (temp == 1)
            {
                Public.identity = "t";
            }
            else
            {
                Public.identity = "a";
            }
        }
    }
}
