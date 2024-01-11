using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone_Directory
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            ChangeUsername cu = new ChangeUsername();
            cu.ShowDialog();
        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
