namespace TicariOtomasyn
{
    partial class FrmPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonel));
            this.LblVd = new DevExpress.XtraEditors.LabelControl();
            this.lblilce = new DevExpress.XtraEditors.LabelControl();
            this.TxtGorev = new DevExpress.XtraEditors.TextEdit();
            this.TxtMail = new DevExpress.XtraEditors.TextEdit();
            this.TxtTc = new DevExpress.XtraEditors.TextEdit();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.lbladres = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.TxtTel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSoyad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtAdres = new DevExpress.XtraEditors.MemoEdit();
            this.TxtIl = new DevExpress.XtraEditors.ComboBoxEdit();
            this.TxtIlce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.TxtGorev.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAdres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIlce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblVd
            // 
            this.LblVd.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.LblVd.Appearance.Options.UseFont = true;
            this.LblVd.Location = new System.Drawing.Point(36, 224);
            this.LblVd.Name = "LblVd";
            this.LblVd.Size = new System.Drawing.Size(44, 14);
            this.LblVd.TabIndex = 0;
            this.LblVd.Text = "Gorev : ";
            // 
            // lblilce
            // 
            this.lblilce.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblilce.Appearance.Options.UseFont = true;
            this.lblilce.Location = new System.Drawing.Point(49, 198);
            this.lblilce.Name = "lblilce";
            this.lblilce.Size = new System.Drawing.Size(31, 14);
            this.lblilce.TabIndex = 0;
            this.lblilce.Text = "İlçe : ";
            // 
            // TxtGorev
            // 
            this.TxtGorev.Location = new System.Drawing.Point(90, 221);
            this.TxtGorev.Name = "TxtGorev";
            this.TxtGorev.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.TxtGorev.Properties.Appearance.Options.UseFont = true;
            this.TxtGorev.Size = new System.Drawing.Size(179, 20);
            this.TxtGorev.TabIndex = 10;
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(90, 143);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.TxtMail.Properties.Appearance.Options.UseFont = true;
            this.TxtMail.Size = new System.Drawing.Size(179, 20);
            this.TxtMail.TabIndex = 7;
            // 
            // TxtTc
            // 
            this.TxtTc.Location = new System.Drawing.Point(90, 117);
            this.TxtTc.Name = "TxtTc";
            this.TxtTc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.TxtTc.Properties.Appearance.Options.UseFont = true;
            this.TxtTc.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.TxtTc.Properties.MaskSettings.Set("mask", "\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d\\d");
            this.TxtTc.Properties.MaskSettings.Set("allowBlankInput", true);
            this.TxtTc.Size = new System.Drawing.Size(179, 20);
            this.TxtTc.TabIndex = 6;
            // 
            // BtnSil
            // 
            this.BtnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.BtnSil.Appearance.Options.UseFont = true;
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(201, 382);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(60, 41);
            this.BtnSil.TabIndex = 14;
            this.BtnSil.Text = "Sil";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.BtnGuncelle.Appearance.Options.UseFont = true;
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(105, 382);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(90, 41);
            this.BtnGuncelle.TabIndex = 13;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.BtnKaydet.Appearance.Options.UseFont = true;
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(17, 382);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(84, 41);
            this.BtnKaydet.TabIndex = 12;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // lbladres
            // 
            this.lbladres.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lbladres.Appearance.Options.UseFont = true;
            this.lbladres.Location = new System.Drawing.Point(37, 249);
            this.lbladres.Name = "lbladres";
            this.lbladres.Size = new System.Drawing.Size(43, 14);
            this.lbladres.TabIndex = 0;
            this.lbladres.Text = "Adres : ";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(62, 172);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(18, 14);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "İl : ";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(49, 146);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(31, 14);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Mail : ";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(20, 120);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(60, 14);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "TC Kimlik : ";
            // 
            // TxtTel
            // 
            this.TxtTel.Location = new System.Drawing.Point(91, 91);
            this.TxtTel.Name = "TxtTel";
            this.TxtTel.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.TxtTel.Properties.Appearance.Options.UseFont = true;
            this.TxtTel.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.TxtTel.Properties.MaskSettings.Set("mask", "(\\(\\d\\d\\d\\) )\\d\\d\\d \\d\\d \\d\\d");
            this.TxtTel.Properties.MaskSettings.Set("culture", null);
            this.TxtTel.Properties.MaskSettings.Set("isAutoComplete", true);
            this.TxtTel.Properties.MaskSettings.Set("showPlaceholders", true);
            this.TxtTel.Properties.MaskSettings.Set("allowBlankInput", true);
            this.TxtTel.Size = new System.Drawing.Size(179, 20);
            this.TxtTel.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(22, 94);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(58, 14);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Telefon :  ";
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(91, 65);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.TxtSoyad.Properties.Appearance.Options.UseFont = true;
            this.TxtSoyad.Size = new System.Drawing.Size(179, 20);
            this.TxtSoyad.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(35, 68);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 14);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Soyad : ";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(91, 39);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.TxtAd.Properties.Appearance.Options.UseFont = true;
            this.TxtAd.Size = new System.Drawing.Size(179, 20);
            this.TxtAd.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(53, 42);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 14);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Ad : ";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(91, 13);
            this.TxtID.Name = "TxtID";
            this.TxtID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.TxtID.Properties.Appearance.Options.UseFont = true;
            this.TxtID.Size = new System.Drawing.Size(179, 20);
            this.TxtID.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(56, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID : ";
            // 
            // TxtAdres
            // 
            this.TxtAdres.Location = new System.Drawing.Point(90, 247);
            this.TxtAdres.Name = "TxtAdres";
            this.TxtAdres.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.TxtAdres.Properties.Appearance.Options.UseFont = true;
            this.TxtAdres.Size = new System.Drawing.Size(179, 103);
            this.TxtAdres.TabIndex = 11;
            // 
            // TxtIl
            // 
            this.TxtIl.Location = new System.Drawing.Point(90, 169);
            this.TxtIl.Name = "TxtIl";
            this.TxtIl.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.TxtIl.Properties.Appearance.Options.UseFont = true;
            this.TxtIl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtIl.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.TxtIl.Size = new System.Drawing.Size(179, 20);
            this.TxtIl.TabIndex = 8;
            this.TxtIl.SelectedIndexChanged += new System.EventHandler(this.TxtIl_SelectedIndexChanged);
            // 
            // TxtIlce
            // 
            this.TxtIlce.Location = new System.Drawing.Point(90, 195);
            this.TxtIlce.Name = "TxtIlce";
            this.TxtIlce.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.TxtIlce.Properties.Appearance.Options.UseFont = true;
            this.TxtIlce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TxtIlce.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.TxtIlce.Size = new System.Drawing.Size(179, 20);
            this.TxtIlce.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 444);
            this.panel3.TabIndex = 1;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(720, 444);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.gridControl1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(720, 444);
            this.panel4.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.LblVd);
            this.panel2.Controls.Add(this.lblilce);
            this.panel2.Controls.Add(this.TxtGorev);
            this.panel2.Controls.Add(this.TxtMail);
            this.panel2.Controls.Add(this.TxtTc);
            this.panel2.Controls.Add(this.BtnSil);
            this.panel2.Controls.Add(this.BtnGuncelle);
            this.panel2.Controls.Add(this.BtnKaydet);
            this.panel2.Controls.Add(this.lbladres);
            this.panel2.Controls.Add(this.labelControl8);
            this.panel2.Controls.Add(this.labelControl7);
            this.panel2.Controls.Add(this.labelControl6);
            this.panel2.Controls.Add(this.TxtTel);
            this.panel2.Controls.Add(this.labelControl4);
            this.panel2.Controls.Add(this.TxtSoyad);
            this.panel2.Controls.Add(this.labelControl3);
            this.panel2.Controls.Add(this.TxtAd);
            this.panel2.Controls.Add(this.labelControl2);
            this.panel2.Controls.Add(this.TxtID);
            this.panel2.Controls.Add(this.labelControl1);
            this.panel2.Controls.Add(this.TxtAdres);
            this.panel2.Controls.Add(this.TxtIl);
            this.panel2.Controls.Add(this.TxtIlce);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(720, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 444);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 444);
            this.panel1.TabIndex = 1;
            // 
            // FrmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 444);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPersonel";
            this.Text = "FrmPersonel";
            this.Load += new System.EventHandler(this.FrmPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtGorev.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAdres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIlce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl LblVd;
        private DevExpress.XtraEditors.LabelControl lblilce;
        private DevExpress.XtraEditors.TextEdit TxtGorev;
        private DevExpress.XtraEditors.TextEdit TxtMail;
        private DevExpress.XtraEditors.TextEdit TxtTc;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.LabelControl lbladres;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit TxtTel;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TxtSoyad;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtAd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit TxtAdres;
        private DevExpress.XtraEditors.ComboBoxEdit TxtIl;
        private DevExpress.XtraEditors.ComboBoxEdit TxtIlce;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}