using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOTO
{
    public partial class FrmLoto : Form
    {
        private Loto loto;
        public FrmLoto()
        {
            InitializeComponent();
            loto = new Loto();
        }

        private void btnUplati_Click(object sender, EventArgs e)
        {
            List<string> listUplati = new List<string>();
            listUplati.Add(txtUplaceniBroj1.Text);
            listUplati.Add(txtUplaceniBroj2.Text);
            listUplati.Add(txtUplaceniBroj3.Text);
            listUplati.Add(txtUplaceniBroj4.Text);
            listUplati.Add(txtUplaceniBroj5.Text);
            listUplati.Add(txtUplaceniBroj6.Text);
            listUplati.Add(txtUplaceniBroj7.Text);

            bool ispravni = loto.unesiUplaceneBrojeve(listUplati);
            if(ispravni == true)
            {
                btnOdigraj.Enabled = true;
            }
            else
            {
                btnOdigraj.Enabled = false;
                MessageBox.Show("neispravna kombinacija");
            }
        }

        private void btnOdigraj_Click(object sender, EventArgs e)
        {
            loto.generirajDobitnuKombinaciju();
            txtDobitniBroj1.Text = loto.dobitniBrojevi[0].ToString();
            txtDobitniBroj2.Text = loto.dobitniBrojevi[1].ToString();
            txtDobitniBroj3.Text = loto.dobitniBrojevi[2].ToString();
            txtDobitniBroj4.Text = loto.dobitniBrojevi[3].ToString();
            txtDobitniBroj5.Text = loto.dobitniBrojevi[4].ToString();
            txtDobitniBroj6.Text = loto.dobitniBrojevi[5].ToString();
            txtDobitniBroj7.Text = loto.dobitniBrojevi[6].ToString();

            lblBrojPogodaka.Text = loto.izracunajBrojPogodaka().ToString();
        }
    }
}
