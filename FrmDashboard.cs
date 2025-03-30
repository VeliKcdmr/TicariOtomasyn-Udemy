using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicariOtomasyn
{
    public partial class FrmDashboard : DevExpress.XtraEditors.XtraForm
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }
        FrmUrunler frmUrunler;
        private void BtnUrunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmUrunler == null || frmUrunler.IsDisposed)
            {
                frmUrunler = new FrmUrunler();
                frmUrunler.MdiParent = this;
                frmUrunler.Show();
            }

        }
        FrmMusteriler frmMusteriler;
        private void BtnMusteriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmMusteriler == null || frmMusteriler.IsDisposed)
            {
                frmMusteriler = new FrmMusteriler();
                frmMusteriler.MdiParent = this;
                frmMusteriler.Show();
            }

        }
    }
}