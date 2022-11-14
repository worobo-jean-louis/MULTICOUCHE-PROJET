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
    public partial class Cathegorie : Form
    {
        public Cathegorie()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lbl_C_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            lbl_C.Text = date.ToString("h:mm:ss");
        }
    }
}
