using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ITEC.controller;
namespace ITEC.view
{
    public partial class Administrator : Form
    {
        #region innerClasses
        public class Group : GroupBox
        {
            private group gr;
            private TextBox des = new TextBox();
            private Button joinBut = new Button();
            private Controller ctr;
            public Group(group gr,Controller ctr)
            {
                this.gr = gr;
                this.ctr = ctr;
                initInterface();
            }

            private void initInterface()
            {
                this.Size = new Size(600, 60);
                this.Text = gr.name;

                des.Multiline = true;
                des.Location = new Point(5, 19);
                des.Size = new Size(440, 30);
                des.Text = gr.descr;
                des.BorderStyle = BorderStyle.FixedSingle;
                des.Enabled = false;
                this.Controls.Add(des);

                joinBut.FlatStyle = FlatStyle.Flat;
                joinBut.Location = new Point(510, 20);
                joinBut.Text = "Details";
                this.Controls.Add(joinBut);
                joinBut.Click += btn_click;
            }

            public group getGroupObject()
            {
                return this.gr;
            }
            public void btn_click(object o, EventArgs e) {
                GroupDetails groupview = new GroupDetails(gr, ctr);
                groupview.ShowDialog();
            }
        }
        #endregion

        #region memberDefinition
        private Controller ctr;
        private user sessionUser;
        private bool passGrBoxSelected = false;
        private BindingList<category> catBindingList;
        private string lastPressed = "";
        private ChartGenerator gen = new ChartGenerator();
        #endregion

        public Administrator(Controller ctr)
        {
            InitializeComponent();
            this.ctr = ctr;
            initView();
            setItemTextBoxState(false);
            loadCategoriesInComboBox(cmbx_categories);
            initInterface();
        }

        #region loadMethods
        private void loadUsers()
        {
            usersList.Items.Clear();
            foreach (user usr in ctr.getUsers())
            {
                ListViewItem it = new ListViewItem();
                it.Text = usr.name;
                it.SubItems.Add(usr.username);
                it.SubItems.Add(usr.reg_data.ToString());
                it.SubItems.Add(usr.no_points.ToString());
                it.SubItems.Add(usr.welcome_msg);
                it.Tag = usr.usr_id;
                usersList.Items.Add(it);
            }
        }
        private void loadItemInTextBox()
        {
            ListView.SelectedListViewItemCollection items = lw_items.SelectedItems;
            try
            {
                textBox1.Text = items[0].Text;
                textBox2.Text = items[0].SubItems[2].Text;
                textBox3.Text = items[0].SubItems[1].Text;
                cmbx_categories.SelectedValue = ((KeyValuePair<int, int>)items[0].Tag).Value;
            }
            catch (Exception e)
            {
            }
        }
        private void loadItems(int catId)
        {
            lw_items.Items.Clear();
            LinkedList<item> itemList = ctr.getItems();
            foreach (item it in itemList)
            {
                ListViewItem vIt = new ListViewItem();
                category cat;
                vIt.Text = it.name;
                vIt.SubItems.Add(it.points.ToString());
                vIt.SubItems.Add(it.price.ToString());
                if ((cat = ctr.getCategory((int)it.cat_id)) == null)
                {
                    continue;
                }
                vIt.SubItems.Add(cat.name);
                vIt.Tag = new KeyValuePair<int, int>(it.item_id, cat.cat_id);
                lw_items.Items.Add(vIt);
            }
        }
        private void loadSettingsData()
        {
            sessionUser = ctr.getSessionUser();
            //pointsTb.Text = sessionUser.no_points.ToString();
            usernameTB.Text = sessionUser.username;
            nameTb.Text = sessionUser.name;
            regDate.Value = (DateTime)sessionUser.reg_data;
            messageTb.Text = sessionUser.welcome_msg;
            typeTB.Text = sessionUser.type;
        }
        private void loadCategories()
        {
            ctr.getCategories();
            catListView.Items.Clear();
            foreach (category cat in ctr.getCategories())
            {
                ListViewItem it = new ListViewItem();
                it.Text = cat.name;
                it.Tag = cat.cat_id;
                catListView.Items.Add(it);
            }

        }
        private void loadGroups()
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (group gr in ctr.getGroups())
            {
                Group grUi = new Group(gr, ctr);
                flowLayoutPanel1.Controls.Add(grUi);

            }
        }
        private void loadCategoriesInComboBox(ComboBox bx)
        {
            catBindingList = ctr.getCategoriesBindingList();
            bx.DataSource = catBindingList;
            bx.DisplayMember = "name";
            bx.ValueMember = "cat_id";
        }
        #endregion

