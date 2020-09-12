using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interface
{
    public interface IMethodActivator
    {
        void CallMethod();
    }

    public interface IMenuItemListener
    {
        void MenuItemClicked();
    }

    public interface IBackOptionListener
    {
        void BackClicked();
    }

    public class MenuItem 
    {
        private readonly string r_HeadLine;
        private List<MenuItem> m_SubMenu;
        private MenuItem m_PreviousItem;
        private IMethodActivator m_MethodAction;
        private bool m_IsLeaf;

        // Constructor
        public MenuItem(string i_HeadLine)
        {
            m_SubMenu = new List<MenuItem>();
            r_HeadLine = i_HeadLine;
            m_PreviousItem = null;
            m_IsLeaf = true;
        }

        // Propetries
        public string HeadLine
        {
            get
            {
                return r_HeadLine;
            }
        }

        public List<MenuItem> SubMenu
        {
            get
            {
                return m_SubMenu;
            }
        }

        public bool IsLeaf
        {
            get
            {
                return m_IsLeaf;
            }

            set
            {
                m_IsLeaf = value;
            }
        }

        public void AddToSubMenu(params MenuItem [] i_MenuItemsToAdd)
        {
            int indexOfMenuItem = 0;
            IsLeaf = false;

            foreach (MenuItem menuItem in i_MenuItemsToAdd)
            {
                m_SubMenu.Add(menuItem);
                m_SubMenu[indexOfMenuItem].m_PreviousItem = this;
            }
        }

        public void ShowSubMenuItem()
        {
            int i = 1;

            foreach(MenuItem menuItem in m_SubMenu)
            {
                Console.WriteLine(string.Format("{0}.{1}",i,menuItem.HeadLine));
            }

            Console.WriteLine("0.Back");
        }

        public void ActiveMethod()
        {
            m_MethodAction.CallMethod();
        }

    }
}
