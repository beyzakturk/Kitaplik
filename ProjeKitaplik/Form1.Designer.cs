namespace ProjeKitaplik
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kitapAd = new System.Windows.Forms.TextBox();
            this.kitapYazar = new System.Windows.Forms.TextBox();
            this.kitapTür = new System.Windows.Forms.ComboBox();
            this.alinmis = new System.Windows.Forms.RadioButton();
            this.alinabilir = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnListe = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.kitapid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Yazarı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kitabın Türü:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kitabın Durumu:";
            // 
            // kitapAd
            // 
            this.kitapAd.Location = new System.Drawing.Point(124, 56);
            this.kitapAd.Name = "kitapAd";
            this.kitapAd.Size = new System.Drawing.Size(191, 22);
            this.kitapAd.TabIndex = 4;
            // 
            // kitapYazar
            // 
            this.kitapYazar.Location = new System.Drawing.Point(124, 100);
            this.kitapYazar.Name = "kitapYazar";
            this.kitapYazar.Size = new System.Drawing.Size(191, 22);
            this.kitapYazar.TabIndex = 5;
            // 
            // kitapTür
            // 
            this.kitapTür.FormattingEnabled = true;
            this.kitapTür.Items.AddRange(new object[] {
            "FANTASTİK ",
            "MACERA ",
            "PSİKOLOJİK ROMANLAR",
            "TOPLUMSAL",
            "HİKAYE",
            "TARİH",
            "ŞİİR"});
            this.kitapTür.Location = new System.Drawing.Point(124, 139);
            this.kitapTür.Name = "kitapTür";
            this.kitapTür.Size = new System.Drawing.Size(190, 24);
            this.kitapTür.TabIndex = 6;
            // 
            // alinmis
            // 
            this.alinmis.AutoSize = true;
            this.alinmis.Location = new System.Drawing.Point(145, 188);
            this.alinmis.Name = "alinmis";
            this.alinmis.Size = new System.Drawing.Size(73, 21);
            this.alinmis.TabIndex = 7;
            this.alinmis.TabStop = true;
            this.alinmis.Text = "Alınmış";
            this.alinmis.UseVisualStyleBackColor = true;
            this.alinmis.CheckedChanged += new System.EventHandler(this.alinmis_CheckedChanged);
            // 
            // alinabilir
            // 
            this.alinabilir.AutoSize = true;
            this.alinabilir.Location = new System.Drawing.Point(233, 188);
            this.alinabilir.Name = "alinabilir";
            this.alinabilir.Size = new System.Drawing.Size(82, 21);
            this.alinabilir.TabIndex = 8;
            this.alinabilir.TabStop = true;
            this.alinabilir.Text = "Alınabilir";
            this.alinabilir.UseVisualStyleBackColor = true;
            this.alinabilir.CheckedChanged += new System.EventHandler(this.alinabilir_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(704, 231);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnListe
            // 
            this.btnListe.Location = new System.Drawing.Point(391, 33);
            this.btnListe.Name = "btnListe";
            this.btnListe.Size = new System.Drawing.Size(126, 68);
            this.btnListe.TabIndex = 10;
            this.btnListe.Text = "Listele";
            this.btnListe.UseVisualStyleBackColor = true;
            this.btnListe.Click += new System.EventHandler(this.btnListe_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(546, 33);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(126, 68);
            this.btnKaydet.TabIndex = 11;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(391, 128);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(126, 68);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncel
            // 
            this.btnGuncel.Location = new System.Drawing.Point(546, 128);
            this.btnGuncel.Name = "btnGuncel";
            this.btnGuncel.Size = new System.Drawing.Size(126, 68);
            this.btnGuncel.TabIndex = 13;
            this.btnGuncel.Text = "Güncelle";
            this.btnGuncel.UseVisualStyleBackColor = true;
            this.btnGuncel.Click += new System.EventHandler(this.btnGuncel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Kitap ID:";
            // 
            // kitapid
            // 
            this.kitapid.Location = new System.Drawing.Point(123, 20);
            this.kitapid.Name = "kitapid";
            this.kitapid.Size = new System.Drawing.Size(191, 22);
            this.kitapid.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(714, 487);
            this.Controls.Add(this.kitapid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGuncel);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnListe);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.alinabilir);
            this.Controls.Add(this.alinmis);
            this.Controls.Add(this.kitapTür);
            this.Controls.Add(this.kitapYazar);
            this.Controls.Add(this.kitapAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Kitaplık Kontrol Paneli";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox kitapAd;
        private System.Windows.Forms.TextBox kitapYazar;
        private System.Windows.Forms.ComboBox kitapTür;
        private System.Windows.Forms.RadioButton alinmis;
        private System.Windows.Forms.RadioButton alinabilir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnListe;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox kitapid;
    }
}

