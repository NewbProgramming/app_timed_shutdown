namespace app_timed_shutdown
{
    partial class timed_shutdown
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(timed_shutdown));
            this.notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.notify_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.notify_menu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.notify_menu_timers = new System.Windows.Forms.ToolStripMenuItem();
            this.check_timers = new System.Windows.Forms.Timer(this.components);
            this.notify_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // notify
            // 
            this.notify.ContextMenuStrip = this.notify_menu;
            this.notify.Icon = ((System.Drawing.Icon)(resources.GetObject("notify.Icon")));
            this.notify.Text = "Timed Shutdown";
            this.notify.Visible = true;
            // 
            // notify_menu
            // 
            this.notify_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notify_menu_timers,
            this.notify_menu_exit});
            this.notify_menu.Name = "notify_menu";
            this.notify_menu.Size = new System.Drawing.Size(111, 48);
            // 
            // notify_menu_exit
            // 
            this.notify_menu_exit.Name = "notify_menu_exit";
            this.notify_menu_exit.Size = new System.Drawing.Size(110, 22);
            this.notify_menu_exit.Text = "Exit";
            this.notify_menu_exit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // notify_menu_timers
            // 
            this.notify_menu_timers.Name = "notify_menu_timers";
            this.notify_menu_timers.Size = new System.Drawing.Size(110, 22);
            this.notify_menu_timers.Text = "Timers";
            // 
            // check_timers
            // 
            this.check_timers.Enabled = true;
            this.check_timers.Interval = 1000;
            this.check_timers.Tick += new System.EventHandler(this.check_timers_Tick);
            // 
            // timed_shutdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 250);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "timed_shutdown";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timed Shutdown";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.timed_shutdown_FormClosing);
            this.Load += new System.EventHandler(this.timed_shutdown_Load);
            this.notify_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notify;
        private System.Windows.Forms.ContextMenuStrip notify_menu;
        private System.Windows.Forms.ToolStripMenuItem notify_menu_exit;
        private System.Windows.Forms.ToolStripMenuItem notify_menu_timers;
        private System.Windows.Forms.Timer check_timers;
    }
}

