using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ArrayListSimpleEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private ArrayList message;
        private void Form1_Load(object sender, EventArgs e)
        {
            message.Add("I");
            message.Add("Love");
            message.Add("Programming");
            message.Add("So");
            message.Add("Much");
        }
        private void btnShowMsg_Click(object sender, EventArgs e)
        {
            
        }
    }
}
