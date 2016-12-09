using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_timed_shutdown
{
    public partial class window_shutdown : Form
    {
        DateTime shutdown = DateTime.Now.AddMinutes(2);

        public window_shutdown()
        {
            InitializeComponent();
        }

        private void window_shutdown_Load(object sender, EventArgs e)
        {

        }

        private void countdown_Tick(object sender, EventArgs e)
        {
            if(this.shutdown <= DateTime.Now)
            {
                label_shutdown.Text = "Shutting down...";
                
                ProcessStartInfo psi = new ProcessStartInfo("shutdown", "/s /t 0");

                psi.CreateNoWindow = true;
                psi.UseShellExecute = false;

                Process.Start(psi);
                return;
            }

            label_shutdown.Text = string.Format(
                "Your Windows computer will shutdown in ~{0} seconds.",
                ((int) (this.shutdown - DateTime.Now).TotalSeconds).ToString()
            );

            this.shutdown = this.shutdown.AddSeconds(-1);
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void window_shutdown_FormClosing(object sender, FormClosingEventArgs e)
        {
            countdown.Enabled = false;
        }
    }
}
