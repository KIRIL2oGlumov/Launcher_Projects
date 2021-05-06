using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher__
{
    public partial class FolderUserControl : Form
    {
        public FolderUserControl()
        {
            InitializeComponent();
        }
        private int x = default, y = default; 

        //Folder Event
        private void CloseD_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void ForwardDir_Click(object sender, EventArgs e)
        {
            try
            { 
                if (DirInfo.CanGoForward) { DirInfo.GoForward(); } 
            }
            catch { }
        }

        private void BackDir_Click(object sender, EventArgs e)
        {
            try 
            {
                if (DirInfo.CanGoBack) { DirInfo.GoBack(); }
            }
            catch { }
        }

        //Move Event
        private void _MouseMove(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    this.Location = new Point(this.Location.X + (e.X - x), this.Location.Y + (e.Y - y));
                    break;
            }
        }

        private void _MouseDown(object sender, MouseEventArgs e)
        {
            switch(e.Button)
            {
                case MouseButtons.Left:
                    x = e.X; y = e.Y;
                    break;
            }
        }
    }
}
