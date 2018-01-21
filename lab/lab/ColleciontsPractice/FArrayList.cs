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

    /*
        Author: Anthony Mendez
        Email: antony0010@hotmail.com
        I created that class just for practice
    */


 
    public partial class FArrayList : Form
    {

      private  ArrayList lista = new ArrayList();
      

        private ArrayList addLista(string name, string lastname)
        {
            
            
            lista.Add(name +" "+lastname);
            txtName.Clear();
            txtLastName.Clear();
            label2.Text = "Capacidad:" + lista.Capacity +" count registed  :"+ lista.Count;
           
            return lista;

        }

        private void readLista()
        {
            
           label1.Text = "Listado del ArrayList \n";
            foreach (string l in lista)
            {

                label1.Text += l + " \n";
            }
           

        }
        public FArrayList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
          
            

            addLista(txtName.Text,txtLastName.Text);
           

        }

        private void FArrayList_Load(object sender, EventArgs e)
        {

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            readLista();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lista.RemoveAt(int.Parse(textBox2.Text));
            MessageBox.Show(textBox2.Text);
            textBox2.Clear();
           
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lista.Remove(textBox3.Text);
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lista.Contains(txtCheck.Text) == true)
            {
                lblExist.Text = "Yes";
                txtName.Text = lista[lista.IndexOf(txtCheck.Text)].ToString().Split(' ').ElementAt(0);
                txtLastName.Text = lista[lista.IndexOf(txtCheck.Text)].ToString().Split(' ').ElementAt(1);
            }
            else {
                lblExist.Text = "No";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }
    }
}
