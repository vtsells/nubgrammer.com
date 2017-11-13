using MetroFramework;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XMLParser.Tags;
namespace Aggregator_App.Classes
{
    class DisplayManager
    {
        private FeedsManager Feeds { get; }
        private WebBrowser Browser { get; }
        private MetroLabel TimeStamp { get; }
        public MetroTile SelectedTile { get; set; }
        public DisplayManager(FeedsManager feeds, WebBrowser browser, MetroLabel timeStamp)
        {
            Feeds = feeds;
            Browser = browser;
            TimeStamp = timeStamp;
        }
        public void AddTile(MetroPanel panel, MetroTile tile)
        {
            var numTiles = panel.Controls.OfType<MetroTile>().Count();
            tile.Location = new Point(numTiles * 155, 0);
            panel.Controls.Add(tile);
        }
        public MetroTile CreateTile(Feed feed)
        {
            MetroTile tile = new MetroTile();
            tile.Text = feed.Name;
            tile.Style = MetroColorStyle.Purple;
            tile.TileTextFontSize = MetroTileTextSize.Tall;
            tile.UseStyleColors = true;
            tile.Theme = MetroThemeStyle.Dark;
            tile.Tag = feed;
            tile.Click += new EventHandler(LoadFeedInBrowser);
            tile.Size = new Size(150, 100);
            return tile;
        }
        public void UpdateTiles(MetroPanel panel)
        {
            UnloadTiles(panel);
            LoadTiles(panel);
        }
        public void LoadTiles(MetroPanel panel)
        {
            foreach (Feed feed in Feeds.GetFeedsFromConfig())
            {
                var tile = CreateTile(feed);
                AddTile(panel, tile);
            }
        }
        public void UnloadTiles(MetroPanel panel)
        {
            SelectedTile = null;
            var tiles = panel.Controls.OfType<MetroTile>().ToArray();
            for (var i = tiles.Count() - 1; i >= 0; i--)
            {
                panel.Controls.Remove(tiles[i]);
                tiles[i].Dispose();
            }
            panel.AutoScrollPosition = new Point(0, 0);
        }
        private void LoadFeedInBrowser(object sender, EventArgs e)
        {
            var html = new HtmlWriter();
            var feed = (Feed)((MetroTile)sender).Tag;
            try
            {
                feed.LoadFeed();
                var feedNameTag = html.CreatePairedTag("p", "", feed.Name);
                html.AddTag(feedNameTag);

                string[] htmlCss = { "font: 15px Arial" };
                html.AddCSSRule("html", htmlCss);

                string[] wrapperCss = { "display: block", "height:400px", "overflow: auto", "border:1px solid #444", "border-radius:50px", "margin: 5px" };
                html.AddCSSRule(".wrapper", wrapperCss);

                string[] sectionCss = { "background: #333", "color: #EEE" };
                html.AddCSSRule(".section", sectionCss);

                string[] hrCss = { "height: 10px", "background: #999" };
                html.AddCSSRule("hr", hrCss);

                foreach (Item item in feed.Items)
                {
                    var pubDateTag = html.CreatePairedTag("div", "", item.PubDate);
                    var hrTag = html.CreateSingleTag("hr", "");
                    var descriptionTag = html.CreatePairedTag("p", "", item.Description);
                    var linkTag = html.CreateLink(item.Link, "", "View on Site");
                    var wrapperTag = html.CreatePairedTag("div", "wrapper", item.Title + descriptionTag);
                    var fullTag = html.CreatePairedTag("div", "section", pubDateTag + linkTag + wrapperTag + hrTag);
                    html.AddTag(fullTag);
                }
                Browser.DocumentText = html.HTML;
                var time = DateTime.Now;
                TimeStamp.Text = "Feed last pulled at " + time.ToString("t") + " on " + time.ToString("D");
                SelectedTile = (MetroTile)sender;
            }
            catch (Exception ex)
            {
                AggForm.Alert(ex.Message);
            }
        }
    }
}
