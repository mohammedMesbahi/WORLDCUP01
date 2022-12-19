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
                this.teamTableAdapter3.FillBy(this.worldcupDataSet4.Team, "D");
                Random rnd = new Random();
                label5.Text =guna2DataGridView1.Rows[rnd.Next(guna2DataGridView1.RowCount)].Cells[0].Value.ToString();
                label6.Text =guna2DataGridView2.Rows[rnd.Next(guna2DataGridView2.RowCount)].Cells[0].Value.ToString();
                label7.Text =guna2DataGridView3.Rows[rnd.Next(guna2DataGridView3.RowCount)].Cells[0].Value.ToString();
                label8.Text =guna2DataGridView4.Rows[rnd.Next(guna2DataGridView4.RowCount)].Cells[0].Value.ToString();
                //label8.Text =guna2DataGridView4.Rows[rnd.Next(guna2DataGridView4.RowCount)].Cells[0].Value.ToString();
                String[] group1 = { label5.Text, label6.Text };
                String[] group2 = { label7.Text, label8.Text };
                label13.Text = group1[rnd.Next(group1.Length)];
                label14.Text = group2[rnd.Next(group2.Length)];
                String[] group3 = { label13.Text, label14.Text };
                label21.Text = group3[rnd.Next(group3.Length)];
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        
    }
}
