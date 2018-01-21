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
    public partial class FHashTable : Form
    {

        Hashtable t = new Hashtable();
        public FHashTable()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(t.ContainsKey(txtID.Text)==true)
            {
                MessageBox.Show("the key already exist");
            }else
            { 
            t.Add(txtID.Text,txtName.Text);
             label2.Text ="Count "+t.Count.ToString();
            }

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            lblLista.Text = "";
            foreach (DictionaryEntry lista in t)
            {
                
               lblLista.Text += lista.Key+" "+lista.Value +"\n";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            t.Remove(textBox2.Text);
            MessageBox.Show(textBox2.Text);

          
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (t.ContainsKey(txtCheck.Text)||t.ContainsValue(txtCheck.Text))
            {

                lblExist.Text = "Yes" + lblLista.Text.Split('4').Count() ;
            }else
            {
                lblExist.Text = "NO";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblExist.Text = ""+lblLista.Text.Split().Count();
        }
    }
}
