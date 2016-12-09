namespace app_timed_shutdown
{
    partial class window_edit_timer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(window_edit_timer));
            this.datetime_date = new System.Windows.Forms.DateTimePicker();
            this.datetime_time = new System.Windows.Forms.DateTimePicker();
            this.checkbox_repeat = new System.Windows.Forms.CheckBox();
            this.button_set = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.input_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // datetime_date
            // 
            this.datetime_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetime_date.Location = new System.Drawing.Point(12, 39);
            this.datetime_date.Name = "datetime_date";
            this.datetime_date.Size = new System.Drawing.Size(200, 20);
            this.datetime_date.TabIndex = 0;
            // 
            // datetime_time
            // 
            this.datetime_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.datetime_time.Location = new System.Drawing.Point(12, 65);
            this.datetime_time.Name = "datetime_time";
            this.datetime_time.ShowUpDown = true;
            this.datetime_time.Size = new System.Drawing.Size(200, 20);
            this.datetime_time.TabIndex = 1;
            // 
            // checkbox_repeat
            // 
            this.checkbox_repeat.AutoSize = true;
            this.checkbox_repeat.Location = new System.Drawing.Point(12, 91);
            this.checkbox_repeat.Name = "checkbox_repeat";
            this.checkbox_repeat.Size = new System.Drawing.Size(67, 17);
            this.checkbox_repeat.TabIndex = 2;
            this.checkbox_repeat.Text = "Repeat?";
            this.checkbox_repeat.UseVisualStyleBackColor = true;
            // 
            // button_set
            // 
            this.button_set.Location = new System.Drawing.Point(12, 114);
            this.button_set.Name = "button_set";
            this.button_set.Size = new System.Drawing.Size(75, 23);
            this.button_set.TabIndex = 3;
            this.button_set.Text = "Set";
            this.button_set.UseVisualStyleBackColor = true;
            this.button_set.Click += new System.EventHandler(this.button_set_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(137, 114);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 4;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // input_name
            // 
            this.input_name.Location = new System.Drawing.Point(12, 13);
            this.input_name.Name = "input_name";
            this.input_name.Size = new System.Drawing.Size(200, 20);
            this.input_name.TabIndex = 5;
            this.input_name.Text = "Name";
            // 
            // window_edit_timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 149);
            this.ControlBox = false;
            this.Controls.Add(this.input_name);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_set);
            this.Controls.Add(this.checkbox_repeat);
            this.Controls.Add(this.datetime_time);
            this.Controls.Add(this.datetime_date);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "window_edit_timer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Shutdown Timer";
            this.Load += new System.EventHandler(this.window_edit_timer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datetime_date;
        private System.Windows.Forms.DateTimePicker datetime_time;
        private System.Windows.Forms.CheckBox checkbox_repeat;
        private System.Windows.Forms.Button button_set;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.TextBox input_name;
    }
}