using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightManagementSystem
{
    public partial class Report3 : FatherForm
    {
        public Report3()
        {
            InitializeComponent();
        }

        class MyClass
        {
            public string Name { get; set; }
            public byte[] Logo { get; set; }
            public int Passengers { get; set; }
        }

        private void Report3_Load(object sender, EventArgs e)
        {
            //List<MyClass > mc = db.Companies
            //    .Select(x => new MyClass
            //    {
            //     Logo = new Bitmap(new MemoryStream(x.Image)),
            //        Name = x.Name,
            //      Passengers = x.Planes.Sum(y => y.Flights.Sum(z => z.Passengers)),
            //    }
            //    ).ToList
            //dataGridView1.DataSource = mc;


            List<MyClass> mc = (
                from company in db.Companies
                join planes in db.Planes on company.Id equals planes.CompanyId
                join flights in db.Flights on planes.Id equals flights.PlaneId
                select company
                ).Select(x => new MyClass
                {
                    Logo  = x.Image,
                    Name = x.Name,
                    Passengers = x.Planes.Sum(y => y.Flights.Sum(z => z.Passengers))
                }).ToList();
            dataGridView1.DataSource = mc;

            (dataGridView1.Columns["Logo"] as DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Zoom;
        }
    }
}
