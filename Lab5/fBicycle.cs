using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLib;

namespace Lab5
{
    public partial class fBicycle : Form
    {
        public Bicycle bicycle = new Bicycle();
        public fBicycle(Bicycle b)
        {
            bicycle = b;
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bicycle.Model = tbModel.Text.Trim();
            bicycle.Frame = tbFrame.Text.Trim();
            bicycle.Broadcast = int.Parse(tbBroadcast.Text.Trim());
            bicycle.Fork = tbFork.Text.Trim();
            bicycle.Handlebars = tbHandlebars.Text.Trim();
            bicycle.Ring = chbRing.Checked;
            bicycle.Has3Wheels = chbHas3Wheels.Checked;

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void fPhone_Load(object sender, EventArgs e)
        {
            if (bicycle != null)
            {
                tbModel.Text = bicycle.Model;
                tbFrame.Text = bicycle.Frame;
                tbBroadcast.Text = bicycle.Broadcast.ToString();
                tbFork.Text = bicycle.Fork;
                tbHandlebars.Text = bicycle.Handlebars;
                chbRing.Checked = bicycle.Ring;
                chbHas3Wheels.Checked = bicycle.Has3Wheels;
            }

        }
    }
}
