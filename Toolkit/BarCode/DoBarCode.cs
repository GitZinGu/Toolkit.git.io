using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Toolkit
{
    enum RCodeType
    {
        Number,   //数字
        Letter,   //字母
        Hybrid     //混合
    }
    public struct PictureSize
    {
        public int width;
        public int height;
    }
       
    class DoBarCode
    {
        protected string barcode;
        private PictureSize code1d;
        private PictureSize code2d;
        private PictureSize codepd;
        public DoBarCode(string _barcode, PictureSize d1s, PictureSize d2s, PictureSize pds)
        {
            this.barcode = _barcode;
            code1d = d1s;
            code2d = d2s;
            codepd = pds;
        }
        public DoBarCode(int codelength, string startcode, string endcode, RCodeType rc, PictureSize d1s, PictureSize d2s, PictureSize pds)
        {        
            string strran = "";
            switch (rc)
            {
                case RCodeType.Number:
                    strran = getRandomNumber(codelength);
                    break;
                case RCodeType.Letter:
                    strran = getRandomLetter(codelength);
                    break;
                case RCodeType.Hybrid:
                    strran = getRandomHybrid(codelength);
                    break;
                default:
                    break;
            }
            if (codelength - startcode.Length - endcode.Length>=0)
            {
                this.barcode = startcode + strran.Substring(0, codelength - startcode.Length - endcode.Length) + endcode;
            }
            else
            {
                this.barcode = startcode + endcode;
            }
            
            code1d = d1s;
            code2d = d2s;
            codepd = pds;
        }
        public string GetBarCode()
        {
            return barcode;
        }

        private string getRandomHybrid(int codelength)
        {
            char[] Pattern = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            string result = "";
            int n = Pattern.Length;
            System.Random random = new Random(~unchecked((int)DateTime.Now.Ticks));
            for (int i = 0; i < codelength; i++)
            {
                int rnd = random.Next(0, n);
                result += Pattern[rnd];
            }
            return result;
        }

        private string getRandomNumber(int codelength)
        {
            Random r = new Random();
            string result = string.Empty;
            for (int i = 0; i < codelength; i++)
            {
                result += r.Next(1, 10).ToString();
            }
            return result;
        }

        private string getRandomLetter(int codelength)
        {
            char[] Pattern = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            string result = "";
            int n = Pattern.Length;
            System.Random random = new Random(~unchecked((int)DateTime.Now.Ticks));
            for (int i = 0; i < codelength; i++)
            {
                int rnd = random.Next(0, n);
                result += Pattern[rnd];
            }
            return result;  
        }

        /// <summary>
        /// 生成一维码
        /// </summary>
        /// <returns></returns>
        public Bitmap Get1DBarCode()
        {
            return BarcodeHelper.Generate2(barcode, code1d.width, code1d.height);
        }
        /// <summary>
        /// 生成二维码
        /// </summary>
        /// <returns></returns>
        public Bitmap Get2DBarCode()
        {
            return BarcodeHelper.Generate1(barcode, code2d.width, code2d.height);
        }
        /// <summary>
        /// 生成带图片二维码
        /// </summary>
        /// <returns></returns>
        public Bitmap GetP2DBarCode(string url)
        {
            return BarcodeHelper.Generate3(barcode, codepd.width, codepd.height, url);
        }
    }
}
