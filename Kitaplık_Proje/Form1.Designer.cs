namespace Kitaplık_Proje
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
            this.TxtAD = new System.Windows.Forms.TextBox();
            this.CmbKitapTür = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtKitapSayfa = new System.Windows.Forms.TextBox();
            this.TxtKitapYazar = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnListele = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGüncelle = new System.Windows.Forms.Button();
            this.TxtKitapBul = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnBul = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Ad :";
            // 
            // TxtAD
            // 
            this.TxtAD.Location = new System.Drawing.Point(146, 89);
            this.TxtAD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtAD.Name = "TxtAD";
            this.TxtAD.Size = new System.Drawing.Size(167, 27);
            this.TxtAD.TabIndex = 1;
            // 
            // CmbKitapTür
            // 
            this.CmbKitapTür.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbKitapTür.FormattingEnabled = true;
            this.CmbKitapTür.Items.AddRange(new object[] {
            "Hikaye",
            "Roman",
            "Şiir ",
            "Tiyatro"});
            this.CmbKitapTür.Location = new System.Drawing.Point(146, 189);
            this.CmbKitapTür.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmbKitapTür.Name = "CmbKitapTür";
            this.CmbKitapTür.Size = new System.Drawing.Size(167, 27);
            this.CmbKitapTür.TabIndex = 2;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(146, 241);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(88, 23);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "İkinci El";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 295);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(735, 295);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yazar :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sayfa :";
            // 
            // TxtKitapSayfa
            // 
            this.TxtKitapSayfa.Location = new System.Drawing.Point(146, 156);
            this.TxtKitapSayfa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtKitapSayfa.Name = "TxtKitapSayfa";
            this.TxtKitapSayfa.Size = new System.Drawing.Size(167, 27);
            this.TxtKitapSayfa.TabIndex = 7;
            // 
            // TxtKitapYazar
            // 
            this.TxtKitapYazar.Location = new System.Drawing.Point(146, 122);
            this.TxtKitapYazar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtKitapYazar.Name = "TxtKitapYazar";
            this.TxtKitapYazar.Size = new System.Drawing.Size(167, 27);
            this.TxtKitapYazar.TabIndex = 8;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(269, 241);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(81, 23);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Pakette";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tür :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Durum :";
            // 
            // TxtID
            // 
            this.TxtID.Enabled = false;
            this.TxtID.Location = new System.Drawing.Point(146, 56);
            this.TxtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(167, 27);
            this.TxtID.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(110, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "ID :";
            // 
            // BtnListele
            // 
            this.BtnListele.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.BtnListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListele.Location = new System.Drawing.Point(398, 58);
            this.BtnListele.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(172, 30);
            this.BtnListele.TabIndex = 14;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = false;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.BtnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnKaydet.Location = new System.Drawing.Point(398, 96);
            this.BtnKaydet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(172, 30);
            this.BtnKaydet.TabIndex = 15;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = false;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.BtnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSil.Location = new System.Drawing.Point(398, 134);
            this.BtnSil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(172, 30);
            this.BtnSil.TabIndex = 16;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.BtnGüncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGüncelle.Location = new System.Drawing.Point(398, 172);
            this.BtnGüncelle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(172, 30);
            this.BtnGüncelle.TabIndex = 17;
            this.BtnGüncelle.Text = "Güncelle";
            this.BtnGüncelle.UseVisualStyleBackColor = false;
            this.BtnGüncelle.Click += new System.EventHandler(this.BtnGüncelle_Click);
            // 
            // TxtKitapBul
            // 
            this.TxtKitapBul.Location = new System.Drawing.Point(536, 219);
            this.TxtKitapBul.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtKitapBul.Name = "TxtKitapBul";
            this.TxtKitapBul.Size = new System.Drawing.Size(167, 27);
            this.TxtKitapBul.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(453, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "Kitap Ad :";
            // 
            // BtnBul
            // 
            this.BtnBul.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.BtnBul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBul.Location = new System.Drawing.Point(592, 257);
            this.BtnBul.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnBul.Name = "BtnBul";
            this.BtnBul.Size = new System.Drawing.Size(67, 30);
            this.BtnBul.TabIndex = 20;
            this.BtnBul.Text = "Bul";
            this.BtnBul.UseVisualStyleBackColor = false;
            this.BtnBul.Click += new System.EventHandler(this.BtnBul_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(764, 603);
            this.Controls.Add(this.BtnBul);
            this.Controls.Add(this.TxtKitapBul);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnGüncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.TxtKitapYazar);
            this.Controls.Add(this.TxtKitapSayfa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.CmbKitapTür);
            this.Controls.Add(this.TxtAD);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtAD;
        private System.Windows.Forms.ComboBox CmbKitapTür;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtKitapSayfa;
        private System.Windows.Forms.TextBox TxtKitapYazar;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGüncelle;
        private System.Windows.Forms.TextBox TxtKitapBul;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnBul;
    }
}

