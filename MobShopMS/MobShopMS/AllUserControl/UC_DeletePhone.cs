using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobShopMS.AllUserControl
{
    public partial class UC_DeletePhone : UserControl
    {
        function fn = new function();
        String query;
        public UC_DeletePhone()
        {
            InitializeComponent();
        }

        private void UC_DeletePhone_Enter(object sender, EventArgs e)
        {
            query = "select * from newmobile";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from newmobile where cname like '" + txtsearch.Text + "%' or mname like '"+txtsearch.Text+"%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        int pid;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                pid = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            query = "delete from newmobile where mid = " + pid + "";
            if(MessageBox.Show("Deleting Record of "+pid+"","Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                fn.setData(query);
            }
            else
            {
                MessageBox.Show("You Cancelled the Delete operation.", "Back <-", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