        #region buttonEvents
        private void button9_Click(object sender, EventArgs e)
        {
            if (lastPressed == "create")
            {
                item it = new item();
                it.name = textBox1.Text;
                it.price = decimal.Parse(textBox2.Text);
                it.points = int.Parse(textBox3.Text);
                it.cat_id = (int)cmbx_categories.SelectedValue;
                if (it.name == "")
                {
                    MessageBox.Show("You have to complete all fields");
                    return;
                }
                else
                {
                    it.item_id = ctr.getMaxItemId() + 1;
                    ctr.addItem(it);
                    ctr.commitChanges();
                    setItemTextBoxState(false);
                }
            }
            else if (lastPressed == "update")
            {
                int itemId = ((KeyValuePair<int, int>)lw_items.SelectedItems[0].Tag).Key;
                item it = ctr.getItem(itemId);
                it.name = textBox1.Text;
                it.price = decimal.Parse(textBox2.Text);
                it.points = int.Parse(textBox3.Text);
                it.cat_id = (int)cmbx_categories.SelectedValue;
                if (it.name == "")
                {
                    MessageBox.Show("You have to complete all fields");
                    return;
                }
                else
                {
                    ctr.commitChanges();
                    setItemTextBoxState(false);
                }
            }
            loadItems(-1);
            lastPressed = "";
        }

        private void menCategoriesBtn_Click(object sender, EventArgs e)
        {
            this.Size = new Size(580, 258);
            loadCategories();
            hideAll();
            panel1.Visible = true;
        }

        private void menItemsBtn_Click(object sender, EventArgs e)
        {
            this.Size = new Size(580, 258);
            hideAll();
            groupBox1.Visible = true;
        }

        private void createCategoryBtn_Click(object sender, EventArgs e)
        {
            nameCatTb.Text = "";
            setStateCat(true);
            lastPressed = "create";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lastPressed = "create";
            setItemTextBoxState(true);
            clearTexts();
        }

        private void saveCategoryBtn_Click(object sender, EventArgs e)
        {
            if (lastPressed == "create")
            {
                category cat = new category();
                cat.name = nameCatTb.Text;
                cat.cat_id = ctr.getMaxCatId() + 1;
                if (cat.name == "")
                {
                    MessageBox.Show("You have to complete all fields");
                    return;
                }
                else
                {
                    ctr.addCategory(cat);
                    ctr.commitChanges();
                    setStateCat(false);
                }
            }
            else if (lastPressed == "update")
            {
                int catId = (int)catListView.SelectedItems[0].Tag;
                category cat = ctr.getCategory(catId);
                cat.name = nameCatTb.Text;
                if (cat.name == "")
                {
                    MessageBox.Show("You have to complete all fields");
                    return;
                }
                else
                {
                    ctr.commitChanges();
                    setStateCat(false);
                }
            }
            loadCategories();
        }

        private void updateCategoryBtn_Click(object sender, EventArgs e)
        {
            setStateCat(true);
            lastPressed = "update";
        }

        private void deleteCategoryBtn_Click(object sender, EventArgs e)
        {
            int catId = (int)catListView.SelectedItems[0].Tag;
            category cat = ctr.getCategory(catId);
            if (cat.items.Count != 0)
            {
                MessageBox.Show("Cannot delete because you have items depending on this category. You can only update");
                return;
            }
            ctr.deleteCategory(cat);
            ctr.commitChanges();
            nameCatTb.Text = "";
            loadCategories();
        }

        private void menUsersBtn_Click(object sender, EventArgs e)
        {
            hideAll();
            loadUsers();
            panel2.Visible = true;
            this.Size = new Size(650, 400);
        }

        private void userCreateBtn_Click(object sender, EventArgs e)
        {
            setStateUsers(true);
            clearUserTxts();
            lastPressed = "create";
        }

