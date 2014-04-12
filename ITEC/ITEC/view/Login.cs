using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITEC.controller;
namespace ITEC
{
    public partial class Login : Form
    {
        private Controller ctr;
        public Login(Controller ctr)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ctr = ctr;
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (ctr.checkLogin(txt_usr.Text, txt_pass.Text) == false)
            {
                MessageBox.Show("Invalid username or password");
                return;
            }
            String type = ctr.getSessionUser().type;
            if (type == "user")
            {
                ITEC.view.User usrWin = new view.User(this.ctr);
                usrWin.FormClosing += usrWin_FormClosing;
                this.Visible = false;
                usrWin.ShowDialog();
            }
            else if (type == "admin")
            {
                ITEC.view.Administrator adminWin = new view.Administrator(ctr);
                adminWin.FormClosing += usrWin_FormClosing;
                this.Visible = false;
                adminWin.ShowDialog();
            }
        }

        private void usrWin_FormClosing(object obj, EventArgs e)
        {
            Application.Exit();
        }



    }
}
