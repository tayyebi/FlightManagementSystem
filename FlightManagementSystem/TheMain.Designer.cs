namespace FlightManagementSystem
{
    partial class TheMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allFlightsInTimeRangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eachTerminalPassengersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eachCompanyFlightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.automationToolStripMenuItem,
            this.flightsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(723, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.userToolStripMenuItem.Text = "User";
            // 
            // automationToolStripMenuItem
            // 
            this.automationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.companiesToolStripMenuItem,
            this.planesToolStripMenuItem,
            this.linesToolStripMenuItem});
            this.automationToolStripMenuItem.Name = "automationToolStripMenuItem";
            this.automationToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.automationToolStripMenuItem.Text = "Automation";
            // 
            // companiesToolStripMenuItem
            // 
            this.companiesToolStripMenuItem.Name = "companiesToolStripMenuItem";
            this.companiesToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.companiesToolStripMenuItem.Text = "Companies";
            this.companiesToolStripMenuItem.Click += new System.EventHandler(this.companiesToolStripMenuItem_Click);
            // 
            // planesToolStripMenuItem
            // 
            this.planesToolStripMenuItem.Name = "planesToolStripMenuItem";
            this.planesToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.planesToolStripMenuItem.Text = "Planes";
            this.planesToolStripMenuItem.Click += new System.EventHandler(this.planesToolStripMenuItem_Click);
            // 
            // linesToolStripMenuItem
            // 
            this.linesToolStripMenuItem.Name = "linesToolStripMenuItem";
            this.linesToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.linesToolStripMenuItem.Text = "Lines";
            this.linesToolStripMenuItem.Click += new System.EventHandler(this.linesToolStripMenuItem_Click);
            // 
            // flightsToolStripMenuItem
            // 
            this.flightsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managementToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.flightsToolStripMenuItem.Name = "flightsToolStripMenuItem";
            this.flightsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.flightsToolStripMenuItem.Text = "Flights";
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.managementToolStripMenuItem.Text = "Management";
            this.managementToolStripMenuItem.Click += new System.EventHandler(this.managementToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allFlightsInTimeRangeToolStripMenuItem,
            this.eachTerminalPassengersToolStripMenuItem,
            this.eachCompanyFlightsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // allFlightsInTimeRangeToolStripMenuItem
            // 
            this.allFlightsInTimeRangeToolStripMenuItem.Name = "allFlightsInTimeRangeToolStripMenuItem";
            this.allFlightsInTimeRangeToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.allFlightsInTimeRangeToolStripMenuItem.Text = "All flights in time range";
            this.allFlightsInTimeRangeToolStripMenuItem.Click += new System.EventHandler(this.allFlightsInTimeRangeToolStripMenuItem_Click);
            // 
            // eachTerminalPassengersToolStripMenuItem
            // 
            this.eachTerminalPassengersToolStripMenuItem.Name = "eachTerminalPassengersToolStripMenuItem";
            this.eachTerminalPassengersToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.eachTerminalPassengersToolStripMenuItem.Text = "Each destination terminal passengers";
            this.eachTerminalPassengersToolStripMenuItem.Click += new System.EventHandler(this.eachTerminalPassengersToolStripMenuItem_Click);
            // 
            // eachCompanyFlightsToolStripMenuItem
            // 
            this.eachCompanyFlightsToolStripMenuItem.Name = "eachCompanyFlightsToolStripMenuItem";
            this.eachCompanyFlightsToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.eachCompanyFlightsToolStripMenuItem.Text = "Each company flights";
            this.eachCompanyFlightsToolStripMenuItem.Click += new System.EventHandler(this.eachCompanyFlightsToolStripMenuItem_Click);
            // 
            // TheMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 354);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TheMain";
            this.Text = "TheMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem automationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flightsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allFlightsInTimeRangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eachTerminalPassengersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eachCompanyFlightsToolStripMenuItem;
    }
}