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
    public partial class SpecialCharacter : Form
    {
        public SpecialCharacter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            Button btn = sender as Button;
            richTextBox1.Text = Symbol.GetSymbol(btn.Text).Replace("\n", "").Replace(" ", "").Replace("\t", "").Replace("\r", "");

        }
    }
}
