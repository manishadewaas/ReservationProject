﻿using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
=======
using System.Data.SqlClient;
>>>>>>> e0bb8ceb52a74d0e174c28ea18f0c9a84b0474f5

namespace ReservationSystem
{
    public partial class Bus : MetroForm
    {
<<<<<<< HEAD
=======
        public SqlConnection con;
        public SqlConnection cmd;
>>>>>>> e0bb8ceb52a74d0e174c28ea18f0c9a84b0474f5
        public Bus()
        {
            InitializeComponent();
        }

        private void Bus_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

=======
            con = new SqlConnection();
            con.ConnectionString=
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {  
                if(String.IsNullOrEmpty(txt_origin.Text)||txt_origin.Text.Any(char.IsDigit))
                { MessageBox.Show("Enter a place for Origin", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning); }
                else if (String.IsNullOrEmpty(txt_dest.Text) || txt_dest.Text.Any(char.IsDigit))
                { MessageBox.Show("Enter a place for Destination", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning); }
                else if( txt_fare.Text.Any  ||
                { MessageBox.Show("Enter a place for Origin", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning); }


                con.Open();
                cmd = new SqlCommand("Insert into Bus values('"+txt_busno.Text+"','"+txt_origin.Text+"','"+txt_dest.Text+"','"+txt_dept.Text+"','"+txt_arr.Text+"','"+txt_fare.Text+"')",con);
                






            }
        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {
            time_dep.Format = DateTimePickerFormat.Time;
            time_dep.ShowUpDown = true;
        }

        private void time_arr_ValueChanged(object sender, EventArgs e)
        {
            time_arr.Format = DateTimePickerFormat.Time;
            time_arr.ShowUpDown = true;
>>>>>>> e0bb8ceb52a74d0e174c28ea18f0c9a84b0474f5
        }
    }
}
