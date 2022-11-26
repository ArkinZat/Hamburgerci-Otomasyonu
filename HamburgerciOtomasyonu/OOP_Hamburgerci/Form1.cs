using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Hamburgerci
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static List<Siparis> tumSiparisler = new List<Siparis>();
        public static List<Siparis> mevcutSiparis = new List<Siparis>();

        public static List<Menu> menuler = new List<Menu>()
        {
            new Menu{MenuAdi = "Big King", Fiyati = 30.25M},
            new Menu{MenuAdi = "Double King Chicken", Fiyati = 28.25M},
            new Menu{MenuAdi = "Steakhouse", Fiyati = 40.50M},
            new Menu{MenuAdi = "Whooper", Fiyati = 32.00M},
            new Menu{MenuAdi = "Whooper Jr.", Fiyati = 20.25M},
            new Menu{MenuAdi = "Chicken Royal", Fiyati = 26.80M},
        };

        public static List<Ekstra> ekstralar = new List<Ekstra>()
        {
            new Ekstra{EkstraAdi = "Ketçap", Fiyati = 0.25M},
            new Ekstra{EkstraAdi = "Mayonez", Fiyati = 0.50M},
            new Ekstra{EkstraAdi = "BBQ", Fiyati = 1M},
            new Ekstra{EkstraAdi = "Soğan Halkası", Fiyati = 7.5M},
            new Ekstra{EkstraAdi = "Ranch Sos", Fiyati = 1M},
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Menu item in menuler)
            {
                cmbMenuler.Items.Add(item);  // ToString() metodunu override ettiğimiz için MenüAdı + Menü olarak comboboxa yazılmaktadır.
            }

            foreach (Ekstra item in ekstralar)
            {
                flpEkstraMalzemeler.Controls.Add(new CheckBox() { Text = item.EkstraAdi, Tag = item });  // Tag propertysi object tutar.
            }

            foreach (Siparis item in mevcutSiparis)
            {
                lbxSiparisler.Items.Add(item);
            }          
            TutarHesapla();
            
            rdKucuk.Checked = true;
            cmbMenuler.SelectedIndex = 0;
        }

        private decimal TutarHesapla()
        {
            decimal toplamTutar = 0;
            for (int i = 0; i < lbxSiparisler.Items.Count; i++)
            {
                Siparis gelenSiparis = (Siparis)lbxSiparisler.Items[i];
                toplamTutar += gelenSiparis.ToplamTutar;
            }
            lblToplamTutar.Text = toplamTutar.ToString("C2");

            return toplamTutar;
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            Siparis yeniSiparis = new Siparis();
            yeniSiparis.SeciliMenu = (Menu)cmbMenuler.SelectedItem;

            if (rdKucuk.Checked)
                yeniSiparis.Boyut = Boyut.Kucuk;
            else if (rdOrta.Checked)
                yeniSiparis.Boyut = Boyut.Orta;
            else
                yeniSiparis.Boyut = Boyut.Buyuk;

            yeniSiparis.EkstraMalzeme = new List<Ekstra>();
            foreach (CheckBox item in flpEkstraMalzemeler.Controls)
            {
                if (item.Checked)
                {
                    yeniSiparis.EkstraMalzeme.Add((Ekstra)item.Tag);
                    // FlowLayoutPanel'deki kontrollerden seçilenlerin her birinin Tag propertysinde tutulan ekstra malzemenin kopyasını verir.
                }
            }

            yeniSiparis.Adet = Convert.ToInt32(nmrAdet.Value);

            yeniSiparis.Hesapla(); // Sipariş classındaki Hesapla metotu oluşan yeni siparişin toplam fiyatını hesaplar.

            tumSiparisler.Add(yeniSiparis);
            mevcutSiparis.Add(yeniSiparis);
            lbxSiparisler.Items.Add(yeniSiparis);
            TutarHesapla();

            Fonsiyon.Temizleme(this.Controls);

            // ÖDEV : Fonksiyonlar isimli bir class oluşturun ve Temizle() adında bir metot oluşturup bu metodu burada kontrol
        }

        private void btnSiparisTamamla_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Toplam Sipariş tutar:" + TutarHesapla().ToString("C2") + "\n Siparişi tamamlamak ister misiniz ? ", "Sipariş Bilgisi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                lbxSiparisler.Items.Clear();
                mevcutSiparis.Clear();
                TutarHesapla();
                MessageBox.Show("Siparişiniz tamamlandı :)");
            }
            else
            {
                MessageBox.Show("Siparişiniz iptal edilmiştir !");
            }
        }

        
    }
}
