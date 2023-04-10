using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ogrencıler
{
    public partial class FaturaEkranı : Form
    {
        OgrenciDersDBEntities3 db = new OgrenciDersDBEntities3();

        public void DOLDUR()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MusterıID");
            dt.Columns.Add("Adı");
            dt.Columns.Add("Soyadı");
            dt.Columns.Add("Telefon");
            dt.Columns.Add("UrunAdı");
            dt.Columns.Add("UrunAdeti");
            dt.Columns.Add("UrunFıyati");
            dt.Columns.Add("Tutar");
            dt.Columns.Add("Giriş Tarihi");

            foreach (var item in db.FATURAMERKEZI.ToList())
            {
                dt.Rows.Add(item.ID, item.Adı, item.Soyadı, item.Telefon, item.UrunAdı, item.UrunAdet, item.UrunFıyat, item.Tutar, item.GırısTarıhı);
            }
            DgvLıstele.DataSource = dt;

        }



        public FaturaEkranı()
        {
            InitializeComponent();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            FATURAMERKEZI F = new FATURAMERKEZI();
            F.Adı = TxtMadı.Text;
            F.Soyadı = TxtSoyadı.Text;
            F.Telefon = TxtNumara.Text;
            F.UrunAdı = TxtUrunAdı.Text;
            F.UrunAdet = Convert.ToInt32(TxtAdet.Text);
            F.UrunFıyat = Convert.ToDecimal(TxtFıyat.Text);
            F.Tutar = Convert.ToDecimal(TxtTutar.Text);
            F.GırısTarıhı = Convert.ToDateTime(DtpTarıh.Text);
            db.FATURAMERKEZI.Add(F);
            db.SaveChanges();
            MessageBox.Show(" FATURA EKLEME İŞLEMİ BAŞARILI ");
            DOLDUR();


        }

        private void FaturaEkranı_Load(object sender, EventArgs e)
        {
            DOLDUR();
        }

        private void DtpTarıh_ValueChanged(object sender, EventArgs e)
        {
            int TUTAR;
            DateTime GırısTarıhı = Convert.ToDateTime(DtpTarıh.Text);

            int Adet = int.Parse(TxtAdet.Text);
            int Fiyat = int.Parse(TxtFıyat.Text);

            int Sonuc;
            TUTAR = Adet * Fiyat ;
            
            TxtTutar.Text = TUTAR.ToString();
        }

        int ID = 0;

        private void DgvLıstele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtMadı.Text = DgvLıstele.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtSoyadı.Text = DgvLıstele.Rows[e.RowIndex].Cells[2].Value.ToString();
            TxtNumara.Text = DgvLıstele.Rows[e.RowIndex].Cells[3].Value.ToString();
            TxtUrunAdı.Text = DgvLıstele.Rows[e.RowIndex].Cells[4].Value.ToString();
            TxtAdet.Text = DgvLıstele.Rows[e.RowIndex].Cells[5].Value.ToString();
            TxtFıyat.Text = DgvLıstele.Rows[e.RowIndex].Cells[6].Value.ToString();
            TxtTutar.Text = DgvLıstele.Rows[e.RowIndex].Cells[7].Value.ToString();
            ID = Convert.ToInt32(DgvLıstele.Rows[e.RowIndex].Cells[0].Value.ToString());


        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                FATURAMERKEZI F = db.FATURAMERKEZI.Find(ID);
                F.Adı = TxtMadı.Text;
                F.Soyadı = TxtSoyadı.Text;
                F.Telefon = TxtNumara.Text;
                F.UrunAdı = TxtUrunAdı.Text;
                F.UrunAdet = Convert.ToInt32(TxtAdet.Text);
                F.UrunFıyat = Convert.ToDecimal(TxtFıyat.Text);
                F.Tutar = Convert.ToDecimal(TxtTutar.Text);
                db.SaveChanges();
                DOLDUR();
                MessageBox.Show(" GÜNCELLEME İŞLEMİ BAŞARILI ");
            }
            else
            {
                MessageBox.Show(" LÜTFEN GÜNCELLEME İŞLEMİ İÇİN SEÇİM YAPIN ");
            }
        }

        private void BtnSıl_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                FATURAMERKEZI F = new FATURAMERKEZI();
                db.FATURAMERKEZI.Remove(F);
                db.SaveChanges();
                DOLDUR();
                MessageBox.Show(" SİLME İŞLEMİ BAŞARILI ");
            }
            else
            {
                MessageBox.Show(" LÜTFEN SİLME İŞLEMİ İÇİN SEÇİN YAPIN");
            }
        }
    }
}
