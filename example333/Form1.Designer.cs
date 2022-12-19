
namespace example333
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnModifieTeam = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddTeam = new Guna.UI2.WinForms.Guna2Button();
            this.btnSimulateWC = new Guna.UI2.WinForms.Guna2Button();
            this.btnDisplayTeams = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.AutoRoundedCorners = true;
            this.guna2Panel1.BorderRadius = 178;
            this.guna2Panel1.Controls.Add(this.btnModifieTeam);
            this.guna2Panel1.Controls.Add(this.btnAddTeam);
            this.guna2Panel1.Controls.Add(this.btnSimulateWC);
            this.guna2Panel1.Controls.Add(this.btnDisplayTeams);
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(359, 492);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnModifieTeam
            // 
            this.btnModifieTeam.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModifieTeam.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModifieTeam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModifieTeam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModifieTeam.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(8)))), ((int)(((byte)(111)))));
            this.btnModifieTeam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifieTeam.ForeColor = System.Drawing.Color.White;
            this.btnModifieTeam.Location = new System.Drawing.Point(26, 342);
            this.btnModifieTeam.Name = "btnModifieTeam";
            this.btnModifieTeam.Size = new System.Drawing.Size(303, 51);
            this.btnModifieTeam.TabIndex = 4;
            this.btnModifieTeam.Text = "Modifie Team";
            this.btnModifieTeam.Click += new System.EventHandler(this.btnModifieTeam_Click);
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTeam.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTeam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddTeam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddTeam.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(8)))), ((int)(((byte)(111)))));
            this.btnAddTeam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeam.ForeColor = System.Drawing.Color.White;
            this.btnAddTeam.Location = new System.Drawing.Point(26, 285);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(303, 45);
            this.btnAddTeam.TabIndex = 3;
            this.btnAddTeam.Text = "Add Team";
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // btnSimulateWC
            // 
            this.btnSimulateWC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSimulateWC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSimulateWC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSimulateWC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSimulateWC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(8)))), ((int)(((byte)(111)))));
            this.btnSimulateWC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimulateWC.ForeColor = System.Drawing.Color.White;
            this.btnSimulateWC.Location = new System.Drawing.Point(26, 227);
            this.btnSimulateWC.Name = "btnSimulateWC";
            this.btnSimulateWC.Size = new System.Drawing.Size(303, 45);
            this.btnSimulateWC.TabIndex = 2;
            this.btnSimulateWC.Text = "Simulate World Cup";
            // 
            // btnDisplayTeams
            // 
            this.btnDisplayTeams.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDisplayTeams.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDisplayTeams.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDisplayTeams.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDisplayTeams.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(8)))), ((int)(((byte)(111)))));
            this.btnDisplayTeams.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayTeams.ForeColor = System.Drawing.Color.White;
            this.btnDisplayTeams.Location = new System.Drawing.Point(26, 167);
            this.btnDisplayTeams.Name = "btnDisplayTeams";
            this.btnDisplayTeams.Size = new System.Drawing.Size(303, 45);
            this.btnDisplayTeams.TabIndex = 1;
            this.btnDisplayTeams.Text = "All Teams";
            this.btnDisplayTeams.Click += new System.EventHandler(this.btnDisplayTeams_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(359, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(818, 492);
            this.mainPanel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(0)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(1177, 492);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorldCup";
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnModifieTeam;
        private Guna.UI2.WinForms.Guna2Button btnAddTeam;
        private Guna.UI2.WinForms.Guna2Button btnSimulateWC;
        private Guna.UI2.WinForms.Guna2Button btnDisplayTeams;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Panel mainPanel;
    }
}

