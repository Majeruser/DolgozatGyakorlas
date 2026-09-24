using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolgozatGyakorlas
{
    public class Menu
    {
        private List<MenuItem> items;
        public string Name { get; set; }
        public Menu(string name)
        {
            Name = name;
            items = new List<MenuItem>();
        }
        public void AddItem(MenuItem item)
        {
            items.Add(item);
        }
        public MenuItem FindByName(string name) {
            foreach (MenuItem item in items) { 
                if (item.Name == name)
                {
                    return item;
                }
                
            }
            return null;
        }
        public List<MenuItem> AvailabelItems()
        {
            List<MenuItem> list = new List<MenuItem>();
            foreach (MenuItem item in items)
            {
                if (item.IsAvailabel == true)
                {
                    list.Add(item);
                }
            }
            return list;
        }
    }
}
