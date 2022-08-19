/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2021-2022 YAZ DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 1. ÖDEV
**				ÖĞRENCİ ADI............: AHMED ASIM AVUTMUŞLU
**				ÖĞRENCİ NUMARASI.......: G211210373
**              DERSİN ALINDIĞI GRUP...: 1. ÖĞRETİM A GRUBU
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

namespace NDPOdev
{
    public partial class Form1 : Form
    {
        public Form1()

        {
            InitializeComponent();


        }
        DataTable dataTable = new DataTable();
        int seriSayisi = 0;




        private void Form1_Load(object sender, EventArgs e)
        {

            dataTable.Columns.Add("Ad");
            dataTable.Columns.Add("Soyad");
            
        }

        private void buttonSutunEkle_Click(object sender, EventArgs e)
        {
            if(seriSayisi<4)//seri sayısı kısıtı uygulanıyor
            {
                if(!(dataTable.Columns.Contains(textBoxEklenecekSutun.Text)))//serinin zaten bulunup bulunmadıgı kontrolu yapılıyor
                {
                    dataTable.Columns.Add(textBoxEklenecekSutun.Text);
                    chart1.Series.Add(textBoxEklenecekSutun.Text);
                    dataGridView1.DataSource = dataTable;
                    seriSayisi++;
                }
                else
                {
                    MessageBox.Show("Bu seri zaten bulunuyor!", "Seri Ekleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                MessageBox.Show("Daha fazla seri ekleyemezsiniz!", "Seri Ekleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void buttonGrafikOlustur_Click(object sender, EventArgs e)
        {
            foreach(var series in chart1.Series)//yukleye basmadan once daha once cizilenlerin ustune cizmesin diye temizleniyor
            {
                series.Points.Clear();
            }

            for(int i=0;i<seriSayisi;i++) // veri alınacak sutunu geziyoruz
            {
                for(int j=0;j< (dataGridView1.Rows.Count-1);j++) // veri alınacak satırı geziyoruz
                {
                    chart1.Series[i].Points.AddXY(dataGridView1.Rows[j].Cells[0].Value.ToString(), dataGridView1.Rows[j].Cells[i+2].Value.ToString());
                }
                
                
            }
            chart1.Titles.Add(textBoxGrafikBasligi.Text);
            chart1.ChartAreas[0].AxisX.Title = textBoxXEkseniBasligi.Text;
            chart1.ChartAreas[0].AxisY.Title = textBoxYEkseniBasligi.Text;
            
        }

        private void label4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            chart1.Titles.Add("");
            chart1.ChartAreas[0].AxisX.Title ="";
            chart1.ChartAreas[0].AxisY.Title = "";
            foreach (var series in chart1.Series)//grafik temizleniyor
            {
                series.Points.Clear();
                
            }
            chart1.Series.Clear();
            seriSayisi = 0;
            dataTable.Rows.Clear();
            dataTable.Columns.Clear();
            dataTable.Columns.Add("Ad");
            dataTable.Columns.Add("Soyad");
            textBoxEklenecekSutun.Clear();
            textBoxGrafikBasligi.Clear();
            textBoxXEkseniBasligi.Clear();
            textBoxYEkseniBasligi.Clear();
        }

        private void buttonNasilKullanilir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İlk olarak seri ekleyiniz. Dört seriye kadar destek sunuyoruz.\nSeri ekleme işlemleri bittikten sonra ekranın sağ tarafındaki tablodan gerekli girişleri yapabilirsiniz.\nVeri girme işlemleri bittikten sonra sol alt kısımda bulunan alanlar doldurularak yükleye basılır ise grafiğiniz oluşturulur. \nLütfen bu sıraya uygun şekilde kullanınız!", "Kullanım Kılavuzu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
