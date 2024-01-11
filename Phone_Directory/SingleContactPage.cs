using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Phone_Directory
{
    public partial class SingleContactPage : DevExpress.XtraReports.UI.XtraReport
    {
        public SingleContactPage()
        {
            InitializeComponent();
        }


        internal void Load(System.Data.DataTable dt)
        {
            objectDataSource1.DataSource = dt;
        }
    }
}
