using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Toolkit
{
    public partial class ApplicationInfo : Form
    {
        private static string Tool = "TOOLBOX      ";
        private static string Author = "Author : ZinGu      ";
        private static string CreateTime = "CreateTime : 2021:01:11    ";
        private static string CodeInfo = "CodeInfo : None     ";
        private static string Other= "Other : Thank you for using...         ";
        private List<string> listinfo =null; 
        public ApplicationInfo()
        {
            InitializeComponent();
            Loadcontrols();     
        }

        private void Loadcontrols()
        {
            this.Controls.Add(label1);
            this.Controls.Add(label2);
            this.Controls.Add(label3);
            this.Controls.Add(label4);
            this.Controls.Add(label5);
            this.Controls.Add(label6);
            this.label1.BackColor = Color.Transparent;
            this.label2.BackColor = Color.Transparent;
            this.label3.BackColor = Color.Transparent;
            this.label4.BackColor = Color.Transparent;
            this.label5.BackColor = Color.Transparent;
            this.label6.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MC", 20, label1.Font.Style | FontStyle.Regular);
            label2.Font = new Font("Comic Sans MC", 20, label2.Font.Style | FontStyle.Regular);
            label3.Font = new Font("Comic Sans MC", 20, label3.Font.Style | FontStyle.Regular);
            label4.Font = new Font("Comic Sans MC", 20, label4.Font.Style | FontStyle.Regular);
            label5.Font = new Font("Comic Sans MC", 20, label5.Font.Style | FontStyle.Regular);
            label6.Font = new Font("Comic Sans MC", 50, label6.Font.Style | FontStyle.Regular);
        }

        private void ApplicationInfo_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.YD;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            label1.Text = "";  
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            listinfo = new List<string>();
            listinfo.Add(Tool);
            listinfo.Add(Author);
            listinfo.Add(CreateTime);
            listinfo.Add(CodeInfo);
            listinfo.Add(Other);       
            InitInfo();     
        }

        private void InitInfo()
        {
            int flg = 0;
            foreach (string item in listinfo)
            {           
                ShowInfo(item,flg);
                Delay(500);
                flg++;
            }
            Delay(2000);
            this.Visible = false;
        }

        private void ShowInfo(string item,int flg)
        {
            for (int i = 0; i < item.Length; i++)
            {
                switch (flg)
                {
                    case 0:
                        label6.Text = item.Substring(0,i+1);
                        break;
                    case 1:
                        label1.Text = item.Substring(0, i+1);
                        break;
                    case 2:
                        label2.Text = item.Substring(0, i+1);
                        break;
                    case 3:
                        label3.Text = item.Substring(0, i + 1);
                        break;
                    case 4:
                        label4.Text = item.Substring(0, i + 1);
                        break;
                    default:
                        break;
                }
                Delay(200);
            }
            
        }
        public static void Delay(int mm)
        {
            DateTime current = DateTime.Now;
            while (current.AddMilliseconds(mm) > DateTime.Now)
            {
                Application.DoEvents();
            }
            return;
        }                    
    }
}
