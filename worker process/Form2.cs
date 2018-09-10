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
    public partial class Form2 : Form
    {
        ListViewItem oldItem = new ListViewItem(); 
        public Form2(ListViewItem listltem)
        {
            InitializeComponent();
            oldItem = listltem;
            this.textBox1.Text = oldItem.SubItems[0].Text;
            this.comboBox1.Text = oldItem.SubItems[1].Text;
            this.textBox2.Text = oldItem.SubItems[2].Text;
            this.textBox3.Text = oldItem.SubItems[3].Text;
            this.textBox4.Text = oldItem.SubItems[4].Text;
            this.textBox5.Text = oldItem.SubItems[5].Text;
            this.textBox6.Text = oldItem.SubItems[6].Text;
            this.textBox7.Text = oldItem.SubItems[7].Text;
            this.textBox8.Text = oldItem.SubItems[8].Text;
            this.textBox9.Text = oldItem.SubItems[9].Text;
            this.textBox10.Text = oldItem.SubItems[10].Text;
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            oldItem.SubItems[0].Text = this.textBox1.Text.Trim();
            oldItem.SubItems[1].Text = this.comboBox1.Text.Trim();
            oldItem.SubItems[2].Text = this.textBox2.Text.Trim();
            oldItem.SubItems[3].Text = this.textBox3.Text.Trim();
            oldItem.SubItems[4].Text = this.textBox4.Text.Trim();
            oldItem.SubItems[5].Text = this.textBox5.Text.Trim();
            oldItem.SubItems[6].Text = this.textBox6.Text.Trim();
            oldItem.SubItems[7].Text = this.textBox7.Text.Trim();
            oldItem.SubItems[8].Text = this.textBox8.Text.Trim();
            oldItem.SubItems[9].Text = this.textBox9.Text.Trim();
            oldItem.SubItems[10].Text = this.textBox10.Text.Trim();
            this.Close();
        }
    }
}
