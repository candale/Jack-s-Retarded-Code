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
    public partial class User : Form
    {

        public class Group : GroupBox
        {
            private group gr;
            private TextBox des = new TextBox();
            private Button btn = new Button();
            private User parent;
            public Group(group gr, User parent)
            {
                this.parent = parent;
                this.gr = gr;
                initInterface();
            }

            private void initInterface()
            {
                this.Size = new Size(520, 60);
                this.Text = gr.name;

                des.Multiline = true;
                des.Location = new Point(5, 19);
                des.Size = new Size(450, 30);
                des.Text = gr.descr;
                des.BorderStyle = BorderStyle.FixedSingle;
                des.Enabled = false;
                this.Controls.Add(des);

                btn.BackgroundImage = Image.FromFile("../../ico/check.ico");
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Size = new Size(16, 16);
                btn.Location = new Point(480, 25);
                this.Controls.Add(btn);
            }

            public group getGroupObject()
            {
                return this.gr;
            }
        }

        private Controller ctr;
        private user sessionUser;
        private BindingList<category> catBindingList;
        int selectedView = 0; // 1 - items, 2 - settings, 3 - groups
        bool passGrBoxSelected = true;
        public User(Controller ctr)
        {
            this.ctr = ctr;
            InitializeComponent();
            initCmbx();
            initView();
            loadSettingsData();
            loadGroups();
        }


        private void initCmbx()
        {
            catBindingList = ctr.getCategoriesBindingList();
            cmbx_categories.DataSource = catBindingList;
            cmbx_categories.DisplayMember = "name";
            cmbx_categories.ValueMember = "cat_id";
        }

        private void loadItems(int catId)
        {
            lw_items.Items.Clear();
            LinkedList<ListViewItem> lvList;
            if (catId == -1)
            {
                lvList = ctr.getItemsForListView();
            }
            else
            {
                lvList = ctr.getItemsForListView(catId);
            }
            foreach (ListViewItem it in lvList)
            {
                lw_items.Items.Add(it);
            }
        }

        public void unsubscribe(object obj, EventArgs e)
        {
            MessageBox.Show("unsubscribe ");
        }

        public void subscribe(object obj, EventArgs e)
        {
            MessageBox.Show("subscribe");
        }

        public delegate void GroupEvent(group gr);
        private void loadGroups()
        {
            LinkedList<Group> uiGroups = Util.constructGroups(ctr.getGroups(), this);
            foreach (Group gr in uiGroups)
            {
                groupsFlowLayout.Controls.Add(gr);
            }
        }

        private void initView()
        {
            lw_items.View = View.Details;
            lw_items.Columns.Add("Name");
            lw_items.Columns.Add("Points");
            lw_items.Columns.Add("Price");
            loadItems((int)cmbx_categories.SelectedValue);
        }

        private void User_Load(object sender, EventArgs e)
        {
            this.Size = new Size(560, 300);
            grb_settings.Location = new Point(4, 54);
            grb_settings.Visible = false;
            groupBoxPassword.Visible = false;
            grb_settings.Controls.Add(groupBoxMessage);
            groupBoxMessage.Location = new Point(322, 67);
            groupBoxMessage.Visible = false;

            groupsFlowLayout.AutoScroll = true;
            groupBoxGroups.Location = new Point(4, 54);
            groupBoxGroups.Visible = false;
            groupsFlowLayout.AutoScroll = true;

            this.Resize += centerMenu;
            //WelcomeMessage welWin = new WelcomeMessage(((user)ctr.getSessionUser()).welcome_msg);
            //welWin.ShowDialog();
            //this.Visible = true;
        }

        private void loadSettingsData()
        {
            sessionUser = ctr.getSessionUser();
            pointsTb.Text = sessionUser.no_points.ToString();
            usernameTB.Text = sessionUser.username;
            nameTb.Text = sessionUser.name;
            regDate.Value = (DateTime)sessionUser.reg_data;
            messageTb.Text = sessionUser.welcome_msg;
            typeTB.Text = sessionUser.type;
        }

        private void cmbx_categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                loadItems((int)cmbx_categories.SelectedValue);
            }
            catch (InvalidCastException ex)
            {

            }
        }

        public void centerMenu(object obj, EventArgs e)
        {
            int c = (this.Width - 570) / 2;
            manPanel.Location = new Point(c, manPanel.Location.Y);
            int lineSize = menLine.X2 - menLine.X1;
            menLine.X1 = c;
            menLine.X2 = c + lineSize;
        }

        private void itemsBtn_Click(object sender, EventArgs e)
        {
            this.Size = new Size(560, 300);
            if (checkUnsavedData())
            {
                return;
            }
            selectedView = 0;
            grb_items.Visible = true;
            grb_settings.Visible = false;
            groupBoxGroups.Visible = false;
        }
        private void settingsBtn_Click(object sender, EventArgs e)
        {
            this.Size = new Size(675, 315);
            selectedView = 1;
            grb_items.Visible = false;
            groupBoxGroups.Visible = false;
            grb_settings.Visible = true;
        }


        private void passwordBtn_Click(object sender, EventArgs e)
        {
            if (passGrBoxSelected == false && checkUnsavedData())
            {
                return;
            }
            passGrBoxSelected = true;
            groupBoxPassword.Visible = true;
        }

        private void resetSettingsFields()
        {
            initialTb.Text = "";
            newPassTb.Text = "";
            repPassTb.Text = "";
            messageTb.Text = sessionUser.welcome_msg;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (passGrBoxSelected == true)
            {
                if (sessionUser.pass != initialTb.Text)
                {
                    MessageBox.Show("Initial password it not correct");
                    resetSettingsFields();
                    return;
                }
                if (newPassTb.Text != repPassTb.Text)
                {
                    MessageBox.Show("Passwords do not match");
                    resetSettingsFields();
                    return;
                }
                sessionUser.pass = newPassTb.Text;
                MessageBox.Show("Password updated successfully");
            }
            else
            {
                sessionUser.welcome_msg = messageTb.Text;
                MessageBox.Show("Welcome message updated successfully");
            }
            ctr.commitChanges();
            groupBoxPassword.Visible = false;
        }

        private void welcomeBtn_Click(object sender, EventArgs e)
        {
            if (passGrBoxSelected == true && checkUnsavedData() )
            {
                return;
            }
            passGrBoxSelected = false;
            groupBoxPassword.Visible = false;
            groupBoxMessage.Visible = true;
        }

        private bool checkUnsavedData()
        {
            if (initialTb.Text != "" || newPassTb.Text != "" || repPassTb.Text != "" || sessionUser.welcome_msg != messageTb.Text)
            {
                if (MessageBox.Show("You have unsaved data that will be lost if not saved. Are you sure you want to leave?", "Attention", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return true;
                }
                else
                {
                    resetSettingsFields();
                    return false;
                }
            }
            return false;
        }

        private void groupBtn_Click(object sender, EventArgs e)
        {
            this.Size = new Size(583, 356);
            if (passGrBoxSelected == true && checkUnsavedData())
            {
                return;
            }
            grb_settings.Visible = false;
            grb_items.Visible = false;
            groupBoxGroups.Visible = true;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pointsTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void lineShape4_Click(object sender, EventArgs e)
        {

        }

        private void grb_items_Enter(object sender, EventArgs e)
        {

        }
        
    }
}
