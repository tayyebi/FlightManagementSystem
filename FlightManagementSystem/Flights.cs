using FlightManagementSystem.Models;
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
using static FlightManagementSystem.Program;

namespace FlightManagementSystem
{
    public partial class Flights : FatherForm
    {
        public Flights()
        {
            InitializeComponent();
        }

        private void Flights_Load(object sender, EventArgs e)
        {
            CurrentMode = Modes.Insert;
            comboBox1.DataSource = db.Lines.Select(x => new { x.Id, Name = x.FromCity + " -> " + x.ToCity + "• Airports: " + x.FromAirport + " -> " + x.ToAirport }).ToList();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
            comboBox2.DataSource = db.Planes.ToList();
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "Id";
        }

        public Flight Selected;
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
                        dataGridView1.DataSource = db.Planes.Select(x => new { x.Id, x.Name }).ToList();
                        textBox1.Value = 0;
                        textBox3.Text = "[None]";
                        numericUpDown1.Value = 0;
                        numericUpDown2.Value = 0;
                        dateTimePicker1.Value = dateTimePicker2.Value = DateTime.Now;
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
                    textBox1.Value = Selected.Passengers;
                    comboBox1.SelectedItem = Selected.LineId;
                    comboBox2.SelectedItem = Selected.PlaneId;
                    textBox3.Text = Selected.Stauts;
                    dateTimePicker1.Value = Selected.TakeOfMoment;
                    dateTimePicker2.Value = Selected.LandingMoment;
                    numericUpDown1.Value = (int)Selected.LandingAirportRunawayNumber;
                    numericUpDown2.Value = (int)Selected.LandingAirportRunawayNumberHost;
                }
                dateTimePicker1.Format = dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = dateTimePicker1.CustomFormat = "yyyy/MM/dd HH:MM";
                dataGridView1.DataSource = db.Flights.OrderByDescending(x => x.TakeOfMoment).ToList();
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Selected = db.Flights.Find(int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString()));
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

        private void button1_Click(object sender, EventArgs e)
        {
            switch (CurrentMode)
            {
                case Modes.Insert:
                    db.Flights.Add(
                        new Flight
                        {
                            Passengers = (int)textBox1.Value,
                            LineId = (int)comboBox1.SelectedValue,
                            PlaneId = (int)comboBox2.SelectedValue,
                            Stauts = textBox3.Text,
                            TakeOfMoment = dateTimePicker1.Value,
                            LandingMoment = dateTimePicker2.Value,
                            LandingAirportRunawayNumber = (short)numericUpDown1.Value,
                            LandingAirportRunawayNumberHost = (short)numericUpDown2.Value,
                        });
                    break;
                case Modes.Update:
                    Selected.Passengers = (int)textBox1.Value;
                    Selected.LineId = (int)comboBox1.SelectedValue;
                    Selected.PlaneId = (int)comboBox2.SelectedValue;
                    Selected.Stauts = textBox3.Text;
                    Selected.TakeOfMoment = dateTimePicker1.Value;
                    Selected.LandingMoment = dateTimePicker2.Value;
                    Selected.LandingAirportRunawayNumber = (short)numericUpDown1.Value;
                    Selected.LandingAirportRunawayNumberHost = (short)numericUpDown2.Value;
                    break;
                case Modes.Delete:
                    db.Flights.Remove(Selected);
                    break;
            }
            db.SaveChanges();
            CurrentMode = Modes.Insert;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            rexaImage1.BackgroundImage = new Bitmap(new MemoryStream(((Plane)comboBox2.SelectedItem).Image));
        }
    }
}
