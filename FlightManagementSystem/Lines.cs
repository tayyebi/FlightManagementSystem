using FlightManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FlightManagementSystem.Program;

namespace FlightManagementSystem
{
    public partial class Lines : FatherForm
    {
        public Lines()
        {
            InitializeComponent();
        }

        private Modes _CurrentMode;
        public Modes CurrentMode
        {
            get { return _CurrentMode; }
            set
            {
                _CurrentMode = value;
                switch (value)
                {
                    case Modes.Insert:
                        textBox2.Text = textBox3.Text = textBox4.Text = textBox1.Text = string.Empty;
                        dataGridView1.DataSource = db.Planes.Select(x => new { x.Id, x.Name }).ToList();
                        break;
                    case Modes.Update:
                        break;
                    case Modes.Delete:
                        break;
                    case Modes.Details:
                        break;
                    default:
                        break;
                }
                if (value != Modes.Insert)
                {
                    textBox1.Text = Selected.FromCity;
                    textBox2.Text = Selected.FromAirport;
                    textBox3.Text = Selected.ToCity;
                    textBox4.Text = Selected.ToAirport;
                }
                dataGridView1.DataSource = db.Lines.ToList();
            }
        }

        public Line Selected;

        private void button2_Click(object sender, EventArgs e)
        {
            CurrentMode = Modes.Insert;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (CurrentMode)
            {
                case Modes.Insert:
                    db.Lines.Add(
                        new Line
                        {
                            FromCity = textBox1.Text,
                            FromAirport = textBox2.Text,
                            ToCity = textBox3.Text,
                            ToAirport = textBox4.Text,
                        }
                        );
                    break;
                case Modes.Update:
                    Selected.FromCity = textBox1.Text;
                    Selected.FromAirport = textBox2.Text;
                    Selected.ToCity = textBox3.Text;
                    Selected.ToAirport = textBox4.Text;
                    break;
                case Modes.Delete:
                    db.Lines.Remove(Selected);
                    break;
            }
            db.SaveChanges();
            CurrentMode = Modes.Insert;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Selected = db.Lines.Find(int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString()));
            if (e.ColumnIndex == 2)
            {
                CurrentMode = Modes.Details;
            }
            else if (e.ColumnIndex == 1)
            {
                CurrentMode = Modes.Delete;
            }
            else if (e.ColumnIndex == 0)
            {
                CurrentMode = Modes.Update;
            }

        }

        private void Lines_Load(object sender, EventArgs e)
        {
            CurrentMode = Modes.Insert;
        }
    }
}
