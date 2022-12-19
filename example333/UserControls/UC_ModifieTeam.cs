using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example333.UserControls
{
    
    public partial class UC_ModifieTeam : UserControl
    {
        Team team = new Team();
        public UC_ModifieTeam()
        {
            InitializeComponent();
            this.group_TableAdapter.Fill(this.worldcupDataSet3.Group_);
            this.teamTableAdapter.Fill(this.worldcupDataSet2.Team);

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (guna2DataGridView1.CurrentRow.Index != -1)
            {
                team.TeamID = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[0].Value);
                using (worldcupEntities db = new worldcupEntities())
                {
                    team = db.Teams.Where(x => x.TeamID == team.TeamID).FirstOrDefault();
                    textBoxTeamId.Text = team.TeamID.ToString();
                    textBoxTeamName.Text = team.teamName;
                    textBoxNbrOfPlayers.Text = team.numberOfPlayers.ToString();
                    
                }
                btnSubmit.Text = "Update";
                
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            team.TeamID =Convert.ToInt32( textBoxTeamId.Text);
            team.teamName = textBoxTeamName.Text.Trim();
            team.numberOfPlayers = Convert.ToInt32(textBoxNbrOfPlayers.Text);
            team.groupName = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            using (worldcupEntities db = new worldcupEntities())
            {
                if (team.TeamID == 0)//Insert
                    db.Teams.Add(team);
                else //Update
                    db.Entry(team).State = EntityState.Modified;
                db.SaveChanges();
            }
            Clear();
            PopulateDataGridView();
            MessageBox.Show("Submitted Successfully");
        }

        private void PopulateDataGridView()
        {
            this.teamTableAdapter.Fill(this.worldcupDataSet2.Team);

        }

        private void Clear()
        {
            textBoxTeamId.Text = "";
            textBoxTeamName.Text = "";
            textBoxNbrOfPlayers.Text = "";
        }
    }
}
