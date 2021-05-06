using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Launcher__
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private int x = default, y = default;

        //MouseEvent
        private void _MouseEnter(object sender, EventArgs e)
        {
            DecoreRight.BackColor = CloseD.BackColor = CloseD.FlatAppearance.BorderColor = Color.White;
            CloseD.BackgroundImage = Properties.Resources.close_window_96;
        }

        private void _MouseLeave(object sender, EventArgs e)
        {
            DecoreRight.BackColor = CloseD.BackColor = CloseD.FlatAppearance.BorderColor = Color.LavenderBlush;
            CloseD.BackgroundImage = null;
        }

        private void CloseD_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    Application.Exit();
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

        private void _MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    x = e.X; y = e.Y;
                    break;
            }
        }

        //drag && drop
        private void FLP_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            try
            {
                foreach (string file in files)
                {
                    DirectoryInfo directory = new DirectoryInfo(file);
                    if (directory.Extension == ".lnk" | directory.Extension == ".exe")
                    {
                        Ticket ticket = new Ticket();
                        ticket.pathrss.Item1 = file;
                        FLP.Controls.Add(ticket);
                    }
                }
            }
            catch { }
        }

        private void FLP_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        //Change control add
        private void FLP_ControlAdded(object sender, ControlEventArgs e) => ControlChange(sender, e);
        private void FLP_ControlRemoved(object sender, ControlEventArgs e) => ControlChange(sender, e);

        private void ControlChange(object sender, ControlEventArgs e)
        {
            FlowLayoutPanel flowLayout = sender as FlowLayoutPanel;
            if (flowLayout.Controls.Count == 0)
            {
                flowLayout.BackColor = Color.White;
                flowLayout.BackgroundImage = Properties.Resources.drag_and_drop_96;
            }
            else
            {
                flowLayout.BackgroundImage = default;
                flowLayout.BackColor = Color.LavenderBlush;
            }
        }

        //Form Event
        private void UserForm_Load(object sender, EventArgs e)
        {
            try
            {
                Setting setting = DeserializeXML();
                foreach (XML xML in setting.fullpath)
                {
                    try
                    {
                        Ticket ticket = new Ticket();
                        ticket.pathrss.Item1 = xML.Path;
                        ticket.pathrss.Item2 = xML.Rss;
                        FLP.Controls.Add(ticket);
                    }
                    catch { };
                }
            }
            catch {}
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                int i = 0;
                Setting setting = new Setting();
                do
                {
                    TicketPath(FLP.Controls[i], setting);
                    i++;
                }
                while (i < FLP.Controls.Count);
                SerializeXML(setting);
            }
            catch
            {
                try
                {
                    File.Delete("Save.xml");
                }
                catch { }
            }
        }
        
        //Save
        private void TicketPath(object sender, Setting s)
        {
            Ticket ticket = sender as Ticket;
            XML xML = new XML(ticket.pathrss.Item1, ticket.pathrss.Item2);
            s.fullpath.Add(xML);
        }

        //XML
        private void SerializeXML(Setting s)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Setting));
            try
            {
                File.Delete("Save.xml");
            }
            catch { }
            finally
            {
                using (FileStream fil = new FileStream("Save.xml", FileMode.OpenOrCreate))
                {

                    xml.Serialize(fil, s);
                }
            }
        }

        private Setting DeserializeXML()
        {
            XmlSerializer xml = new XmlSerializer(typeof(Setting));
            using (FileStream fil = new FileStream("Save.xml", FileMode.OpenOrCreate))
            { return (Setting)xml.Deserialize(fil); }
        }
    }
}
