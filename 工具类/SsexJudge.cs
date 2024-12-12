using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemTool.数据类;

namespace SystemTool.工具类
{
    class SsexJudge
    {
        public static void Ssex_Judge(int temp)
        {
            if (temp == 0)
            {
                Public.Ssex = "男";
            }
            else if (temp == 1)
            {
                Public.Ssex = "女";
            }
        }
    }
}
