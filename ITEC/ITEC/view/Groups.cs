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
    public partial class Groups : Form
    {
        private user usr;
        private Controller ctr;
        private bool edit;
        private Dictionary<int, group> has = new Dictionary<int, group>();
        private Dictionary<int, group> notHas = new Dictionary<int, group>();
        public Groups(user usr, Controller ctr, bool edit)
        {
            InitializeComponent();
            this.usr = usr;
            this.ctr = ctr;
            this.edit = edit;
            loadList();
            initInterface();
        }

        public void initInterface()
        {
            if (edit == false)
            {
                groupList.Enabled = false;
                saveBtn.Visible = false;
                closeBtn.Text = "Close";
            }
            nameTb.Enabled = false;
            nameTb.Text = usr.name;
        }

        private void loadList()
        {
            int count = 0;
            foreach(group gr in usr.groups)
            {
                has.Add(count++, gr);
                groupList.Items.Add(gr.name, true);
            }
            foreach (group gr in ctr.getGroups())
            {
                if (!has.Values.Contains(gr))
                {
                    groupList.Items.Add(gr.name, false);
                    notHas.Add(count++, gr);
                }
            }
        }

        private void Groups_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < groupList.Items.Count; i++)
            {
                if (has.ContainsKey(i) && groupList.GetItemCheckState(i) == CheckState.Unchecked)
                {
                    usr.groups1.Remove(has[i]);
                }
                else if (!has.ContainsKey(i) && groupList.GetItemCheckState(i) == CheckState.Checked)
                {
                    usr.groups1.Add(notHas[i]);
                }
            }
            //ctr.commitGroupUser(usr);
            ctr.commitChanges();
            this.Close();
        }
    }
}
