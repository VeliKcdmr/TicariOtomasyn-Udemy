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
    public partial class FrmUrunler : DevExpress.XtraEditors.XtraForm
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From tblUrunler", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        //işlem sonrası temizlemek için metot
        void Temizle()
        {
            TxtID.Text = "";
            TxtAd.Text = "";
            TxtMarka.Text = "";
            TxtModel.Text = "";
            TxtYil.EditValue = DateTime.Now.Year;
            TxtAdet.Value = 0;
            TxtAFiyat.Text = "";
            TxtSFiyat.Text = "";
            TxtDetay.Text = "";
        }
        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            //boş alan kontrolü
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtMarka.Text) || string.IsNullOrEmpty(TxtModel.Text) || string.IsNullOrEmpty(TxtYil.Text) || string.IsNullOrEmpty(TxtAdet.Value.ToString()) || string.IsNullOrEmpty(TxtAFiyat.Text) || string.IsNullOrEmpty(TxtSFiyat.Text) || string.IsNullOrEmpty(TxtDetay.Text))
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //ürün ekleme
            SqlCommand komut = new SqlCommand("Insert into tblUrunler (UrunAd,Marka,Model,Yil,Adet,AlisFiyat,SatisFiyat,Detay) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtMarka.Text);
            komut.Parameters.AddWithValue("@p3", TxtModel.Text);
            komut.Parameters.AddWithValue("@p4", TxtYil.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse(TxtAdet.Value.ToString()));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(TxtAFiyat.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(TxtSFiyat.Text));
            komut.Parameters.AddWithValue("@p8", TxtDetay.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            //boş alan kontrolü
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtMarka.Text) || string.IsNullOrEmpty(TxtModel.Text) || string.IsNullOrEmpty(TxtYil.Text) || string.IsNullOrEmpty(TxtAdet.Value.ToString()) || string.IsNullOrEmpty(TxtAFiyat.Text) || string.IsNullOrEmpty(TxtSFiyat.Text) || string.IsNullOrEmpty(TxtDetay.Text))
            {
                XtraMessageBox.Show("Lütfen Boş Alanları Doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //ürün güncelleme
            SqlCommand komut = new SqlCommand("Update tblUrunler set UrunAd=@p1,Marka=@p2,Model=@p3,Yil=@p4,Adet=@p5,AlisFiyat=@p6,SatisFiyat=@p7,Detay=@p8 where ID=@p9", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtMarka.Text);
            komut.Parameters.AddWithValue("@p3", TxtModel.Text);
            komut.Parameters.AddWithValue("@p4", TxtYil.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse(TxtAdet.Value.ToString()));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(TxtAFiyat.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(TxtSFiyat.Text));
            komut.Parameters.AddWithValue("@p8", TxtDetay.Text);
            komut.Parameters.AddWithValue("@p9", TxtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            //boş alan kontrolü
            if (string.IsNullOrEmpty(TxtID.Text))
            {
                XtraMessageBox.Show("Lütfen Ürün Seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //ürün silme
            SqlCommand komut = new SqlCommand("Delete from tblUrunler where ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Sistemden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            Temizle();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                TxtID.Text = dr["ID"].ToString();
                TxtAd.Text = dr["UrunAd"].ToString();
                TxtMarka.Text = dr["Marka"].ToString();
                TxtModel.Text = dr["Model"].ToString();
                TxtYil.EditValue = dr["Yil"].ToString();
                TxtAdet.Value = int.Parse(dr["Adet"].ToString());
                TxtAFiyat.Text = dr["AlisFiyat"].ToString();
                TxtSFiyat.Text = dr["SatisFiyat"].ToString();
                TxtDetay.Text = dr["Detay"].ToString();
            }
        }
    }
}