using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ReservationSystem
{
    public partial class adminDetails : MetroForm
    {
        public SqlConnection con;
        public SqlCommand cmd;
        int id;

        public adminDetails()
        {
            InitializeComponent();
        }

        private void adminDetails_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString=
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_id.Text) || txt_id.Text.Any(c => char.IsDigit(c)))
            {
                MessageBox.Show("please enter your id number");
            }
            if (string.IsNullOrEmpty(txt_name.Text) || txt_name.Text.Any(c => char.IsNumber(c)))
            {
                MessageBox.Show("please enter your name only in characters");
            }
            try
            {
                con.Open();
                cmd = new SqlCommand("Insert into Admin values ('" + txt_id.Text + "','" + txt_name.Text + "','" + mtxt_tp + "')", con);
                int line=cmd.ExecuteNonQuery();
                con.Dispose();
                con.Close();
             if(line==1)
                {
                    MessageBox.Show("Data Inserted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
             else
                {
                    MessageBox.Show("Data not Inserted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch(SqlException)
            {
                MessageBox.Show("database error");
            }
            catch(Exception)
            {
                MessageBox.Show("errors");
            }
        }
        private void dgv_admin_cellcontentclick(object sender,DataGridViewCellEventArgs e)
        {
            txt_id.Text = dgv_admin.CurrentRow.Cells["admin_id"].Value.ToString();
            txt_name.Text = dgv_admin.CurrentRow.Cells["admin_name"].Value.ToString();
            mtxt_tp.Text = dgv_admin.CurrentRow.Cells["admin_tp"].Value.ToString();

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txt_name.Text) || txt_name.Text.Any(c => char.IsNumber(c)))
            {
                MessageBox.Show("please enter your name only in characters");
            }
            try
            {
                DialogResult dr = MessageBox.Show("do you want to update ?","Information",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if(dr.ToString()=="yes")
                {
                    id = Convert.ToInt32(dgv_admin.CurrentRow.Cells[0].Value.ToString());
                    con.Open();
                    cmd = new SqlCommand("update Admin set admin_name='" + txt_name.Text + "',admin_tp='" + mtxt_tp + "' where admin_id='" + txt_id.Text + "'", con);
                    int line = cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                    if(line==0)
                    {
                        MessageBox.Show("Data Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Data Not Updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch(SqlException)
            {
                MessageBox.Show("Database Error");
            }
            catch(Exception)
            {
                MessageBox.Show("Errors");
            }
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            try
            {

            }
        }
    }
}
