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
    public partial class Companies : FatherForm
    {
        public Companies()
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
                dataGridView1.DataSource = db.Companies.Select(x => new { x.Id, x.Name }).ToList();
                switch (value)
                {
                    case Modes.Insert:
                        textBox1.Text = string.Empty;
                        rexaImage1.BackgroundImage = null;
                        label3.Text = "Please select an image";
                        break;
                    case Modes.Update:
                        break;
                    case Modes.Delete:
                        break;
                    default:
                        break;
                }
                if (value != Modes.Insert)
                {
                    textBox1.Text = Selected.Name;
                    label3.Text = "Please select an image";

                    Stream s = new MemoryStream(Selected.Image);
                    rexaImage1.BackgroundImage = new Bitmap(s);
                }

            }



        }



        private void button2_Click(object sender, EventArgs e)
        {
            CurrentMode = Modes.Insert;
        }

        private void Companies_Load(object sender, EventArgs e)
        {
            CurrentMode = Modes.Insert;

        }
        public Company Selected;

        private void button1_Click(object sender, EventArgs e)
        {
            if ((label3.Text == "Please select an image" || textBox1.Text == string.Empty)&&(CurrentMode == Modes.Insert || CurrentMode == Modes.Update))
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }
            switch (CurrentMode)
            {
                case Modes.Insert:
                    byte[] MyImage = File.ReadAllBytes(label3.Text);
                    db.Companies.Add(new Company { Name = textBox1.Text, Image  = MyImage});
                    break;
                case Modes.Update:
                    Selected.Name = textBox1.Text;
                    Selected.Image = File.ReadAllBytes(label3.Text);
                    break;
                case Modes.Delete:
                    db.Companies.Remove(Selected);
                    break;
                default:
                    break;
            }
            db.SaveChanges();
            CurrentMode = Modes.Insert;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Selected = db.Companies.Find(int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString()));
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
    }
}
