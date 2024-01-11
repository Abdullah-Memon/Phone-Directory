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
    public partial class AllContactReport : Form
    {
        public AllContactReport()
        {
            InitializeComponent();
        }

        private void AllContactReport_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            AllContactPage acp = new AllContactPage();

            DB.sqlcon();
            SqlDataAdapter sda = new SqlDataAdapter("select * from pdirectory", DB.con);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            acp.Load(dt);

            documentViewer1.DocumentSource = acp;
            acp.CreateDocument();
        }
    }
}
