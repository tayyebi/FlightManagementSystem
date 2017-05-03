using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightManagementSystem
{
    public partial class TheMain : Form
    {
        public TheMain()
        {
            InitializeComponent();
        }

        private void companiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var c = new Companies();
            c.MdiParent = this;
            c.Show();
        }

        private void planesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var c = new Planes();
            c.MdiParent = this;
            c.Show();
        }

        private void linesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var c = new Lines();
            c.MdiParent = this;
            c.Show();
        }

        private void managementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var c = new Flights();
            c.MdiParent = this;
            c.Show();
        }

        private void allFlightsInTimeRangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           var c = new Report1();
            c.MdiParent = this;
            c.Show();
        }

        private void eachTerminalPassengersToolStripMenuItem_Click(object sender, EventArgs e)
        {
           var c = new Report2();
            c.MdiParent = this;
            c.Show();
        }

        private void eachCompanyFlightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
         var c = new Report3();
            c.MdiParent = this;
            c.Show();
        }
    }
}
