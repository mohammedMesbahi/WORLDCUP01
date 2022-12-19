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
    public partial class UC_SimulateWorldCup : UserControl
    {
        public UC_SimulateWorldCup()
        {
            InitializeComponent();

        }

        

        private void UC_SimulateWorldCup_Load(object sender, EventArgs e)
        {
            try
            {
                this.teamTableAdapter.FillBy(this.worldcupDataSet.Team, "A");
                this.teamTableAdapter1.FillBy(this.worldcupDataSet1.Team, "B");
                this.teamTableAdapter2.FillBy(this.worldcupDataSet2.Team, "C");

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

    }
}
