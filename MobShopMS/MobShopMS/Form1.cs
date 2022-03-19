using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobShopMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            panel1.Visible = false;
            uC_AddNewPhone1.Visible = false;
            uC_Customer1.Visible = false;
            uC_Stock1.Visible = false;
            uC_CustomerRecord1.Visible = false;
            uC_DeletePhone1.Visible = false;

            enableDisable(false, false, false);
            
        }

        private void btnaddnew_Click(object sender, EventArgs e)
        {
            uC_AddNewPhone1.Visible = true;
            uC_AddNewPhone1.BringToFront();

        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btncustomer_Click(object sender, EventArgs e)
        {
            uC_Customer1.Visible = true;
            uC_Customer1.BringToFront();

        }

        private void btnstock_Click(object sender, EventArgs e)
        {
            uC_Stock1.Visible = true;
            uC_Stock1.BringToFront();
        }

        private void btnCustomerrecord_Click(object sender, EventArgs e)
        {
            uC_CustomerRecord1.Visible = true;
            uC_CustomerRecord1.BringToFront();      
        }
        private void btndeletephone_Click(object sender, EventArgs e)
        {
            panel2.Enabled = false;
            enableDisable(true, true, true);

        }
        private void btncancel_Click(object sender, EventArgs e)
        {
            panel2.Enabled = true;
            enableDisable(false, false, false);

        }
        private void btnverify_Click(object sender, EventArgs e)
        {
           if(txtpass.Text == "shoaib")
            {
                panel2.Enabled= true;
                uC_DeletePhone1.Visible = true;
                uC_DeletePhone1.BringToFront();
                enableDisable(false, false, false);
                txtpass.Clear();

                
            }
            else
            {
                txtpass.Clear();
            }

        }


        //======================REQUIRED METHOAD FOR DELETE PHONE RECORD=====================
        public void enableDisable(Boolean txtbox, Boolean btn1, Boolean btn2)
        {
            txtpass.Visible = txtbox;
            btnverify.Visible = btn1;
            btncancel.Visible = btn2;
        }

       

        

        

        private void uC_Stock1_Load(object sender, EventArgs e)
        {

        }

        private void uC_Login4_VisibleChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            btnaddnew.PerformClick();
        }

        private void uC_Login4_Load(object sender, EventArgs e)
        {

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void uC_Login5_Load(object sender, EventArgs e)
        {

        }
    }
}
