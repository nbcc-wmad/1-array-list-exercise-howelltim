using System;
using System.Collections;
using System.Windows.Forms;

namespace ArrayListSimpleEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private ArrayList message = new ArrayList();
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
            for (int i = 0; i < message.Count; i++)
            {
                lblMessage.Text += message[i] + " ";
            }
        }
        private void btnReverse_Click(object sender, EventArgs e)
        {
            message.Reverse();
            lblMessage.ResetText();

            for (int i = 0; i < message.Count; i++)
            {
                lblMessage.Text += message[i] + " ";
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtSecondPos.Text != String.Empty)
            {
                message.Insert(1, txtSecondPos.Text);
                lblMessage.ResetText();

                for (int i = 0; i < message.Count; i++)
                {
                    lblMessage.Text += message[i] + " ";
                }
            }
            else
            {
                MessageBox.Show("Please enter a value.");
            }
        }
        private void btnRmoveSecondPos_Click(object sender, EventArgs e)
        {
            if (message.Count >= 2)
            {
                message.RemoveAt(1);
                lblMessage.ResetText();

                for (int i = 0; i < message.Count; i++)
                {
                    lblMessage.Text += message[i] + " ";
                }
            }
            else
            {
                MessageBox.Show("There is no item at position 2.");
            }
        }
    }
}
