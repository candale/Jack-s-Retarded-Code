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

namespace ITEC.view
{
    public partial class GroupDetails : Form

    {
        private group gr;
        private Controller ctr;
        public GroupDetails(group gr , Controller ctr)
        {
            InitializeComponent();
            this.gr = gr;
            this.ctr = ctr;
            initInterface();
            listUsers();
            listUsersRequests();
        }

        public void initInterface(){
            textBox1.Text = gr.name;
            listView1.Columns.Add("Name");
            listView2.Columns.Add("Name");
            listView1.View = View.Details;
            listView2.View = View.Details;
        }

        public void listUsersRequests()
        {
            listView2.Items.Clear();
            foreach (user us in gr.users) {
                ListViewItem lv = new ListViewItem();
                lv.Text = us.name;
                lv.Tag = us.usr_id;
                listView2.Items.Add(lv);
            }
        }

        public void listUsers()
        {
            listView1.Items.Clear();
            foreach (user us in gr.users1)
            {
                ListViewItem lv = new ListViewItem();
                lv.Text = us.name;
                lv.Tag = us.usr_id;
                listView1.Items.Add(lv);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int usrId = (int)listView1.SelectedItems[0].Tag;
            user usr = ctr.getUser(usrId);
            gr.users1.Remove(usr);
            ctr.commitChanges();
            listUsers();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int usrId = (int)listView2.SelectedItems[0].Tag;
            user usr = ctr.getUser(usrId);
            gr.users.Remove(usr);
            gr.users1.Add(usr);
            ctr.commitChanges();
            listUsers();
            listUsersRequests();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int usrId = (int)listView2.SelectedItems[0].Tag;
            user usr = ctr.getUser(usrId);
            gr.users.Remove(usr);
            ctr.commitChanges();
            listUsers();
            listUsersRequests();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int points;
            if (false == int.TryParse(noPointsTb.Text, out points))
            {
                MessageBox.Show("Invalid number format");
                return;

            }
            foreach (user us in gr.users1)
            {
               us.no_points += points;
            }
            ctr.commitChanges();
        }
    }
}
