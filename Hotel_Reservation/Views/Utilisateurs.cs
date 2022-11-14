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
    public partial class Utilisateurs : Form
    {
        public Utilisateurs()
        {
            InitializeComponent();
        }

        private void lbl_U_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            lbl_U.Text = date.ToString("h:mm:ss");
        }
    }
}
