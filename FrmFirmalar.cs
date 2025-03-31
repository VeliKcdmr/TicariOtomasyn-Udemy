using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicariOtomasyn
{
    public partial class FrmFirmalar : DevExpress.XtraEditors.XtraForm
    {
        public FrmFirmalar()
        {
            InitializeComponent();
        }
        void temizle()
        {
            TxtID.Text = "";
            TxtAd.Text = "";
            TxtSektor.Text = "";
            TxtYetkili.Text = "";
            TxtYGorev.Text = "";
            TxtYTc.Text = "";
            TxtMail.Text = "";
            TxtFax.Text = "";
            TxtTel1.Text = "";
            TxtTel2.Text = "";
            TxtTel3.Text = "";
            TxtIl.SelectedIndex=0;
            TxtIlce.SelectedIndex = 0;
            TxtVD.Text = "";
            TxtAdres.Text = "";
        }

        SqlBaglanti bgl = new SqlBaglanti();
        void FirmaListesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tblFirmalar", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void FrmFirmalar_Load(object sender, EventArgs e)
        {
            FirmaListesi();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            //firma bilgilerini gridviewden textboxlara aktarma
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                TxtID.Text = dr["ID"].ToString();
                TxtAd.Text = dr["Ad"].ToString();
                TxtSektor.Text = dr["Sektor"].ToString();
                TxtYetkili.Text = dr["YetkiliAdSoyad"].ToString();
                TxtYGorev.Text = dr["YetkiliStatu"].ToString();
                TxtYTc.Text = dr["YetkiliTc"].ToString();
                TxtMail.Text = dr["Mail"].ToString();
                TxtFax.Text = dr["Fax"].ToString();
                TxtTel1.Text = dr["Telefon1"].ToString();
                TxtTel2.Text = dr["Telefon2"].ToString();
                TxtTel3.Text = dr["Telefon3"].ToString();
                TxtIl.Text = dr["IL"].ToString();
                TxtIlce.Text = dr["ILCE"].ToString();
                TxtVD.Text = dr["VergiDaire"].ToString();
                TxtAdres.Text = dr["Adres"].ToString();
                TxtOKod1.Text = dr["OzelKod1"].ToString();
                TxtOKod2.Text = dr["OzelKod2"].ToString();
                TxtOKod3.Text = dr["OzelKod3"].ToString();                
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand(
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {

        }
    }
}