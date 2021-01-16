namespace EmlakcıOtomasyon
{
    partial class KullaniciAnasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciAnasayfa));
            this.btnKonutEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnAraziEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnIlanGoster = new DevExpress.XtraEditors.SimpleButton();
            this.lblHosgeldin = new DevExpress.XtraEditors.LabelControl();
            this.lblKullanici = new DevExpress.XtraEditors.LabelControl();
            this.btnCikis = new DevExpress.XtraEditors.SimpleButton();
            this.btnLogout = new DevExpress.XtraEditors.SimpleButton();
            this.btnSetting = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnKonutEkle
            // 
            this.btnKonutEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnKonutEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKonutEkle.Location = new System.Drawing.Point(34, 381);
            this.btnKonutEkle.Name = "btnKonutEkle";
            this.btnKonutEkle.Size = new System.Drawing.Size(181, 111);
            this.btnKonutEkle.TabIndex = 0;
            this.btnKonutEkle.Click += new System.EventHandler(this.btnKonutEkle_Click);
            // 
            // btnAraziEkle
            // 
            this.btnAraziEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnAraziEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAraziEkle.Location = new System.Drawing.Point(291, 412);
            this.btnAraziEkle.Name = "btnAraziEkle";
            this.btnAraziEkle.Size = new System.Drawing.Size(163, 101);
            this.btnAraziEkle.TabIndex = 1;
            this.btnAraziEkle.Click += new System.EventHandler(this.btnAraziEkle_Click);
            // 
            // btnIlanGoster
            // 
            this.btnIlanGoster.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnIlanGoster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIlanGoster.Location = new System.Drawing.Point(529, 425);
            this.btnIlanGoster.Name = "btnIlanGoster";
            this.btnIlanGoster.Size = new System.Drawing.Size(141, 88);
            this.btnIlanGoster.TabIndex = 2;
            this.btnIlanGoster.Click += new System.EventHandler(this.btnIlanGoster_Click);
            // 
            // lblHosgeldin
            // 
            this.lblHosgeldin.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHosgeldin.Appearance.Options.UseFont = true;
            this.lblHosgeldin.Location = new System.Drawing.Point(315, 29);
            this.lblHosgeldin.Name = "lblHosgeldin";
            this.lblHosgeldin.Size = new System.Drawing.Size(63, 13);
            this.lblHosgeldin.TabIndex = 4;
            this.lblHosgeldin.Text = "HOŞGELDİN";
            // 
            // lblKullanici
            // 
            this.lblKullanici.Appearance.BackColor = System.Drawing.Color.Silver;
            this.lblKullanici.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanici.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblKullanici.Appearance.Options.UseBackColor = true;
            this.lblKullanici.Appearance.Options.UseFont = true;
            this.lblKullanici.Appearance.Options.UseForeColor = true;
            this.lblKullanici.Location = new System.Drawing.Point(384, 28);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(82, 14);
            this.lblKullanici.TabIndex = 5;
            this.lblKullanici.Text = "labelControl2";
            // 
            // btnCikis
            // 
            this.btnCikis.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnCikis.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.ImageOptions.Image")));
            this.btnCikis.Location = new System.Drawing.Point(23, 28);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(50, 56);
            this.btnCikis.TabIndex = 16;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click_1);
            // 
            // btnLogout
            // 
            this.btnLogout.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnLogout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.ImageOptions.Image")));
            this.btnLogout.Location = new System.Drawing.Point(661, 28);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(61, 56);
            this.btnLogout.TabIndex = 18;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnSetting.Location = new System.Drawing.Point(529, 543);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(193, 37);
            this.btnSetting.TabIndex = 19;
            this.btnSetting.Text = "KULLANICIYI SİL";
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // KullaniciAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(744, 607);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.lblHosgeldin);
            this.Controls.Add(this.btnIlanGoster);
            this.Controls.Add(this.btnAraziEkle);
            this.Controls.Add(this.btnKonutEkle);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "KullaniciAnasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KullaniciAnasayfa";
            this.Load += new System.EventHandler(this.KullaniciAnasayfa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnKonutEkle;
        private DevExpress.XtraEditors.SimpleButton btnAraziEkle;
        private DevExpress.XtraEditors.SimpleButton btnIlanGoster;
        private DevExpress.XtraEditors.LabelControl lblHosgeldin;
        private DevExpress.XtraEditors.LabelControl lblKullanici;
        private DevExpress.XtraEditors.SimpleButton btnLogout;
        private DevExpress.XtraEditors.SimpleButton btnCikis;
        private DevExpress.XtraEditors.SimpleButton btnSetting;
    }
}