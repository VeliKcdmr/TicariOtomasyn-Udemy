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
    public partial class FrmMusteriler : DevExpress.XtraEditors.XtraForm
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        void Listele()
        {
            //veritabanındaki musteriler tablosundaki tüm verileri çekip gridcontrol'e dolduruyoruz
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From tblMusteriler", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
            //illeri comboboxa dolduruyoruz
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
        //işlem sonrası temizlemek için metot
        void Temizle()
        {
            TxtID.Text = "";
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            TxtTel1.Text = "";
            TxtTel2.Text = "";
            TxtTc.Text = "";
            TxtMail.Text = "";
            TxtIl.SelectedIndex = 0;
            TxtIlce.SelectedIndex = 0;
            TxtVD.Text = "";
            TxtAdres.Text = "";

        }
        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            //boş alan kontrolü
            if (TxtAd.Text == "" || TxtSoyad.Text == "" || TxtTel1.Text == "" || TxtTc.Text == "" || TxtMail.Text == "" || TxtIl.Text == "" || TxtIlce.Text == "" || TxtVD.Text == "" || TxtAdres.Text == "")
            {
                XtraMessageBox.Show("Lütfen Boş Alan Bırakmayınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //müşteri ekleme
            SqlCommand komut = new SqlCommand("Insert Into tblMusteriler (Ad,Soyad,Telefon,Telefon2,TC,Mail,Il,Ilce,VergiDairesi,Adres) Values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", TxtTel1.Text);
            komut.Parameters.AddWithValue("@p4", TxtTel2.Text);
            komut.Parameters.AddWithValue("@p5", TxtTc.Text);
            komut.Parameters.AddWithValue("@p6", TxtMail.Text);
            komut.Parameters.AddWithValue("@p7", TxtIl.Text);
            komut.Parameters.AddWithValue("@p8", TxtIlce.Text);
            komut.Parameters.AddWithValue("@p9", TxtVD.Text);
            komut.Parameters.AddWithValue("@p10", TxtAdres.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            XtraMessageBox.Show("Müşteri Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle();
            Listele();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            //boş alan kontrolü
            if (TxtAd.Text == "" || TxtSoyad.Text == "" || TxtTel1.Text == "" || TxtTc.Text == "" || TxtMail.Text == "" || TxtIl.Text == "" || TxtIlce.Text == "" || TxtVD.Text == "" || TxtAdres.Text == "")
            {
                XtraMessageBox.Show("Lütfen Boş Alan Bırakmayınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //müşteri güncelleme
            SqlCommand komut = new SqlCommand("Update tblMusteriler Set Ad=@p1,Soyad=@p2,Telefon=@p3,Telefon2=@p4,TC=@p5,Mail=@p6,Il=@p7,Ilce=@p8,VergiDairesi=@p9,Adres=@p10 Where ID=@p11", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", TxtTel1.Text);
            komut.Parameters.AddWithValue("@p4", TxtTel2.Text);
            komut.Parameters.AddWithValue("@p5", TxtTc.Text);
            komut.Parameters.AddWithValue("@p6", TxtMail.Text);
            komut.Parameters.AddWithValue("@p7", TxtIl.Text);
            komut.Parameters.AddWithValue("@p8", TxtIlce.Text);
            komut.Parameters.AddWithValue("@p9", TxtVD.Text);
            komut.Parameters.AddWithValue("@p10", TxtAdres.Text);
            komut.Parameters.AddWithValue("@p11", TxtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            XtraMessageBox.Show("Müşteri Bilgileri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle();
            Listele();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            //müşteri silme
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Müşteri Silinsin mi?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Delete From tblMusteriler Where ID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtID.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Müşteri Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
                Listele();
            }
        }

        private void TxtIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ile göre ilçeri comboboxa dolduruyoruz
            TxtIlce.Properties.Items.Clear();
            SqlCommand komut2 = new SqlCommand("Select DistrictName From Districts Where CityID=@p1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", TxtIl.SelectedIndex + 1);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                TxtIlce.Properties.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
            TxtIlce.SelectedIndex = 0;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                TxtID.Text = dr["ID"].ToString();
                TxtAd.Text = dr["Ad"].ToString();
                TxtSoyad.Text = dr["Soyad"].ToString();
                TxtTel1.Text = dr["Telefon"].ToString();
                TxtTel2.Text = dr["Telefon2"].ToString();
                TxtTc.Text = dr["TC"].ToString();
                TxtMail.Text = dr["Mail"].ToString();
                TxtIl.Text = dr["Il"].ToString();
                TxtIlce.Text = dr["Ilce"].ToString();
                TxtVD.Text = dr["VergiDairesi"].ToString();
                TxtAdres.Text = dr["Adres"].ToString();
            }
        }
    }
}