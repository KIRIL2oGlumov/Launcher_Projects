
namespace Launcher__
{
    partial class Ticket
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LayoutButton = new System.Windows.Forms.TableLayoutPanel();
            this.ToolTicket = new System.Windows.Forms.TableLayoutPanel();
            this.Delist = new System.Windows.Forms.Button();
            this.RSS = new System.Windows.Forms.Button();
            this.DecoreTop = new System.Windows.Forms.Panel();
            this.ToolExe = new System.Windows.Forms.TableLayoutPanel();
            this.Play = new System.Windows.Forms.Button();
            this.Folder = new System.Windows.Forms.Button();
            this.DecoreBottom = new System.Windows.Forms.Panel();
            this.TicketRss = new System.Windows.Forms.FlowLayoutPanel();
            this.TimeFeed = new System.Windows.Forms.Timer(this.components);
            this.LayoutButton.SuspendLayout();
            this.ToolTicket.SuspendLayout();
            this.ToolExe.SuspendLayout();
            this.SuspendLayout();
            // 
            // LayoutButton
            // 
            this.LayoutButton.ColumnCount = 1;
            this.LayoutButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutButton.Controls.Add(this.ToolTicket, 0, 0);
            this.LayoutButton.Controls.Add(this.ToolExe, 0, 2);
            this.LayoutButton.Controls.Add(this.TicketRss, 0, 1);
            this.LayoutButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutButton.Location = new System.Drawing.Point(0, 0);
            this.LayoutButton.Name = "LayoutButton";
            this.LayoutButton.RowCount = 3;
            this.LayoutButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.LayoutButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.LayoutButton.Size = new System.Drawing.Size(727, 586);
            this.LayoutButton.TabIndex = 0;
            // 
            // ToolTicket
            // 
            this.ToolTicket.ColumnCount = 3;
            this.ToolTicket.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ToolTicket.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.ToolTicket.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.ToolTicket.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ToolTicket.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ToolTicket.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ToolTicket.Controls.Add(this.Delist, 2, 0);
            this.ToolTicket.Controls.Add(this.RSS, 1, 0);
            this.ToolTicket.Controls.Add(this.DecoreTop, 0, 0);
            this.ToolTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolTicket.Location = new System.Drawing.Point(0, 0);
            this.ToolTicket.Margin = new System.Windows.Forms.Padding(0);
            this.ToolTicket.Name = "ToolTicket";
            this.ToolTicket.RowCount = 1;
            this.ToolTicket.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ToolTicket.Size = new System.Drawing.Size(727, 48);
            this.ToolTicket.TabIndex = 0;
            // 
            // Delist
            // 
            this.Delist.BackColor = System.Drawing.Color.White;
            this.Delist.BackgroundImage = global::Launcher__.Properties.Resources.delete_bin_96;
            this.Delist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Delist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Delist.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Delist.FlatAppearance.BorderSize = 0;
            this.Delist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Delist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.Delist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delist.Location = new System.Drawing.Point(682, 3);
            this.Delist.Name = "Delist";
            this.Delist.Size = new System.Drawing.Size(42, 42);
            this.Delist.TabIndex = 4;
            this.Delist.UseVisualStyleBackColor = false;
            this.Delist.Click += new System.EventHandler(this.Delist_Click);
            // 
            // RSS
            // 
            this.RSS.BackColor = System.Drawing.Color.White;
            this.RSS.BackgroundImage = global::Launcher__.Properties.Resources.rss_96;
            this.RSS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RSS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RSS.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.RSS.FlatAppearance.BorderSize = 0;
            this.RSS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.RSS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.RSS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RSS.Location = new System.Drawing.Point(634, 3);
            this.RSS.Name = "RSS";
            this.RSS.Size = new System.Drawing.Size(42, 42);
            this.RSS.TabIndex = 5;
            this.RSS.UseVisualStyleBackColor = false;
            this.RSS.Click += new System.EventHandler(this.RSS_Click);
            // 
            // DecoreTop
            // 
            this.DecoreTop.BackColor = System.Drawing.Color.White;
            this.DecoreTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DecoreTop.Location = new System.Drawing.Point(3, 3);
            this.DecoreTop.Name = "DecoreTop";
            this.DecoreTop.Size = new System.Drawing.Size(625, 42);
            this.DecoreTop.TabIndex = 6;
            // 
            // ToolExe
            // 
            this.ToolExe.ColumnCount = 3;
            this.ToolExe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ToolExe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.ToolExe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.ToolExe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ToolExe.Controls.Add(this.Play, 2, 0);
            this.ToolExe.Controls.Add(this.Folder, 1, 0);
            this.ToolExe.Controls.Add(this.DecoreBottom, 0, 0);
            this.ToolExe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolExe.Location = new System.Drawing.Point(0, 538);
            this.ToolExe.Margin = new System.Windows.Forms.Padding(0);
            this.ToolExe.Name = "ToolExe";
            this.ToolExe.RowCount = 1;
            this.ToolExe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ToolExe.Size = new System.Drawing.Size(727, 48);
            this.ToolExe.TabIndex = 1;
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.Color.White;
            this.Play.BackgroundImage = global::Launcher__.Properties.Resources.game_controller_96;
            this.Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Play.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Play.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Play.FlatAppearance.BorderSize = 0;
            this.Play.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Play.Location = new System.Drawing.Point(682, 3);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(42, 42);
            this.Play.TabIndex = 1;
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Folder
            // 
            this.Folder.BackColor = System.Drawing.Color.White;
            this.Folder.BackgroundImage = global::Launcher__.Properties.Resources.folder_96;
            this.Folder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Folder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Folder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Folder.FlatAppearance.BorderSize = 0;
            this.Folder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Folder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.Folder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Folder.Location = new System.Drawing.Point(634, 3);
            this.Folder.Name = "Folder";
            this.Folder.Size = new System.Drawing.Size(42, 42);
            this.Folder.TabIndex = 2;
            this.Folder.UseVisualStyleBackColor = false;
            this.Folder.Click += new System.EventHandler(this.Folder_Click);
            // 
            // DecoreBottom
            // 
            this.DecoreBottom.BackColor = System.Drawing.Color.White;
            this.DecoreBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DecoreBottom.Location = new System.Drawing.Point(3, 3);
            this.DecoreBottom.Name = "DecoreBottom";
            this.DecoreBottom.Size = new System.Drawing.Size(625, 42);
            this.DecoreBottom.TabIndex = 4;
            // 
            // TicketRss
            // 
            this.TicketRss.AutoScroll = true;
            this.TicketRss.AutoSize = true;
            this.TicketRss.BackColor = System.Drawing.Color.White;
            this.TicketRss.BackgroundImage = global::Launcher__.Properties.Resources.news_96;
            this.TicketRss.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TicketRss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TicketRss.Location = new System.Drawing.Point(3, 51);
            this.TicketRss.Name = "TicketRss";
            this.TicketRss.Size = new System.Drawing.Size(721, 484);
            this.TicketRss.TabIndex = 2;
            this.TicketRss.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.TicketRss_ControlAdded);
            this.TicketRss.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.TicketRss_ControlRemoved);
            // 
            // TimeFeed
            // 
            this.TimeFeed.Enabled = true;
            this.TimeFeed.Interval = 30000;
            this.TimeFeed.Tick += new System.EventHandler(this.TimeFeed_Tick);
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.Controls.Add(this.LayoutButton);
            this.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Name = "Ticket";
            this.Size = new System.Drawing.Size(727, 586);
            this.Load += new System.EventHandler(this.Ticket_Load);
            this.LayoutButton.ResumeLayout(false);
            this.LayoutButton.PerformLayout();
            this.ToolTicket.ResumeLayout(false);
            this.ToolExe.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel LayoutButton;
        private System.Windows.Forms.TableLayoutPanel ToolTicket;
        private System.Windows.Forms.Button Delist;
        private System.Windows.Forms.TableLayoutPanel ToolExe;
        private System.Windows.Forms.Panel DecoreBottom;
        private System.Windows.Forms.Button RSS;
        private System.Windows.Forms.Panel DecoreTop;
        public System.Windows.Forms.FlowLayoutPanel TicketRss;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Folder;
        private System.Windows.Forms.Timer TimeFeed;
    }
}
