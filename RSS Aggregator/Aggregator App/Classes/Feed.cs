using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XMLParser;
using XMLParser.Tags;

namespace Aggregator_App.Classes
{
    class Feed
    {
        public string Name { get; set; }
        public string URL { get; set; }
        public Channel Channel { get; set; }
        public List<Item> Items { get; set; }
        public string LastBuildDate { get; set; }
        private Parser RSSParser { get; set; }
        public Feed(string name, string url)
        {
            Name = name;
            URL = url;
        }
        public void LoadFeed()
        {
            try
            {
                RSSParser = new Parser(URL);
            }
            catch (Exception)
            {
                throw new InvalidFeedException("Feed URL was not valid");
            }
            MapToParser();
        }
        public override string ToString()
        {
            return Name;
        }
        public void UpdateFeed()
        {
            LoadFeed();
        }
        private void MapToParser()
        {
            Channel = RSSParser.RSSChannel;
            Items = RSSParser.Items;
            LastBuildDate = RSSParser.RSSChannel.BuildDate;
        }
    }
}
