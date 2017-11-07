using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregator_App.Classes
{
    class FeedsManager
    {
        public List<Feed> Feeds { get; set; }
        public Feed SelectedFeed { get; set; }
        public FeedsManager()
        {
            Feeds = GetFeedsFromConfig();
        }
        public void AddFeedToConfig(Feed feed)
        {
            if (IsUnique(feed.Name))
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = config.AppSettings.Settings;
                settings.Add(feed.Name, feed.URL);
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
            }
            else
            {
                throw new ConfigurationErrorsException("Feed name must be unique");
            }
        }
        public void RemoveFeedFromConfig(string key)
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
        public void UpdateFeedInConfig(Feed oldFeed, Feed newFeed)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = config.AppSettings.Settings;
            if (settings[oldFeed.Name] == null)
            {
                throw new ConfigurationErrorsException("Cannot Update item " + oldFeed.Name + " because it doesn't exist or can't be read");
            }
            else if (oldFeed.Name != newFeed.Name)
            {
                AddFeedToConfig(newFeed);
                RemoveFeedFromConfig(oldFeed.Name);
            }
            else
            {
                settings[oldFeed.Name].Value = newFeed.URL;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
            }
        }
        public List<Feed> GetFeedsFromConfig()
        {
            var feeds = new List<Feed>();
            var AppSettings = ConfigurationManager.AppSettings;
            foreach (var key in AppSettings.AllKeys)
            {
                Feed feed = new Feed(key, AppSettings[key]);
                feeds.Add(feed);
            }
            return feeds;
        }
        public Feed GetFeed(string name)
        {
            var appSettings = ConfigurationManager.AppSettings;
            if (appSettings[name] != null)
            {
                return new Feed(name, appSettings[name]);
            }
            else
            {
                throw new ConfigurationErrorsException("The setting with key " + name + " does not exist or can't be read");
            }
        }
        public bool IsUnique(string key)
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
}
