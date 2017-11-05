namespace Aggregator_App
{
    partial class AggForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AggForm));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.lb_last_updated_at = new MetroFramework.Controls.MetroLabel();
            this.btn_update_news = new MetroFramework.Controls.MetroButton();
            this.wb_display = new System.Windows.Forms.WebBrowser();
            this.pn_tiles = new MetroFramework.Controls.MetroPanel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.btn_add_feed = new MetroFramework.Controls.MetroButton();
            this.btn_delete_selected_feed = new MetroFramework.Controls.MetroButton();
            this.btn_edit_selected_feed = new MetroFramework.Controls.MetroButton();
            this.tb_selected_feed_url = new MetroFramework.Controls.MetroTextBox();
            this.lb_selected_feed_url = new MetroFramework.Controls.MetroLabel();
            this.tb_selected_feed = new MetroFramework.Controls.MetroTextBox();
            this.lb_selected_feed_name = new MetroFramework.Controls.MetroLabel();
            this.ltb_feeds = new System.Windows.Forms.ListBox();
            this.tb_feed_url = new MetroFramework.Controls.MetroTextBox();
            this.lb_feed_url = new MetroFramework.Controls.MetroLabel();
            this.tb_easy_name = new MetroFramework.Controls.MetroTextBox();
            this.lb_easy_name = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(704, 590);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.lb_last_updated_at);
            this.metroTabPage1.Controls.Add(this.btn_update_news);
            this.metroTabPage1.Controls.Add(this.wb_display);
            this.metroTabPage1.Controls.Add(this.pn_tiles);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(696, 548);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "News";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // lb_last_updated_at
            // 
            this.lb_last_updated_at.AutoSize = true;
            this.lb_last_updated_at.Location = new System.Drawing.Point(0, 102);
            this.lb_last_updated_at.Name = "lb_last_updated_at";
            this.lb_last_updated_at.Size = new System.Drawing.Size(103, 19);
            this.lb_last_updated_at.TabIndex = 5;
            this.lb_last_updated_at.Text = "Last Updated At";
            // 
            // btn_update_news
            // 
            this.btn_update_news.AutoSize = true;
            this.btn_update_news.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_update_news.Location = new System.Drawing.Point(0, 525);
            this.btn_update_news.Name = "btn_update_news";
            this.btn_update_news.Size = new System.Drawing.Size(696, 23);
            this.btn_update_news.TabIndex = 4;
            this.btn_update_news.Text = "Update News";
            this.btn_update_news.UseSelectable = true;
            // 
            // wb_display
            // 
            this.wb_display.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wb_display.Location = new System.Drawing.Point(4, 127);
            this.wb_display.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb_display.Name = "wb_display";
            this.wb_display.Size = new System.Drawing.Size(689, 385);
            this.wb_display.TabIndex = 3;
            // 
            // pn_tiles
            // 
            this.pn_tiles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_tiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_tiles.HorizontalScrollbarBarColor = true;
            this.pn_tiles.HorizontalScrollbarHighlightOnWheel = false;
            this.pn_tiles.HorizontalScrollbarSize = 10;
            this.pn_tiles.Location = new System.Drawing.Point(0, 0);
            this.pn_tiles.Name = "pn_tiles";
            this.pn_tiles.Size = new System.Drawing.Size(696, 100);
            this.pn_tiles.TabIndex = 2;
            this.pn_tiles.VerticalScrollbarBarColor = true;
            this.pn_tiles.VerticalScrollbarHighlightOnWheel = false;
            this.pn_tiles.VerticalScrollbarSize = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.btn_add_feed);
            this.metroTabPage2.Controls.Add(this.btn_delete_selected_feed);
            this.metroTabPage2.Controls.Add(this.btn_edit_selected_feed);
            this.metroTabPage2.Controls.Add(this.tb_selected_feed_url);
            this.metroTabPage2.Controls.Add(this.lb_selected_feed_url);
            this.metroTabPage2.Controls.Add(this.tb_selected_feed);
            this.metroTabPage2.Controls.Add(this.lb_selected_feed_name);
            this.metroTabPage2.Controls.Add(this.ltb_feeds);
            this.metroTabPage2.Controls.Add(this.tb_feed_url);
            this.metroTabPage2.Controls.Add(this.lb_feed_url);
            this.metroTabPage2.Controls.Add(this.tb_easy_name);
            this.metroTabPage2.Controls.Add(this.lb_easy_name);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(696, 548);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Feeds";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // btn_add_feed
            // 
            this.btn_add_feed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_feed.Location = new System.Drawing.Point(3, 105);
            this.btn_add_feed.Name = "btn_add_feed";
            this.btn_add_feed.Size = new System.Drawing.Size(689, 23);
            this.btn_add_feed.TabIndex = 6;
            this.btn_add_feed.Text = "Add New Feed";
            this.btn_add_feed.UseSelectable = true;
            // 
            // btn_delete_selected_feed
            // 
            this.btn_delete_selected_feed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete_selected_feed.Location = new System.Drawing.Point(3, 518);
            this.btn_delete_selected_feed.Name = "btn_delete_selected_feed";
            this.btn_delete_selected_feed.Size = new System.Drawing.Size(689, 23);
            this.btn_delete_selected_feed.TabIndex = 13;
            this.btn_delete_selected_feed.Text = "Delete Selected Feed";
            this.btn_delete_selected_feed.UseSelectable = true;
            // 
            // btn_edit_selected_feed
            // 
            this.btn_edit_selected_feed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_edit_selected_feed.Location = new System.Drawing.Point(3, 489);
            this.btn_edit_selected_feed.Name = "btn_edit_selected_feed";
            this.btn_edit_selected_feed.Size = new System.Drawing.Size(689, 23);
            this.btn_edit_selected_feed.TabIndex = 12;
            this.btn_edit_selected_feed.Text = "Edit Selected Feed";
            this.btn_edit_selected_feed.UseSelectable = true;
            // 
            // tb_selected_feed_url
            // 
            this.tb_selected_feed_url.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tb_selected_feed_url.CustomButton.Image = null;
            this.tb_selected_feed_url.CustomButton.Location = new System.Drawing.Point(667, 1);
            this.tb_selected_feed_url.CustomButton.Name = "";
            this.tb_selected_feed_url.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_selected_feed_url.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_selected_feed_url.CustomButton.TabIndex = 1;
            this.tb_selected_feed_url.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_selected_feed_url.CustomButton.UseSelectable = true;
            this.tb_selected_feed_url.CustomButton.Visible = false;
            this.tb_selected_feed_url.Lines = new string[0];
            this.tb_selected_feed_url.Location = new System.Drawing.Point(3, 459);
            this.tb_selected_feed_url.MaxLength = 32767;
            this.tb_selected_feed_url.Name = "tb_selected_feed_url";
            this.tb_selected_feed_url.PasswordChar = '\0';
            this.tb_selected_feed_url.PromptText = "URL of Selected Feed";
            this.tb_selected_feed_url.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_selected_feed_url.SelectedText = "";
            this.tb_selected_feed_url.SelectionLength = 0;
            this.tb_selected_feed_url.SelectionStart = 0;
            this.tb_selected_feed_url.ShortcutsEnabled = true;
            this.tb_selected_feed_url.Size = new System.Drawing.Size(689, 23);
            this.tb_selected_feed_url.TabIndex = 11;
            this.tb_selected_feed_url.UseSelectable = true;
            this.tb_selected_feed_url.WaterMark = "URL of Selected Feed";
            this.tb_selected_feed_url.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_selected_feed_url.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lb_selected_feed_url
            // 
            this.lb_selected_feed_url.AutoSize = true;
            this.lb_selected_feed_url.Location = new System.Drawing.Point(3, 436);
            this.lb_selected_feed_url.Name = "lb_selected_feed_url";
            this.lb_selected_feed_url.Size = new System.Drawing.Size(121, 19);
            this.lb_selected_feed_url.TabIndex = 10;
            this.lb_selected_feed_url.Text = "Selected Feed URL:";
            // 
            // tb_selected_feed
            // 
            this.tb_selected_feed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tb_selected_feed.CustomButton.Image = null;
            this.tb_selected_feed.CustomButton.Location = new System.Drawing.Point(667, 1);
            this.tb_selected_feed.CustomButton.Name = "";
            this.tb_selected_feed.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_selected_feed.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_selected_feed.CustomButton.TabIndex = 1;
            this.tb_selected_feed.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_selected_feed.CustomButton.UseSelectable = true;
            this.tb_selected_feed.CustomButton.Visible = false;
            this.tb_selected_feed.Lines = new string[0];
            this.tb_selected_feed.Location = new System.Drawing.Point(3, 410);
            this.tb_selected_feed.MaxLength = 32767;
            this.tb_selected_feed.Name = "tb_selected_feed";
            this.tb_selected_feed.PasswordChar = '\0';
            this.tb_selected_feed.PromptText = "Name of Selected Feed";
            this.tb_selected_feed.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_selected_feed.SelectedText = "";
            this.tb_selected_feed.SelectionLength = 0;
            this.tb_selected_feed.SelectionStart = 0;
            this.tb_selected_feed.ShortcutsEnabled = true;
            this.tb_selected_feed.Size = new System.Drawing.Size(689, 23);
            this.tb_selected_feed.TabIndex = 9;
            this.tb_selected_feed.UseSelectable = true;
            this.tb_selected_feed.WaterMark = "Name of Selected Feed";
            this.tb_selected_feed.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_selected_feed.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lb_selected_feed_name
            // 
            this.lb_selected_feed_name.AutoSize = true;
            this.lb_selected_feed_name.Location = new System.Drawing.Point(3, 387);
            this.lb_selected_feed_name.Name = "lb_selected_feed_name";
            this.lb_selected_feed_name.Size = new System.Drawing.Size(134, 19);
            this.lb_selected_feed_name.TabIndex = 8;
            this.lb_selected_feed_name.Text = "Selected Feed Name:";
            // 
            // ltb_feeds
            // 
            this.ltb_feeds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ltb_feeds.FormattingEnabled = true;
            this.ltb_feeds.Location = new System.Drawing.Point(3, 134);
            this.ltb_feeds.Name = "ltb_feeds";
            this.ltb_feeds.Size = new System.Drawing.Size(689, 251);
            this.ltb_feeds.TabIndex = 7;
            // 
            // tb_feed_url
            // 
            this.tb_feed_url.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tb_feed_url.CustomButton.Image = null;
            this.tb_feed_url.CustomButton.Location = new System.Drawing.Point(667, 1);
            this.tb_feed_url.CustomButton.Name = "";
            this.tb_feed_url.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_feed_url.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_feed_url.CustomButton.TabIndex = 1;
            this.tb_feed_url.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_feed_url.CustomButton.UseSelectable = true;
            this.tb_feed_url.CustomButton.Visible = false;
            this.tb_feed_url.Lines = new string[0];
            this.tb_feed_url.Location = new System.Drawing.Point(3, 76);
            this.tb_feed_url.MaxLength = 32767;
            this.tb_feed_url.Name = "tb_feed_url";
            this.tb_feed_url.PasswordChar = '\0';
            this.tb_feed_url.PromptText = "New Feed URL";
            this.tb_feed_url.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_feed_url.SelectedText = "";
            this.tb_feed_url.SelectionLength = 0;
            this.tb_feed_url.SelectionStart = 0;
            this.tb_feed_url.ShortcutsEnabled = true;
            this.tb_feed_url.Size = new System.Drawing.Size(689, 23);
            this.tb_feed_url.TabIndex = 5;
            this.tb_feed_url.UseSelectable = true;
            this.tb_feed_url.WaterMark = "New Feed URL";
            this.tb_feed_url.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_feed_url.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lb_feed_url
            // 
            this.lb_feed_url.AutoSize = true;
            this.lb_feed_url.Location = new System.Drawing.Point(3, 53);
            this.lb_feed_url.Name = "lb_feed_url";
            this.lb_feed_url.Size = new System.Drawing.Size(68, 19);
            this.lb_feed_url.TabIndex = 4;
            this.lb_feed_url.Text = "Feed URL:";
            // 
            // tb_easy_name
            // 
            this.tb_easy_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tb_easy_name.CustomButton.Image = null;
            this.tb_easy_name.CustomButton.Location = new System.Drawing.Point(667, 1);
            this.tb_easy_name.CustomButton.Name = "";
            this.tb_easy_name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_easy_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_easy_name.CustomButton.TabIndex = 1;
            this.tb_easy_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_easy_name.CustomButton.UseSelectable = true;
            this.tb_easy_name.CustomButton.Visible = false;
            this.tb_easy_name.Lines = new string[0];
            this.tb_easy_name.Location = new System.Drawing.Point(3, 27);
            this.tb_easy_name.MaxLength = 32767;
            this.tb_easy_name.Name = "tb_easy_name";
            this.tb_easy_name.PasswordChar = '\0';
            this.tb_easy_name.PromptText = "Easy Name for New Feed";
            this.tb_easy_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_easy_name.SelectedText = "";
            this.tb_easy_name.SelectionLength = 0;
            this.tb_easy_name.SelectionStart = 0;
            this.tb_easy_name.ShortcutsEnabled = true;
            this.tb_easy_name.Size = new System.Drawing.Size(689, 23);
            this.tb_easy_name.TabIndex = 3;
            this.tb_easy_name.UseSelectable = true;
            this.tb_easy_name.WaterMark = "Easy Name for New Feed";
            this.tb_easy_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_easy_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lb_easy_name
            // 
            this.lb_easy_name.AutoSize = true;
            this.lb_easy_name.Location = new System.Drawing.Point(3, 4);
            this.lb_easy_name.Name = "lb_easy_name";
            this.lb_easy_name.Size = new System.Drawing.Size(77, 19);
            this.lb_easy_name.TabIndex = 2;
            this.lb_easy_name.Text = "Easy Name:";
            // 
            // AggForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 670);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AggForm";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "News Feed";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroButton btn_update_news;
        private System.Windows.Forms.WebBrowser wb_display;
        private MetroFramework.Controls.MetroPanel pn_tiles;
        private MetroFramework.Controls.MetroLabel lb_last_updated_at;
        private MetroFramework.Controls.MetroButton btn_add_feed;
        private MetroFramework.Controls.MetroButton btn_delete_selected_feed;
        private MetroFramework.Controls.MetroButton btn_edit_selected_feed;
        private MetroFramework.Controls.MetroTextBox tb_selected_feed_url;
        private MetroFramework.Controls.MetroLabel lb_selected_feed_url;
        private MetroFramework.Controls.MetroTextBox tb_selected_feed;
        private MetroFramework.Controls.MetroLabel lb_selected_feed_name;
        private System.Windows.Forms.ListBox ltb_feeds;
        private MetroFramework.Controls.MetroTextBox tb_feed_url;
        private MetroFramework.Controls.MetroLabel lb_feed_url;
        private MetroFramework.Controls.MetroTextBox tb_easy_name;
        private MetroFramework.Controls.MetroLabel lb_easy_name;
    }
}

