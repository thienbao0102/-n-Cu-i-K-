using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKyLTHDT
{
    public partial class DKOKTX : Form
    {

        private Point lastLocation;
        public DKOKTX()
        {
            InitializeComponent();
        }

        private void BackPage_Click(object sender, EventArgs e)
        {

            lastLocation = this.Location;
            this.Hide();

            Login f = new Login();

            f.StartPosition = FormStartPosition.Manual;
            f.Location = lastLocation;

            f.ShowDialog();
            
        }
    }
}
