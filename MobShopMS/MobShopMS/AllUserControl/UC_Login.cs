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
    public partial class UC_Login : UserControl
    {
        public UC_Login()
        {
            InitializeComponent();
            toshowlabel.Visible = false;
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
            panel1.Visible = false;
            this.guna2WinProgressIndicator1.Start();
        }
        int time = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            if(time == 10)
            {
                time = 0;
                if(txtusername.Text == "shoaib" && txtpass.Text == "1598")
                {
                    this.Hide();
                    timer1.Stop();
                }
                else
                {
                    panel1.Visible = true;
                    toshowlabel.Visible = true;
                    timer1.Stop();
                    txtpass.Clear();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
