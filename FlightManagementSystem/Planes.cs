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
    public partial class Planes : FatherForm
    {
        public Planes()
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
                        textBox1.Text = string.Empty;
                        rexaImage1.BackgroundImage = null;
                        label3.Text = "Please select an image";
                        numericUpDown1.Value = 0;
                        numericUpDown2.Value = 2012;

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
                    textBox1.Text = Selected.Name;
                    label3.Text = "Please select an image";
                    numericUpDown1.Value = Selected.Capacity;
                    numericUpDown2.Value = Selected.ProduceYear;
                    Stream s = new MemoryStream(Selected.Image);
                    rexaImage1.BackgroundImage = new Bitmap(s);
                    comboBox1.SelectedValue = Selected.CompanyId;
                }
            }
        }



        private void Planes_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = db.Companies.ToList();
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "Name";

            CurrentMode = Modes.Insert;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CurrentMode = Modes.Insert;
        }

        public Plane Selected;

        private void button1_Click(object sender, EventArgs e)
        {
            if (label3.Text == "Please select an image" || textBox1.Text == string.Empty || numericUpDown1.Value <= 0 || numericUpDown2.Value <= 0)
            {
                if (CurrentMode == Modes.Insert || CurrentMode == Modes.Update)
                {
                    MessageBox.Show("Please fill out all fields.");
                    return;
                }
            }

            switch (CurrentMode)
            {
                case Modes.Insert:
                    db.Planes.Add
                        (
                        new Plane
                        {
                            Name = textBox1.Text,
                            Capacity
                             = (int)numericUpDown1.Value,
                            ProduceYear = (int)numericUpDown2.Value,
                            Image = File.ReadAllBytes(label3.Text),
                            CompanyId = (int)comboBox1.SelectedValue
                        }
                        );

                    break;
                case Modes.Update:
                    Selected.Name = textBox1.Text;
                    Selected.Capacity
                            = (int)numericUpDown1.Value;
                    Selected.ProduceYear = (int)numericUpDown2.Value;
                    Selected.Image = File.ReadAllBytes(label3.Text);
                    Selected.CompanyId = (int)comboBox1.SelectedValue;
                    break;
                case Modes.Delete:
                    db.Planes.Remove(Selected);
                    break;
                default:
                    break;
            }
            db.SaveChanges();
            CurrentMode = Modes.Insert;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Selected = db.Planes.Find(int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString()));
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

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All files|*.*|BMP|*.bmp|JPG|*.jpg|JPEG|*.jpeg|PNG|*.png|TIF|*.tif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    rexaImage1.BackgroundImage = Bitmap.FromFile(ofd.FileName);
                    label3.Text = ofd.FileName;
                }
                catch
                {
                    MessageBox.Show("Please select a valid image");

                }

            }

        }
    }
}
