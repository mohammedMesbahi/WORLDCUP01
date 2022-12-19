using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example333.UserControls
{
    public partial class UC_AddTeam : UserControl
    {
        public UC_AddTeam()
        {
            InitializeComponent();
            this.group_TableAdapter.Fill(this.worldcupDataSet3.Group_);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using (worldcupEntities db = new worldcupEntities())
            {
                Team team = new Team();
                team.TeamID = Convert.ToInt32(textBoxTeamId.Text);
                team.teamName = textBoxTeamName.Text;
                team.numberOfPlayers = Convert.ToInt32(textBoxNbrOfPlayers.Text);
                team.groupName = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
                db.Teams.Add(team);
                db.SaveChanges();
                MessageBox.Show("Created successfully");
            }
            
            clear();
        }
        private void clear()
        {
            textBoxTeamId.Text = "";
            textBoxTeamName.Text = "";
            textBoxNbrOfPlayers.Text = "";
        }
    }
}
