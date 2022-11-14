using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Reservation.Views
{
    public partial class Facture : Form
    {
        public Facture()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_F_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            lbl_F.Text = date.ToString("h:mm:ss");
        }
    }
}
