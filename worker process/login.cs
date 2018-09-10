using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace worker_process
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "guanliyuan" && textBox2.Text == "111111")
            {
                MessageBox.Show("用户登录权限为管理员", "提示");
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }
            else if (textBox1.Text == "caozuoyuan" && textBox2.Text == "222222")
            {
                MessageBox.Show("用户登录权限为操作员", "提示");
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }
        }

    }
}
