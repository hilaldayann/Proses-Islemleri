using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Projesi___1
{
    public partial class Form1 : Form
    {
        public class Kuyruk
        {
            public string proses1;
            public string proses2;
            public string proses3;
            public string prosesAna;
            public Kuyruk sonraki;
        }

        Kuyruk onkuyruk;
        Kuyruk arkakuyruk;
        Kuyruk tut;

        string ekle;
        int sayi1;
        int sayi2;
        int sayi3;

        public class Yigin
        {
            public string eklenecek;
            public Yigin siradaki;
        }

        Yigin ilkyigin;
        Yigin sonyigin;

        int deger;

        public Form1()
        {
            InitializeComponent();
        } 

        private void timer1_Tick(object sender, EventArgs e)
        {
            yiginOlustur();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            deger = trackBar1.Value;
            timer1.Interval = 1000 / deger;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random uret = new Random();
            sayi1 = uret.Next(0, 6);
            ekle = "P1  ->  " + sayi1 + "\r\n";
            textBox2.Text += ekle;
            //proses1Olustur();
            prosesanakuyruguOlustur();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            deger = trackBar2.Value;
            timer2.Interval = 1000 / deger;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Random uret = new Random();
            sayi2 = uret.Next(0, 6);
            ekle = "P2  ->  " + sayi2 + "\r\n";
            textBox3.Text += ekle;
            //proses2Olustur();
            prosesanakuyruguOlustur();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            deger = trackBar3.Value;
            timer3.Interval = 1000 / deger;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            Random uret = new Random();
            sayi3 = uret.Next(0, 6);
            ekle = "P3  ->  " + sayi3 + "\r\n";
            textBox4.Text += ekle;
            //proses3Olustur();
            prosesanakuyruguOlustur();
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            deger = trackBar4.Value;
            timer4.Interval = 1000 / deger;
        }

        public void proses1Olustur()
        {
            Kuyruk yeni = new Kuyruk();
            yeni.proses1 = ekle;

            if (onkuyruk == null)
            {
                onkuyruk = yeni;
                arkakuyruk = yeni;
            }
            else
            {
                arkakuyruk.sonraki = yeni;
                arkakuyruk = yeni;
                arkakuyruk.sonraki = null;
            }
            proses1Listele();
        }

        public void proses1Listele()
        {
            textBox6.Text = null;
            if (arkakuyruk == null)
            {
                MessageBox.Show("Kuyrukta Gösterilecek Eleman Bulunamadı.");
            }
            else
            {
                Kuyruk gecici = onkuyruk;
                while (gecici != null)
                {
                    textBox6.Text += gecici.proses1;
                    gecici = gecici.sonraki;
                }
            }
        }

        public void proses2Olustur()
        {
            Kuyruk yeni = new Kuyruk();
            yeni.proses2 = ekle;

            if (onkuyruk == null)
            {
                onkuyruk = yeni;
                arkakuyruk = yeni;
            }
            else
            {
                arkakuyruk.sonraki = yeni;
                arkakuyruk = yeni;
                arkakuyruk.sonraki = null;
            }
            proses2Listele();
        }

        public void proses2Listele()
        {
            textBox7.Text = null;
            if (arkakuyruk == null)
            {
                MessageBox.Show("Kuyrukta Gösterilecek Eleman Bulunamadı.");
            }
            else
            {
                Kuyruk gecici = onkuyruk;
                while (gecici != null)
                {
                    textBox7.Text += gecici.proses2;
                    gecici = gecici.sonraki;
                }
            }
        }
        
        public void proses3Olustur()
        {
            Kuyruk yeni = new Kuyruk();
            yeni.proses3 = ekle;

            if (onkuyruk == null)
            {
                onkuyruk = yeni;
                arkakuyruk = yeni;
            }
            else
            {
                arkakuyruk.sonraki = yeni;
                arkakuyruk = yeni;
                arkakuyruk.sonraki = null;
            }
            proses3Listele();
        }

        public void proses3Listele()
        {
            textBox8.Text = null;
            if (arkakuyruk == null)
            {
                MessageBox.Show("Kuyrukta Gösterilecek Eleman Bulunamadı.");
            }
            else
            {
                Kuyruk gecici = onkuyruk;
                while (gecici != null)
                {
                    textBox8.Text += gecici.proses3;
                    gecici = gecici.sonraki;
                }
            }
        }

        public void prosesanakuyruguOlustur()
        {
            Kuyruk yeni = new Kuyruk();
            yeni.prosesAna = ekle;

            Kuyruk gecici, büyük = null, kücük = null;
            gecici = onkuyruk;
            if (onkuyruk == null)
            {
                onkuyruk = yeni;
                arkakuyruk = yeni;
            }
            else
            {
                if (Int32.Parse((yeni.prosesAna).Substring(8, 1)) > Int32.Parse((arkakuyruk.prosesAna).Substring(8, 1)) || Int32.Parse((yeni.prosesAna).Substring(8, 1)) == Int32.Parse((arkakuyruk.prosesAna).Substring(8, 1)))
                {
                    arkakuyruk.sonraki = yeni;
                    arkakuyruk = yeni;
                    arkakuyruk.sonraki = null;
                }
                if (Int32.Parse((yeni.prosesAna).Substring(8, 1)) < Int32.Parse((onkuyruk.prosesAna).Substring(8, 1)) || Int32.Parse((yeni.prosesAna).Substring(8, 1)) == Int32.Parse((onkuyruk.prosesAna).Substring(8, 1)))
                {
                    tut = yeni;
                    tut.sonraki = onkuyruk;
                    onkuyruk = tut;
                    tut = null;
                }
                if (Int32.Parse((onkuyruk.prosesAna).Substring(8, 1)) < Int32.Parse((yeni.prosesAna).Substring(8, 1)) && Int32.Parse((yeni.prosesAna).Substring(8, 1)) < Int32.Parse((arkakuyruk.prosesAna).Substring(8, 1)))
                {
                    while (gecici != null)
                    {
                        if ((Int32.Parse((gecici.prosesAna).Substring(8, 1)) < Int32.Parse((yeni.prosesAna).Substring(8, 1))))
                        {
                            kücük = gecici;
                            büyük = gecici.sonraki;
                        }
                        gecici = gecici.sonraki;
                    }
                    tut = yeni;
                    tut.sonraki = büyük;
                    kücük.sonraki = tut;
                    tut = null;
                }
            }
            prosesanakuyruguListele();
        }

        public void prosesanakuyruguListele()
        {
            textBox1.Text = null;
            if (arkakuyruk == null)
            {
                MessageBox.Show("Kuyrukta Gösterilecek Eleman Bulunamadı.");
            }
            else
            {
                Kuyruk gecici = onkuyruk;
                while (gecici != null)
                {
                    textBox1.Text += gecici.prosesAna;
                    gecici = gecici.sonraki;
                }
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        public void yiginOlustur()
        {
            Yigin yeni = new Yigin();
            yeni.eklenecek = textBox1.Text;

            if (ilkyigin == null)
            {
                ilkyigin = yeni;
                sonyigin = ilkyigin;
                ilkyigin.siradaki = yeni;
                sonyigin.siradaki = null;
            }
            else
            {
                yeni.siradaki = ilkyigin;
                ilkyigin = yeni;
            }
            //yiginListele();
            kuyrukSil();
        }

        public void yiginListele()
        {
            /*textBox9.Text = null;
            if (ilkyigin == null)
            {
                MessageBox.Show("Yığında Gösterilecek Eleman Yok");
            }
            else
            {
                Yigin gecici = ilkyigin;
                while (gecici != null)
                {
                    textBox9.Text += gecici.eklenecek;
                    gecici = gecici.siradaki;
                }
            }
            kuyrukSil();*/
        }

        public void kuyrukSil()
        {
            if (onkuyruk == null)
            {
                onkuyruk = null;
                arkakuyruk = null;
                return;
            }
            Kuyruk gecici = onkuyruk;
            onkuyruk = gecici.sonraki;
            prosesanakuyruguListele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false)
            {
                MessageBox.Show("Bitirilen Prosesleri Görmek İçin En Az Bir Proses Seçimi Yapmalısınız.");
            }
            if (checkBox1.Checked)
            {
                Yigin gecici = ilkyigin;
                while (gecici != null)
                {
                    if (((gecici.eklenecek).Substring(1, 1)) == "1")
                    {
                        textBox5.Text += "P1 -- > " + (gecici.eklenecek).Substring(8, 1) + "\r\n";
                        gecici = gecici.siradaki;
                    }
                }
            }
            else if (checkBox2.Checked)
            {
                Yigin gecici = ilkyigin;
                while (gecici != null)
                {
                    if (((gecici.eklenecek).Substring(1, 1)) == "2")
                    {
                        textBox9.Text += "P2 -- > " + (gecici.eklenecek).Substring(8, 1) + "\r\n";
                        gecici = gecici.siradaki;
                    }
                }
            }
            else if (checkBox3.Checked)
            {
                Yigin gecici = ilkyigin;
                while (gecici != null)
                {
                    if (((gecici.eklenecek).Substring(1, 1)) == "3")
                    {
                        textBox10.Text += "P3 -- > " + (gecici.eklenecek).Substring(8, 1) + "\r\n";
                        gecici = gecici.siradaki;
                    }
                }
            }
        }
    }
}