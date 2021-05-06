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
    public partial class RssAddress : Form
    {
        public RssAddress()
        {
            InitializeComponent();
        }

        private int x = default, y = default;

        private void _MouseDown(object sender, MouseEventArgs e)
        {
            switch(e.Button)
            {
                case MouseButtons.Left:
                    x = e.X; y = e.Y;
                    break;
            }
        }

        private void _MouseMove(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    this.Location = new Point(this.Location.X + (e.X - x), this.Location.Y + (e.Y - y));
                    break;
            }
        }
    }
}
