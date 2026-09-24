using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolgozatGyakorlas
{
    public class MenuItem
    {
        public string Name { get; set; }
        public string Category { get; set; }
        private int price;
        public int Price { get { return price; } set { price = value < 0 ? 0 : value;} } 
        public bool IsAvailabel { get; set; }
        public static int Count;

        public MenuItem(string name, string cathegory, int price)
        {
            Name = name;
            Category = cathegory;
            Price =  price;
            IsAvailabel = true;
            Count++;

        }
        public void Sellout()
        {
            IsAvailabel = false;
        }
        public void Restock()
        {
            IsAvailabel = true;
        }
        public string GetDescription()
        {
            return $"{Name} -- {Category} -- {price}";
        }
    }
}
