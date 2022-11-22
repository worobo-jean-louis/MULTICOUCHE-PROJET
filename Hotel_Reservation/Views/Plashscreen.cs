using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel_Reservation.Views
{
    public partial class Plashscreen : Form
    {
        public Plashscreen()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            for (int i = 0; i <= guna2ProgressBar1.Maximum; i += guna2ProgressBar1.TabIndex)
            {
                lblstatus.Text = Guid.NewGuid().ToString();
                lblstatus.Refresh();
                guna2ProgressBar1.Value = i;
                guna2ProgressBar1.Refresh();
                Thread.Sleep(1000);
          
            }
            Authentification authentification = new Authentification();
            authentification.Show();
            this.Close();
        }

       
        
    }
}
