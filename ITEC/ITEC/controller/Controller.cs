using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using ITEC.model;
using System.Windows.Forms;

namespace ITEC.controller
{
    public class Controller
    {
        private Model model;
        public Controller(Model model)
        {
            this.model = model;
        }

        public bool checkLogin(string username, string password)
        {
            return model.checkLogin(username, password);
        }

        public BindingList<category> getCategoriesBindingList()
        {
            BindingList<category> categories = new BindingList<category>();
            foreach (category category in model.Categories)
            {
                categories.Add(category);
            }
            return categories;
        }

        public LinkedList<ListViewItem> getItemsForListView()
        {
            return buildListViewArray(model.Items);            
        }

        public LinkedList<item> getItems()
        {
            return model.Items;
        }

        private LinkedList<ListViewItem> buildListViewArray(LinkedList<item> list) 
        {
            LinkedList<ListViewItem> items = new LinkedList<ListViewItem>();
            foreach (item it in list)
            {
                String[] itemStr = new String[2];
                itemStr[0] = it.points.ToString();
                itemStr[1] = it.price.ToString();

                ListViewItem lvItem = new ListViewItem();
                lvItem.Text = it.name;
                lvItem.Tag = it.item_id;
                lvItem.SubItems.AddRange(itemStr);
                items.AddLast(lvItem);
            }
            return items;
        }
        public LinkedList<category> getCategories() {
            return model.Categories;
        }

        public category getCategory(int catId)
        {
            return model.getCategory(catId);
        }

        public LinkedList<group> getGroups()
        {
            return model.Groups;
        }


        public LinkedList<ListViewItem> getItemsForListView(int catId)
        {
            return buildListViewArray(model.getItems(catId));
        }

        public item getItem(int itemId)
        {
            return model.getItem(itemId);
        }

        public void deleteItem(item it)
        {
            model.deleteItem(it);
        }
        
        public void deleteCategory(category cat)
        {
            model.deleteCategory(cat);
        }

        public void commitGroupUser(user usr)
        {
            model.commitGroupUsers(usr);
        }

        public void commitChanges()
        {
            model.commitChanges();
        }
        public int getMaxCatId() 
        {
            return model.getMaxCatId();
        }

        public user getUser(int usrId)
        {
            return model.getUser(usrId);
        }

        public void deleteUser(user usr)
        {
            model.deleteUser(usr);
        }

        public void addUser(user usr)
        {
            model.addUser(usr);
        }

        public int getMaxUserId()
        {
            return model.getMaxUserId();
        }

        public int getMaxItemId()
        {
            return model.getMaxItemId();
        }
        public user getSessionUser()
        {
            return model.getSessionUser();
        }

        public void addItem(item it)
        {
            model.addItem(it);
        }

        public void addCategory(category cat)
        {
            model.addCategory(cat);
        }

        public LinkedList<user> getUsers()
        {
            return model.Users;
        }

    }
}
