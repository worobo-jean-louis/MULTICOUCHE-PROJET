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
    public partial class MDI_parentcs : Form
    {
        public MDI_parentcs()
        {
            InitializeComponent();
        }

        private void Menu_Deroule_Click(object sender, EventArgs e)
        {
            if (panel_Menu.Width == 0)
            {
                panel_Menu.Width = 126;
                btn_logout.Location = new Point(30, 609);
            }
            else
            {
                panel_Menu.Width = 0;
                btn_logout.Location = new Point(30, 304);
            }

            if (panel_Menu.Height == 0)
            {
                panel_Menu.Height = 449;
                btn_logout.Location = new Point(30, 609);
            }
            else
            {
                panel_Menu.Height = 0;
                btn_logout.Location = new Point(30, 304);
            }
        }

        private void MDI_parentcs_Load(object sender, EventArgs e)
        {
            lbl_hC.Text = DateTime.UtcNow.ToString(/*"h:mm:ss"*/);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
