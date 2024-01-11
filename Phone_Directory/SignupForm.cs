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
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        SqlDataAdapter sda;
        DataTable dt;
        SqlCommand cmd;

        // close button coding;
        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Form1"].Show();
        }

        // minimize button coding;
        private void gunaCircleButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //terms and condition coding;
        private void tc_CheckedChanged(object sender, EventArgs e)
        {
            if (tc.Checked)
                signup.Enabled = true;
            else
                signup.Enabled = false;
        }

        // form load coding;
        private void SignupForm_Load(object sender, EventArgs e)
        {
            signup.Enabled = false;
            DB.sqlcon();
            sda = new SqlDataAdapter("select * from SecurityQuestions", DB.con);
            dt = new DataTable();
            sda.Fill(dt);

            quest.DataSource = dt;
            quest.DisplayMember = "questions";
            quest.ValueMember = "qid";
        }

        //upload button coding;
        private void uploadButton1_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog opf = new OpenFileDialog())
            {
                opf.Filter = "Image File (*.jpg; *.png; *.gif;)|*.jpg; *.png; *.gif;";

                if (opf.ShowDialog() == DialogResult.OK)
                {
                    gunaPictureBox1.Image = Image.FromFile(opf.FileName);
                }
            }
        }

        // signup button coding;
        private void signup_Click(object sender, EventArgs e)
        {
            if (fname.Text != "" && lname.Text != "" && dob.Text != "" && email.Text != "" && quest.Text != "" && ans.Text != "" && uname.Text != "" && pass.Text != "" && cpass.Text != "")
            {
                // if password and confirm password is same
                if (pass.Text == cpass.Text)
                {
                    // cheching for the data duplication
                    sda = new SqlDataAdapter("select userid from users where username = '" + uname.Text + "' and userpassword = '" + cpass.Text + "'", DB.con);
                    dt = new DataTable();

                    sda.Fill(dt);

                    // if data matches with other user
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("User already Exits Please try with another username");
                    }
                    // if data doesn't matches
                    else
                    {
                        // converting image data into bytes to save in database;
                        ImageConverter img = new ImageConverter();
                        byte[] pic = (byte[])img.ConvertTo(gunaPictureBox1.Image, Type.GetType("System.Byte[]"));
                        
                        // inserting data into database;
                        cmd = new SqlCommand("insert into users (Firstname , Lastname, DOB , Email_Address, UserName, UserPassword, Question, QuestionKey, ProfilePic) Values ('" + fname.Text + "','" + lname.Text + "','" + dob.Value + "','" + email.Text + "','" + uname.Text + "','" + cpass.Text + "','" + quest.Text + "','" + ans.Text + "', @profile)", DB.con);
                        
                        //connection open;
                        DB.con.Open();
                        cmd.Parameters.AddWithValue("@profile", pic);
                        int chk = cmd.ExecuteNonQuery();
                        //connection close;
                        DB.con.Close();
                        
                        if (chk > 0)
                        {
                            MessageBox.Show("User Successfully Singed up!");
                            this.Close();
                            Application.OpenForms["Form1"].Show();
                        }
                    }

                }
                // if password and confirm password is not same
                else
                {
                    MessageBox.Show("Password doesn't match");
                    cpass.Focus();
                }

            }
            // focus on unfilled text boxes;
            else if (fname.Text == "")
                fname.Focus();
            else if (lname.Text == "")
                lname.Focus();
            else if (dob.Value == null)
                dob.Focus();
            else if (email.Text == "")
                email.Focus();
            else if (quest.Text == "")
                quest.Focus();
            else if (ans.Text == "")
                ans.Focus();
            else if (uname.Text == "")
                uname.Focus();
            else if (pass.Text == "")
                pass.Focus();
            else if (cpass.Text == "")
                cpass.Focus();
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void show1_CheckedChanged(object sender, EventArgs e)
        {
            if (show1.Checked)
                pass.UseSystemPasswordChar = false;
            else
                pass.UseSystemPasswordChar = true;
        }

        private void show2_CheckedChanged(object sender, EventArgs e)
        {
            if (show2.Checked)
                cpass.UseSystemPasswordChar = false;
            else
                cpass.UseSystemPasswordChar = true;
        }

               
    }
}
