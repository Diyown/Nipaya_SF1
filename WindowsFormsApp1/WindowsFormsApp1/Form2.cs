using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class addButton : Form
    {
        private Form1 form1;
        public addButton(Form1 form1)
        {
            InitializeComponent();

            Form1 frm = new Form1();
            this.form1 = form1;
        }

        private void addButton_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
} 

