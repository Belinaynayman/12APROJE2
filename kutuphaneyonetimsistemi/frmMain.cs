using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphaneyonetimsistemi
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnOdunc_Click(object sender, EventArgs e)
        {

        }

        private void btnKitapTur_Click(object sender, EventArgs e)
        {

        }

        private void btnKitap_Click(object sender, EventArgs e)
        {

        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            frmOgrenciler frmOgrenciler = new frmOgrenciler();
            frmOgrenciler.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.Everaldo_Desktoon_Library;
            this.Text = "Okul Kütüphane Programı";
        }
    }
}
