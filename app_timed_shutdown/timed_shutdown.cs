using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_timed_shutdown
{
    public partial class timed_shutdown : Form
    {
        bool close = false;

        public timed_shutdown()
        {
            InitializeComponent();
        }

        private void UpdateMenu()
        {
            // Load them.
            ShutdownTimer.LoadAll();

            // Clear Timers.
            notify_menu_timers.DropDownItems.Clear();

            // Show Timers.
            ToolStripItem menu_item = null;

            foreach(ShutdownTimer timer in ShutdownTimer.Timers)
            {
                menu_item = notify_menu_timers.DropDownItems.Add(timer.Name);
                menu_item.Click += timer_Click;
            }

            // Add Timer.
            menu_item = notify_menu_timers.DropDownItems.Add("Add Timer");
            menu_item.Click += add_timer_Click;
            return;
        }

        private void timed_shutdown_Load(object sender, EventArgs e)
        {
            this.Hide();

            UpdateMenu();
        }

        private void timed_shutdown_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.close == false)
            {
                e.Cancel = true;

                this.Hide();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShutdownTimer.SaveAll();

            this.close = true;
            Application.Exit();
        }

        private void add_timer_Click(object sender, EventArgs e)
        {
            window_edit_timer edit_timer = new window_edit_timer();

            edit_timer.ShowDialog();

            if(edit_timer.cancelled == true)
            {
                MessageBox.Show("You cancelled.");
                return;
            }

            ShutdownTimer timer = new ShutdownTimer();

            timer.Name = edit_timer.name;
            timer.Repeat = edit_timer.repeat;
            timer.Time = edit_timer.time;

            if(ShutdownTimer.Add(timer) == false)
            {
                return;
            }

            ShutdownTimer.SaveAll();
            UpdateMenu();

            MessageBox.Show(string.Format(
                "Timer added. {0}\n" +
                "Name: {1}\n" +
                "Time: {2}\n" +
                "Repeated: {3}\n",
                ShutdownTimer.Timers.Count.ToString(),
                timer.Name,
                timer.Time.ToString(),
                timer.Repeat.ToString()
            ));
        }

        private void timer_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;

            ShutdownTimer old_timer = null;

            foreach(ShutdownTimer t in ShutdownTimer.Timers)
            {
                if(t.Name == item.Text)
                {
                    old_timer = t;
                    break;
                }
            }

            if(old_timer == null)
            {
                MessageBox.Show("Something went wrong!!!");

                ShutdownTimer.SaveAll();
                UpdateMenu();
                return;
            }

            window_edit_timer edit_timer = new window_edit_timer();

            edit_timer.name = old_timer.Name;
            edit_timer.repeat = old_timer.Repeat;
            edit_timer.time = old_timer.Time;
            edit_timer.ShowDialog();

            if(edit_timer.cancelled == true)
            {
                MessageBox.Show("You cancelled.");
                return;
            }

            ShutdownTimer timer = new ShutdownTimer();

            timer.Name = edit_timer.name;
            timer.Repeat = edit_timer.repeat;
            timer.Time = edit_timer.time;

            if(ShutdownTimer.Remove(old_timer) == false)
            {
                return;
            }

            if(ShutdownTimer.Add(timer) == false)
            {
                return;
            }

            ShutdownTimer.SaveAll();
            UpdateMenu();

            MessageBox.Show("Timer edited.");
        }

        private void check_timers_Tick(object sender, EventArgs e)
        {
            foreach(ShutdownTimer timer in ShutdownTimer.Timers)
            {
                if((timer.Time - DateTime.Now).Seconds <= 0)
                {
                    if(timer.Repeat == false)
                    {
                        ShutdownTimer.Remove(timer);
                    }
                    else
                    {
                        timer.Time = timer.Time.AddDays(1);
                    }

                    ShutdownTimer.SaveAll();
                    UpdateMenu();

                    window_shutdown shutdown = new window_shutdown();

                    shutdown.ShowDialog();
                    break;
                }
            }
        }
    }
}
