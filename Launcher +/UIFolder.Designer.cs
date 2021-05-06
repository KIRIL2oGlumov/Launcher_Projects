
using System;
using System.Windows.Forms;

namespace Launcher__
{
    partial class FolderUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FolderUserControl));
            this.FolderLayout = new System.Windows.Forms.TableLayoutPanel();
            this.DecoreRight = new System.Windows.Forms.Panel();
            this.CloseD = new System.Windows.Forms.Button();
            this.DirInfo = new System.Windows.Forms.WebBrowser();
            this.ForwardDir = new System.Windows.Forms.Button();
            this.BackDir = new System.Windows.Forms.Button();
            this.FolderLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // FolderLayout
            // 
            this.FolderLayout.ColumnCount = 2;
            this.FolderLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FolderLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.FolderLayout.Controls.Add(this.DecoreRight, 1, 3);
            this.FolderLayout.Controls.Add(this.CloseD, 1, 0);
            this.FolderLayout.Controls.Add(this.DirInfo, 0, 0);
            this.FolderLayout.Controls.Add(this.ForwardDir, 1, 1);
            this.FolderLayout.Controls.Add(this.BackDir, 1, 2);
            this.FolderLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FolderLayout.Location = new System.Drawing.Point(0, 0);
            this.FolderLayout.Margin = new System.Windows.Forms.Padding(0);
            this.FolderLayout.Name = "FolderLayout";
            this.FolderLayout.RowCount = 4;
            this.FolderLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.FolderLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.FolderLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.FolderLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FolderLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.FolderLayout.Size = new System.Drawing.Size(584, 461);
            this.FolderLayout.TabIndex = 0;
            // 
            // DecoreRight
            // 
            this.DecoreRight.BackColor = System.Drawing.Color.White;
            this.DecoreRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DecoreRight.Location = new System.Drawing.Point(539, 147);
            this.DecoreRight.Name = "DecoreRight";
            this.DecoreRight.Size = new System.Drawing.Size(42, 311);
            this.DecoreRight.TabIndex = 0;
            this.DecoreRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this._MouseDown);
            this.DecoreRight.MouseMove += new System.Windows.Forms.MouseEventHandler(this._MouseMove);
            // 
            // CloseD
            // 
            this.CloseD.BackColor = System.Drawing.Color.White;
            this.CloseD.BackgroundImage = global::Launcher__.Properties.Resources.close_window_96;
            this.CloseD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CloseD.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CloseD.FlatAppearance.BorderSize = 0;
            this.CloseD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.CloseD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.CloseD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseD.Location = new System.Drawing.Point(539, 3);
            this.CloseD.Name = "CloseD";
            this.CloseD.Size = new System.Drawing.Size(42, 42);
            this.CloseD.TabIndex = 1;
            this.CloseD.UseVisualStyleBackColor = false;
            this.CloseD.Click += new System.EventHandler(this.CloseD_Click);
            // 
            // DirInfo
            // 
            this.DirInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DirInfo.Location = new System.Drawing.Point(3, 3);
            this.DirInfo.MinimumSize = new System.Drawing.Size(20, 20);
            this.DirInfo.Name = "DirInfo";
            this.FolderLayout.SetRowSpan(this.DirInfo, 4);
            this.DirInfo.Size = new System.Drawing.Size(530, 455);
            this.DirInfo.TabIndex = 2;
            // 
            // ForwardDir
            // 
            this.ForwardDir.BackColor = System.Drawing.Color.White;
            this.ForwardDir.BackgroundImage = global::Launcher__.Properties.Resources.forward_96;
            this.ForwardDir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ForwardDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ForwardDir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ForwardDir.FlatAppearance.BorderSize = 0;
            this.ForwardDir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ForwardDir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.ForwardDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForwardDir.ForeColor = System.Drawing.Color.Black;
            this.ForwardDir.Location = new System.Drawing.Point(539, 51);
            this.ForwardDir.Name = "ForwardDir";
            this.ForwardDir.Size = new System.Drawing.Size(42, 42);
            this.ForwardDir.TabIndex = 3;
            this.ForwardDir.UseVisualStyleBackColor = false;
            this.ForwardDir.Click += new System.EventHandler(this.ForwardDir_Click);
            // 
            // BackDir
            // 
            this.BackDir.BackColor = System.Drawing.Color.White;
            this.BackDir.BackgroundImage = global::Launcher__.Properties.Resources.back_96;
            this.BackDir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackDir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BackDir.FlatAppearance.BorderSize = 0;
            this.BackDir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BackDir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.BackDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackDir.Location = new System.Drawing.Point(539, 99);
            this.BackDir.Name = "BackDir";
            this.BackDir.Size = new System.Drawing.Size(42, 42);
            this.BackDir.TabIndex = 5;
            this.BackDir.UseVisualStyleBackColor = false;
            this.BackDir.Click += new System.EventHandler(this.BackDir_Click);
            // 
            // FolderUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.ControlBox = false;
            this.Controls.Add(this.FolderLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FolderUserControl";
            this.Text = "Folder";
            this.TransparencyKey = System.Drawing.Color.LavenderBlush;
            this.FolderLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel FolderLayout;
        private System.Windows.Forms.Panel DecoreRight;
        private System.Windows.Forms.Button CloseD;
        public WebBrowser DirInfo;
        private Button ForwardDir;
        private Button BackDir;
    }
}