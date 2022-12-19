using example333.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example333
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UcHomeScreen homeScreen = new UcHomeScreen();
            addUserControle(homeScreen);
        }
        private void addUserControle(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnDisplayTeams_Click(object sender, EventArgs e)
        {
            UC_DisplayAllTeams uC_DisplayAllTeams = new UC_DisplayAllTeams();
            addUserControle(uC_DisplayAllTeams);
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            UC_AddTeam uC_AddTeam = new UC_AddTeam();
            addUserControle(uC_AddTeam);
        }

        private void btnModifieTeam_Click(object sender, EventArgs e)
        {
            UC_ModifieTeam uC_ModifieTeam = new UC_ModifieTeam();
            addUserControle(uC_ModifieTeam);
        }
    }
}
