using Aggregator_App.Classes;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aggregator_App
{
    public partial class AggForm : MetroForm
    {
        private FeedsManager feedsManager;
        public AggForm()
        {
            InitializeComponent();
            LoadApp();
        }
        public void LoadApp()
        {
            feedsManager = new FeedsManager();
            LoadListBox(ltb_feeds, this.feedsManager.Feeds.ToArray());
        }
        private void btn_add_feed_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tb_easy_name.Text) &&
               !string.IsNullOrWhiteSpace(tb_feed_url.Text))
            {
                try
                {
                    Feed feed = new Feed(tb_easy_name.Text, tb_feed_url.Text);
                    feedsManager.AddFeedToConfig(feed);
                    AddItemToListBox(ltb_feeds, feed);
                }
                catch (ConfigurationErrorsException ex)
                {
                    Alert(ex.Message);
                }
            }
            else
            {
                string prompt = "Please enter a name and URL for the new feed";
                MetroMessageBox.Show(this, prompt, "Add New Feed", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void btn_edit_selected_feed_Click(object sender, EventArgs e)
        {
            string prompt = "Are you sure you want to edit the selected feed(s)?";
            if (feedsManager.SelectedFeed != null &&
                ltb_feeds.SelectedItem != null &&
                MetroMessageBox.Show(this, prompt, "Edit Feed", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    feedsManager.UpdateFeedInConfig(feedsManager.SelectedFeed, new Feed(tb_selected_feed.Text, tb_selected_feed_url.Text));
                    UpdateItemInListBox(ltb_feeds, feedsManager.SelectedFeed, new Feed(tb_selected_feed.Text, tb_selected_feed_url.Text));
                }
                catch (ConfigurationErrorsException ex)
                {
                    Alert(ex.Message);
                }
                
            }
        }

        private void btn_delete_selected_feed_Click(object sender, EventArgs e)
        {
            string prompt = "Are you sure you want to delete the selected feed(s)?";
            if (ltb_feeds.SelectedItems.Count > 0 &&
                MetroMessageBox.Show(this, prompt, "Delete Feed", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = ltb_feeds.SelectedItems.Count - 1; i >= 0; i--)
                {
                    try
                    {
                        feedsManager.RemoveFeedFromConfig(((Feed)ltb_feeds.SelectedItems[i]).Name);
                        RemoveItemFromListBox(ltb_feeds, (Feed)ltb_feeds.SelectedItems[i]);
                    }
                    catch (ConfigurationErrorsException ex)
                    {
                        Alert(ex.Message);
                        continue;
                    }
                }
            }
        }
        private void LoadListBox(ListBox listBox, object[] items)
        {
            foreach (object item in items)
            {
                AddItemToListBox(listBox, item);
            }
        }
        private void AddItemToListBox(ListBox listBox, object item)
        {
            listBox.Items.Add(item);
        }
        private void RemoveItemFromListBox(ListBox listBox, object item)
        {
            listBox.Items.Remove(item);
        }
        private void UpdateItemInListBox(ListBox listBox, object oldItem, object newItem)
        {
            listBox.Items[listBox.Items.IndexOf(oldItem)] = newItem;
        }
        public static void Alert(string message)
        {
            MessageBox.Show(message);
        }

        private void ltb_feeds_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltb_feeds.SelectedItem != null)
            {
                feedsManager.SelectedFeed = ((Feed)ltb_feeds.SelectedItem);
                tb_selected_feed.Text = feedsManager.SelectedFeed.Name;
                tb_selected_feed_url.Text = feedsManager.SelectedFeed.URL;
            }
            else
            {
                tb_selected_feed.Text = "";
                tb_selected_feed_url.Text = "";
            }
        }
    }
}
