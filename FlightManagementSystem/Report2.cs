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
    public partial class Report2 : FatherForm
    {
        public Report2()
        {
            InitializeComponent();
        }

        private void Report2_Load(object sender, EventArgs e)
        {
            var tt = (from line in db.Lines
                      group line by new { line.ToCity, line.ToAirport }
                                    into g
                      select new { g.Key.ToCity, g.Key.ToAirport }).ToList();
            comboBox1.DataSource = tt;
            comboBox2.DataSource = tt;
            comboBox2.ValueMember = comboBox2.DisplayMember = "ToAirport";
            comboBox1.ValueMember = comboBox1.DisplayMember = "ToCity";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Lines.Where(x => x.ToAirport == comboBox2.SelectedValue.ToString() || x.ToCity == comboBox2.SelectedValue.ToString())
                .Select(x=> new {x.ToCity, x.ToAirport, Passengers = x.Flights.Sum(y => y.Passengers) }).DefaultIfEmpty()
                .ToList();
        }
    }
}
