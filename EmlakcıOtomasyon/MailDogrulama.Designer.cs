namespace EmlakcıOtomasyon
{
    partial class MailDogrulama
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailDogrulama));
            this.lblUyari = new DevExpress.XtraEditors.LabelControl();
            this.txtGirilen = new DevExpress.XtraEditors.TextEdit();
            this.btnDogrulama = new System.Windows.Forms.Button();
            this.lblDakika = new DevExpress.XtraEditors.LabelControl();
            this.lblCizgi = new DevExpress.XtraEditors.LabelControl();
            this.lblSaniye = new DevExpress.XtraEditors.LabelControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblKalan = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnTekrar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCikis = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtGirilen.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUyari
            // 
            this.lblUyari.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblUyari.Appearance.Options.UseFont = true;
            this.lblUyari.Location = new System.Drawing.Point(23, 72);
            this.lblUyari.Name = "lblUyari";
            this.lblUyari.Size = new System.Drawing.Size(284, 13);
            this.lblUyari.TabIndex = 0;
            this.lblUyari.Text = "MAİLE GÖNDERİLEN AKTİVASYON KODUNU GİRİNİZ :";
            // 
            // txtGirilen
            // 
            this.txtGirilen.Location = new System.Drawing.Point(153, 110);
            this.txtGirilen.Name = "txtGirilen";
            this.txtGirilen.Size = new System.Drawing.Size(125, 20);
            this.txtGirilen.TabIndex = 1;
            // 
            // btnDogrulama
            // 
            this.btnDogrulama.Location = new System.Drawing.Point(153, 152);
            this.btnDogrulama.Name = "btnDogrulama";
            this.btnDogrulama.Size = new System.Drawing.Size(105, 32);
            this.btnDogrulama.TabIndex = 2;
            this.btnDogrulama.Text = "DOĞRULA";
            this.btnDogrulama.UseVisualStyleBackColor = true;
            this.btnDogrulama.Click += new System.EventHandler(this.btnDogrulama_Click);
            // 
            // lblDakika
            // 
            this.lblDakika.Location = new System.Drawing.Point(378, 166);
            this.lblDakika.Name = "lblDakika";
            this.lblDakika.Size = new System.Drawing.Size(6, 13);
            this.lblDakika.TabIndex = 3;
            this.lblDakika.Text = "0";
            // 
            // lblCizgi
            // 
            this.lblCizgi.Location = new System.Drawing.Point(391, 166);
            this.lblCizgi.Name = "lblCizgi";
            this.lblCizgi.Size = new System.Drawing.Size(4, 13);
            this.lblCizgi.TabIndex = 4;
            this.lblCizgi.Text = ":";
            // 
            // lblSaniye
            // 
            this.lblSaniye.Location = new System.Drawing.Point(402, 166);
            this.lblSaniye.Name = "lblSaniye";
            this.lblSaniye.Size = new System.Drawing.Size(6, 13);
            this.lblSaniye.TabIndex = 5;
            this.lblSaniye.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblKalan
            // 
            this.lblKalan.Location = new System.Drawing.Point(351, 134);
            this.lblKalan.Name = "lblKalan";
            this.lblKalan.Size = new System.Drawing.Size(68, 13);
            this.lblKalan.TabIndex = 6;
            this.lblKalan.Text = "KALAN SÜRE :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(83, 72);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(257, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "BELİRTİLEN SÜREDE KOD GİRİŞİ YAPMADINIZ !";
            this.labelControl1.Visible = false;
            // 
            // btnTekrar
            // 
            this.btnTekrar.Location = new System.Drawing.Point(164, 136);
            this.btnTekrar.Name = "btnTekrar";
            this.btnTekrar.Size = new System.Drawing.Size(94, 29);
            this.btnTekrar.TabIndex = 8;
            this.btnTekrar.Text = "Tekrar Gönder";
            this.btnTekrar.Visible = false;
            this.btnTekrar.Click += new System.EventHandler(this.btnTekrar_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnCikis.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.ImageOptions.Image")));
            this.btnCikis.Location = new System.Drawing.Point(391, -2);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(50, 56);
            this.btnCikis.TabIndex = 29;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // MailDogrulama
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(440, 205);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnTekrar);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lblKalan);
            this.Controls.Add(this.lblSaniye);
            this.Controls.Add(this.lblCizgi);
            this.Controls.Add(this.lblDakika);
            this.Controls.Add(this.btnDogrulama);
            this.Controls.Add(this.txtGirilen);
            this.Controls.Add(this.lblUyari);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MailDogrulama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MailDogrulama";
            this.Load += new System.EventHandler(this.MailDogrulama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtGirilen.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblUyari;
        private DevExpress.XtraEditors.TextEdit txtGirilen;
        private System.Windows.Forms.Button btnDogrulama;
        private DevExpress.XtraEditors.LabelControl lblDakika;
        private DevExpress.XtraEditors.LabelControl lblCizgi;
        private DevExpress.XtraEditors.LabelControl lblSaniye;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.LabelControl lblKalan;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnTekrar;
        private DevExpress.XtraEditors.SimpleButton btnCikis;
    }
}