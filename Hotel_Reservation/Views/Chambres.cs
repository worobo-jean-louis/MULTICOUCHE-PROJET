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
        /*ateTime date = DateTime.Now;*/

        public Chambres()
        {
            InitializeComponent();

        }

       

        private void lbl_hC_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.UtcNow;

            lbl_hC.Text = date.ToString("h:mm:ss");
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
    }
}
