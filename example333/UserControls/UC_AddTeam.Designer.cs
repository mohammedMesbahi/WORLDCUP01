
namespace example333.UserControls
{
    partial class UC_AddTeam
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelCreateTeam = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxTeamId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.textBoxTeamName = new System.Windows.Forms.TextBox();
            this.textBoxNbrOfPlayers = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.worldcupDataSet3 = new example333.worldcupDataSet3();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.group_TableAdapter = new example333.worldcupDataSet3TableAdapters.Group_TableAdapter();
            this.panelCreateTeam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.worldcupDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCreateTeam
            // 
            this.panelCreateTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(101)))));
            this.panelCreateTeam.Controls.Add(this.comboBox1);
            this.panelCreateTeam.Controls.Add(this.textBoxTeamId);
            this.panelCreateTeam.Controls.Add(this.label4);
            this.panelCreateTeam.Controls.Add(this.btnSubmit);
            this.panelCreateTeam.Controls.Add(this.textBoxTeamName);
            this.panelCreateTeam.Controls.Add(this.textBoxNbrOfPlayers);
            this.panelCreateTeam.Controls.Add(this.label3);
            this.panelCreateTeam.Controls.Add(this.label2);
            this.panelCreateTeam.Controls.Add(this.label1);
            this.panelCreateTeam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCreateTeam.Location = new System.Drawing.Point(0, 0);
            this.panelCreateTeam.Name = "panelCreateTeam";
            this.panelCreateTeam.Size = new System.Drawing.Size(818, 492);
            this.panelCreateTeam.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.groupBindingSource;
            this.comboBox1.DisplayMember = "groupName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(441, 276);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(284, 28);
            this.comboBox1.TabIndex = 17;
            // 
            // textBoxTeamId
            // 
            this.textBoxTeamId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTeamId.Location = new System.Drawing.Point(441, 109);
            this.textBoxTeamId.Name = "textBoxTeamId";
            this.textBoxTeamId.Size = new System.Drawing.Size(284, 30);
            this.textBoxTeamId.TabIndex = 16;
            this.textBoxTeamId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(117, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 26);
            this.label4.TabIndex = 15;
            this.label4.Text = "Team id";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(8)))), ((int)(((byte)(111)))));
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(122, 367);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(603, 50);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // textBoxTeamName
            // 
            this.textBoxTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTeamName.Location = new System.Drawing.Point(441, 165);
            this.textBoxTeamName.Name = "textBoxTeamName";
            this.textBoxTeamName.Size = new System.Drawing.Size(284, 30);
            this.textBoxTeamName.TabIndex = 14;
            this.textBoxTeamName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxNbrOfPlayers
            // 
            this.textBoxNbrOfPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNbrOfPlayers.Location = new System.Drawing.Point(441, 221);
            this.textBoxNbrOfPlayers.Name = "textBoxNbrOfPlayers";
            this.textBoxNbrOfPlayers.Size = new System.Drawing.Size(284, 30);
            this.textBoxNbrOfPlayers.TabIndex = 12;
            this.textBoxNbrOfPlayers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(117, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "Group";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(117, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Number Of Players";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(117, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Team Name";
            // 
            // worldcupDataSet3
            // 
            this.worldcupDataSet3.DataSetName = "worldcupDataSet3";
            this.worldcupDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataMember = "Group_";
            this.groupBindingSource.DataSource = this.worldcupDataSet3;
            // 
            // group_TableAdapter
            // 
            this.group_TableAdapter.ClearBeforeFill = true;
            // 
            // UC_AddTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelCreateTeam);
            this.Name = "UC_AddTeam";
            this.Size = new System.Drawing.Size(818, 492);
            this.panelCreateTeam.ResumeLayout(false);
            this.panelCreateTeam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.worldcupDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCreateTeam;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private worldcupDataSet3 worldcupDataSet3;
        private System.Windows.Forms.TextBox textBoxTeamId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox textBoxTeamName;
        private System.Windows.Forms.TextBox textBoxNbrOfPlayers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private worldcupDataSet3TableAdapters.Group_TableAdapter group_TableAdapter;
    }
}
