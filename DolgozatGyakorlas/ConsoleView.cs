using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolgozatGyakorlas
{
    public class ConsoleView
    {
        public void ShowItem (MenuItem item)
        {
            Console.WriteLine(item.GetDescription());
        }
        public void ShowMessage(string mes)
        {
            Console.WriteLine(mes);
        }
        public void showItems(List<MenuItem>items)
        {
            foreach (MenuItem item in items)
            {
                Console.WriteLine(item.GetDescription());
            }
        }
    }
}
