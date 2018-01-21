using System;
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
    public partial class FArgoritmos : Form
    {
        public FArgoritmos()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            char id =char.Parse(textBox1.Text);
            int repite = 0;
            string caracteres = txtValue1.Text;
            if (caracteres.Contains(id))
            {
                label1.Text = "";
               
                foreach(char i in caracteres)
                {
                    if(i.Equals(id))
                    {
                        repite = repite + 1;
                    }
                   
                  
                }
                label1.Text = repite.ToString();

            }
            else
            {
                label1.Text = "No";

            }
        }
    }
}
