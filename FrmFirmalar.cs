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
            TxtIl.SelectedIndex = 0;
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
        void CitiesList()
        {
            TxtIl.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("Select CityName from Cities", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtIl.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
            TxtIl.SelectedIndex = 0;
        }
        void CariKodAciklama()
        {
            SqlCommand komut = new SqlCommand("Select FirmaKod1 from tblKodlar", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                MTextOKod1.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
        }

        private void FrmFirmalar_Load(object sender, EventArgs e)
        {
            FirmaListesi();
            CitiesList();
            CariKodAciklama();
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
            //hata kontrolü
            if (TxtAd.Text == "" || TxtSektor.Text == "" || TxtYetkili.Text == "" || TxtYGorev.Text == "" || TxtYTc.Text == "" || TxtMail.Text == "" || TxtFax.Text == "" || TxtTel1.Text == "" || TxtTel2.Text == "" || TxtTel3.Text == "" || TxtIl.Text == "" || TxtIlce.Text == "" || TxtVD.Text == "" || TxtAdres.Text == "")
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Firma Ekleme
            SqlCommand komut = new SqlCommand("insert into tblFirmalar (Ad,Sektor,YetkiliStatu,YetkiliAdSoyad,YetkiliTc,Telefon1,Telefon2,Telefon3,Mail,Fax,IL,ILCE,VergiDaire,Adres,OzelKod1,OzelKod2,OzelKod3) Values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSektor.Text);
            komut.Parameters.AddWithValue("@p3", TxtYetkili.Text);
            komut.Parameters.AddWithValue("@p4", TxtYGorev.Text);
            komut.Parameters.AddWithValue("@p5", TxtYTc.Text);
            komut.Parameters.AddWithValue("@p6", TxtTel1.Text);
            komut.Parameters.AddWithValue("@p7", TxtTel2.Text);
            komut.Parameters.AddWithValue("@p8", TxtTel3.Text);
            komut.Parameters.AddWithValue("@p9", TxtMail.Text);
            komut.Parameters.AddWithValue("@p10", TxtFax.Text);
            komut.Parameters.AddWithValue("@p11", TxtIl.Text);
            komut.Parameters.AddWithValue("@p12", TxtIlce.Text);
            komut.Parameters.AddWithValue("@p13", TxtVD.Text);
            komut.Parameters.AddWithValue("@p14", TxtAdres.Text);
            komut.Parameters.AddWithValue("@p15", TxtOKod1.Text);
            komut.Parameters.AddWithValue("@p16", TxtOKod2.Text);
            komut.Parameters.AddWithValue("@p17", TxtOKod3.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Firma Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
            FirmaListesi();
        }
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            //hata kontrolü
            if (TxtAd.Text == "" || TxtSektor.Text == "" || TxtYetkili.Text == "" || TxtYGorev.Text == "" || TxtYTc.Text == "" || TxtMail.Text == "" || TxtFax.Text == "" || TxtTel1.Text == "" || TxtTel2.Text == "" || TxtTel3.Text == "" || TxtIl.Text == "" || TxtIlce.Text == "" || TxtVD.Text == "" || TxtAdres.Text == "")
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Firma Güncelleme
            SqlCommand komut = new SqlCommand("update tblFirmalar set Ad=@p1,Sektor=@p2,YetkiliStatu=@p3,YetkiliAdSoyad=@p4,YetkiliTc=@p5,Telefon1=@p6,Telefon2=@p7,Telefon3=@p8,Mail=@p9,Fax=@p10,IL=@p11,ILCE=@p12,VergiDaire=@p13,Adres=@p14,OzelKod1=@p15,OzelKod2=@p16,OzelKod3=@p17 where ID=@p18", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSektor.Text);
            komut.Parameters.AddWithValue("@p3", TxtYetkili.Text);
            komut.Parameters.AddWithValue("@p4", TxtYGorev.Text);
            komut.Parameters.AddWithValue("@p5", TxtYTc.Text);
            komut.Parameters.AddWithValue("@p6", TxtTel1.Text);
            komut.Parameters.AddWithValue("@p7", TxtTel2.Text);
            komut.Parameters.AddWithValue("@p8", TxtTel3.Text);
            komut.Parameters.AddWithValue("@p9", TxtMail.Text);
            komut.Parameters.AddWithValue("@p10", TxtFax.Text);
            komut.Parameters.AddWithValue("@p11", TxtIl.Text);
            komut.Parameters.AddWithValue("@p12", TxtIlce.Text);
            komut.Parameters.AddWithValue("@p13", TxtVD.Text);
            komut.Parameters.AddWithValue("@p14", TxtAdres.Text);
            komut.Parameters.AddWithValue("@p15", TxtOKod1.Text);
            komut.Parameters.AddWithValue("@p16", TxtOKod2.Text);
            komut.Parameters.AddWithValue("@p17", TxtOKod3.Text);
            komut.Parameters.AddWithValue("@p18", TxtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Firma Bilgileri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
            FirmaListesi();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            //hata kontrolü
            if (TxtID.Text == "")
            {
                MessageBox.Show("Lütfen Firma Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Firma Silme
            SqlCommand komut = new SqlCommand("delete from tblFirmalar where ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Firma Sistemden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
            FirmaListesi();
        }

        private void TxtIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //il seçildiğinde ilçeleri getirme
            TxtIlce.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("Select DistrictName from Districts where CityID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtIl.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtIlce.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
            TxtIlce.SelectedIndex = 0;

        }
    }
}