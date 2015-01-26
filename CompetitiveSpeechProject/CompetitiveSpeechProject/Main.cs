using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CompetitiveSpeechProject
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            pnlNavigation.Dock = DockStyle.Left;
            //Set Main.cs as MDI container to open child forms insdie
            this.IsMdiContainer = true;
            //Load LogIn.cs on start-up
            LogIn frm = new LogIn();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            string ExitMsg = "Are you sure you want to exit the application?";
            if (MessageBox.Show(ExitMsg, "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void menuLogOut_Click(object sender, EventArgs e)
        {
            string LogOutMsg = "Do you want to log out?";
            if (MessageBox.Show(LogOutMsg, "Log out?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                LogIn frm = new LogIn();
                frm.MdiParent = this; 
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }

        private void menuCompetitor_Click(object sender, EventArgs e)
        {
            CompetitorInput frm = new CompetitorInput();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void menuLocation_Click(object sender, EventArgs e)
        {
            Location frm = new Location();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void menuRank_Click(object sender, EventArgs e)
        {
            Rank frm = new Rank();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void menuTournament_Click(object sender, EventArgs e)
        {
            Tournament frm = new Tournament();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        
    }
}