        private void saveUserBtn_Click(object sender, EventArgs e)
        {
            if (lastPressed == "create")
            {
                user usr = new user();
                usr.usr_id = ctr.getMaxUserId() + 1;
                usr.name = textBox4.Text;
                usr.username = textBox5.Text;
                usr.pass = textBox6.Text;
                usr.reg_data = dateTimePicker1.Value;
                usr.welcome_msg = textBox8.Text;
                usr.no_points = int.Parse(textBox9.Text);
                usr.type = "user";
                if (usr.name == "" || usr.username == "" || usr.pass == "" || usr.welcome_msg == "")
                {
                    MessageBox.Show("You have to complete all fields");
                    return;
                }
                else
                {
                    ctr.addUser(usr);
                    ctr.commitChanges();
                }
            }
            else if (lastPressed == "update")
            {
                int usrId = (int)usersList.SelectedItems[0].Tag;
                user usr = ctr.getUser(usrId);
                usr.name = textBox4.Text;
                usr.username = textBox5.Text;
                usr.pass = textBox6.Text;
                usr.reg_data = dateTimePicker1.Value;
                usr.welcome_msg = textBox8.Text;
                usr.no_points = int.Parse(textBox9.Text);
                if (usr.name == "" || usr.username == "" || usr.pass == "" || usr.welcome_msg == "")
                {
                    MessageBox.Show("You have to complete all fields");
                    return;
                }
                else
                {
                    ctr.commitChanges();
                }
            }
            setStateUsers(false);
            loadUsers();
            lastPressed = "";
        }

