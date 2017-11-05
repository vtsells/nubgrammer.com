using ConfigurationManagerPlayground;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationManager.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            //  Testing an application-wide setting
            Console.WriteLine("Testing Settings.  GlobalPath setting is: \n" + Properties.Settings.Default.GlobalPath + "\n");

            //  Show what the configuration looks like before we do anything to it
            Console.WriteLine("Initial Configuration:\n");
            foreach (Item item in manager.List())
            {
                Console.WriteLine(item.ToString());
            }

            //  Building our config
            Console.WriteLine("\nAdding Items to Configuration:\n");
            for (var i = 0; i < 5; i++)
            {
                Item item = new Item("key " + i, "data for key " + i);
                try
                {
                    manager.Add(item);
                }
                catch (ConfigurationErrorsException ex)
                {
                    Console.WriteLine("Cannot Add " + item.ToString() + "\n to configuration.\n" + ex.Message + "\n");
                }
            }

            //  Testing Remove and GetSetting
            try
            {
                string key = "key 8";
                Console.WriteLine("**Removing " + key + "**");
                manager.Remove(key);
                manager.GetItem(key);
            }
            catch (ConfigurationErrorsException ex)
            {
                Console.WriteLine("Cannot find setting with key 8\n" + ex.Message + "\n");
                manager.Add(new Item("key 8", "Data replacing old value for key 8"));
            }

            //  Testing Update
            //      Changing the value for key 2
            Item oldItem = new Item("key 2", "data for key 2");
            Item newItem = new Item("key 2", "new data for key 2");
            try
            {
                manager.Update(oldItem, newItem);
            }
            catch (ConfigurationErrorsException ex)
            {
                Console.WriteLine("Cannot update item " + oldItem.ToString() + "\n" + ex.Message + "\n");
            }

            //      Changing the key and value for key 2
            oldItem = newItem;
            newItem = new Item("key 20", "Modified data for the key that used to be key 2");
            try
            {
                manager.Update(oldItem, newItem);
            }
            catch (ConfigurationErrorsException ex)
            {
                Console.WriteLine("Cannot update item " + oldItem.ToString() + "\n" + ex.Message + "\n");
            }

            //      Try changing the value of a key that doesn't exist
            oldItem = new Item("Key 700", "data for key 700");
            newItem = new Item("key 700", "Modified data for the key that used to be key 700");
            try
            {
                manager.Update(oldItem, newItem);
            }
            catch (ConfigurationErrorsException ex)
            {
                Console.WriteLine("Cannot update item " + oldItem.ToString() + "\n" + ex.Message + "\n");
            }

            //  Show us our results.  If these values are not as expected, there is an issue in the code
            Console.WriteLine("Final Configuration:\n");
            foreach (Item item in manager.List())
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
