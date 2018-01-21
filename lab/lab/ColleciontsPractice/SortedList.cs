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
    public partial class SortedList : Form
    {
        private SortedList<int,string> sl = new SortedList<int, string>();
        public SortedList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            sl.Add(Int32.Parse(txtID.Text), txtName.Text);
            label2.Text = " Count " + sl.Count;
            txtID.Clear();
            txtName.Clear();

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            lblLista.Text = null;
            int i = 0;
            foreach (int l in sl.Keys)
            {
              lblLista.Text += l +"-"+sl.Values[i] +"\n";
                i++;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
         sl.RemoveAt(Int32.Parse(txtremove.Text));
            MessageBox.Show(" Index removed" + txtremove.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sl.Remove(Int32.Parse(txtremove.Text));
          MessageBox.Show( " Key removed " + txtremove.Text);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (sl.ContainsKey(Int32.Parse(txtCheck.Text)))
            {
                lblExist.Text = "Yes";
            }
            else
            {

                lblExist.Text = "No";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (sl.ContainsValue(txtCheck.Text))
            {
                lblExist.Text = "Yes";
            }
            else
            {

                lblExist.Text = "No";
            }
        }
    }
}
