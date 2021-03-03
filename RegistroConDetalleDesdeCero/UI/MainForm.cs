using RegistroConDetalleDesdeCero.UI.Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RegistroConDetalleDesdeCero.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.rolesToolStripMenuItem.Click += new EventHandler(this.rolesToolStripMenuItem_ItemClicked);
            
            
        }

        private void rolesToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var Roles = new rRoles();
            Roles.MdiParent = this;
            Roles.Show();
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
