namespace ReservationSystem
{
    partial class Bus
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txt_busno = new MetroFramework.Controls.MetroTextBox();
            this.txt_origin = new MetroFramework.Controls.MetroTextBox();
            this.txt_dest = new MetroFramework.Controls.MetroTextBox();
            this.txt_fare = new MetroFramework.Controls.MetroTextBox();
            this.btn_add = new MetroFramework.Controls.MetroButton();
            this.btn_update = new MetroFramework.Controls.MetroButton();
            this.btn_delete = new MetroFramework.Controls.MetroButton();
            this.btn_display = new MetroFramework.Controls.MetroButton();
            this.btn_exit = new MetroFramework.Controls.MetroButton();
            this.time_dep = new MetroFramework.Controls.MetroDateTime();
            this.time_arr = new MetroFramework.Controls.MetroDateTime();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(17, 56);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(58, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Bus No :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(17, 94);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(53, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Origin :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(17, 134);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(80, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Destination :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(17, 167);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(109, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Departure Time :";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(17, 207);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(87, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Arrival Time :";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(17, 243);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(41, 19);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Fare :";
            // 
            // txt_busno
            // 
            // 
            // 
            // 
            this.txt_busno.CustomButton.Image = null;
            this.txt_busno.CustomButton.Location = new System.Drawing.Point(84, 2);
            this.txt_busno.CustomButton.Name = "";
            this.txt_busno.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txt_busno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_busno.CustomButton.TabIndex = 1;
            this.txt_busno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_busno.CustomButton.UseSelectable = true;
            this.txt_busno.CustomButton.Visible = false;
            this.txt_busno.Lines = new string[0];
            this.txt_busno.Location = new System.Drawing.Point(170, 63);
            this.txt_busno.MaxLength = 32767;
            this.txt_busno.Name = "txt_busno";
            this.txt_busno.PasswordChar = '\0';
            this.txt_busno.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_busno.SelectedText = "";
            this.txt_busno.SelectionLength = 0;
            this.txt_busno.SelectionStart = 0;
            this.txt_busno.ShortcutsEnabled = true;
            this.txt_busno.Size = new System.Drawing.Size(104, 22);
            this.txt_busno.TabIndex = 6;
            this.txt_busno.UseSelectable = true;
            this.txt_busno.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_busno.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_origin
            // 
            // 
            // 
            // 
            this.txt_origin.CustomButton.Image = null;
            this.txt_origin.CustomButton.Location = new System.Drawing.Point(84, 2);
            this.txt_origin.CustomButton.Name = "";
            this.txt_origin.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txt_origin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_origin.CustomButton.TabIndex = 1;
            this.txt_origin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_origin.CustomButton.UseSelectable = true;
            this.txt_origin.CustomButton.Visible = false;
            this.txt_origin.Lines = new string[0];
            this.txt_origin.Location = new System.Drawing.Point(170, 94);
            this.txt_origin.MaxLength = 32767;
            this.txt_origin.Name = "txt_origin";
            this.txt_origin.PasswordChar = '\0';
            this.txt_origin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_origin.SelectedText = "";
            this.txt_origin.SelectionLength = 0;
            this.txt_origin.SelectionStart = 0;
            this.txt_origin.ShortcutsEnabled = true;
            this.txt_origin.Size = new System.Drawing.Size(104, 22);
            this.txt_origin.TabIndex = 9;
            this.txt_origin.UseSelectable = true;
            this.txt_origin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_origin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_dest
            // 
            // 
            // 
            // 
            this.txt_dest.CustomButton.Image = null;
            this.txt_dest.CustomButton.Location = new System.Drawing.Point(84, 2);
            this.txt_dest.CustomButton.Name = "";
            this.txt_dest.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txt_dest.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_dest.CustomButton.TabIndex = 1;
            this.txt_dest.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_dest.CustomButton.UseSelectable = true;
            this.txt_dest.CustomButton.Visible = false;
            this.txt_dest.Lines = new string[0];
            this.txt_dest.Location = new System.Drawing.Point(170, 131);
            this.txt_dest.MaxLength = 32767;
            this.txt_dest.Name = "txt_dest";
            this.txt_dest.PasswordChar = '\0';
            this.txt_dest.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_dest.SelectedText = "";
            this.txt_dest.SelectionLength = 0;
            this.txt_dest.SelectionStart = 0;
            this.txt_dest.ShortcutsEnabled = true;
            this.txt_dest.Size = new System.Drawing.Size(104, 22);
            this.txt_dest.TabIndex = 10;
            this.txt_dest.UseSelectable = true;
            this.txt_dest.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_dest.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_fare
            // 
            // 
            // 
            // 
            this.txt_fare.CustomButton.Image = null;
            this.txt_fare.CustomButton.Location = new System.Drawing.Point(84, 2);
            this.txt_fare.CustomButton.Name = "";
            this.txt_fare.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txt_fare.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_fare.CustomButton.TabIndex = 1;
            this.txt_fare.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_fare.CustomButton.UseSelectable = true;
            this.txt_fare.CustomButton.Visible = false;
            this.txt_fare.Lines = new string[0];
            this.txt_fare.Location = new System.Drawing.Point(170, 243);
            this.txt_fare.MaxLength = 1000;
            this.txt_fare.Name = "txt_fare";
            this.txt_fare.PasswordChar = '\0';
            this.txt_fare.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_fare.SelectedText = "";
            this.txt_fare.SelectionLength = 0;
            this.txt_fare.SelectionStart = 0;
            this.txt_fare.ShortcutsEnabled = true;
            this.txt_fare.Size = new System.Drawing.Size(104, 22);
            this.txt_fare.TabIndex = 11;
            this.txt_fare.UseSelectable = true;
            this.txt_fare.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_fare.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(22, 299);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(48, 16);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "Add";
            this.btn_add.UseSelectable = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(101, 299);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(48, 16);
            this.btn_update.TabIndex = 13;
            this.btn_update.Text = "Update";
            this.btn_update.UseSelectable = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(185, 299);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(48, 16);
            this.btn_delete.TabIndex = 14;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseSelectable = true;
            // 
            // btn_display
            // 
            this.btn_display.Location = new System.Drawing.Point(258, 299);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(48, 16);
            this.btn_display.TabIndex = 15;
            this.btn_display.Text = "Display";
            this.btn_display.UseSelectable = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(337, 299);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(48, 16);
            this.btn_exit.TabIndex = 16;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseSelectable = true;
            // 
            // time_dep
            // 
            this.time_dep.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.time_dep.Location = new System.Drawing.Point(170, 167);
            this.time_dep.MinimumSize = new System.Drawing.Size(0, 29);
            this.time_dep.Name = "time_dep";
            this.time_dep.Size = new System.Drawing.Size(200, 29);
            this.time_dep.TabIndex = 17;
            this.time_dep.ValueChanged += new System.EventHandler(this.metroDateTime1_ValueChanged);
            // 
            // time_arr
            // 
            this.time_arr.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.time_arr.Location = new System.Drawing.Point(170, 202);
            this.time_arr.MinimumSize = new System.Drawing.Size(0, 29);
            this.time_arr.Name = "time_arr";
            this.time_arr.Size = new System.Drawing.Size(200, 29);
            this.time_arr.TabIndex = 18;
            this.time_arr.ValueChanged += new System.EventHandler(this.time_arr_ValueChanged);
            // 
            // Bus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 407);
            this.Controls.Add(this.time_arr);
            this.Controls.Add(this.time_dep);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_display);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_fare);
            this.Controls.Add(this.txt_dest);
            this.Controls.Add(this.txt_origin);
            this.Controls.Add(this.txt_busno);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Bus";
            this.Text = "Bus";
            this.Load += new System.EventHandler(this.Bus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txt_busno;
        private MetroFramework.Controls.MetroTextBox txt_origin;
        private MetroFramework.Controls.MetroTextBox txt_dest;
        private MetroFramework.Controls.MetroTextBox txt_fare;
        private MetroFramework.Controls.MetroButton btn_add;
        private MetroFramework.Controls.MetroButton btn_update;
        private MetroFramework.Controls.MetroButton btn_delete;
        private MetroFramework.Controls.MetroButton btn_display;
        private MetroFramework.Controls.MetroButton btn_exit;
        private MetroFramework.Controls.MetroDateTime time_dep;
        private MetroFramework.Controls.MetroDateTime time_arr;
    }
}