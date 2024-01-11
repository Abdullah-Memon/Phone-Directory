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
    public partial class ChangeUsername : Form
    {
        public ChangeUsername()
        {
            InitializeComponent();
        }

        // load form coding
        private void ChangeUsername_Load(object sender, EventArgs e)
        {
            // hiding confirmation context
            confirmation.Hide();
            gunaLabel3.Hide();
            update.Hide();
        }

        private void cu_Click(object sender, EventArgs e)
        {
            if (username.Text != "")
            {
                // update lable form confirmation stage;
                gunaLabel2.Text = "Password";
                
                // hiding context for confimation stage;
                username.Hide();
                cu.Hide();

                // showing data from confimation satge;
                confirmation.Show();
                gunaLabel3.Show();
                update.Show();

            }
            else
            {
                username.Focus();
            }
            
        }

        // user confimation button coding
        private void confirm_Click(object sender, EventArgs e)
        {
            // searching user in database;
            SqlDataAdapter sda = new SqlDataAdapter("select userid from users where userid= '" + Form1.uid + "' and userpassword = '" + confirmation.Text + "'", DB.con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

           // if user exist
            if (dt.Rows.Count > 0)
            {
                // updating username;
                DB.con.Open();
                SqlCommand cmd = new SqlCommand("update users set username = '" + username.Text + "' where userid = '" + Form1.uid + "'", DB.con);
                int chk = cmd.ExecuteNonQuery();
                DB.con.Close();
                
                if (chk > 0)
                {
                    MessageBox.Show("Username successfull updated!");
                    // closing form after updation;
                    this.Close();
                }
            }
                // if user doesn't exits;
            else
            {
                MessageBox.Show("Invalid Password Please try again!");
            }
        }
    }
}
