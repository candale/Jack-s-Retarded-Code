using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITEC.model
{
    public class Model
    {
        private ITECEntities ent = new ITECEntities();
        public Model()
        {
            ent.Configuration.ValidateOnSaveEnabled = true;
        }

        public void commitGroupUsers(user usr)
        {
            foreach (group gr in usr.groups)
            {
                ent.Database.ExecuteSqlCommand("insert into user_groups values ({0}, {0})", usr.usr_id, gr.gr_id);
                ent.SaveChanges();
            }
        }

        public int getMaxItemId()
        {
            return ((item)ent.items.SqlQuery("select * from items where item_id = (select max(item_id) from items)").FirstOrDefault()).item_id;
        }

        public int getMaxUserId()
        {
            return ((user)ent.users.SqlQuery("select * from users where usr_id = (select max(usr_id) from users)").FirstOrDefault()).usr_id;
        }

        public int getMaxCatId()
        {
            return ((category)ent.categories.SqlQuery("select * from categories where cat_id = (select max(cat_id) from categories)").FirstOrDefault()).cat_id;
        }

        public bool checkLogin(string username, string pass)
        {
            user usr = null;
            try
            {
                usr = ent.users.First(e => e.username == username && e.pass == pass);
                Context.User = usr;
                return true;
            }
            catch (InvalidOperationException e)
            {
                return false;
            }
        }

        public LinkedList<user> Users
        {
            get
            {
                LinkedList<user> users = new LinkedList<user>();
                foreach (user usr in ent.Set<user>())
                {
                    users.AddLast(usr);
                }
                return users;
            }
        }

        public void addUser(user usr)
        {
            ent.users.Add(usr);
        }

        public void deleteUser(user usr)
        {
            ent.users.Remove(usr);
        }

        public user getUser(int usrId)
        {
            try
            {
                return ent.users.First(e => e.usr_id == usrId);
            }
            catch (InvalidOperationException e)
            {
                return null;
            }
        }

        public LinkedList<category> Categories
        {
            get
            {
                LinkedList<category> categories = new LinkedList<category>();
                foreach (category cat in ent.Set<category>())
                {
                    categories.AddLast(cat);
                }
                return categories;
            }
        }

        public LinkedList<item> Items
        {
            get
            {
                LinkedList<item> items = new LinkedList<item>();
                foreach (item it in ent.Set<item>())
                {
                    items.AddLast(it);
                }
                return items;
            }
        }

        public LinkedList<group> Groups
        {
            get
            {
                LinkedList<group> groups = new LinkedList<group>();
                foreach (group gr in ent.Set<group>())
                {
                    groups.AddLast(gr);
                }
                return groups;
            }
        }

        public LinkedList<item> getItems(int catId) {
            LinkedList<item> items = new LinkedList<item>();
            foreach (item it in ent.items.SqlQuery("select * from items where items.cat_id = {0}", catId))
            {
                items.AddLast(it);
            }
            return items;
        }

        public category getCategory(int catId)
        {
            try
            {
                return ent.categories.First(e => e.cat_id == catId);
            }
            catch (InvalidOperationException e)
            {
                return null;
            }
        }

        public void addItem(item it)
        {
            ent.items.Add(it);
        }

        public void addCategory(category cat)
        {
            ent.categories.Add(cat);
        }

        public item getItem(int itemId)
        {
            try
            {
                return ent.items.First(e => e.item_id == itemId);
            }
            catch (InvalidOperationException e)
            {
                return null;
            }
        }

        public void deleteItem(item it)
        {
            ent.items.Remove(it);
        }

        public void deleteCategory(category cat)
        {
            ent.categories.Remove(cat);
        }

        public void commitChanges()
        {
            try
            {
                ent.SaveChanges();
            }
            catch (Exception e)
            {
                String a = e.Message;
            }
        }

        public user getSessionUser()
        {
            return Context.User;
        }
    }
}
