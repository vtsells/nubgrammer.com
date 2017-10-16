﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XMLParser.Tags;

namespace XMLParser
{
    public class Parser
    {
        public Channel RSSChannel { get; set; }
        public List<Item> Items { get; set; }
        private XDocument doc;
        public Parser(string RSSFeedURL)
        {
            this.doc = XDocument.Load(RSSFeedURL);
            this.RSSChannel = this.CreateChannel();
            this.Items = this.CreateItems();
        }
        private Channel CreateChannel()
        {
            string title = (from c in doc.Root.Descendants("channel")
                            select c.Element("title").Value).FirstOrDefault();
            string link = (from c in doc.Root.Descendants("channel")
                           select c.Element("link").Value).FirstOrDefault();
            string description = (from c in doc.Root.Descendants("channel")
                                  select c.Element("description").Value).FirstOrDefault();
            string buildDate;
            try
            {
                buildDate = (from c in doc.Root.Descendants("channel")
                             select c.Element("lastBuildDate").Value).FirstOrDefault();
            }
            catch (Exception ex)
            {
                buildDate = "Not Available";
            }
            return new Channel(title, link, description, buildDate);
        }
        private List<Item> CreateItems()
        {
            List<XElement> itemTags = doc.Root.Element("channel").Elements("item").ToList();
            List<Item> items = new List<Item>();
            foreach (XElement item in itemTags)
            {
                string title = item.Element("title").Value;
                string link = item.Element("link").Value;
                string description = item.Element("description").Value;
                string modifiedDescription = description.Replace("src=\"//", "src=\"http://");
                string pubDate = item.Element("pubDate").Value;
                items.Add(new Item(title, link, modifiedDescription, pubDate));
            }
            return items;
        }
        public override string ToString()
        {
            string output = "";
            output += this.RSSChannel.ToString();
            foreach(Item item in this.Items)
            {
                output += item.ToString();
            }
            return output;
        }
    }
}
