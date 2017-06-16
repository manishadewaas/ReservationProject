namespace ReservationSystem
{
    partial class Driver
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_id = new MetroFramework.Controls.MetroLabel();
            this.txt_did = new MetroFramework.Controls.MetroTextBox();
            this.txt_dname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mtxt_dtp = new System.Windows.Forms.MaskedTextBox();
            this.btn_dadd = new MetroFramework.Controls.MetroButton();
            this.btn_ddisplay = new MetroFramework.Controls.MetroButton();
            this.btn_ddelete = new MetroFramework.Controls.MetroButton();
            this.btn_dclr = new MetroFramework.Controls.MetroButton();
            this.btn_dexit = new MetroFramework.Controls.MetroButton();
            this.btn_dupdate = new MetroFramework.Controls.MetroButton();
            this.dgv_driver = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_driver)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.AutoSize = true;
            this.txt_id.Location = new System.Drawing.Point(24, 88);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(0, 0);
            this.txt_id.TabIndex = 0;
            // 
            // txt_did
            // 
            // 
            // 
            // 
            this.txt_did.CustomButton.Image = null;
            this.txt_did.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txt_did.CustomButton.Name = "";
            this.txt_did.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_did.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_did.CustomButton.TabIndex = 1;
            this.txt_did.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_did.CustomButton.UseSelectable = true;
            this.txt_did.CustomButton.Visible = false;
            this.txt_did.Lines = new string[0];
            this.txt_did.Location = new System.Drawing.Point(175, 83);
            this.txt_did.MaxLength = 32767;
            this.txt_did.Name = "txt_did";
            this.txt_did.PasswordChar = '\0';
            this.txt_did.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_did.SelectedText = "";
            this.txt_did.SelectionLength = 0;
            this.txt_did.SelectionStart = 0;
            this.txt_did.ShortcutsEnabled = true;
            this.txt_did.Size = new System.Drawing.Size(75, 23);
            this.txt_did.TabIndex = 3;
            this.txt_did.UseSelectable = true;
            this.txt_did.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_did.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_dname
            // 
            // 
            // 
            // 
            this.txt_dname.CustomButton.Image = null;
            this.txt_dname.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txt_dname.CustomButton.Name = "";
            this.txt_dname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_dname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_dname.CustomButton.TabIndex = 1;
            this.txt_dname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_dname.CustomButton.UseSelectable = true;
            this.txt_dname.CustomButton.Visible = false;
            this.txt_dname.Lines = new string[0];
            this.txt_dname.Location = new System.Drawing.Point(175, 151);
            this.txt_dname.MaxLength = 32767;
            this.txt_dname.Name = "txt_dname";
            this.txt_dname.PasswordChar = '\0';
            this.txt_dname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_dname.SelectedText = "";
            this.txt_dname.SelectionLength = 0;
            this.txt_dname.SelectionStart = 0;
            this.txt_dname.ShortcutsEnabled = true;
            this.txt_dname.Size = new System.Drawing.Size(75, 23);
            this.txt_dname.TabIndex = 4;
            this.txt_dname.UseSelectable = true;
            this.txt_dname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_dname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 83);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(113, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Driver ID Number";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 151);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(84, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Driver Name";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 201);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(76, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Contact No";
            // 
            // mtxt_dtp
            // 
            this.mtxt_dtp.Location = new System.Drawing.Point(175, 199);
            this.mtxt_dtp.Name = "mtxt_dtp";
            this.mtxt_dtp.Size = new System.Drawing.Size(100, 20);
            this.mtxt_dtp.TabIndex = 9;
            // 
            // btn_dadd
            // 
            this.btn_dadd.Location = new System.Drawing.Point(35, 298);
            this.btn_dadd.Name = "btn_dadd";
            this.btn_dadd.Size = new System.Drawing.Size(75, 23);
            this.btn_dadd.TabIndex = 10;
            this.btn_dadd.Text = "Add";
            this.btn_dadd.UseSelectable = true;
            this.btn_dadd.Click += new System.EventHandler(this.btn_dadd_Click);
            // 
            // btn_ddisplay
            // 
            this.btn_ddisplay.Location = new System.Drawing.Point(149, 297);
            this.btn_ddisplay.Name = "btn_ddisplay";
            this.btn_ddisplay.Size = new System.Drawing.Size(75, 23);
            this.btn_ddisplay.TabIndex = 11;
            this.btn_ddisplay.Text = "Display";
            this.btn_ddisplay.UseSelectable = true;
            this.btn_ddisplay.Click += new System.EventHandler(this.btn_ddisplay_Click);
            // 
            // btn_ddelete
            // 
            this.btn_ddelete.Location = new System.Drawing.Point(385, 296);
            this.btn_ddelete.Name = "btn_ddelete";
            this.btn_ddelete.Size = new System.Drawing.Size(75, 23);
            this.btn_ddelete.TabIndex = 13;
            this.btn_ddelete.Text = "Delete";
            this.btn_ddelete.UseSelectable = true;
            this.btn_ddelete.Click += new System.EventHandler(this.btn_ddelete_Click);
            // 
            // btn_dclr
            // 
            this.btn_dclr.Location = new System.Drawing.Point(503, 296);
            this.btn_dclr.Name = "btn_dclr";
            this.btn_dclr.Size = new System.Drawing.Size(75, 23);
            this.btn_dclr.TabIndex = 14;
            this.btn_dclr.Text = "Clear";
            this.btn_dclr.UseSelectable = true;
            this.btn_dclr.Click += new System.EventHandler(this.btn_dclr_Click);
            // 
            // btn_dexit
            // 
            this.btn_dexit.Location = new System.Drawing.Point(631, 298);
            this.btn_dexit.Name = "btn_dexit";
            this.btn_dexit.Size = new System.Drawing.Size(75, 23);
            this.btn_dexit.TabIndex = 15;
            this.btn_dexit.Text = "Exit";
            this.btn_dexit.UseSelectable = true;
            this.btn_dexit.Click += new System.EventHandler(this.btn_dexit_Click);
            // 
            // btn_dupdate
            // 
            this.btn_dupdate.Location = new System.Drawing.Point(269, 295);
            this.btn_dupdate.Name = "btn_dupdate";
            this.btn_dupdate.Size = new System.Drawing.Size(75, 23);
            this.btn_dupdate.TabIndex = 16;
            this.btn_dupdate.Text = "Update";
            this.btn_dupdate.UseSelectable = true;
            this.btn_dupdate.Click += new System.EventHandler(this.btn_dupdate_Click);
            // 
            // dgv_driver
            // 
            this.dgv_driver.AllowUserToResizeRows = false;
            this.dgv_driver.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_driver.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_driver.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_driver.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_driver.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgv_driver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_driver.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgv_driver.EnableHeadersVisualStyles = false;
            this.dgv_driver.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgv_driver.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_driver.Location = new System.Drawing.Point(385, 63);
            this.dgv_driver.Name = "dgv_driver";
            this.dgv_driver.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_driver.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgv_driver.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_driver.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_driver.Size = new System.Drawing.Size(356, 196);
            this.dgv_driver.TabIndex = 17;
            this.dgv_driver.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_driver_CellContentClick);
            // 
            // Driver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 368);
            this.Controls.Add(this.dgv_driver);
            this.Controls.Add(this.btn_dupdate);
            this.Controls.Add(this.btn_dexit);
            this.Controls.Add(this.btn_dclr);
            this.Controls.Add(this.btn_ddelete);
            this.Controls.Add(this.btn_ddisplay);
            this.Controls.Add(this.btn_dadd);
            this.Controls.Add(this.mtxt_dtp);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txt_dname);
            this.Controls.Add(this.txt_did);
            this.Controls.Add(this.txt_id);
            this.Name = "Driver";
            this.Text = "Driver";
            this.Load += new System.EventHandler(this.Driver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_driver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel txt_id;
        private MetroFramework.Controls.MetroTextBox txt_did;
        private MetroFramework.Controls.MetroTextBox txt_dname;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.MaskedTextBox mtxt_dtp;
        private MetroFramework.Controls.MetroButton btn_dadd;
        private MetroFramework.Controls.MetroButton btn_ddisplay;
        private MetroFramework.Controls.MetroButton btn_ddelete;
        private MetroFramework.Controls.MetroButton btn_dclr;
        private MetroFramework.Controls.MetroButton btn_dexit;
        private MetroFramework.Controls.MetroButton btn_dupdate;
        private MetroFramework.Controls.MetroGrid dgv_driver;
    }
}