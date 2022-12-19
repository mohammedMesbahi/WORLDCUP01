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
    public partial class UC_DisplayAllTeams : UserControl
    {
        public UC_DisplayAllTeams()
        {
            InitializeComponent();
            this.teamTableAdapter.Fill(this.worldcupDataSet1.Team);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
