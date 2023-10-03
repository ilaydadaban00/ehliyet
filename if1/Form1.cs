using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace if1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
           
                
               
                
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            {
                int yas = Convert.ToInt32(txtYas.Text);
                if (yas >= 18)
                {
                    MessageBox.Show("ehliyet alır");
                }
                else
                {
                    MessageBox.Show("ehliyet almaz");
                }
            }
        }
    }
}
