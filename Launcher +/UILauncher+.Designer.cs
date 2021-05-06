
namespace Launcher__
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.TLP = new System.Windows.Forms.TableLayoutPanel();
            this.FLP = new System.Windows.Forms.FlowLayoutPanel();
            this.DecoreRight = new System.Windows.Forms.Panel();
            this.CloseD = new System.Windows.Forms.Button();
            this.TLP.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLP
            // 
            this.TLP.BackColor = System.Drawing.Color.LavenderBlush;
            this.TLP.ColumnCount = 2;
            this.TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.TLP.Controls.Add(this.FLP, 0, 0);
            this.TLP.Controls.Add(this.DecoreRight, 1, 1);
            this.TLP.Controls.Add(this.CloseD, 1, 0);
            this.TLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP.Location = new System.Drawing.Point(0, 0);
            this.TLP.Name = "TLP";
            this.TLP.RowCount = 2;
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP.Size = new System.Drawing.Size(800, 600);
            this.TLP.TabIndex = 0;
            this.TLP.MouseEnter += new System.EventHandler(this._MouseEnter);
            // 
            // FLP
            // 
            this.FLP.AllowDrop = true;
            this.FLP.AutoScroll = true;
            this.FLP.AutoSize = true;
            this.FLP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FLP.BackColor = System.Drawing.Color.White;
            this.FLP.BackgroundImage = global::Launcher__.Properties.Resources.drag_and_drop_96;
            this.FLP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.FLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLP.Location = new System.Drawing.Point(3, 3);
            this.FLP.Name = "FLP";
            this.TLP.SetRowSpan(this.FLP, 2);
            this.FLP.Size = new System.Drawing.Size(746, 594);
            this.FLP.TabIndex = 0;
            this.FLP.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.FLP_ControlAdded);
            this.FLP.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.FLP_ControlRemoved);
            this.FLP.DragDrop += new System.Windows.Forms.DragEventHandler(this.FLP_DragDrop);
            this.FLP.DragEnter += new System.Windows.Forms.DragEventHandler(this.FLP_DragEnter);
            this.FLP.MouseEnter += new System.EventHandler(this._MouseEnter);
            this.FLP.MouseLeave += new System.EventHandler(this._MouseLeave);
            // 
            // DecoreRight
            // 
            this.DecoreRight.BackColor = System.Drawing.Color.White;
            this.DecoreRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DecoreRight.Location = new System.Drawing.Point(755, 51);
            this.DecoreRight.Name = "DecoreRight";
            this.DecoreRight.Size = new System.Drawing.Size(42, 546);
            this.DecoreRight.TabIndex = 2;
            this.DecoreRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this._MouseDown);
            this.DecoreRight.MouseEnter += new System.EventHandler(this._MouseEnter);
            this.DecoreRight.MouseLeave += new System.EventHandler(this._MouseLeave);
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
            this.CloseD.Location = new System.Drawing.Point(755, 3);
            this.CloseD.Name = "CloseD";
            this.CloseD.Size = new System.Drawing.Size(42, 42);
            this.CloseD.TabIndex = 3;
            this.CloseD.UseVisualStyleBackColor = false;
            this.CloseD.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CloseD_MouseClick);
            this.CloseD.MouseEnter += new System.EventHandler(this._MouseEnter);
            this.CloseD.MouseLeave += new System.EventHandler(this._MouseLeave);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.TLP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Launcher +";
            this.TransparencyKey = System.Drawing.Color.LavenderBlush;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserForm_FormClosed);
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.TLP.ResumeLayout(false);
            this.TLP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLP;
        private System.Windows.Forms.Panel DecoreRight;
        private System.Windows.Forms.Button CloseD;
        public System.Windows.Forms.FlowLayoutPanel FLP;
    }
}

