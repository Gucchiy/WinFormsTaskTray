using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WinFormsTaskTray
{
    public partial class Form1 : Form
    {
        NotifyIcon notifyIcon;
        public Form1()
        {
            InitializeComponent();
            ShowInTaskbar = false;
            SetComponents();
            
        }

        private void SetComponents()
        {
            notifyIcon = new NotifyIcon();
            notifyIcon.Icon = new Icon(@"C:\temp\favicon.ico");
            notifyIcon.Visible = true;
            notifyIcon.Text = "NofityIcon のテスト";

            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
            ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem.Text = "&終了";
            toolStripMenuItem.Click += ToolStripMenuItem_Click;
            contextMenuStrip.Items.Add(toolStripMenuItem);
            notifyIcon.ContextMenuStrip = contextMenuStrip;
        }

        private void ToolStripMenuItem_Click(object sendor, EventArgs e)
        {
            Application.Exit();
        }

    }
}
