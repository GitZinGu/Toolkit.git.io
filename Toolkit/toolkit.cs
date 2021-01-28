using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;                        
using System.Text;
using System.Windows.Forms;

namespace Toolkit
{
 
    public partial class toolkit : Form
    {
         //--Info
        private ApplicationInfo appinfo = null; //相关信息

        //--Tool
        private BarCode barcode = null; //条码
        private FormJSON json = null;         //JSON
        private CaseConversion casecon = null;      //大小写转换
        private SpecialCharacter spcharacter = null; //特殊符号

        //--Database
        private exetowinform odm = null;

        //--- Game
        private Tetris snk = null; // 俄罗斯方块
        private Klotski HuaRongDao = null; // 华容道
        private SnakeGame sg = null;   //贪吃蛇    
        private TwoZeroFourEight tzfe = null; //2048



        public toolkit()
        {
            InitializeComponent();      
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
        }      
        private void jSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseODM();
            panel1.Controls.Clear();
            json = new FormJSON();
            json.Dock = DockStyle.Fill;
            json.TopLevel = false;
            panel1.Controls.Add(json);
            json.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CloseODM();
            panel1.Controls.Clear();
            barcode = new BarCode();     
            barcode.Dock = DockStyle.Fill;
            barcode.TopLevel = false;
            panel1.Controls.Add(barcode);
            barcode.Show();    

        }

        private void CaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseODM();
            panel1.Controls.Clear();
             casecon  = new CaseConversion();   
            casecon.Dock = DockStyle.Fill;
            casecon.TopLevel = false;
            panel1.Controls.Add(casecon);
            casecon.Show();
        }

        private void SymbolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseODM();
            panel1.Controls.Clear();
            spcharacter = new SpecialCharacter();
            spcharacter.Dock = DockStyle.Fill;
            spcharacter.TopLevel = false;
            panel1.Controls.Add(spcharacter);
            spcharacter.Show();
        }

        private void 贪吃蛇ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseODM();
            panel1.Controls.Clear();
            sg = new SnakeGame();
            sg.TopLevel = false;
            panel1.Controls.Add(sg);
            sg.Show();
        }

        private void 俄罗斯方块ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CloseODM();
            snk = new Tetris();
            snk.TopLevel = false;
            panel1.Controls.Add(snk);
            snk.Show();
        }

        private void HRDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseODM();
            panel1.Controls.Clear();                        
            HuaRongDao = new Klotski();
            HuaRongDao.TopLevel = false;
            panel1.Controls.Add(HuaRongDao);
            HuaRongDao.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            CloseODM();
            panel1.Controls.Clear();                        
            tzfe = new TwoZeroFourEight();
            tzfe.TopLevel = false;
            panel1.Controls.Add(tzfe);
            tzfe.Show();
        }

        private void toolkit_Load(object sender, EventArgs e)
        {
           //1. 初始化位置
            this.Width = 1200;    //窗体宽
            this.Height = 800;    //窗体高
            this.StartPosition = FormStartPosition.CenterParent;  //居中
            //2.设定TmenuStrip1图片 
            /*                            
            toolStripMenuItem1.BackgroundImage = Properties.Resources.Scan_Barcode;
            jSONToolStripMenuItem.BackgroundImage = Properties.Resources.json_file;
            CaseToolStripMenuItem.BackgroundImage = Properties.Resources.software;
            SymbolToolStripMenuItem.BackgroundImage = Properties.Resources.Symbol;
            gameToolStripMenuItem.BackgroundImage = Properties.Resources.Cgame;
            ODMToolStripMenuItem.BackgroundImage = Properties.Resources.database_file;
            InfoToolStripMenuItem1.BackgroundImage = Properties.Resources.info_24;
            ExitToolStripMenuItem2.BackgroundImage = Properties.Resources.exit_24;
            */
            

        }
        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(new Bitmap(Properties.Resources.FJ), 0, 0);
        }

        private void InfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CloseODM();
            panel1.Controls.Clear();
            appinfo = new ApplicationInfo();
            appinfo.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            appinfo.TopLevel = false;
            panel1.Controls.Add(appinfo);
            appinfo.Show();
            appinfo.Close();
            appinfo.Dispose();             
        }

        private void toolkit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CloseODM()
        {
            try
            {
                if (odm.IsStarted == true)
                {
                    odm.Stop();
                }
            }
            catch (Exception)
            {
                return;
            }
            
        }
        private void ODMToolStripMenuItem_Click(object sender, EventArgs e)
        {        
            string Directoryurl =  Properties.Settings.Default.DataBaseUrl;
            string DirectoryFile = Directoryurl+ @"/SQL工具.exe";
            FileInfo file = new FileInfo(DirectoryFile);  
            string fullName = file.FullName;
            if (File.Exists(fullName))
            {
                panel1.Controls.Clear();
                odm = new exetowinform(panel1, "");
                odm.Start(fullName);
            }

        }

        private void 退出ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
