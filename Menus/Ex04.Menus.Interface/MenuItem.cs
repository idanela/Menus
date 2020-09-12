using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interface
{
    internal class MenuItem
    {
        readonly string r_HeadLine;
        List<MenuItem> m_SubMenu;
        MenuItem m_PreviousItem;
        bool m_IsLeaf;

        // Constructor
        public MenuItem(string i_HeadLine, MenuItem i_previousItem, bool i_IsLeaf)
        {
            m_SubMenu = new List<MenuItem>();
            r_HeadLine = i_HeadLine;
            m_PreviousItem = i_previousItem;
            m_IsLeaf = i_IsLeaf;
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

        public MenuItem PreviousItem
        {
            get
            {
                return m_PreviousItem;
            }
        }

        public bool IsLeaf
        {
            get
            {
                return m_IsLeaf;
            }
        }

        public void AddToSubMenu(MenuItem i_MenuItemToAdd)
        {
            m_SubMenu.Add(i_MenuItemToAdd);
        }


    }
}
