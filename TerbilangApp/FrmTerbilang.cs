using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerbilangLibrary;
namespace TerbilangApp
{
    public partial class FrmTerbilang : Form
    {
        public FrmTerbilang()
        {
            InitializeComponent();
        }

        private void btnCek_Click(object sender, EventArgs e)
        {
            int nominal = int.Parse(txtNominal.Text);
            Terbilang terbilang = new Terbilang();
            tampil.Items.Clear();
            tampil.Items.Add(terbilang.TerbilangIndonesia(nominal));
        }
    }
}