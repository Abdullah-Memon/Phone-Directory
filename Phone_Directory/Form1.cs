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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        SqlDataAdapter sda;
        DataTable dt;
        public static string uname= null;
        public static string uid=null;
        
        // load form coding;
        private void Form1_Load(object sender, EventArgs e)
        {
            username.Text = "";
            password.Text = "";
        }

        // login button coding;
        private void login_Click(object sender, EventArgs e)
        {
            if (username.Text != "" && password.Text != "")
            {
                // database connection query;
                DB.sqlcon();

                // retriving the data of the user if exits;
                sda = new SqlDataAdapter("select userid, username, userpassword from users where username = '" + username.Text + "' and userpassword = '" + password.Text + "' ",DB.con);
                dt = new DataTable();
                sda.Fill(dt);

                // if user exit;
                if (dt.Rows.Count > 0)
                {
                    // saving the uid and username of the user;
                    uid = dt.Rows[0][0].ToString();
                    uname = dt.Rows[0][1].ToString();

                    //clear login screen
                    username.Text = null;
                    password.Text = null;

                    // Contact form;
                    UserForm uf = new UserForm();
                    uf.Show();
                    this.Hide();
                }
                // if user doesn't exit;
                else
                {
                    MessageBox.Show("Invalid Username or Password!");
                }
            }
            else if (username.Text == "")
            {
                username.Focus();
            }
            else
            {
                password.Focus();
            }
        }


        // show password check box coding;
        private void showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showpassword.Checked)
                password.UseSystemPasswordChar = false;
            else
                password.UseSystemPasswordChar = true;
        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaCircleButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void signup_Click(object sender, EventArgs e)
        {
            username.Text = null;
            password.Text = null;
            SignupForm sf = new SignupForm();
            sf.Show();
            this.Hide();
        }

        
    }
}
