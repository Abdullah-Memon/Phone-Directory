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

namespace Phone_Directory
{
    public partial class AddContactForm : Form
    {
        public AddContactForm()
        {
            InitializeComponent();
        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (fname.Text != "" && num.Text != "")
            {
                DB.sqlcon();
                SqlDataAdapter sda = new SqlDataAdapter("select cid from pdirectory where number = '" + num.Text + "'", DB.con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Contact already exists!");
                }
                else
                {
                    ImageConverter img = new ImageConverter();
                    byte[] pic = (byte[])img.ConvertTo(gunaPictureBox1.Image, Type.GetType("System.Byte[]"));

                    DB.con.Open();
                    SqlCommand cmd = new SqlCommand("insert into pdirectory (userid, name, lastname, cemail, number, cpic)Values ('" + Form1.uid + "', '" + fname.Text + "', '" + lastname.Text + "', '" + email.Text + "', '" + num.Text + "', @profile)", DB.con);
                    cmd.Parameters.AddWithValue("@profile", pic);
                    int chk = cmd.ExecuteNonQuery();
                    DB.con.Close();

                    if (chk > 0)
                    {
                        MessageBox.Show("Contact added successfully!");
                        
                        this.Close();
                    }

                }
            }
            else if (fname.Text == "")
                fname.Focus();
            else
                num.Focus();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog opf = new OpenFileDialog())
            {
                opf.Filter = "Image File (*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";

                if (opf.ShowDialog() == DialogResult.OK)
                {
                    gunaPictureBox1.Image = Image.FromFile(opf.FileName);
                }
            }
        }
    }
}
