using System.Security.Cryptography.X509Certificates;

namespace DolgozatGyakorlas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuItem a = new MenuItem("leves", "etel", 100);
            MenuItem b = new MenuItem("chupichups", "drionk", 1000);

            ConsoleView view = new ConsoleView();
            view.ShowItem(a);
            view.ShowItem(b);

            MenuItem c = new MenuItem("a", "aa", 100);
            MenuItem d = new MenuItem("d", "dd", 200);
            MenuItem e = new MenuItem("e", "ee", 300);
            List<MenuItem> itemss = new List<MenuItem>();
            itemss.Add(a);
            itemss.Add(b);
            itemss.Add(c);
            itemss.Add(d);
            itemss.Add(e);
            view.showItems(itemss);
            view.ShowMessage(MenuItem.Count.ToString());
            Menu menu = new Menu("kw");
            menu.AddItem(a);
            menu.AddItem(b);
            menu.AddItem(c);
            menu.AddItem(d);
            menu.AddItem(e);
            if (menu.FindByName("b") != null) 
            {
                view.ShowItem(menu.FindByName("b"));
            }
            else
            {
                view.ShowMessage("nincs ilyen elem");
            }
            
                

           

        }
    }
}
