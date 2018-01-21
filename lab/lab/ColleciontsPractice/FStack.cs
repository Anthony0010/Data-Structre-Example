using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab.ColleciontsPractice
{
    public partial class FStack : Form
    {
        private Stack stack = new Stack();
        public FStack()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            stack.Push(txtID.Text + "-" + txtName.Text);
            label2.Text = "Count "+stack.Count;
            txtID.Clear();
            txtName.Clear();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            lblLista.Text = "";
            foreach (String i in stack)
            {
                lblLista.Text += i+ "\n";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (stack.Contains(txtCheck.Text))
            {
                lblExist.Text = "Yes";
            }
            else
            {
                lblExist.Text = "No";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           MessageBox.Show(stack.Pop().ToString());
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(stack.Peek().ToString());
           
        }
    }
}
