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
    public partial class CaseConversion : Form
    {
        public CaseConversion()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 大小写
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox2.Text = Character.strToLower(richTextBox1.Text.Trim());
            richTextBox3.Text = Character.strToUpper(richTextBox1.Text.Trim());
        }
         /// <summary>
         /// MD5
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox4.Text.Trim()))
            {                                    
                richTextBox5.Text = Character.MD5Encryption(richTextBox4.Text.Trim());
            }
            else
            {
                richTextBox5.Text = richTextBox4.Text.Trim();
            }
        }
        /// <summary>
        ///  汉字转拼音
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox6.Text.Trim()))
            {                                    
                richTextBox7.Text = Character.ChineseToPinyin(richTextBox6.Text.Trim());
            }
            else
            {
                richTextBox7.Text = richTextBox6.Text.Trim();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            if (!string.IsNullOrEmpty(richTextBox4.Text.Trim()))
            {
                richTextBox4.ReadOnly = false;
                richTextBox5.Text = Character.MD5Encryption(richTextBox4.Text.Trim());
            }
            richTextBox4.ReadOnly = true;
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            if (!string.IsNullOrEmpty(richTextBox6.Text.Trim()))
            {
                richTextBox6.ReadOnly = false;
                richTextBox7.Text = Character.ChineseToPinyin(richTextBox6.Text.Trim());
            }
            richTextBox6.ReadOnly = true;
            */
        }
    }
}
