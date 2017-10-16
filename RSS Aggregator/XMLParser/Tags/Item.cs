using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLParser.Tags
{
    public class Item
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public string PubDate { get; set; }
        public Item(string title, string link, string description, string pubDate)
        {
            this.Title = title;
            this.Link = link;
            this.Description = description;
            this.PubDate = pubDate;
        }
        public override string ToString()
        {
            return "\nTitle: " + this.Title +
                    "\nLink: " + this.Link +
                    "\nDescription: " + this.Description +
                    "\nPublish Date: " + this.PubDate;
        }
    }
}
