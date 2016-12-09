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
    public partial class window_edit_timer : Form
    {
        public bool cancelled = false;

        public string name = string.Empty;
        public bool repeat = false;
        public DateTime time = DateTime.Now;

        public window_edit_timer()
        {
            InitializeComponent();
        }

        private void window_edit_timer_Load(object sender, EventArgs e)
        {
            input_name.Text = this.name;
            checkbox_repeat.Checked = this.repeat;

            time = this.time.AddSeconds(30);
            datetime_date.MinDate = DateTime.Now;
            datetime_time.MinDate = DateTime.Now;
            datetime_date.Value = this.time;
            datetime_time.Value = this.time;
        }

        private void button_set_Click(object sender, EventArgs e)
        {
            this.name = input_name.Text;
            this.repeat = checkbox_repeat.Checked;
            this.time = new DateTime(
                datetime_date.Value.Year, datetime_date.Value.Month, datetime_date.Value.Day,
                datetime_time.Value.Hour, datetime_time.Value.Minute, datetime_time.Value.Second
            );

            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.cancelled = true;
            this.Close();
        }
    }
}
