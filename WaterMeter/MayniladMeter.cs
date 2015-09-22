//
// Programmed by: Alfred Benigno
//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterMeter
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void meterValidate()
        {
            string valInit = numI1.Value.ToString() + numI2.Value.ToString() + numI3.Value.ToString();
            double init = double.Parse(valInit);
            string valFin = numF1.Value.ToString() + numF2.Value.ToString() + numF3.Value.ToString();
            double fin = double.Parse(valFin);

            double cubic = int.Parse(numFinal.Value.ToString()) - int.Parse(numInitial.Value.ToString());
            double liters = cubic * 1000;

            if(fin >= init)
            {
                liters += fin - init;
            }
            else if(fin < init)
            {
                liters += fin;
            }
            
            
            lblCubic.Text = cubic.ToString();
            lblLiters.Text = liters.ToString();

            double amount = (liters / double.Parse(txtChargeLiters.Text) * double.Parse(txtChargeRate.Text));
            lblAmount.Text = string.Concat("Php ",amount);
        }

        private void numInitial_ValueChanged(object sender, EventArgs e)
        {
            meterValidate();
        }

        private void numFinal_ValueChanged(object sender, EventArgs e)
        {
            meterValidate();
        }

        private void numI1_ValueChanged(object sender, EventArgs e)
        {
            meterValidate();
        }

        private void numI2_ValueChanged(object sender, EventArgs e)
        {
            meterValidate();
        }

        private void numI3_ValueChanged(object sender, EventArgs e)
        {
            meterValidate();
        }

        private void numI4_ValueChanged(object sender, EventArgs e)
        {
            meterValidate();
        }

        private void numF1_ValueChanged(object sender, EventArgs e)
        {
            meterValidate();
        }

        private void numF2_ValueChanged(object sender, EventArgs e)
        {
            meterValidate();
        }

        private void numF3_ValueChanged(object sender, EventArgs e)
        {
            meterValidate();
        }

        private void numF4_ValueChanged(object sender, EventArgs e)
        {
            meterValidate();
        }

        private void numInitial_Click(object sender, EventArgs e)
        {
            numInitial.Select(0, 5);
        }

        private void numFinal_Click(object sender, EventArgs e)
        {
            numFinal.Select(0, 5);
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Thank you for using the program!", "Quit", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programmed by: Alfred Benigno", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numF1_Click(object sender, EventArgs e)
        {
            numF1.Select(0, 1);
        }

        private void numF2_Click(object sender, EventArgs e)
        {
            numF2.Select(0, 1);
        }

        private void numF3_Click(object sender, EventArgs e)
        {
            numF3.Select(0, 1);
        }

        private void numF4_Click(object sender, EventArgs e)
        {
            numF4.Select(0, 1);
        }

        private void numI1_Click(object sender, EventArgs e)
        {
            numI1.Select(0, 1);
        }

        private void numI2_Click(object sender, EventArgs e)
        {
            numI2.Select(0, 1);
        }

        private void numI3_Click(object sender, EventArgs e)
        {
            numI4.Select(0, 1);
        }

        private void numI4_Click(object sender, EventArgs e)
        {
            numI4.Select(0, 1);
        }

        private void txtChargeRate_Click(object sender, EventArgs e)
        {
            txtChargeRate.Select(0, txtChargeRate.TextLength);
        }

        private void txtChargeLiters_Click(object sender, EventArgs e)
        {
            txtChargeLiters.Select(0, txtChargeLiters.TextLength);
        }

        private void txtChargeRate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(txtChargeRate.Text) < 0)
                {
                    txtChargeRate.Text = "0";
                }
                meterValidate();
            }
            catch { }
        }

        private void txtChargeLiters_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(double.Parse(txtChargeLiters.Text) < 0)
                {
                    txtChargeLiters.Text = "0";
                }
                meterValidate();
            }
            catch { }
        }

        private void frmMain_LocationChanged(object sender, EventArgs e)
        {
            statusStrip.Text = string.Concat(Location.X, ",", Location.Y);
        }
    }
}
