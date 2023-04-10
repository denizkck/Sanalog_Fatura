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
    public partial class Form1 : Form
    {
        OgrenciDersDBEntities3 db = new OgrenciDersDBEntities3();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string KategorıAdı = TxtGırısAdı.Text;

            GırısBılgılerı gırıs = db.GırısBılgılerı.Where(x => x.KategorıAdı == KategorıAdı).FirstOrDefault();
            if (gırıs != null)
            {
                FaturaEkranı  Frm = new FaturaEkranı();
                Frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(" KATEGORİ BİLGİSİNİ YANLIŞ GİRDİNİZ LÜTFEN TERKAR DENEYİN. ");
            }
            
        }
    }
}
