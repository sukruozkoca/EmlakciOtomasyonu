namespace EmlakcıOtomasyon
{
    partial class KullaniciKonutEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciKonutEkle));
            this.cmbIlanTuru = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbIlSec = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtKatNo = new DevExpress.XtraEditors.TextEdit();
            this.txtAlan = new DevExpress.XtraEditors.TextEdit();
            this.txtOdaSayisi = new DevExpress.XtraEditors.TextEdit();
            this.txtBinaYili = new DevExpress.XtraEditors.TextEdit();
            this.txtFiyati = new DevExpress.XtraEditors.TextEdit();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cmbIlce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnFoto = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.btnCikis = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIlanTuru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIlSec.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKatNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOdaSayisi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBinaYili.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyati.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIlce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbIlanTuru
            // 
            this.cmbIlanTuru.Location = new System.Drawing.Point(212, 69);
            this.cmbIlanTuru.Name = "cmbIlanTuru";
            this.cmbIlanTuru.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbIlanTuru.Properties.Items.AddRange(new object[] {
            "SATILIK",
            "KİRALIK"});
            this.cmbIlanTuru.Size = new System.Drawing.Size(176, 20);
            this.cmbIlanTuru.TabIndex = 0;
            // 
            // cmbIlSec
            // 
            this.cmbIlSec.Location = new System.Drawing.Point(212, 110);
            this.cmbIlSec.Name = "cmbIlSec";
            this.cmbIlSec.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbIlSec.Size = new System.Drawing.Size(176, 20);
            this.cmbIlSec.TabIndex = 1;
            this.cmbIlSec.SelectedIndexChanged += new System.EventHandler(this.cmbIlSec_SelectedIndexChanged);
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(212, 178);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(176, 74);
            this.txtAdres.TabIndex = 2;
            // 
            // txtKatNo
            // 
            this.txtKatNo.Location = new System.Drawing.Point(212, 258);
            this.txtKatNo.Name = "txtKatNo";
            this.txtKatNo.Properties.Mask.EditMask = "d";
            this.txtKatNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtKatNo.Properties.MaxLength = 3;
            this.txtKatNo.Size = new System.Drawing.Size(176, 20);
            this.txtKatNo.TabIndex = 3;
            // 
            // txtAlan
            // 
            this.txtAlan.Location = new System.Drawing.Point(212, 314);
            this.txtAlan.Name = "txtAlan";
            this.txtAlan.Properties.Mask.EditMask = "d";
            this.txtAlan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtAlan.Size = new System.Drawing.Size(176, 20);
            this.txtAlan.TabIndex = 4;
            // 
            // txtOdaSayisi
            // 
            this.txtOdaSayisi.Location = new System.Drawing.Point(212, 367);
            this.txtOdaSayisi.Name = "txtOdaSayisi";
            this.txtOdaSayisi.Properties.MaxLength = 3;
            this.txtOdaSayisi.Size = new System.Drawing.Size(176, 20);
            this.txtOdaSayisi.TabIndex = 5;
            // 
            // txtBinaYili
            // 
            this.txtBinaYili.Location = new System.Drawing.Point(212, 426);
            this.txtBinaYili.Name = "txtBinaYili";
            this.txtBinaYili.Properties.Mask.EditMask = "d";
            this.txtBinaYili.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtBinaYili.Properties.MaxLength = 4;
            this.txtBinaYili.Size = new System.Drawing.Size(176, 20);
            this.txtBinaYili.TabIndex = 6;
            // 
            // txtFiyati
            // 
            this.txtFiyati.Location = new System.Drawing.Point(212, 489);
            this.txtFiyati.Name = "txtFiyati";
            this.txtFiyati.Properties.Mask.EditMask = "c";
            this.txtFiyati.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtFiyati.Size = new System.Drawing.Size(176, 20);
            this.txtFiyati.TabIndex = 7;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cmbIlce
            // 
            this.cmbIlce.Location = new System.Drawing.Point(212, 152);
            this.cmbIlce.Name = "cmbIlce";
            this.cmbIlce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbIlce.Size = new System.Drawing.Size(176, 20);
            this.cmbIlce.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(231, 562);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnEkle
            // 
            this.btnEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Appearance.Options.UseFont = true;
            this.btnEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.ImageOptions.Image")));
            this.btnEkle.Location = new System.Drawing.Point(21, 628);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(194, 45);
            this.btnEkle.TabIndex = 12;
            this.btnEkle.Text = "İLAN EKLE";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click_1);
            // 
            // btnFoto
            // 
            this.btnFoto.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFoto.Appearance.Options.UseFont = true;
            this.btnFoto.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnFoto.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFoto.ImageOptions.Image")));
            this.btnFoto.Location = new System.Drawing.Point(21, 562);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(194, 43);
            this.btnFoto.TabIndex = 13;
            this.btnFoto.Text = "FOTOĞRAF EKLE";
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(80, 70);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 16);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "İLAN TÜRÜ :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(134, 111);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(21, 16);
            this.labelControl2.TabIndex = 15;
            this.labelControl2.Text = "İL :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(119, 153);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 16);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "İLÇE :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(103, 207);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(52, 16);
            this.labelControl4.TabIndex = 17;
            this.labelControl4.Text = "ADRES :";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(49, 264);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(107, 16);
            this.labelControl5.TabIndex = 18;
            this.labelControl5.Text = "KAT NUMARASI :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(58, 318);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(100, 16);
            this.labelControl6.TabIndex = 19;
            this.labelControl6.Text = "TOPLAM ALAN :";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(72, 371);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(86, 16);
            this.labelControl7.TabIndex = 20;
            this.labelControl7.Text = "ODA SAYISI :";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(88, 430);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(70, 16);
            this.labelControl8.TabIndex = 21;
            this.labelControl8.Text = "BİNA YILI :";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.DarkRed;
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Appearance.Options.UseForeColor = true;
            this.labelControl9.Location = new System.Drawing.Point(112, 493);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(46, 16);
            this.labelControl9.TabIndex = 22;
            this.labelControl9.Text = "FİYAT :";
            // 
            // btnCikis
            // 
            this.btnCikis.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnCikis.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.ImageOptions.Image")));
            this.btnCikis.Location = new System.Drawing.Point(418, 2);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(50, 56);
            this.btnCikis.TabIndex = 29;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // KullaniciKonutEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(466, 685);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cmbIlce);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtFiyati);
            this.Controls.Add(this.txtBinaYili);
            this.Controls.Add(this.txtOdaSayisi);
            this.Controls.Add(this.txtAlan);
            this.Controls.Add(this.txtKatNo);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.cmbIlSec);
            this.Controls.Add(this.cmbIlanTuru);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KullaniciKonutEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " v-vvvvvvvvvvvvvvvvvvvvvvvvv**";
            this.Load += new System.EventHandler(this.KullaniciKonutEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbIlanTuru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIlSec.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKatNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOdaSayisi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBinaYili.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyati.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIlce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cmbIlanTuru;
        private DevExpress.XtraEditors.ComboBoxEdit cmbIlSec;
        private System.Windows.Forms.TextBox txtAdres;
        private DevExpress.XtraEditors.TextEdit txtKatNo;
        private DevExpress.XtraEditors.TextEdit txtAlan;
        private DevExpress.XtraEditors.TextEdit txtOdaSayisi;
        private DevExpress.XtraEditors.TextEdit txtBinaYili;
        private DevExpress.XtraEditors.TextEdit txtFiyati;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbIlce;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.SimpleButton btnFoto;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SimpleButton btnCikis;
    }
}