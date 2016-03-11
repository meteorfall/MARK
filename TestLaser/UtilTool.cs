using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestLaser
{
    class UtilTool
    {
        public static string GetNextSeqNo(string curNo,int numQty)
        {
            string pre = curNo.Substring(0, curNo.Length - numQty);
            string strNum = curNo.Substring(curNo.Length - numQty, numQty);

            return pre + (Convert.ToInt32(strNum) + 1).ToString().PadLeft(5, '0');
        }
        public static string GetPreSeqNo(string curNo, int numQty)
        {
            string pre = curNo.Substring(0, curNo.Length - numQty);
            string strNum = curNo.Substring(curNo.Length - numQty, numQty);

            return pre + (Convert.ToInt32(strNum) - 1).ToString().PadLeft(5, '0');
        }

    }
}

