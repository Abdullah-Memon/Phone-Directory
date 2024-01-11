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
using System.IO;

namespace Phone_Directory
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        SqlCommand cmd;
        SqlDataAdapter sda;
        DataTable dt;
        public static SingleContactPage scp;

        void getcontactdata()
        {
            DB.sqlcon();
             sda = new SqlDataAdapter("select cid, cpic, name, lastname, number, cemail from pdirectory where userid = '" + Form1.uid + "'", DB.con);
             dt = new DataTable();

            sda.Fill(dt);

            gunaDataGridView1.DataSource = dt;

        }

        void getuserdata()
        {
            DB.sqlcon();
             sda = new SqlDataAdapter("select profilepic from users where userid = '"+Form1.uid+"'",DB.con);
             dt = new DataTable();
            sda.Fill(dt);
        
            byte[] pic = (byte[]) dt.Rows[0][0];
            
            MemoryStream ms = new MemoryStream(pic);
                    
            gunaCirclePictureBox1.Image = Image.FromStream(ms);
        
        }
        // load form coding;
        private void UserForm_Load(object sender, EventArgs e)
        {
            getcontactdata();
            getuserdata();
            username.Text = Form1.uname;
        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Form1"].Show();
        }

        private void gunaCircleButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void gunaCirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            AddContactForm acf = new AddContactForm();
            acf.ShowDialog();
            getcontactdata();
        }

        //search button coding
        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {

            if (searchbox.Text != "")
            {
                 sda = new SqlDataAdapter("select CID, cpic, name, lastname, number, cemail from pdirectory where userid = '" + Form1.uid + "' and name like '%" + searchbox.Text + "%'", DB.con);
                 dt = new DataTable();

                sda.Fill(dt);
      
                gunaDataGridView1.DataSource = dt;
            }
            else
                searchbox.Focus();
                
        }
        // clear search coding
        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            getcontactdata();
            searchbox.Text = "";
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DB.sqlcon();
           // MessageBox.Show(e.ColumnIndex.ToString());
            
            //update buttun
            if (e.ColumnIndex == 0)
            {
                ImageConverter img = new ImageConverter();

                byte[] pic = (byte[])img.ConvertTo(cpic.Image, Type.GetType("System.Byte[]"));

                DB.con.Open();
                 cmd = new SqlCommand("update pdirectory set name = '" + gunaDataGridView1.Rows[e.RowIndex].Cells["firstname"].Value + "', cemail = '" + gunaDataGridView1.Rows[e.RowIndex].Cells["email"].Value + "', lastname = '" + gunaDataGridView1.Rows[e.RowIndex].Cells["lastname"].Value + "', number= '" + gunaDataGridView1.Rows[e.RowIndex].Cells["phone"].Value + "', cpic = @updatepic where CID = '" + gunaDataGridView1.Rows[e.RowIndex].Cells["cid"].Value + "'", DB.con);
                cmd.Parameters.AddWithValue("@updatepic", pic);

                int check = cmd.ExecuteNonQuery();
                DB.con.Close();
                MessageBox.Show("Contact Updated!");
                getcontactdata();

            }
            //delete button
            if (e.ColumnIndex == 1)
            {
                DB.con.Open();
                cmd = new SqlCommand("delete pdirectory where CID = '" + gunaDataGridView1.Rows[e.RowIndex].Cells["cid"].Value + "'", DB.con);
                int check = cmd.ExecuteNonQuery();
                DB.con.Close();

                getcontactdata();
            }

            // contact report button
            if (e.ColumnIndex == 2)
            {
                scp = new SingleContactPage();

                DB.sqlcon();
                sda = new SqlDataAdapter("select * from pdirectory where userid = '" + Form1.uid + "' and cid = '"+gunaDataGridView1.Rows[e.RowIndex].Cells["cid"].Value+"'", DB.con);
                dt = new DataTable();
                sda.Fill(dt);

                scp.Load(dt);
                ContactReport cr = new ContactReport();
                cr.ShowDialog();
            }

            if (e.ColumnIndex == 4)
            {
                using (OpenFileDialog opf = new OpenFileDialog())
                {
                    opf.Filter = "ImageFile (*.jpg; *.jfif; *.png;)|*.jfif; *.jpg; *.png;";
                    if (opf.ShowDialog() == DialogResult.OK)
                    {
                        cpic.Image = Image.FromFile(opf.FileName);
                        gunaDataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Image.FromFile(opf.FileName);
                    }
                }
            }
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            AllContactReport acr = new AllContactReport();
            acr.ShowDialog();
        }

        private void logoutButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Form1"].Show();
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            SettingForm sf = new SettingForm();
            sf.Show();

        }

    }
}
