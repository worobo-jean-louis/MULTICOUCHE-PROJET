using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Reservation
{
    public partial class Chambres : Form
    {
        bool exitApp = true;

        public Chambres()
        {
            InitializeComponent();

        }

   
        private void btn_save_Click(object sender, EventArgs e)
        {
            if(txtnumCh.Text ==""  && txtstatut.Text == "")
            {
                MessageBox.Show("Champs vide !", "Remplissez les Champs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Données prises en compte","Enregistrement",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_annuller_Click(object sender, EventArgs e)
        {
            txtstatut.Text = "";
            txtnumCh.Text = "";
        }

      
    }
}
