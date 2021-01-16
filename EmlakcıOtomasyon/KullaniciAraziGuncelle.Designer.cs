namespace EmlakcıOtomasyon
{
    partial class KullaniciAraziGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciAraziGuncelle));
            this.cmbTapu = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbIlce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbIl = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbImar = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtFiyat = new DevExpress.XtraEditors.TextEdit();
            this.txtParsel = new DevExpress.XtraEditors.TextEdit();
            this.txtAda = new DevExpress.XtraEditors.TextEdit();
            this.txtAlan = new DevExpress.XtraEditors.TextEdit();
            this.lblFiyat = new DevExpress.XtraEditors.LabelControl();
            this.lblTapu = new DevExpress.XtraEditors.LabelControl();
            this.lblParsel = new DevExpress.XtraEditors.LabelControl();
            this.lblAda = new DevExpress.XtraEditors.LabelControl();
            this.lblIlce = new DevExpress.XtraEditors.LabelControl();
            this.lblIl = new DevExpress.XtraEditors.LabelControl();
            this.lblAlan = new DevExpress.XtraEditors.LabelControl();
            this.lblImar = new DevExpress.XtraEditors.LabelControl();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnCikis = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTapu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIlce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParsel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTapu
            // 
            this.cmbTapu.Location = new System.Drawing.Point(174, 283);
            this.cmbTapu.Name = "cmbTapu";
            this.cmbTapu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTapu.Properties.Items.AddRange(new object[] {
            "HİSSELİ",
            "MÜSTAKİL PARSEL",
            "ZİLLİYET"});
            this.cmbTapu.Size = new System.Drawing.Size(135, 20);
            this.cmbTapu.TabIndex = 43;
            // 
            // cmbIlce
            // 
            this.cmbIlce.Location = new System.Drawing.Point(174, 151);
            this.cmbIlce.Name = "cmbIlce";
            this.cmbIlce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbIlce.Size = new System.Drawing.Size(135, 20);
            this.cmbIlce.TabIndex = 42;
            // 
            // cmbIl
            // 
            this.cmbIl.Location = new System.Drawing.Point(174, 118);
            this.cmbIl.Name = "cmbIl";
            this.cmbIl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbIl.Size = new System.Drawing.Size(135, 20);
            this.cmbIl.TabIndex = 41;
            this.cmbIl.SelectedIndexChanged += new System.EventHandler(this.cmbIl_SelectedIndexChanged);
            // 
            // cmbImar
            // 
            this.cmbImar.Location = new System.Drawing.Point(174, 84);
            this.cmbImar.Name = "cmbImar";
            this.cmbImar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbImar.Properties.Items.AddRange(new object[] {
            "KONUT",
            "SANAYİ",
            "TARLA",
            "TİCARİ"});
            this.cmbImar.Size = new System.Drawing.Size(135, 20);
            this.cmbImar.TabIndex = 40;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(174, 316);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Properties.Mask.EditMask = "c";
            this.txtFiyat.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtFiyat.Size = new System.Drawing.Size(135, 20);
            this.txtFiyat.TabIndex = 39;
            // 
            // txtParsel
            // 
            this.txtParsel.Location = new System.Drawing.Point(174, 251);
            this.txtParsel.Name = "txtParsel";
            this.txtParsel.Properties.Mask.EditMask = "d";
            this.txtParsel.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtParsel.Size = new System.Drawing.Size(135, 20);
            this.txtParsel.TabIndex = 38;
            // 
            // txtAda
            // 
            this.txtAda.Location = new System.Drawing.Point(174, 220);
            this.txtAda.Name = "txtAda";
            this.txtAda.Properties.Mask.EditMask = "d";
            this.txtAda.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtAda.Size = new System.Drawing.Size(135, 20);
            this.txtAda.TabIndex = 37;
            // 
            // txtAlan
            // 
            this.txtAlan.Location = new System.Drawing.Point(174, 186);
            this.txtAlan.Name = "txtAlan";
            this.txtAlan.Properties.Mask.EditMask = "d";
            this.txtAlan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtAlan.Size = new System.Drawing.Size(135, 20);
            this.txtAlan.TabIndex = 36;
            // 
            // lblFiyat
            // 
            this.lblFiyat.Appearance.Font = new System.Drawing.Font("Yu Gothic", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblFiyat.Appearance.Options.UseFont = true;
            this.lblFiyat.Location = new System.Drawing.Point(84, 318);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(43, 16);
            this.lblFiyat.TabIndex = 35;
            this.lblFiyat.Text = "FİYAT :";
            // 
            // lblTapu
            // 
            this.lblTapu.Appearance.Font = new System.Drawing.Font("Yu Gothic", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblTapu.Appearance.Options.UseFont = true;
            this.lblTapu.Location = new System.Drawing.Point(31, 285);
            this.lblTapu.Name = "lblTapu";
            this.lblTapu.Size = new System.Drawing.Size(98, 16);
            this.lblTapu.TabIndex = 34;
            this.lblTapu.Text = "TAPU DURUMU :";
            // 
            // lblParsel
            // 
            this.lblParsel.Appearance.Font = new System.Drawing.Font("Yu Gothic", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblParsel.Appearance.Options.UseFont = true;
            this.lblParsel.Location = new System.Drawing.Point(51, 253);
            this.lblParsel.Name = "lblParsel";
            this.lblParsel.Size = new System.Drawing.Size(75, 16);
            this.lblParsel.TabIndex = 33;
            this.lblParsel.Text = "PARSEL NO :";
            // 
            // lblAda
            // 
            this.lblAda.Appearance.Font = new System.Drawing.Font("Yu Gothic", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblAda.Appearance.Options.UseFont = true;
            this.lblAda.Location = new System.Drawing.Point(74, 222);
            this.lblAda.Name = "lblAda";
            this.lblAda.Size = new System.Drawing.Size(53, 16);
            this.lblAda.TabIndex = 32;
            this.lblAda.Text = "ADA NO :";
            // 
            // lblIlce
            // 
            this.lblIlce.Appearance.Font = new System.Drawing.Font("Yu Gothic", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblIlce.Appearance.Options.UseFont = true;
            this.lblIlce.Location = new System.Drawing.Point(88, 153);
            this.lblIlce.Name = "lblIlce";
            this.lblIlce.Size = new System.Drawing.Size(38, 16);
            this.lblIlce.TabIndex = 31;
            this.lblIlce.Text = "İLÇE  :";
            // 
            // lblIl
            // 
            this.lblIl.Appearance.Font = new System.Drawing.Font("Yu Gothic", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblIl.Appearance.Options.UseFont = true;
            this.lblIl.Location = new System.Drawing.Point(105, 120);
            this.lblIl.Name = "lblIl";
            this.lblIl.Size = new System.Drawing.Size(21, 16);
            this.lblIl.TabIndex = 30;
            this.lblIl.Text = " İL :";
            // 
            // lblAlan
            // 
            this.lblAlan.Appearance.Font = new System.Drawing.Font("Yu Gothic", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblAlan.Appearance.Options.UseFont = true;
            this.lblAlan.Location = new System.Drawing.Point(88, 188);
            this.lblAlan.Name = "lblAlan";
            this.lblAlan.Size = new System.Drawing.Size(39, 16);
            this.lblAlan.TabIndex = 29;
            this.lblAlan.Text = "ALAN :";
            // 
            // lblImar
            // 
            this.lblImar.Appearance.Font = new System.Drawing.Font("Yu Gothic", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblImar.Appearance.Options.UseFont = true;
            this.lblImar.Location = new System.Drawing.Point(30, 86);
            this.lblImar.Name = "lblImar";
            this.lblImar.Size = new System.Drawing.Size(96, 16);
            this.lblImar.TabIndex = 28;
            this.lblImar.Text = "İMAR DURUMU :";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(118, 373);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(120, 40);
            this.btnGuncelle.TabIndex = 45;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btnCikis.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.ImageOptions.Image")));
            this.btnCikis.Location = new System.Drawing.Point(291, -1);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(50, 56);
            this.btnCikis.TabIndex = 46;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // KullaniciAraziGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(341, 439);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.cmbTapu);
            this.Controls.Add(this.cmbIlce);
            this.Controls.Add(this.cmbIl);
            this.Controls.Add(this.cmbImar);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtParsel);
            this.Controls.Add(this.txtAda);
            this.Controls.Add(this.txtAlan);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblTapu);
            this.Controls.Add(this.lblParsel);
            this.Controls.Add(this.lblAda);
            this.Controls.Add(this.lblIlce);
            this.Controls.Add(this.lblIl);
            this.Controls.Add(this.lblAlan);
            this.Controls.Add(this.lblImar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KullaniciAraziGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KullaniciAraziGuncelle";
            this.Load += new System.EventHandler(this.KullaniciAraziGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbTapu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIlce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParsel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlan.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cmbTapu;
        private DevExpress.XtraEditors.ComboBoxEdit cmbIlce;
        private DevExpress.XtraEditors.ComboBoxEdit cmbIl;
        private DevExpress.XtraEditors.ComboBoxEdit cmbImar;
        private DevExpress.XtraEditors.TextEdit txtFiyat;
        private DevExpress.XtraEditors.TextEdit txtParsel;
        private DevExpress.XtraEditors.TextEdit txtAda;
        private DevExpress.XtraEditors.TextEdit txtAlan;
        private DevExpress.XtraEditors.LabelControl lblFiyat;
        private DevExpress.XtraEditors.LabelControl lblTapu;
        private DevExpress.XtraEditors.LabelControl lblParsel;
        private DevExpress.XtraEditors.LabelControl lblAda;
        private DevExpress.XtraEditors.LabelControl lblIlce;
        private DevExpress.XtraEditors.LabelControl lblIl;
        private DevExpress.XtraEditors.LabelControl lblAlan;
        private DevExpress.XtraEditors.LabelControl lblImar;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnCikis;
    }
}