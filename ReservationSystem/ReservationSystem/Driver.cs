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
    public partial class Driver : MetroForm
    {
        public SqlConnection con;
        public SqlCommand cmd;
        int did;
        public Driver()
        {
            InitializeComponent();
        }

        private void Driver_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString=
        }

        private void btn_dadd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_did.Text) || txt_did.Text.Any(c => char.IsDigit(c)))
            {
                MessageBox.Show("please enter your id number");
            }
            if (string.IsNullOrEmpty(txt_dname.Text) || txt_dname.Text.Any(c => char.IsNumber(c)))
            {
                MessageBox.Show("please enter your name only in characters");
            }
            try
            {
                con.Open();
                cmd = new SqlCommand("Insert into Admin values ('" + txt_did.Text + "','" + txt_dname.Text + "','" + mtxt_dtp + "')", con);
                int line = cmd.ExecuteNonQuery();
                con.Dispose();
                con.Close();
                if (line == 1)
                {
                    MessageBox.Show("Data Inserted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Data not Inserted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (SqlException)
            {
                MessageBox.Show("database error");
            }
            catch (Exception)
            {
                MessageBox.Show("errors");
            }
        }

        private void dgv_driver_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_did.Text = dgv_driver.CurrentRow.Cells["driver_id"].Value.ToString();
            txt_dname.Text = dgv_driver.CurrentRow.Cells["driver_name"].Value.ToString();
            mtxt_dtp.Text = dgv_driver.CurrentRow.Cells["driver_tp"].Value.ToString();

        }

        private void btn_dupdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_dname.Text) || txt_dname.Text.Any(c => char.IsNumber(c)))
            {
                MessageBox.Show("please enter your name only in characters");
            }
            try
            {
                DialogResult dr = MessageBox.Show("do you want to update ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr.ToString() == "yes")
                {
                    did = Convert.ToInt32(dgv_driver.CurrentRow.Cells[0].Value.ToString());
                    con.Open();
                    cmd = new SqlCommand("update Admin set admin_name='" + txt_dname.Text + "',admin_tp='" + mtxt_dtp + "' where admin_id='" + txt_did.Text + "'", con);
                    int line = cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                    if (line == 0)
                    {
                        MessageBox.Show("Data Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Data Not Updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Database Error");
            }
            catch (Exception)
            {
                MessageBox.Show("Errors");
            }
        }

        private void btn_ddisplay_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select from Admin", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_driver.DataSource = dt;


            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ddelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Do you want to delete the selected row?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr.ToString() == "Yes")
                {
                    did = Convert.ToInt32(dgv_driver.CurrentRow.Cells[0].Value.ToString());
                    con.Open();
                    cmd = new SqlCommand("Delete from Admin where admin_id='" + txt_did.Text + "'");
                    int line = cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                    if (line == 0)
                    {
                        MessageBox.Show("Data Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Data Not Deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            
            catch(Exception)
            {
                MessageBox.Show("Error", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void btn_dclr_Click(object sender, EventArgs e)
        {
            txt_did.Clear();
            txt_dname.Clear();
            mtxt_dtp.Clear();
        }

        private void btn_dexit_Click(object sender, EventArgs e)
        {

        }
    }
