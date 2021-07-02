using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyMenuAccess
{
    public partial class Display : Form
    {
        Dictionary<string, string> dict = new Dictionary<string, string>();
        static String basepath = "";

        public Display()
        {
            InitializeComponent();
            basepath = Path.GetDirectoryName(Application.ExecutablePath) + "/Menu";
        }

        private void displaybtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (contextMenuStrip1.Visible)
            {
                contextMenuStrip1.Close();
            }
            else
            {
                if (e.Button == MouseButtons.Right)
                {
                    displayContextMenu();
                }
            }
        }

        private void Display_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, Screen.PrimaryScreen.WorkingArea.Height - this.Size.Height);
        }

        private void displayContextMenu()
        {

            contextMenuStrip1.Items.Clear();
            dict.Clear();

            foreach (var f in Directory.GetDirectories(basepath))
            {
                addToolItems(f);
            }

            foreach (var f in Directory.GetFiles(basepath))
            {
                addToolItems(f);
            }
            ToolStripMenuItem toolstripitem = new ToolStripMenuItem("close", null, (object sender, EventArgs e) => this.Close(), "X - close");
            contextMenuStrip1.Items.Add(toolstripitem);
            contextMenuStrip1.Show(Cursor.Position);
            contextMenuStrip1.Focus();
        }

        private void addToolItems(string path, ToolStripMenuItem parentitem = null)
        {

            var isfolder = Directory.Exists(path);
            var itemname = Path.GetFileName(path);

            var id = "ctx_" + Guid.NewGuid().ToString().Replace("-", "");
            ToolStripMenuItem toolstripitem = new ToolStripMenuItem(itemname, isfolder ? Properties.Resources.Folder : null, onClickToolStripItem, id);
            dict.Add(id, path);
            if (parentitem != null)
            {
                parentitem.DropDownItems.Add(toolstripitem);
            }
            else
            {
                contextMenuStrip1.Items.Add(toolstripitem);
            }

            if (Directory.Exists(path))
            {
                foreach (var f in Directory.GetDirectories(path))
                {
                    addToolItems(f, toolstripitem);
                }
                foreach (var f in Directory.GetFiles(path))
                {
                    addToolItems(f, toolstripitem);
                }
            }

        }



        private void onClickToolStripItem(object sender, System.EventArgs e)
        {
            var t = (ToolStripMenuItem)sender;

            if (dict.ContainsKey(t.Name))
            {
                var fname = dict[t.Name];
                var isfolder = Directory.Exists(fname);
                if (!isfolder)
                {

                    //ProcessStartInfo info = new ProcessStartInfo(fname);
                    //info.CreateNoWindow = true;
                    //info.UseShellExecute = false;
                    //info.RedirectStandardError = true;
                    //info.RedirectStandardOutput = true;
                    //info.RedirectStandardInput = true;
                    //Process whatever = Process.Start(info);

                    //Process proc = new Process();
                    //proc.StartInfo.FileName = "cmd.exe";
                    //proc.StartInfo.Arguments = " /c \"" + fname.Replace("/", "\\").Replace("\\\\", "\\") + "\"";
                    //proc.Start();
                    //System.Threading.Thread.Sleep(2000);
                    //proc.Close();
                    var p = Process.Start("cmd.exe ", " /c \"" + fname.Replace("/", "\\").Replace("\\\\", "\\") + "\"");
                    System.Threading.Thread.Sleep(15000);
                    var process =
                        Process.GetProcessById(p.Id);
                    process.Kill();

                    //Process p = new Process();                    
                    ////p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    ////p.StartInfo.FileName = "cmd.exe";
                    ////p.StartInfo.Arguments = "start \\" +  fname + "\\";
                    //p.StartInfo.FileName =  fname;
                    //Process.Start(fname);
                    //p.Start();
                }
            }
        }

        private Point _mouseLoc;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseLoc = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - _mouseLoc.X;
                int dy = e.Location.Y - _mouseLoc.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }

        private void displaybtn_Click(object sender, EventArgs e)
        {

        }
    }
}
