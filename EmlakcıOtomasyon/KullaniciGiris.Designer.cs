namespace EmlakcıOtomasyon
{
    partial class KullaniciGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciGiris));
            this.btnGiris = new DevExpress.XtraEditors.SimpleButton();
            this.pctId = new DevExpress.XtraEditors.PictureEdit();
            this.txtKullanici = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.txtSifre = new DevExpress.XtraEditors.TextEdit();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnKayit = new DevExpress.XtraEditors.SimpleButton();
            this.lblSifremiUnuttum = new DevExpress.XtraEditors.LabelControl();
            this.chkSifre = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pctId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanici.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSifre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnGiris.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnGiris.Appearance.Options.UseFont = true;
            this.btnGiris.Appearance.Options.UseForeColor = true;
            this.btnGiris.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnGiris.Location = new System.Drawing.Point(79, 530);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(209, 34);
            this.btnGiris.TabIndex = 0;
            this.btnGiris.Text = "GİRİŞ YAP";
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // pctId
            // 
            this.pctId.EditValue = ((object)(resources.GetObject("pctId.EditValue")));
            this.pctId.Location = new System.Drawing.Point(124, 373);
            this.pctId.Name = "pctId";
            this.pctId.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pctId.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pctId.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pctId.Size = new System.Drawing.Size(61, 49);
            this.pctId.TabIndex = 1;
            // 
            // txtKullanici
            // 
            this.txtKullanici.Location = new System.Drawing.Point(191, 386);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Properties.Appearance.BackColor = System.Drawing.Color.SkyBlue;
            this.txtKullanici.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtKullanici.Properties.Appearance.Options.UseBackColor = true;
            this.txtKullanici.Properties.Appearance.Options.UseFont = true;
            this.txtKullanici.Size = new System.Drawing.Size(230, 20);
            this.txtKullanici.TabIndex = 2;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(129, 428);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(56, 54);
            this.pictureEdit1.TabIndex = 3;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(191, 440);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Properties.Appearance.BackColor = System.Drawing.Color.SkyBlue;
            this.txtSifre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtSifre.Properties.Appearance.Options.UseBackColor = true;
            this.txtSifre.Properties.Appearance.Options.UseFont = true;
            this.txtSifre.Size = new System.Drawing.Size(230, 20);
            this.txtSifre.TabIndex = 4;
            this.txtSifre.EditValueChanged += new System.EventHandler(this.txtSifre_EditValueChanged);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.Location = new System.Drawing.Point(30, 33);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 46);
            this.btnExit.TabIndex = 5;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnKayit
            // 
            this.btnKayit.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnKayit.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnKayit.Appearance.Options.UseFont = true;
            this.btnKayit.Appearance.Options.UseForeColor = true;
            this.btnKayit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnKayit.Location = new System.Drawing.Point(341, 530);
            this.btnKayit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(209, 34);
            this.btnKayit.TabIndex = 6;
            this.btnKayit.Text = "KAYIT OL";
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // lblSifremiUnuttum
            // 
            this.lblSifremiUnuttum.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblSifremiUnuttum.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblSifremiUnuttum.Appearance.Options.UseFont = true;
            this.lblSifremiUnuttum.Appearance.Options.UseForeColor = true;
            this.lblSifremiUnuttum.Location = new System.Drawing.Point(214, 592);
            this.lblSifremiUnuttum.Name = "lblSifremiUnuttum";
            this.lblSifremiUnuttum.Size = new System.Drawing.Size(175, 13);
            this.lblSifremiUnuttum.TabIndex = 7;
            this.lblSifremiUnuttum.Text = "Kullanıcı Adı / Şifremi Unuttum ";
            this.lblSifremiUnuttum.Click += new System.EventHandler(this.SifremiUnuttumClick);
            // 
            // chkSifre
            // 
            this.chkSifre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chkSifre.Location = new System.Drawing.Point(440, 441);
            this.chkSifre.Name = "chkSifre";
            this.chkSifre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.chkSifre.Properties.Appearance.Options.UseFont = true;
            this.chkSifre.Properties.Caption = "Şifreyi Göster";
            this.chkSifre.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.chkSifre.Size = new System.Drawing.Size(120, 19);
            this.chkSifre.TabIndex = 8;
            this.chkSifre.CheckedChanged += new System.EventHandler(this.chkSifre_CheckedChanged);
            // 
            // KullaniciGiris
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(612, 689);
            this.Controls.Add(this.chkSifre);
            this.Controls.Add(this.lblSifremiUnuttum);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.pctId);
            this.Controls.Add(this.btnGiris);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "KullaniciGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Girişi";
            this.Load += new System.EventHandler(this.KullaniciGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanici.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSifre.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnGiris;
        private DevExpress.XtraEditors.PictureEdit pctId;
        private DevExpress.XtraEditors.TextEdit txtKullanici;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.TextEdit txtSifre;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnKayit;
        private DevExpress.XtraEditors.LabelControl lblSifremiUnuttum;
        private DevExpress.XtraEditors.CheckEdit chkSifre;
    }
}

