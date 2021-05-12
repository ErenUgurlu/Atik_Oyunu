/****************************************************************************
**
**				ÖĞRENCİ ADI................: Eren Uğurlu
**				ÖĞRENCİ NUMARASI............: B181210082
**				DERS GRUBU…………………:  D /1.öğretim
*               DERS KODU.........:  BSM102
****************************************************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NDP_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblPuan.BackColor = Color.Gray;     //başlangıcda labellerin disable oldugunu görsel olarak göstermek için rekleri değiştiriliyor
            lblSure.BackColor = Color.Gray;
        }

        List<Image> images = new List<Image>();     // kullanılan resimlerin listesi
        Random random = new Random();
        int counter = 60;       //sayaç ın saniyelerini tutan değişken
        int puan = 0;
        int[] araci = new int[4];   // araci dizisi 4 değişken tutabiliyor her atık türü için 1 tane aynı türdeki atıkların daha kolay kutu kapasitesine aktarımı için

        CamAtikKutusu camAtikKutusu = new CamAtikKutusu();      //kulanılacak nesneler oluşturuluyor
        Atik camSise = new CamSise();
        Atik camBardak = new CamBardak();

        KagitAtikKutusu kagitAtikKutusu = new KagitAtikKutusu();
        Atik gazete = new Gazete();
        Atik dergi = new Dergi();

        OrganikAtikKutusu organikAtikKutusu = new OrganikAtikKutusu();
        Atik domates = new Domates();
        Atik salatalik = new Salatalık();

        MetalAtikKutusu metalAtikKutusu = new MetalAtikKutusu();
        Atik kolaKutusu = new Kolakutusu();
        Atik salcaKutusu = new SalcaKutusu();
        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            counter = 60;
            lstbCam.Items.Clear();      //listboxlar temizleniyor
            lstbKagit.Items.Clear();
            lstbMetal.Items.Clear();
            lstbOrganikA.Items.Clear();
            progressBarCam.Value = 0;
            progressBarKgt.Value = 0;
            progressBarMetal.Value = 0;
            progressBarOrgA.Value = 0;
            puan = 0;
            lblPuan.Text = (0).ToString();
            lblPuan.BackColor = Color.SpringGreen;
            lblSure.BackColor = Color.SpringGreen;

            for (int i = 0; i < 4; i++)     // her seferinde sıfırlanıyor
                araci[i] = 0;

            timer1.Start();     //sayaç başlatılıyor
            pictureBox1.Enabled = true;     // butonlar aktifleştiriliyor
            btnOrgnkA.Enabled = true;       
            btnKagitA.Enabled = true;
            btnMetalA.Enabled = true;
            btnCamA.Enabled = true;
            btnBsltCam.Enabled = true;
            btnBsltKgt.Enabled = true;
            btnBsltMtl.Enabled = true;
            btnBsltOrg.Enabled = true;
            lblPuan.Enabled = true;
            lblSure.Enabled = true;
            lstbCam.Enabled = true;
            lstbKagit.Enabled = true;
            lstbMetal.Enabled = true;
            lstbOrganikA.Enabled = true;
            
            
            

            images.Add(Properties.Resources.CamSise);       //resimler listeye listeye ekleniyor
            images.Add(Properties.Resources.CamBardak);
            images.Add(Properties.Resources.Gazete);
            images.Add(Properties.Resources.dergi);
            images.Add(Properties.Resources.Domates);
            images.Add(Properties.Resources.salatalık);
            images.Add(Properties.Resources.kolaKutusu);
            images.Add(Properties.Resources.KonserveSalça);

            pictureBox1.Image = images[random.Next(0, 8)];      //ilk resim ekleniyor

        }
        
        private void BtnCamA_Click(object sender, EventArgs e)      //if komutuyla pictureboxdaki resim ile butonun cinsi karşılaştırılıyor
        {
            
            if (pictureBox1.Image.Equals(images[0]))        
            {
                if(progressBarCam.Value<75)     //yüzde yetmişbeşin altındaki kutuya atık eklenmesine izin veriliyor
                {
                    pictureBox1.Image = images[random.Next(0, 8)];      //rasgele yeni resim atanıyor
                    araci[0] += camSise.Hacim;                          //aracı ya hacimler aktarılıyor
                    camAtikKutusu.Kapasite = araci[0];
                    lstbCam.Items.Add("Cam Sise(600)");
                    progressBarCam.Value = camAtikKutusu.DolulukOrani;

                    puan += camSise.Hacim;
                    lblPuan.Text = puan.ToString();
                }
            }
            else if(pictureBox1.Image.Equals(images[1]))
            {
                if (progressBarCam.Value < 75)
                {
                    lstbCam.Items.Add("Cam Bardak(250)");
                    pictureBox1.Image = images[random.Next(0, 8)];
                    araci[0] += camBardak.Hacim;
                    camAtikKutusu.Kapasite = araci[0];
                    progressBarCam.Value = camAtikKutusu.DolulukOrani;

                    puan += camBardak.Hacim;
                    lblPuan.Text = puan.ToString();
                }
            }
        }

        private void btnKagitA_Click(object sender, EventArgs e)
        {
            
            if (pictureBox1.Image.Equals(images[2]))
            {
                if (progressBarKgt.Value < 75)
                {
                    lstbKagit.Items.Add("Gazete(250)");
                    pictureBox1.Image = images[random.Next(0, 8)];
                    araci[1] += gazete.Hacim;
                    kagitAtikKutusu.Kapasite = araci[1];
                    progressBarKgt.Value = kagitAtikKutusu.DolulukOrani;

                    puan += gazete.Hacim;
                    lblPuan.Text = puan.ToString();
                }
            }
            else if (pictureBox1.Image.Equals(images[3]))
            {
                if (progressBarKgt.Value < 75)
                {
                    lstbKagit.Items.Add("Dergi(200)");
                    pictureBox1.Image = images[random.Next(0, 8)];
                    araci[1] += dergi.Hacim;
                    kagitAtikKutusu.Kapasite = araci[1];
                    progressBarKgt.Value = kagitAtikKutusu.DolulukOrani;
                    puan += dergi.Hacim;
                    lblPuan.Text = puan.ToString();
                }
            }   
        }

        private void btnOrgnkA_Click(object sender, EventArgs e)
        {
            
            if (pictureBox1.Image.Equals(images[4]))
            {
                if (progressBarOrgA.Value < 75)
                {
                    lstbOrganikA.Items.Add("Domates(150)");
                    pictureBox1.Image = images[random.Next(0, 8)];
                    araci[2] += domates.Hacim;
                    organikAtikKutusu.Kapasite = araci[2];
                    progressBarOrgA.Value = organikAtikKutusu.DolulukOrani;
                    puan += domates.Hacim;
                    lblPuan.Text = puan.ToString();
                }
            }
            else if(pictureBox1.Image.Equals(images[5]))
            {             
                if (progressBarOrgA.Value < 75)
                {
                    lstbOrganikA.Items.Add("Salatalık(120)");
                    pictureBox1.Image = images[random.Next(0, 8)];
                    araci[2] += salatalik.Hacim;
                    organikAtikKutusu.Kapasite = araci[2];
                    progressBarOrgA.Value = organikAtikKutusu.DolulukOrani;
                    puan += salatalik.Hacim;
                    lblPuan.Text = puan.ToString();
                }
            }
            
        }

        private void BtnMetalA_Click(object sender, EventArgs e)
        {
            
            if (pictureBox1.Image.Equals(images[6]))
            {                
                if (progressBarMetal.Value < 75)
                {
                    lstbMetal.Items.Add("Kola Kutusu(350)");
                    pictureBox1.Image = images[random.Next(0, 8)];
                    araci[3] += kolaKutusu.Hacim;
                    metalAtikKutusu.Kapasite = araci[3];
                    progressBarMetal.Value = metalAtikKutusu.DolulukOrani;
                    puan += kolaKutusu.Hacim;
                    lblPuan.Text = puan.ToString();
                }    
            }
            else if(pictureBox1.Image.Equals(images[7]))
            {               
                if (progressBarMetal.Value < 75)
                {
                    lstbMetal.Items.Add("Salca Kutusu(550)");
                    pictureBox1.Image = images[random.Next(0, 8)];
                    araci[3] += salcaKutusu.Hacim;
                    metalAtikKutusu.Kapasite = araci[3];
                    progressBarMetal.Value = metalAtikKutusu.DolulukOrani;
                    puan += salcaKutusu.Hacim;
                    lblPuan.Text = puan.ToString();
                }
            }          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSure.Text = counter.ToString();
            if (counter == 0)
            {
                timer1.Stop();      //timer durduruluyor
                btnCamA.Enabled = false;        // butonlar tekrar deaktive ediliyor
                btnKagitA.Enabled = false;
                btnMetalA.Enabled = false;
                btnOrgnkA.Enabled = false;
                btnBsltCam.Enabled = false;
                btnBsltKgt.Enabled = false;
                btnBsltMtl.Enabled = false;
                btnBsltOrg.Enabled = false;
                pictureBox1.Enabled = false;
                lblPuan.Enabled = false;
                lblSure.Enabled = false;
                lstbCam.Enabled = false;
                lstbKagit.Enabled = false;
                lstbMetal.Enabled = false;
                lstbOrganikA.Enabled = false;
                lblPuan.BackColor = Color.Gray;
                lblSure.BackColor = Color.Gray;
            }
                
            counter--;      // zamanı içinte tutan değişken her saniyede 1 azalıyor
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }       //cikis Butonu

        private void btnBsltOrg_Click(object sender, EventArgs e)
        {
            if (progressBarOrgA.Value > 75)     //yüzde 75 in üstündeki kutuların bosaltılmasına izin veriliyor ve kutular bosaltılıyor
            {
                lstbOrganikA.Items.Clear();
                puan += organikAtikKutusu.BosaltmaPuani;
                lblPuan.Text = puan.ToString();
                organikAtikKutusu.Kapasite = 0;
                araci[2] = 0;
                progressBarOrgA.Value = 0;
                counter = counter + 3;
            }
        }

        private void btnBsltKgt_Click(object sender, EventArgs e)
        {
            if (progressBarKgt.Value > 75)
            {
                lstbKagit.Items.Clear();
                puan += kagitAtikKutusu.BosaltmaPuani;
                lblPuan.Text = puan.ToString();
                kagitAtikKutusu.Kapasite = 0;
                araci[1] = 0;
                progressBarKgt.Value = 0;
                counter = counter + 3;
            }
        }

        private void btnBsltCam_Click(object sender, EventArgs e)
        {
            if (progressBarCam.Value > 75)
            {
                lstbCam.Items.Clear();
                puan += camAtikKutusu.BosaltmaPuani;
                lblPuan.Text = puan.ToString();
                camAtikKutusu.Kapasite = 0;
                araci[0] = 0;
                progressBarCam.Value = 0;
                counter = counter + 3;
            }
        }

        private void btnBsltMtl_Click(object sender, EventArgs e)
        {
            if (progressBarMetal.Value > 75)
            {
                lstbMetal.Items.Clear();
                puan += metalAtikKutusu.BosaltmaPuani;
                lblPuan.Text = puan.ToString();
                metalAtikKutusu.Kapasite = 0;
                araci[3] = 0;
                progressBarMetal.Value = 0;
                counter = counter + 3;

            }
        }
    }

    public interface IAtik
    {
        int Hacim { get; }
    }
    public interface IAtikKutusu : IDolabilen
    {
        /// <summary>
        /// Atık kutusu boşaltıldığında oyun puanına kaç puan ekleneceğini döndürür.
        /// </summary>
        int BosaltmaPuani { get; }
       
    }
    public interface IDolabilen
    {
        int Kapasite { get; set; }
        int DoluHacim { get; }
        int DolulukOrani { get; }
    }
    public class Atik : IAtik
    {
        protected int _hacim = 0;
        public int Hacim { get { return _hacim; } }

    }
    public class CamSise : Atik
    {
        public CamSise()
        {
            _hacim = 600;
        }
    }
    public class CamBardak : Atik
    {
        public CamBardak()
        {
            _hacim = 250;
        }
    }
    public class Gazete : Atik
    {
        public Gazete()
        {
            _hacim = 250;
        }

    }
    public class Dergi : Atik
    {
        public Dergi()
        {
            _hacim = 200;
        }
    }
    public class Domates : Atik
    {
        public Domates()
        {
            _hacim = 150;
        }
    }
    public class Salatalık : Atik
    {
        public Salatalık()
        {
            _hacim = 120;
        }
    }
    public class Kolakutusu : Atik
    {
        public Kolakutusu()
        {
            _hacim = 350;
        }
    }
    public class SalcaKutusu : Atik
    {
        public SalcaKutusu()
        {
            _hacim = 550;
        }
    }
    public class OrganikAtikKutusu : IAtikKutusu
    {
        int _kapasite = 0;
        int _doluHacim = 700;
        int _bosaltmaPuani = 0;

        public int BosaltmaPuani { get { return _bosaltmaPuani; } }

        public int Kapasite { get { return _kapasite; } set { _kapasite = value; } }

        public int DoluHacim { get { return _doluHacim; } }

        public int DolulukOrani { get { return ((_kapasite * 100) / _doluHacim); } }

    }
    public class CamAtikKutusu : IAtikKutusu
    {
        int _kapasite = 0;
        int _doluHacim = 2200;
        int _bosaltmaPuani = 600;
        public int BosaltmaPuani { get { return _bosaltmaPuani; } }

        public int Kapasite { get { return _kapasite; } set { _kapasite = value; } }

        public int DoluHacim { get { return _doluHacim; } }

        public int DolulukOrani { get { return ((_kapasite * 100) / _doluHacim); } }

    }
    public class MetalAtikKutusu : IAtikKutusu
    {
        int _kapasite = 0;
        int _doluHacim = 2200;
        int _bosaltmaPuani = 600;
        public int BosaltmaPuani { get { return _bosaltmaPuani; } }

        public int Kapasite { get { return _kapasite; } set { _kapasite = value; } }

        public int DoluHacim { get { return _doluHacim; } }

        public int DolulukOrani { get { return ((_kapasite * 100) / _doluHacim); } }

    }
    public class KagitAtikKutusu : IAtikKutusu
    {
        int _kapasite = 0;
        int _doluHacim = 2200;
        int _bosaltmaPuani = 600;
        public int BosaltmaPuani { get { return _bosaltmaPuani; } }

        public int Kapasite { get { return _kapasite; } set { _kapasite = value; } }

        public int DoluHacim { get { return _doluHacim; } }

        public int DolulukOrani { get { return ((_kapasite * 100) / _doluHacim); } }

    }
}

