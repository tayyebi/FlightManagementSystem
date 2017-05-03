using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightManagementSystem
{
    public partial class RexaImage : PictureBox
    {
        public RexaImage()
        {
            InitializeComponent();
        }

        public RexaImage(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void RexaImage_Click(object sender, EventArgs e)
        {
            if (BackgroundImage != null)
            {
                var f = new Form1();
                f.BackgroundImage = BackgroundImage;
                f.ShowDialog();
            }
        }
    }
}
