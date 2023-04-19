using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        internal object textBox1;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = comboBox1.GetItemText("Selected Item: " + comboBox1.SelectedItem);
            comboBox1.Items.Insert(0, textBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
            label1.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Sorted = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           //addButton newform = new addButton();
           // newform.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Remove(comboBox1.SelectedIndex);
            comboBox1.Text = string.Empty;
        }
    }
}
