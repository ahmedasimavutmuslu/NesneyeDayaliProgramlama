
namespace NDPOdev
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxEklenecekSutun = new System.Windows.Forms.TextBox();
            this.buttonSutunEkle = new System.Windows.Forms.Button();
            this.buttonGrafikOlustur = new System.Windows.Forms.Button();
            this.textBoxGrafikBasligi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxYEkseniBasligi = new System.Windows.Forms.TextBox();
            this.textBoxXEkseniBasligi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.buttonNasilKullanilir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(597, 503);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(615, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(578, 503);
            this.dataGridView1.TabIndex = 1;
            // 
            // textBoxEklenecekSutun
            // 
            this.textBoxEklenecekSutun.Location = new System.Drawing.Point(1055, 549);
            this.textBoxEklenecekSutun.Name = "textBoxEklenecekSutun";
            this.textBoxEklenecekSutun.Size = new System.Drawing.Size(138, 22);
            this.textBoxEklenecekSutun.TabIndex = 2;
            // 
            // buttonSutunEkle
            // 
            this.buttonSutunEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSutunEkle.Location = new System.Drawing.Point(1055, 587);
            this.buttonSutunEkle.Name = "buttonSutunEkle";
            this.buttonSutunEkle.Size = new System.Drawing.Size(138, 33);
            this.buttonSutunEkle.TabIndex = 3;
            this.buttonSutunEkle.Text = "Seri Ekle";
            this.buttonSutunEkle.UseVisualStyleBackColor = true;
            this.buttonSutunEkle.Click += new System.EventHandler(this.buttonSutunEkle_Click);
            // 
            // buttonGrafikOlustur
            // 
            this.buttonGrafikOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGrafikOlustur.Location = new System.Drawing.Point(374, 569);
            this.buttonGrafikOlustur.Name = "buttonGrafikOlustur";
            this.buttonGrafikOlustur.Size = new System.Drawing.Size(138, 33);
            this.buttonGrafikOlustur.TabIndex = 4;
            this.buttonGrafikOlustur.Text = "Yükle";
            this.buttonGrafikOlustur.UseVisualStyleBackColor = true;
            this.buttonGrafikOlustur.Click += new System.EventHandler(this.buttonGrafikOlustur_Click);
            // 
            // textBoxGrafikBasligi
            // 
            this.textBoxGrafikBasligi.Location = new System.Drawing.Point(166, 569);
            this.textBoxGrafikBasligi.Name = "textBoxGrafikBasligi";
            this.textBoxGrafikBasligi.Size = new System.Drawing.Size(138, 22);
            this.textBoxGrafikBasligi.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(34, 569);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Grafik Başlığı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 624);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Y Ekseni Başlığı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(13, 686);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "X Ekseni Başlığı";
            // 
            // textBoxYEkseniBasligi
            // 
            this.textBoxYEkseniBasligi.Location = new System.Drawing.Point(166, 623);
            this.textBoxYEkseniBasligi.Name = "textBoxYEkseniBasligi";
            this.textBoxYEkseniBasligi.Size = new System.Drawing.Size(138, 22);
            this.textBoxYEkseniBasligi.TabIndex = 9;
            // 
            // textBoxXEkseniBasligi
            // 
            this.textBoxXEkseniBasligi.Location = new System.Drawing.Point(166, 686);
            this.textBoxXEkseniBasligi.Name = "textBoxXEkseniBasligi";
            this.textBoxXEkseniBasligi.Size = new System.Drawing.Size(138, 22);
            this.textBoxXEkseniBasligi.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(959, 549);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Seri Adı";
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTemizle.Location = new System.Drawing.Point(374, 624);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(138, 33);
            this.buttonTemizle.TabIndex = 12;
            this.buttonTemizle.Text = "Temizle";
            this.buttonTemizle.UseVisualStyleBackColor = true;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // buttonNasilKullanilir
            // 
            this.buttonNasilKullanilir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonNasilKullanilir.Location = new System.Drawing.Point(374, 675);
            this.buttonNasilKullanilir.Name = "buttonNasilKullanilir";
            this.buttonNasilKullanilir.Size = new System.Drawing.Size(138, 33);
            this.buttonNasilKullanilir.TabIndex = 13;
            this.buttonNasilKullanilir.Text = "Nasıl Kullanılır";
            this.buttonNasilKullanilir.UseVisualStyleBackColor = true;
            this.buttonNasilKullanilir.Click += new System.EventHandler(this.buttonNasilKullanilir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 720);
            this.Controls.Add(this.buttonNasilKullanilir);
            this.Controls.Add(this.buttonTemizle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxXEkseniBasligi);
            this.Controls.Add(this.textBoxYEkseniBasligi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxGrafikBasligi);
            this.Controls.Add(this.buttonGrafikOlustur);
            this.Controls.Add(this.buttonSutunEkle);
            this.Controls.Add(this.textBoxEklenecekSutun);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxEklenecekSutun;
        private System.Windows.Forms.Button buttonSutunEkle;
        private System.Windows.Forms.Button buttonGrafikOlustur;
        private System.Windows.Forms.TextBox textBoxGrafikBasligi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxYEkseniBasligi;
        private System.Windows.Forms.TextBox textBoxXEkseniBasligi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonTemizle;
        private System.Windows.Forms.Button buttonNasilKullanilir;
    }
}

