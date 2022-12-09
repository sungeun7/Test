using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Test
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            isChecked(checkBox1.Checked);
        }
        public void isChecked(bool Checked)
        {
            if (Checked)
            {
                Enabled = true;
                textBox1.Text = "체크 되어있음";
            }
            else
            {
                Enabled = false;
                textBox1.Text = "체크 되어있지 않음";
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            isChecked(checkBox1.Checked);
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
