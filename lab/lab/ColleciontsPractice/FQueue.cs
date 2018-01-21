using System;
using System.Collections;
using System.IO;
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
    public partial class FQueue : Form
    {

        private Queue q = new Queue();
        public FQueue()
        {
            InitializeComponent();
        }

        private void FQueue_Load(object sender, EventArgs e)
        {

        }
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
           
            q.Enqueue(txtID.Text+"-"+txtName.Text);
            label2.Text = "Count" + q.Count;
            txtID.Clear();
            txtName.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            q.Dequeue();
            label2.Text = "Count" + q.Count;
            MessageBox.Show("Deleted");
            
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            lblLista.Text = "";
           
            foreach(string i in q)
            {
                lblLista.Text += i +" \n";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try { 
            MessageBox.Show(""+q.Peek());
            } catch(InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (q.Contains(txtCheck.Text) == true)
            {
                lblExist.Text = "Yes";
            }else
            {

                lblExist.Text = "NO";

            }
        }
    }
}
