namespace EmlakcıOtomasyon
{
    partial class KullaniciIlanlariGoster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciIlanlariGoster));
            this.pctDaireResim = new System.Windows.Forms.PictureBox();
            this.dataDaireGoster = new System.Windows.Forms.DataGridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataAraziGoster = new System.Windows.Forms.DataGridView();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnDaireSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKonutGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnAraziSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnAraziGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnCikis = new DevExpress.XtraEditors.SimpleButton();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnLogout = new DevExpress.XtraEditors.SimpleButton();
            this.btnYenile = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pctDaireResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDaireGoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAraziGoster)).BeginInit();
            this.SuspendLayout();
            // 
            // pctDaireResim
            // 
            this.pctDaireResim.Location = new System.Drawing.Point(248, 240);
            this.pctDaireResim.Name = "pctDaireResim";
            this.pctDaireResim.Size = new System.Drawing.Size(254, 135);
            this.pctDaireResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctDaireResim.TabIndex = 0;
            this.pctDaireResim.TabStop = false;
            // 
            // dataDaireGoster
            // 
            this.dataDaireGoster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDaireGoster.Location = new System.Drawing.Point(12, 406);
            this.dataDaireGoster.Name = "dataDaireGoster";
            this.dataDaireGoster.ReadOnly = true;
            this.dataDaireGoster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataDaireGoster.Size = new System.Drawing.Size(724, 125);
            this.dataDaireGoster.TabIndex = 1;
            this.dataDaireGoster.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDaireGoster_CellContentClick);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(673, 90);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "labelControl1";
            this.labelControl1.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(139, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "ARAZİ İLANLARI";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.arsaclick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(418, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 45);
            this.button2.TabIndex = 4;
            this.button2.Text = "DAİRE İLANLARI";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.daireclick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(375, 118);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(8, 8);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataAraziGoster
            // 
            this.dataAraziGoster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAraziGoster.Location = new System.Drawing.Point(12, 406);
            this.dataAraziGoster.Name = "dataAraziGoster";
            this.dataAraziGoster.ReadOnly = true;
            this.dataAraziGoster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataAraziGoster.Size = new System.Drawing.Size(724, 125);
            this.dataAraziGoster.TabIndex = 1;
            this.dataAraziGoster.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataAraziGoster_CellContentClick_1);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(673, 118);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "labelControl2";
            this.labelControl2.Visible = false;
            // 
            // btnDaireSil
            // 
            this.btnDaireSil.Appearance.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDaireSil.Appearance.Options.UseFont = true;
            this.btnDaireSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDaireSil.ImageOptions.Image")));
            this.btnDaireSil.Location = new System.Drawing.Point(45, 556);
            this.btnDaireSil.Name = "btnDaireSil";
            this.btnDaireSil.Size = new System.Drawing.Size(192, 44);
            this.btnDaireSil.TabIndex = 9;
            this.btnDaireSil.Text = "İLANI SİL";
            this.btnDaireSil.Visible = false;
            this.btnDaireSil.Click += new System.EventHandler(this.btnDaireSil_Click);
            // 
            // btnKonutGuncelle
            // 
            this.btnKonutGuncelle.Appearance.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnKonutGuncelle.Appearance.Options.UseFont = true;
            this.btnKonutGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKonutGuncelle.ImageOptions.Image")));
            this.btnKonutGuncelle.Location = new System.Drawing.Point(268, 556);
            this.btnKonutGuncelle.Name = "btnKonutGuncelle";
            this.btnKonutGuncelle.Size = new System.Drawing.Size(189, 44);
            this.btnKonutGuncelle.TabIndex = 10;
            this.btnKonutGuncelle.Text = "İLANI GÜNCELLE";
            this.btnKonutGuncelle.Click += new System.EventHandler(this.btnKonutGuncelle_Click);
            // 
            // btnAraziSil
            // 
            this.btnAraziSil.Appearance.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAraziSil.Appearance.Options.UseFont = true;
            this.btnAraziSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAraziSil.ImageOptions.Image")));
            this.btnAraziSil.Location = new System.Drawing.Point(45, 556);
            this.btnAraziSil.Name = "btnAraziSil";
            this.btnAraziSil.Size = new System.Drawing.Size(192, 44);
            this.btnAraziSil.TabIndex = 12;
            this.btnAraziSil.Text = "İLANI SİL";
            this.btnAraziSil.Visible = false;
            this.btnAraziSil.Click += new System.EventHandler(this.btnAraziSil_Click);
            // 
            // btnAraziGuncelle
            // 
            this.btnAraziGuncelle.Appearance.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAraziGuncelle.Appearance.Options.UseFont = true;
            this.btnAraziGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAraziGuncelle.ImageOptions.Image")));
            this.btnAraziGuncelle.Location = new System.Drawing.Point(268, 556);
            this.btnAraziGuncelle.Name = "btnAraziGuncelle";
            this.btnAraziGuncelle.Size = new System.Drawing.Size(189, 44);
            this.btnAraziGuncelle.TabIndex = 13;
            this.btnAraziGuncelle.Text = "İLANI GÜNCELLE";
            this.btnAraziGuncelle.Click += new System.EventHandler(this.btnAraziGuncelle_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnCikis.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.ImageOptions.Image")));
            this.btnCikis.Location = new System.Drawing.Point(68, 1);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(50, 56);
            this.btnCikis.TabIndex = 14;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnBack.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.ImageOptions.Image")));
            this.btnBack.Location = new System.Drawing.Point(1, 1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(61, 56);
            this.btnBack.TabIndex = 15;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnLogout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.ImageOptions.Image")));
            this.btnLogout.Location = new System.Drawing.Point(685, 1);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(61, 56);
            this.btnLogout.TabIndex = 16;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.Appearance.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnYenile.Appearance.Options.UseFont = true;
            this.btnYenile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYenile.ImageOptions.Image")));
            this.btnYenile.Location = new System.Drawing.Point(489, 556);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(205, 44);
            this.btnYenile.TabIndex = 17;
            this.btnYenile.Text = "YENİLE";
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // KullaniciIlanlariGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(746, 618);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnAraziGuncelle);
            this.Controls.Add(this.btnAraziSil);
            this.Controls.Add(this.btnKonutGuncelle);
            this.Controls.Add(this.btnDaireSil);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.dataAraziGoster);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dataDaireGoster);
            this.Controls.Add(this.pctDaireResim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KullaniciIlanlariGoster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KullaniciIlanlariGoster";
            this.Load += new System.EventHandler(this.KullaniciIlanlariGoster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctDaireResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDaireGoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAraziGoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctDaireResim;
        private System.Windows.Forms.DataGridView dataDaireGoster;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataAraziGoster;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnDaireSil;
        private DevExpress.XtraEditors.SimpleButton btnKonutGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnAraziSil;
        private DevExpress.XtraEditors.SimpleButton btnAraziGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnCikis;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraEditors.SimpleButton btnLogout;
        private DevExpress.XtraEditors.SimpleButton btnYenile;
    }
}