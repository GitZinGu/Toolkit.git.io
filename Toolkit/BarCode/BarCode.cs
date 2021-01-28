using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Toolkit
{
    public partial class BarCode : Form
    {
        private DoBarCode dob = null;
        private PictureSize p1s = new PictureSize();
        private PictureSize p2s = new PictureSize();
        private PictureSize pps = new PictureSize();
        private RadioButton rb;


        public BarCode()
        {
            InitializeComponent();
            //鼠标滚动
            this.MouseWheel += new MouseEventHandler(pictureBox1_MouseWheel);
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            Initial();            
        }

        private void Initial()
        {
            //初始化二维码图片地址
            textBox4.Text = @"..\\..\\Resources\\Picture.jpg";
            p1s.width = pictureBox1.Width;
            p1s.height = pictureBox1.Height;
            p2s.width = pictureBox2.Width;
            p2s.height = pictureBox2.Height;
            pps.width = pictureBox3.Width;
            pps.height = pictureBox3.Height;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //创建一个对话框对象
            OpenFileDialog ofd = new OpenFileDialog();
            //为对话框设置标题
            ofd.Title = "请选择上传的图片";
            //设置筛选的图片格式
            ofd.Filter = "图片格式|*.jpg|*.png|*.bpm";
            //设置是否允许多选
            ofd.Multiselect = false;
            //如果你点了“确定”按钮
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //获得文件的完整路径（包括名字后后缀）
                textBox4.Text = ofd.FileName;     
            }
        }
        /// <summary>
        /// 点击生成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {               
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("不能打印空内容，请输入！");
                return;
            }
            dob = new DoBarCode(textBox1.Text, p1s, p2s, pps);
           
            pictureBox1.Image = dob.Get1DBarCode();
            pictureBox2.Image = dob.Get2DBarCode();
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                textBox4.Text= @"..\\..\\Resources\\Picture.jpg";
            }
            pictureBox3.Image = dob.GetP2DBarCode(textBox4.Text);
            if (sender.ToString()!= "History")
            {
                bool IsExist = true;
                foreach (var item in listBox1.Items)
                {
                    if (item.ToString()== textBox1.Text)
                    {
                        IsExist = false;
                    }
                }
                if (IsExist)    
                listBox1.Items.Add(textBox1.Text);
            }
            
        }

        /// <summary>
        /// 选择历史记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = listBox1.SelectedItem.ToString();
                button1_Click("History", null);
            }
            catch (Exception)
            {
                return;
            }
            
        }
        private void radioButtonExc(RCodeType rct)
        {
            dob = new DoBarCode((int)numericUpDown1.Value, textBox2.Text, textBox3.Text, rct, p1s, p2s, pps);
            textBox1.Text = dob.GetBarCode();
            pictureBox1.Image = dob.Get1DBarCode();
            pictureBox2.Image = dob.Get2DBarCode();
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                textBox4.Text = @"..\\..\\Resources\\Picture.jpg";
            }
            pictureBox3.Image = dob.GetP2DBarCode(textBox4.Text);   
            bool IsExist = true;
            foreach (var item in listBox1.Items)
            {
                if (item.ToString() == textBox1.Text)
                {
                    IsExist = false;
                }
            }
            if (IsExist)
                listBox1.Items.Add(textBox1.Text);    
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                rb = radioButton1;
                radioButtonExc(RCodeType.Number);
            }       
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                rb = radioButton2;
                radioButtonExc(RCodeType.Letter);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                rb = radioButton3;
                radioButtonExc(RCodeType.Hybrid);
            }
        }
        private void pictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            //throw new NotImplementedException();
            var t = pictureBox1.Size;
            t.Width += e.Delta;
            t.Height += e.Delta;
            pictureBox1.Size = t;
            //图片按中心比例放大缩小
           // pictureBox1.Location = new Point((this.Width - pictureBox1.Width) / 2, (this.Height - pictureBox1.Height) / 2);
        }

        //鼠标移动
        int xPos;
        int yPos;
        bool MoveFlag;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            MoveFlag = true;//已经按下.
            xPos = e.X;//当前x坐标.
            yPos = e.Y;//当前y坐标.
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            MoveFlag = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (MoveFlag)
            {
                pictureBox1.Left += Convert.ToInt16(e.X - xPos);//设置x坐标.
                pictureBox1.Top += Convert.ToInt16(e.Y - yPos);//设置y坐标.
            }
        }
    }
}
