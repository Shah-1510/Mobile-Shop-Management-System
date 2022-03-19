using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MobShopMS.AllUserControl
{
    public partial class UC_Customer : UserControl
    {
        function fn = new function();
        String query;
        public UC_Customer()
        {
            InitializeComponent();
        }
        private void UC_Customer_Enter(object sender, EventArgs e)
        {
            txtcompany.Items.Clear();
            query = "select distinct cname from newmobile";
            setComboBox(query, txtcompany);
        }
        private void txtcompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtmodel.Items.Clear();
            String cname = txtcompany.Text;
            query = "select mname from newmobile where cname = '" + cname + "'";
            setComboBox(query, txtmodel);

        }
        private void txtmodel_SelectedIndexChanged(object sender, EventArgs e)
        {
            rectangleShape1.BorderColor = System.Drawing.ColorTranslator.FromHtml("Red");
            query = "select * from newmobile where mname = '" + txtmodel.Text + "'";
            DataSet ds = fn.getData(query);

            ramlabel.Text = ds.Tables[0].Rows[0][3].ToString();
            internallabel.Text = ds.Tables[0].Rows[0][4].ToString();
            expandablelabel.Text = ds.Tables[0].Rows[0][5].ToString();
            rearlabel.Text = ds.Tables[0].Rows[0][7].ToString();
            frontlabel.Text = ds.Tables[0].Rows[0][8].ToString();
            fingerlabel.Text = ds.Tables[0].Rows[0][9].ToString();
            pricelabel.Text = ds.Tables[0].Rows[0][12].ToString();
        }
        private void btnpurchase_Click(object sender, EventArgs e)
        {
            if (txtname.Text != "" && txtgender.Text != "" && txtcontact.Text != "" && txtemail.Text != "" && txtaddress.Text != "" && txtcompany.Text != "" && txtmodel.Text != "" && txtimei.Text != "")
            {
                String name = txtname.Text;
                String gender = txtgender.Text;
                Int64 contact = Int64.Parse(txtcontact.Text);
                String email = txtemail.Text;
                String address = txtaddress.Text;
                String company = txtcompany.Text;
                String model = txtmodel.Text;
                String imei = txtimei.Text;

                query = "insert into customerpurchase (cname,gender,contact,email,caddress,company,model,imei) values ('" + name + "','" + gender + "'," + contact + ",'" + email + "','" + address + "','" + company + "','" + model + "','" + imei + "')";
                fn.setData(query);
                txtname.Clear();
                txtgender.SelectedIndex = -1;
                txtcontact.Clear();
                txtemail.Clear();
                txtaddress.Clear();
                txtimei.Clear();
            }
            else
            {
                MessageBox.Show("Fill All Fields.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        // =================REQUIRED METHODS==================
        public void setComboBox(String query, ComboBox combo)
        {
            SqlDataReader sdr = fn.getforcombo(query);     // select model from newmobile
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
        }

        private void UC_Customer_Load(object sender, EventArgs e)
        {

        }
    }
}
