using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationManagerPlayground
{
    public class Manager
    {
        public Manager()
        {
            Console.WriteLine("I was initiated");
        }
        public void Add(Item item)
        {
            if (IsUnique(item.Key))
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = config.AppSettings.Settings;
                settings.Add(item.Key, item.Data);
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
            }
            else
            {
                throw new ConfigurationErrorsException("Item Key: " + item.Key + " is not unique");
            }
        }
        public void Remove(string key)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = config.AppSettings.Settings;
            if (settings[key] != null)
            {
                settings.Remove(key);
            }
            else
            {
                throw new ConfigurationErrorsException(key + " does not exist or can't be read");
            }
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
        }
        public void Update(Item oldItem, Item newItem)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = config.AppSettings.Settings;
            if (settings[oldItem.Key] == null)
            {
                throw new ConfigurationErrorsException("Cannot Update item " + oldItem.Key + " because it doesn't exist or can't be read");
            }
            else if (oldItem.Key != newItem.Key)
            {
                Remove(oldItem.Key);
                Add(newItem);

            }
            else
            {
                settings[oldItem.Key].Value = newItem.Data;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
            }
        }
        public List<Item> List()
        {
            var items = new List<Item>();
            var AppSettings = ConfigurationManager.AppSettings;
            foreach (var key in AppSettings.AllKeys)
            {
                var item = new Item(key, AppSettings[key]);
                items.Add(item);
            }
            return items;
        }
        public Item GetItem(string key)
        {
            var appSettings = ConfigurationManager.AppSettings;
            if (appSettings[key] != null)
            {
                return new Item(key, appSettings[key]);
            }
            else
            {
                throw new ConfigurationErrorsException("The setting with key " + key + " does not exist or can't be read");
            }
        }
        private bool IsUnique(string key)
        {
            if (ConfigurationManager.AppSettings[key] == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public class Item
    {
        public string Key { get; }
        public string Data { get; }
        public Item(string key, string data)
        {
            this.Key = key;
            this.Data = data;
        }
        public override string ToString()
        {
            return "Key: " + this.Key + ", Data: " + this.Data;
        }
    }
}
