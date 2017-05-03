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
    public partial class Report1 : FatherForm
    {
        public Report1()
        {
            InitializeComponent();
        }

        private void Report1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = dateTimePicker1.CustomFormat = "yyyy/MM/dd HH:MM";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Flights.Where(x => x.TakeOfMoment >= dateTimePicker1.Value && x.LandingMoment <= dateTimePicker2.Value).ToList();
        }
    }
}
