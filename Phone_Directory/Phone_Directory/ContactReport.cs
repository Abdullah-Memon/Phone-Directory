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
    public partial class ContactReport : Form
    {
        public ContactReport()
        {
            InitializeComponent();
        }

        private void ContactReport_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            documentViewer1.DocumentSource = UserForm.scp;
            UserForm.scp.CreateDocument();
        }

        
    }
}
