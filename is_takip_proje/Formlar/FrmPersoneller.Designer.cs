﻿
namespace is_takip_proje.Formlar
{
    partial class FrmPersoneller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersoneller));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnListele = new DevExpress.XtraEditors.SimpleButton();
            this.TxtAd = new DevExpress.XtraEditors.TextEdit();
            this.TxtID = new DevExpress.XtraEditors.TextEdit();
            this.LblPersonelAd = new DevExpress.XtraEditors.LabelControl();
            this.LblPersonelId = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.gridLookUpEdit1 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(-2, 1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(701, 488);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridLookUpEdit1);
            this.groupControl1.Controls.Add(this.BtnSil);
            this.groupControl1.Controls.Add(this.BtnGuncelle);
            this.groupControl1.Controls.Add(this.BtnEkle);
            this.groupControl1.Controls.Add(this.BtnListele);
            this.groupControl1.Controls.Add(this.textEdit3);
            this.groupControl1.Controls.Add(this.textEdit2);
            this.groupControl1.Controls.Add(this.TxtAd);
            this.groupControl1.Controls.Add(this.textEdit1);
            this.groupControl1.Controls.Add(this.TxtID);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.LblPersonelAd);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.LblPersonelId);
            this.groupControl1.Location = new System.Drawing.Point(705, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(282, 488);
            this.groupControl1.TabIndex = 6;
            // 
            // BtnSil
            // 
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(92, 282);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(86, 42);
            this.BtnSil.TabIndex = 2;
            this.BtnSil.Text = "Sil";
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(187, 282);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(86, 42);
            this.BtnGuncelle.TabIndex = 2;
            this.BtnGuncelle.Text = "Güncelle";
            // 
            // BtnEkle
            // 
            this.BtnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnEkle.ImageOptions.Image")));
            this.BtnEkle.Location = new System.Drawing.Point(0, 282);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(86, 42);
            this.BtnEkle.TabIndex = 2;
            this.BtnEkle.Text = "Ekle";
            // 
            // BtnListele
            // 
            this.BtnListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnListele.ImageOptions.Image")));
            this.BtnListele.Location = new System.Drawing.Point(9, 250);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(256, 26);
            this.BtnListele.TabIndex = 2;
            this.BtnListele.Text = "Listele";
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(82, 81);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(183, 20);
            this.TxtAd.TabIndex = 1;
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(82, 51);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(183, 20);
            this.TxtID.TabIndex = 1;
            // 
            // LblPersonelAd
            // 
            this.LblPersonelAd.Location = new System.Drawing.Point(5, 84);
            this.LblPersonelAd.Name = "LblPersonelAd";
            this.LblPersonelAd.Size = new System.Drawing.Size(22, 13);
            this.LblPersonelAd.TabIndex = 0;
            this.LblPersonelAd.Text = "Adı :";
            // 
            // LblPersonelId
            // 
            this.LblPersonelId.Location = new System.Drawing.Point(5, 54);
            this.LblPersonelId.Name = "LblPersonelId";
            this.LblPersonelId.Size = new System.Drawing.Size(59, 13);
            this.LblPersonelId.TabIndex = 0;
            this.LblPersonelId.Text = "Personel ID:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 114);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Soyadı :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 144);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(25, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mail :";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(84, 115);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(183, 20);
            this.textEdit1.TabIndex = 1;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(82, 141);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(183, 20);
            this.textEdit2.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 172);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Görsel :";
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(82, 169);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(183, 20);
            this.textEdit3.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(5, 200);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Departman :";
            // 
            // gridLookUpEdit1
            // 
            this.gridLookUpEdit1.Location = new System.Drawing.Point(82, 200);
            this.gridLookUpEdit1.Name = "gridLookUpEdit1";
            this.gridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEdit1.Properties.PopupView = this.gridLookUpEdit1View;
            this.gridLookUpEdit1.Size = new System.Drawing.Size(183, 20);
            this.gridLookUpEdit1.TabIndex = 3;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // FrmPersoneller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 490);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmPersoneller";
            this.Text = "Personeller";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnEkle;
        private DevExpress.XtraEditors.SimpleButton BtnListele;
        private DevExpress.XtraEditors.TextEdit TxtAd;
        private DevExpress.XtraEditors.TextEdit TxtID;
        private DevExpress.XtraEditors.LabelControl LblPersonelAd;
        private DevExpress.XtraEditors.LabelControl LblPersonelId;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}