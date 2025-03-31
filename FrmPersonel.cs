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
    public partial class FrmPersonel : DevExpress.XtraEditors.XtraForm
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        //personel listeleme
        void PersonelListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From tblPersoneller", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        //temizleme
        void Temizle()
        {
            TxtID.Text = "";
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            TxtTel.Text = "";
            TxtTc.Text = "";
            TxtMail.Text = "";
            TxtIl.SelectedIndex=0;
            TxtIlce.SelectedIndex=0;
            TxtGorev.Text = "";
            TxtAdres.Text = "";
        }
        //illeri comboboxa çekme
        void SehirListesi()
        {
            TxtIl.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("Select CityName From Cities", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtIl.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
            TxtIl.SelectedIndex = 0;
        }
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            PersonelListele();
            SehirListesi();
        }
        //personel ekleme
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            // hata kontrolü
            if (TxtAd.Text == "" || TxtSoyad.Text == "" || TxtTel.Text == "" || TxtTc.Text == "" || TxtMail.Text == "" || TxtIl.Text == "" || TxtIlce.Text == "" || TxtGorev.Text == "" || TxtAdres.Text == "")
            {
                XtraMessageBox.Show("Lütfen Boş Alanları Doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlCommand komut = new SqlCommand("insert into tblPersoneller (Ad,Soyad,Telefon,TC,Mail,Il,Ilce,Gorev,Adres) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", TxtTel.Text);
            komut.Parameters.AddWithValue("@p4", TxtTc.Text);
            komut.Parameters.AddWithValue("@p5", TxtMail.Text);
            komut.Parameters.AddWithValue("@p6", TxtIl.Text);
            komut.Parameters.AddWithValue("@p7", TxtIlce.Text);
            komut.Parameters.AddWithValue("@p8", TxtGorev.Text);
            komut.Parameters.AddWithValue("@p9", TxtAdres.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            XtraMessageBox.Show("Personel Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PersonelListele();
            Temizle();
        }
        //personel güncelleme
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            //hata kontrolü
            if (TxtAd.Text == "" || TxtSoyad.Text == "" || TxtTel.Text == "" || TxtTc.Text == "" || TxtMail.Text == "" || TxtIl.Text == "" || TxtIlce.Text == "" || TxtGorev.Text == "" || TxtAdres.Text == "")
            {
                XtraMessageBox.Show("Lütfen Boş Alanları Doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlCommand komut = new SqlCommand("update tblPersoneller set Ad=@p1,Soyad=@p2,Telefon=@p3,TC=@p4,Mail=@p5,Il=@p6,Ilce=@p7,Gorev=@p8,Adres=@p9 where ID=@p10", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", TxtTel.Text);
            komut.Parameters.AddWithValue("@p4", TxtTc.Text);
            komut.Parameters.AddWithValue("@p5", TxtMail.Text);
            komut.Parameters.AddWithValue("@p6", TxtIl.Text);
            komut.Parameters.AddWithValue("@p7", TxtIlce.Text);
            komut.Parameters.AddWithValue("@p8", TxtGorev.Text);
            komut.Parameters.AddWithValue("@p9", TxtAdres.Text);
            komut.Parameters.AddWithValue("@p10", TxtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            XtraMessageBox.Show("Personel Bilgileri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PersonelListele();
            Temizle();
        }
        //personel silme
        private void BtnSil_Click(object sender, EventArgs e)
        {
            //hata kontrolü
            if (TxtID.Text == "")
            {
                XtraMessageBox.Show("Lütfen Personel Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlCommand komut = new SqlCommand("delete from tblPersoneller where ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            XtraMessageBox.Show("Personel Sistemden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            PersonelListele();
            Temizle();
        }
        //Seçilen ilin ilçelerini getirme
        private void TxtIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtIlce.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("Select DistrictName From Districts where CityID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtIl.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtIlce.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
            TxtIlce.SelectedIndex = 0;
        }
        //gridviewdeki verileri textboxlara çekme
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                TxtID.Text = dr["ID"].ToString();
                TxtAd.Text = dr["Ad"].ToString();
                TxtSoyad.Text = dr["Soyad"].ToString();
                TxtTel.Text = dr["Telefon"].ToString();
                TxtTc.Text = dr["TC"].ToString();
                TxtMail.Text = dr["Mail"].ToString();
                TxtIl.Text = dr["Il"].ToString();
                TxtIlce.Text = dr["Ilce"].ToString();
                TxtGorev.Text = dr["Gorev"].ToString();
                TxtAdres.Text = dr["Adres"].ToString();
            }
        }
    }
}