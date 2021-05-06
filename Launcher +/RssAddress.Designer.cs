
namespace Launcher__
{
    partial class RssAddress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RssAddress));
            this.LayoutControl = new System.Windows.Forms.TableLayoutPanel();
            this.CloseD = new System.Windows.Forms.Button();
            this.TextAddress = new System.Windows.Forms.TextBox();
            this.LayoutControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // LayoutControl
            // 
            this.LayoutControl.ColumnCount = 2;
            this.LayoutControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.LayoutControl.Controls.Add(this.CloseD, 1, 0);
            this.LayoutControl.Controls.Add(this.TextAddress, 0, 0);
            this.LayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutControl.Location = new System.Drawing.Point(0, 0);
            this.LayoutControl.Name = "LayoutControl";
            this.LayoutControl.RowCount = 1;
            this.LayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutControl.Size = new System.Drawing.Size(417, 48);
            this.LayoutControl.TabIndex = 0;
            // 
            // CloseD
            // 
            this.CloseD.BackColor = System.Drawing.Color.White;
            this.CloseD.BackgroundImage = global::Launcher__.Properties.Resources.add_new_96;
            this.CloseD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseD.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CloseD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CloseD.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CloseD.FlatAppearance.BorderSize = 0;
            this.CloseD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.CloseD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.CloseD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseD.Location = new System.Drawing.Point(372, 3);
            this.CloseD.Name = "CloseD";
            this.CloseD.Size = new System.Drawing.Size(42, 42);
            this.CloseD.TabIndex = 0;
            this.CloseD.UseVisualStyleBackColor = false;
            // 
            // TextAddress
            // 
            this.TextAddress.BackColor = System.Drawing.Color.White;
            this.TextAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TextAddress.Location = new System.Drawing.Point(3, 3);
            this.TextAddress.Multiline = true;
            this.TextAddress.Name = "TextAddress";
            this.TextAddress.Size = new System.Drawing.Size(363, 42);
            this.TextAddress.TabIndex = 1;
            this.TextAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextAddress.MouseDown += new System.Windows.Forms.MouseEventHandler(this._MouseDown);
            this.TextAddress.MouseMove += new System.Windows.Forms.MouseEventHandler(this._MouseMove);
            // 
            // RssAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(417, 48);
            this.Controls.Add(this.LayoutControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RssAddress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rss";
            this.TransparencyKey = System.Drawing.Color.LavenderBlush;
            this.LayoutControl.ResumeLayout(false);
            this.LayoutControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel LayoutControl;
        public System.Windows.Forms.TextBox TextAddress;
        public System.Windows.Forms.Button CloseD;
    }
}