        private void updateUserBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int usrId = (int)usersList.SelectedItems[0].Tag;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No user selected");
                return;
            }
            setStateUsers(true);
            lastPressed = "update";
        }

        private void deleteUserBtn_Click(object sender, EventArgs e)
        {
            int usrId = 0;
            try
            {
                usrId = (int)usersList.SelectedItems[0].Tag;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No user was selected");
            }

            user usr = ctr.getUser(usrId);
            ctr.deleteUser(usr);
            ctr.commitChanges();
            loadUsers();
        }

        private void menSettingsBtn_Clikc(object sender, EventArgs e)
        {
            this.Size = new Size(580, 258);
            hideAll();
            panel3.Visible = true;
            loadSettingsData();
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

        private void button8_Click(object sender, EventArgs e)
        {
            int itemId = ((KeyValuePair<int, int>)lw_items.SelectedItems[0].Tag).Key;
            item it = ctr.getItem(itemId);
            ctr.deleteItem(it);
            ctr.commitChanges();
            clearTexts();
            loadItems(-1);
        }

        private void passwordBtn_Click_1(object sender, EventArgs e)
        {
            if (passGrBoxSelected == false && checkUnsavedData())
            {
                return;
            }
            passGrBoxSelected = true;
            groupBoxMessage.Visible = false;
            groupBoxPassword.Visible = true;
        }

        private void welcomeBtn_Click(object sender, EventArgs e)
        {
            if (passGrBoxSelected == true && checkUnsavedData())
            {
                return;
            }
            passGrBoxSelected = false;
            groupBoxPassword.Visible = false;
            groupBoxMessage.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            loadCategoriesInComboBox(cmbx_categories);
            lastPressed = "update";
            setItemTextBoxState(true);

        }

        private void saveSettingsBtn_Click(object sender, EventArgs e)
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

        private void editGroupsBtn_Click(object sender, EventArgs e)
        {
            int usrId;
            try
            {
                usrId = (int)usersList.SelectedItems[0].Tag;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No user selected");
                return;
            }
            user usr = ctr.getUser(usrId);
            Groups grWin;
            if (lastPressed == "update" || lastPressed == "create")
            {
                grWin = new Groups(usr, ctr, true);
            }
            else
            {
                grWin = new Groups(usr, ctr, false);
            }
            grWin.Enabled = true;
            grWin.ShowDialog();
        }

        private void menBtnAlerts_Click(object sender, EventArgs e)
        {
            this.Size = new Size(650, 331);
            hideAll();
            panel4.Visible = true;
            loadGroups();
        }

        private void menBtnReports_Click(object sender, EventArgs e)
        {
            this.Size = new Size(715, 460);
            hideAll();
            loadCategoriesInComboBox(comboBox1);
            panel5.Visible = true;
        }

        private void generateReportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                gen.run(ctr, (int)comboBox1.SelectedValue, int.Parse(textBox7.Text), chart1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ivalid budget format");
                return;
            }
        }

        private void exportReportBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox2.Text);
            if (comboBox2.Text == ".jpeg")
            {
                gen.exportAsPicture(chart1);
            }
            else if (comboBox2.Text == ".csv")
            {
                gen.exportCSV(ctr);
            }
            else
            {
                MessageBox.Show("Invalid export option");
            }
        }

        #endregion

        #region otherEvents
        private void lw_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadItemInTextBox();
        }

        private void catListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListView.SelectedListViewItemCollection cat = catListView.SelectedItems;
                nameCatTb.Text = cat[0].Text;
            }
            catch (Exception ex)
            {
            }
        }

        private void usersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int usrId;
            try
            {
                usrId = (int)usersList.SelectedItems[0].Tag;
            }
            catch (Exception ex)
            {
                return;
            }

            user usr = ctr.getUser(usrId);
            textBox4.Text = usr.name;
            textBox5.Text = usr.username;
            textBox6.Text = usr.pass;
            dateTimePicker1.Value = (DateTime)usr.reg_data;
            textBox8.Text = usr.welcome_msg;
            textBox9.Text = usr.no_points.ToString();
        }
        #endregion

        #region controlsManipulation
        public void initInterface()
        {
            hideAll();
            groupBox1.Visible = true;
            catListView.View = View.Details;
            catListView.Columns.Add("Name");
            catListView.Columns[0].Width = catListView.Size.Width - 5;
            panel1.Location = new Point(8, 49);
            panel2.Location = new Point(8, 49);
            panel3.Location = new Point(8, 49);
            panel4.Location = new Point(8, 49);
            panel5.Location = new Point(8, 49);
            this.MinimumSize = new Size(614, 359);
            this.Size = new Size(614, 359);
            setStateCat(false);
            setStateUsers(false);

            usersList.View = View.Details;
            usersList.Columns.Add("Name");
            usersList.Columns.Add("Username");
            usersList.Columns.Add("Registration Date");
            usersList.Columns.Add("No. Points");
            usersList.Columns.Add("Welcome Message");

            flowLayoutPanel1.AutoScroll = true;

            this.Resize += centerMenu;
        }
        private void setStateCat(bool state)
        {
            nameCatTb.Enabled = state;
            saveCategoryBtn.Enabled = state;
        }

        private void setStateUsers(bool state)
        {
            if (state == true)
            {
                editGroupsBtn.Text = "Edit Groups";
            }
            else
            {
                editGroupsBtn.Text = "Groups";
            }
            Label tmp = new Label();
            foreach (Control ct in groupBox5.Controls)
            {
                if (ct.GetType() != tmp.GetType() && ct != editGroupsBtn)
                {
                    ct.Enabled = state;
                }
            }
        }

        private void clearUserTxts()
        {
            TextBox tmp = new TextBox();
            foreach (Control ct in groupBox5.Controls)
            {
                if (ct.GetType() == tmp.GetType())
                {
                    ct.Text = "";
                }
            }
        }

        private void hideAll()
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            groupBoxPassword.Visible = false;
            groupBoxMessage.Visible = false;
            groupBox1.Visible = false;

        }

        private void initView()
        {
            lw_items.View = View.Details;
            lw_items.Columns.Add("Name");
            lw_items.Columns.Add("Points");
            lw_items.Columns.Add("Price");
            lw_items.Columns.Add("Category");
            loadItems(-1);
        }

        private void setItemTextBoxState(bool state)
        {
            Label tmp = new Label();
            foreach (Control control in groupBox2.Controls)
            {
                if (control.GetType() != tmp.GetType())
                {
                    control.Enabled = state;
                }
            }
        }

        private void clearTexts()
        {
            TextBox tmp = new TextBox();
            foreach (Control control in groupBox2.Controls)
            {
                if (control.GetType() == tmp.GetType())
                {
                    control.Text = "";
                }
            }

        }

        private void centerMenu(object obj, EventArgs e)
        {
            int span = 570;
            int c = (int)Math.Floor((this.Width - 570) / 2.6);
            menPanel.Location = new Point(c, menPanel.Location.Y);
            int lineSize = menLine.X2 - menLine.X1;
            menLine.X1 = c;
            menLine.X2 = c + lineSize;

        }

        private void resetSettingsFields()
        {
            initialTb.Text = "";
            newPassTb.Text = "";
            repPassTb.Text = "";
            messageTb.Text = sessionUser.welcome_msg;
        }
        #endregion

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

    }
}
