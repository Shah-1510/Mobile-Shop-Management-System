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
    
    public partial class UC_CustomerRecord : UserControl
    {
        function fn = new function();
        String query;
        public UC_CustomerRecord()
        {
            InitializeComponent();
        }

        private void UC_CustomerRecord_Enter(object sender, EventArgs e)
        {
            query = "select * from customerpurchase";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

        }
        Boolean flag;
        private void txtsearchby_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtsearchby.SelectedIndex == 0)
            {
                flag = false;
                labeltoset.Text = "Enter Customer Name";
            }
            else if(txtsearchby.SelectedIndex == 1)
            {
                flag = true;
                labeltoset.Text = "Enter IMEI";
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if(flag == false)
            {
                query = "select * from customerpurchase where cname like '" + txtsearch.Text + "%'";
                DataSet ds = fn.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                query = "select * from customerpurchase where imei like '" + txtsearch.Text + "%'";
                DataSet ds = fn.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];

            }
        }

        private void UC_CustomerRecord_Load(object sender, EventArgs e)
        {

        }
    }
}
