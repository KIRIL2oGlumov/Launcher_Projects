using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;
using CodeHollow.FeedReader;
using System.Diagnostics;

namespace Launcher__
{
    public partial class Ticket : UserControl
    {
        public Ticket()
        {
            InitializeComponent();
        }
        public (string, string) pathrss;

        // Show
        private void Ticket_Load(object sender, EventArgs e)
        {
            try
            {
                Icon icon = Icon.ExtractAssociatedIcon(pathrss.Item1);
                Bitmap bitmap = icon.ToBitmap();
                Play.BackgroundImage = bitmap;
                _Rss(pathrss.Item2);
            }
            catch { }
        }

        //Tools
        private void Delist_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void RSS_Click(object sender, EventArgs e)
        {
            RssAddress rssAddress = new RssAddress();
            if (rssAddress.ShowDialog() == DialogResult.OK)
            {
                pathrss.Item2 = rssAddress.TextAddress.Text;
                _Rss(pathrss.Item2);
            }
        }

        private void Folder_Click(object sender, EventArgs e)
        {
            DirectoryInfo directory = new DirectoryInfo(pathrss.Item1);
            FolderUserControl userControl = new FolderUserControl();
            userControl.DirInfo.Navigate(@directory.Parent.FullName);
            userControl.Show();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            try { Process.Start(pathrss.Item1); }
            catch { Dispose(); }
        }

        //Rss
        public async void _Rss(string Url)
        {
            try
            {
                if (TicketRss.Controls.Count == 0)
                {
                    var feed = await FeedReader.ReadAsync(Url);
                    foreach (var item in feed.Items)
                    {
                        _Add(item.Link, item.Title, false);
                    };
                }
                else
                {
                    var update = await FeedReader.ReadAsync(Url);
                    foreach (var item in update.Items)
                    {
                        if (item.Link == TicketRss.Controls[0].Name)
                        {
                            break;
                        }
                        else
                        {
                            _Add(item.Link, item.Title, true);
                            break;
                        }
                    };
                }
                pathrss.Item2 = Url;
            }
            catch
            {
                pathrss.Item2 = null;
                TicketRss.Controls.Clear();
            }
            finally
            {
                if (string.IsNullOrEmpty(pathrss.Item2))
                {
                    pathrss.Item2 = null;
                    TicketRss.Controls.Clear();
                }
            }
        }

        private void _Add(string link, string title, bool up)
        {
            Button button = new Button()
            {
                BackColor = Color.White,
                Size = new Size(225, 200),
                Text = title,
                ImageAlign = ContentAlignment.MiddleCenter,
                TextAlign = ContentAlignment.BottomCenter,
                FlatStyle = FlatStyle.Flat,
                Name = link,
            };

            button.FlatAppearance.BorderColor = Color.White;
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseDownBackColor = Color.White;
            button.FlatAppearance.MouseOverBackColor = Color.LightBlue;
            button.MouseEnter += Button_MouseEnter;
            button.Click += Button_Click;

            if (up == false)
            {
                button.Image = Properties.Resources.news_96;
                TicketRss.Controls.Add(button);
            }
            else
            {
                button.Image = Properties.Resources.newspaper_96;
                TicketRss.Controls.Add(button);
                TicketRss.Controls.SetChildIndex(button, 0);
            }
            TicketRss.ResumeLayout();
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.Image = Properties.Resources.news_96;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Process.Start(button.Name);
        }

        //Control change
        private void TicketRss_ControlAdded(object sender, ControlEventArgs e) => ControlChange(TicketRss, e);
        private void TicketRss_ControlRemoved(object sender, ControlEventArgs e) => ControlChange(TicketRss, e);
      
        internal void ControlChange(object seander, ControlEventArgs e)
        {
            FlowLayoutPanel flowLayout = seander as FlowLayoutPanel;
            if (flowLayout.Controls.Count == 0)
            {
                flowLayout.BackColor = Color.White;
                flowLayout.BackgroundImage = Properties.Resources.news_96;
            }
            else
            {
                flowLayout.BackColor = Color.LavenderBlush;
                flowLayout.BackgroundImage = null;
            }
        }

        //Time Event
        private void TimeFeed_Tick(object sender, EventArgs e)
        {
            _Rss(pathrss.Item2);
        }
    }
}
