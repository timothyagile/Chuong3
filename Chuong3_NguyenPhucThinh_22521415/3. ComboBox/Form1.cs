using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string str = "";
            str = comboBox1.Items[comboBox1.SelectedIndex].ToString();
            MessageBox.Show(str);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            list.Add(textBox1.Text);
            if(comboBox1.Items.IndexOf(textBox1.Text) >= 0) 
            {
                comboBox1.DataSource = list;
            }
        }
    }
}
