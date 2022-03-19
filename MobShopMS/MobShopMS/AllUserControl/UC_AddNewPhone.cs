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
    public partial class UC_AddNewPhone : UserControl
    {
        function fn = new function();
        String query;
        public UC_AddNewPhone()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtcompany.Text != "" && txtmodel.Text != "" && txtram.Text != "" && txtinternal.Text != "" && txtexpandable.Text != "" && txtdisplay.Text != "" && txtrearcam.Text != "" && txtfrontcam.Text != "" && txtfingerprint.Text != "" && txtsim.Text != "" && txtnetwork.Text != "" && txtprice.Text != "")
            {
                String company = txtcompany.Text;
                String model = txtmodel.Text;
                String ram = txtram.Text;
                String intel = txtinternal.Text;
                String expand = txtexpandable.Text;
                String display = txtdisplay.Text;
                String rear = txtrearcam.Text;
                String front = txtfrontcam.Text;
                String finger = txtfingerprint.Text;
                String sim = txtsim.Text;
                String network = txtnetwork.Text;
                Int64 price = Int64.Parse(txtprice.Text);

                query = "insert into newmobile (cname,mname,ram,internal,expandable,display,rear,front,finger,sim,network,price) values ('" + company + "','" + model + "','" + ram + "','" + intel + "','" + expand + "','" + display + "','" + rear + "','" + front + "','" + finger + "','" + sim + "','" + network + "'," + price + ")";
                fn.setData(query);
                
            }
            else
            {
                MessageBox.Show("Fill All Fields.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }           
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtcompany.Clear();
            txtmodel.Clear();
            txtram.SelectedIndex = -1;
            txtinternal.SelectedIndex = -1;
            txtexpandable.SelectedIndex = -1;
            txtdisplay.SelectedIndex = -1;
            txtrearcam.SelectedIndex = -1;
            txtfrontcam.SelectedIndex = -1;
            txtfingerprint.SelectedIndex = -1;
            txtsim.SelectedIndex = -1;
            txtnetwork.SelectedIndex = -1;
            txtprice.Clear();
        }

        private void UC_AddNewPhone_Load(object sender, EventArgs e)
        {

        }
    }
}
