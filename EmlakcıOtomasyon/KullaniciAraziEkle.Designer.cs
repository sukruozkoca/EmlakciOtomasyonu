namespace EmlakcıOtomasyon
{
    partial class KullaniciAraziEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciAraziEkle));
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.lblImar = new DevExpress.XtraEditors.LabelControl();
            this.lblAlan = new DevExpress.XtraEditors.LabelControl();
            this.lblIl = new DevExpress.XtraEditors.LabelControl();
            this.lblIlce = new DevExpress.XtraEditors.LabelControl();
            this.lblAda = new DevExpress.XtraEditors.LabelControl();
            this.lblParsel = new DevExpress.XtraEditors.LabelControl();
            this.lblTapu = new DevExpress.XtraEditors.LabelControl();
            this.btnFotografEkle = new DevExpress.XtraEditors.SimpleButton();
            this.pctFotograf = new System.Windows.Forms.PictureBox();
            this.lblFiyat = new DevExpress.XtraEditors.LabelControl();
            this.txtAlan = new DevExpress.XtraEditors.TextEdit();
            this.txtAda = new DevExpress.XtraEditors.TextEdit();
            this.txtParsel = new DevExpress.XtraEditors.TextEdit();
            this.txtFiyat = new DevExpress.XtraEditors.TextEdit();
            this.cmbImar = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbIl = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbIlce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbTapu = new DevExpress.XtraEditors.ComboBoxEdit();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnCikis = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pctFotograf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParsel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIlce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTapu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(12, 451);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(216, 43);
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "İLAN EKLE";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblImar
            // 
            this.lblImar.Appearance.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblImar.Appearance.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblImar.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblImar.Appearance.Options.UseBackColor = true;
            this.lblImar.Appearance.Options.UseFont = true;
            this.lblImar.Appearance.Options.UseForeColor = true;
            this.lblImar.Location = new System.Drawing.Point(57, 80);
            this.lblImar.Name = "lblImar";
            this.lblImar.Size = new System.Drawing.Size(107, 17);
            this.lblImar.TabIndex = 10;
            this.lblImar.Text = "İMAR DURUMU :";
            // 
            // lblAlan
            // 
            this.lblAlan.Appearance.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblAlan.Appearance.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlan.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblAlan.Appearance.Options.UseBackColor = true;
            this.lblAlan.Appearance.Options.UseFont = true;
            this.lblAlan.Appearance.Options.UseForeColor = true;
            this.lblAlan.Location = new System.Drawing.Point(120, 182);
            this.lblAlan.Name = "lblAlan";
            this.lblAlan.Size = new System.Drawing.Size(44, 17);
            this.lblAlan.TabIndex = 11;
            this.lblAlan.Text = "ALAN :";
            // 
            // lblIl
            // 
            this.lblIl.Appearance.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblIl.Appearance.Font = new System.Drawing.Font("Yu Gothic", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblIl.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIl.Appearance.Options.UseBackColor = true;
            this.lblIl.Appearance.Options.UseFont = true;
            this.lblIl.Appearance.Options.UseForeColor = true;
            this.lblIl.Location = new System.Drawing.Point(143, 115);
            this.lblIl.Name = "lblIl";
            this.lblIl.Size = new System.Drawing.Size(21, 16);
            this.lblIl.TabIndex = 12;
            this.lblIl.Text = " İL :";
            // 
            // lblIlce
            // 
            this.lblIlce.Appearance.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblIlce.Appearance.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIlce.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblIlce.Appearance.Options.UseBackColor = true;
            this.lblIlce.Appearance.Options.UseFont = true;
            this.lblIlce.Appearance.Options.UseForeColor = true;
            this.lblIlce.Location = new System.Drawing.Point(123, 147);
            this.lblIlce.Name = "lblIlce";
            this.lblIlce.Size = new System.Drawing.Size(41, 17);
            this.lblIlce.TabIndex = 13;
            this.lblIlce.Text = "İLÇE  :";
            // 
            // lblAda
            // 
            this.lblAda.Appearance.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblAda.Appearance.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAda.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblAda.Appearance.Options.UseBackColor = true;
            this.lblAda.Appearance.Options.UseFont = true;
            this.lblAda.Appearance.Options.UseForeColor = true;
            this.lblAda.Location = new System.Drawing.Point(100, 216);
            this.lblAda.Name = "lblAda";
            this.lblAda.Size = new System.Drawing.Size(60, 17);
            this.lblAda.TabIndex = 14;
            this.lblAda.Text = "ADA NO :";
            // 
            // lblParsel
            // 
            this.lblParsel.Appearance.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblParsel.Appearance.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblParsel.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblParsel.Appearance.Options.UseBackColor = true;
            this.lblParsel.Appearance.Options.UseFont = true;
            this.lblParsel.Appearance.Options.UseForeColor = true;
            this.lblParsel.Location = new System.Drawing.Point(80, 247);
            this.lblParsel.Name = "lblParsel";
            this.lblParsel.Size = new System.Drawing.Size(84, 17);
            this.lblParsel.TabIndex = 15;
            this.lblParsel.Text = "PARSEL NO :";
            // 
            // lblTapu
            // 
            this.lblTapu.Appearance.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblTapu.Appearance.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTapu.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblTapu.Appearance.Options.UseBackColor = true;
            this.lblTapu.Appearance.Options.UseFont = true;
            this.lblTapu.Appearance.Options.UseForeColor = true;
            this.lblTapu.Location = new System.Drawing.Point(54, 279);
            this.lblTapu.Name = "lblTapu";
            this.lblTapu.Size = new System.Drawing.Size(110, 17);
            this.lblTapu.TabIndex = 16;
            this.lblTapu.Text = "TAPU DURUMU :";
            // 
            // btnFotografEkle
            // 
            this.btnFotografEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFotografEkle.Appearance.Options.UseFont = true;
            this.btnFotografEkle.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnFotografEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFotografEkle.ImageOptions.Image")));
            this.btnFotografEkle.Location = new System.Drawing.Point(12, 386);
            this.btnFotografEkle.Name = "btnFotografEkle";
            this.btnFotografEkle.Size = new System.Drawing.Size(216, 39);
            this.btnFotografEkle.TabIndex = 17;
            this.btnFotografEkle.Text = "FOTOĞRAF EKLE";
            this.btnFotografEkle.Click += new System.EventHandler(this.btnFotografEkle_Click);
            // 
            // pctFotograf
            // 
            this.pctFotograf.Location = new System.Drawing.Point(271, 386);
            this.pctFotograf.Name = "pctFotograf";
            this.pctFotograf.Size = new System.Drawing.Size(177, 108);
            this.pctFotograf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctFotograf.TabIndex = 18;
            this.pctFotograf.TabStop = false;
            // 
            // lblFiyat
            // 
            this.lblFiyat.Appearance.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblFiyat.Appearance.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyat.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblFiyat.Appearance.Options.UseBackColor = true;
            this.lblFiyat.Appearance.Options.UseFont = true;
            this.lblFiyat.Appearance.Options.UseForeColor = true;
            this.lblFiyat.Location = new System.Drawing.Point(117, 312);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(47, 17);
            this.lblFiyat.TabIndex = 19;
            this.lblFiyat.Text = "FİYAT :";
            // 
            // txtAlan
            // 
            this.txtAlan.Location = new System.Drawing.Point(213, 181);
            this.txtAlan.Name = "txtAlan";
            this.txtAlan.Properties.Mask.EditMask = "d";
            this.txtAlan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtAlan.Size = new System.Drawing.Size(135, 20);
            this.txtAlan.TabIndex = 20;
            // 
            // txtAda
            // 
            this.txtAda.Location = new System.Drawing.Point(213, 215);
            this.txtAda.Name = "txtAda";
            this.txtAda.Properties.Mask.EditMask = "d";
            this.txtAda.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtAda.Size = new System.Drawing.Size(135, 20);
            this.txtAda.TabIndex = 21;
            // 
            // txtParsel
            // 
            this.txtParsel.Location = new System.Drawing.Point(213, 246);
            this.txtParsel.Name = "txtParsel";
            this.txtParsel.Properties.Mask.EditMask = "d";
            this.txtParsel.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtParsel.Size = new System.Drawing.Size(135, 20);
            this.txtParsel.TabIndex = 22;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(213, 311);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Properties.Mask.EditMask = "c";
            this.txtFiyat.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtFiyat.Size = new System.Drawing.Size(135, 20);
            this.txtFiyat.TabIndex = 23;
            // 
            // cmbImar
            // 
            this.cmbImar.Location = new System.Drawing.Point(213, 79);
            this.cmbImar.Name = "cmbImar";
            this.cmbImar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbImar.Properties.Items.AddRange(new object[] {
            "KONUT",
            "SANAYİ",
            "TARLA",
            "TİCARİ"});
            this.cmbImar.Size = new System.Drawing.Size(135, 20);
            this.cmbImar.TabIndex = 24;
            // 
            // cmbIl
            // 
            this.cmbIl.Location = new System.Drawing.Point(213, 113);
            this.cmbIl.Name = "cmbIl";
            this.cmbIl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbIl.Size = new System.Drawing.Size(135, 20);
            this.cmbIl.TabIndex = 25;
            this.cmbIl.SelectedIndexChanged += new System.EventHandler(this.cmbIl_SelectedIndexChanged);
            // 
            // cmbIlce
            // 
            this.cmbIlce.Location = new System.Drawing.Point(213, 146);
            this.cmbIlce.Name = "cmbIlce";
            this.cmbIlce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbIlce.Size = new System.Drawing.Size(135, 20);
            this.cmbIlce.TabIndex = 26;
            // 
            // cmbTapu
            // 
            this.cmbTapu.Location = new System.Drawing.Point(213, 278);
            this.cmbTapu.Name = "cmbTapu";
            this.cmbTapu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTapu.Properties.Items.AddRange(new object[] {
            "HİSSELİ",
            "MÜSTAKİL PARSEL",
            "ZİLLİYET"});
            this.cmbTapu.Size = new System.Drawing.Size(135, 20);
            this.cmbTapu.TabIndex = 27;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnCikis
            // 
            this.btnCikis.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnCikis.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.ImageOptions.Image")));
            this.btnCikis.Location = new System.Drawing.Point(488, -2);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(50, 56);
            this.btnCikis.TabIndex = 28;
            // 
            // btnKapat
            // 
            this.btnKapat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
            this.btnKapat.Location = new System.Drawing.Point(412, 1);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(50, 56);
            this.btnKapat.TabIndex = 30;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // KullaniciAraziEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(462, 506);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.cmbTapu);
            this.Controls.Add(this.cmbIlce);
            this.Controls.Add(this.cmbIl);
            this.Controls.Add(this.cmbImar);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtParsel);
            this.Controls.Add(this.txtAda);
            this.Controls.Add(this.txtAlan);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.pctFotograf);
            this.Controls.Add(this.btnFotografEkle);
            this.Controls.Add(this.lblTapu);
            this.Controls.Add(this.lblParsel);
            this.Controls.Add(this.lblAda);
            this.Controls.Add(this.lblIlce);
            this.Controls.Add(this.lblIl);
            this.Controls.Add(this.lblAlan);
            this.Controls.Add(this.lblImar);
            this.Controls.Add(this.btnKaydet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KullaniciAraziEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KullaniciAraziEkle";
            this.Load += new System.EventHandler(this.KullaniciAraziEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctFotograf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParsel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIlce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTapu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.LabelControl lblImar;
        private DevExpress.XtraEditors.LabelControl lblAlan;
        private DevExpress.XtraEditors.LabelControl lblIl;
        private DevExpress.XtraEditors.LabelControl lblIlce;
        private DevExpress.XtraEditors.LabelControl lblAda;
        private DevExpress.XtraEditors.LabelControl lblParsel;
        private DevExpress.XtraEditors.LabelControl lblTapu;
        private DevExpress.XtraEditors.SimpleButton btnFotografEkle;
        private System.Windows.Forms.PictureBox pctFotograf;
        private DevExpress.XtraEditors.LabelControl lblFiyat;
        private DevExpress.XtraEditors.TextEdit txtAlan;
        private DevExpress.XtraEditors.TextEdit txtAda;
        private DevExpress.XtraEditors.TextEdit txtParsel;
        private DevExpress.XtraEditors.TextEdit txtFiyat;
        private DevExpress.XtraEditors.ComboBoxEdit cmbImar;
        private DevExpress.XtraEditors.ComboBoxEdit cmbIl;
        private DevExpress.XtraEditors.ComboBoxEdit cmbIlce;
        private DevExpress.XtraEditors.ComboBoxEdit cmbTapu;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraEditors.SimpleButton btnCikis;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
    }
}