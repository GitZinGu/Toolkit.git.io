using Microsoft.International.Converters.PinYinConverter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Toolkit 
{
     
    public  class Character
    {
        /// <summary>
        /// 转大写
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string strToUpper(string str)
        {
            return str.ToUpper();
        }
        /// <summary>
        /// 转小写
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string strToLower(string str)
        {
            return str.ToLower();
        }
        /// <summary>
        /// 汉字转拼音
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ChineseToPinyin(string str)
        {
            ChineseChar cc = null;
            StringBuilder strb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {

                try
                {
                    cc = new ChineseChar(str[i]);
                    strb.Append(cc.Pinyins[0].Substring(0, cc.Pinyins[0].Length - 1));
                }
                catch (Exception)
                {
                    strb.Append(" ");
                }
                   
            }
            return strb.ToString();
        }

        public static string MD5Encryption(string str)
        {
            using (MD5 mi = MD5.Create())
            {
                byte[] buffer = Encoding.Default.GetBytes(str);
                //开始加密
                byte[] newBuffer = mi.ComputeHash(buffer);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < newBuffer.Length; i++)
                {
                    sb.Append(newBuffer[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }

    }
}
