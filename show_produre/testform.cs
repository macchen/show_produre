using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using show_produre.ADO;

namespace show_produre
{
    public partial class testform : Form
    {
        public testform()
        {
            InitializeComponent();
        }

        private void btntest_Click(object sender, EventArgs e)
        {
            SqlHelper connect = new SqlHelper();

           // dgv_showdata.DataSource = connect.getresult("select name, type from sysobjects where type in('P','TR')");
            //dgv_showdata.DataSource = connect.getresult("pr_gettable_parm","P");

            //dgv_showdata.DataSource = connect.getresult("pr_gettable_parm", "P","t_bd_item_info");
            //dgv_showdata.AutoResizeColumns();

          
        }
    }
}
