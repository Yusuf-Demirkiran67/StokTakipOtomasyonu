
namespace WebFormsUI
{
    partial class Guncelle
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
            this.pbxQR = new System.Windows.Forms.PictureBox();
            this.cbxCategoryIdUpdate = new System.Windows.Forms.ComboBox();
            this.GuncelleButon = new System.Windows.Forms.Button();
            this.tbxStockAmountUpdate = new System.Windows.Forms.TextBox();
            this.tbxQuantityUpdate = new System.Windows.Forms.TextBox();
            this.tbxUnitPriceUpdate = new System.Windows.Forms.TextBox();
            this.tbxProductNameUpdate = new System.Windows.Forms.TextBox();
            this.CategoryNameLbl = new System.Windows.Forms.Label();
            this.StokAmountLbl = new System.Windows.Forms.Label();
            this.QuantityLbl = new System.Windows.Forms.Label();
            this.UnitPriceLbl = new System.Windows.Forms.Label();
            this.ProductNameLbl = new System.Windows.Forms.Label();
            this.GeriBtn = new System.Windows.Forms.Button();
            this.RtbxOR = new System.Windows.Forms.RichTextBox();
            this.QRKodCoz = new System.Windows.Forms.Button();
            this.SilButon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxQR)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxQR
            // 
            this.pbxQR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxQR.Location = new System.Drawing.Point(646, 28);
            this.pbxQR.Name = "pbxQR";
            this.pbxQR.Size = new System.Drawing.Size(534, 293);
            this.pbxQR.TabIndex = 27;
            this.pbxQR.TabStop = false;
            // 
            // cbxCategoryIdUpdate
            // 
            this.cbxCategoryIdUpdate.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxCategoryIdUpdate.FormattingEnabled = true;
            this.cbxCategoryIdUpdate.Location = new System.Drawing.Point(357, 157);
            this.cbxCategoryIdUpdate.Name = "cbxCategoryIdUpdate";
            this.cbxCategoryIdUpdate.Size = new System.Drawing.Size(171, 24);
            this.cbxCategoryIdUpdate.TabIndex = 26;
            this.cbxCategoryIdUpdate.SelectedIndexChanged += new System.EventHandler(this.cbxCategoryIdUpdate_SelectedIndexChanged);
            // 
            // GuncelleButon
            // 
            this.GuncelleButon.BackColor = System.Drawing.Color.DarkOrange;
            this.GuncelleButon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GuncelleButon.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GuncelleButon.Location = new System.Drawing.Point(214, 402);
            this.GuncelleButon.Name = "GuncelleButon";
            this.GuncelleButon.Size = new System.Drawing.Size(122, 77);
            this.GuncelleButon.TabIndex = 25;
            this.GuncelleButon.Text = "Güncelle";
            this.GuncelleButon.UseVisualStyleBackColor = false;
            this.GuncelleButon.Click += new System.EventHandler(this.GuncelleButon_Click);
            // 
            // tbxStockAmountUpdate
            // 
            this.tbxStockAmountUpdate.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxStockAmountUpdate.Location = new System.Drawing.Point(357, 219);
            this.tbxStockAmountUpdate.Name = "tbxStockAmountUpdate";
            this.tbxStockAmountUpdate.Size = new System.Drawing.Size(171, 22);
            this.tbxStockAmountUpdate.TabIndex = 24;
            // 
            // tbxQuantityUpdate
            // 
            this.tbxQuantityUpdate.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxQuantityUpdate.Location = new System.Drawing.Point(357, 280);
            this.tbxQuantityUpdate.Name = "tbxQuantityUpdate";
            this.tbxQuantityUpdate.Size = new System.Drawing.Size(171, 22);
            this.tbxQuantityUpdate.TabIndex = 23;
            // 
            // tbxUnitPriceUpdate
            // 
            this.tbxUnitPriceUpdate.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUnitPriceUpdate.Location = new System.Drawing.Point(357, 349);
            this.tbxUnitPriceUpdate.Name = "tbxUnitPriceUpdate";
            this.tbxUnitPriceUpdate.Size = new System.Drawing.Size(171, 22);
            this.tbxUnitPriceUpdate.TabIndex = 22;
            // 
            // tbxProductNameUpdate
            // 
            this.tbxProductNameUpdate.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxProductNameUpdate.Location = new System.Drawing.Point(357, 99);
            this.tbxProductNameUpdate.Name = "tbxProductNameUpdate";
            this.tbxProductNameUpdate.Size = new System.Drawing.Size(171, 22);
            this.tbxProductNameUpdate.TabIndex = 21;
            // 
            // CategoryNameLbl
            // 
            this.CategoryNameLbl.AutoSize = true;
            this.CategoryNameLbl.BackColor = System.Drawing.Color.DarkRed;
            this.CategoryNameLbl.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CategoryNameLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CategoryNameLbl.Location = new System.Drawing.Point(220, 158);
            this.CategoryNameLbl.Name = "CategoryNameLbl";
            this.CategoryNameLbl.Size = new System.Drawing.Size(78, 23);
            this.CategoryNameLbl.TabIndex = 20;
            this.CategoryNameLbl.Text = "Kategori ";
            // 
            // StokAmountLbl
            // 
            this.StokAmountLbl.AutoSize = true;
            this.StokAmountLbl.BackColor = System.Drawing.Color.DarkRed;
            this.StokAmountLbl.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StokAmountLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StokAmountLbl.Location = new System.Drawing.Point(220, 219);
            this.StokAmountLbl.Name = "StokAmountLbl";
            this.StokAmountLbl.Size = new System.Drawing.Size(97, 23);
            this.StokAmountLbl.TabIndex = 19;
            this.StokAmountLbl.Text = "Stok Adedi:";
            // 
            // QuantityLbl
            // 
            this.QuantityLbl.AutoSize = true;
            this.QuantityLbl.BackColor = System.Drawing.Color.DarkRed;
            this.QuantityLbl.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.QuantityLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.QuantityLbl.Location = new System.Drawing.Point(220, 280);
            this.QuantityLbl.Name = "QuantityLbl";
            this.QuantityLbl.Size = new System.Drawing.Size(102, 23);
            this.QuantityLbl.TabIndex = 18;
            this.QuantityLbl.Text = "Birim Adedi:";
            // 
            // UnitPriceLbl
            // 
            this.UnitPriceLbl.AutoSize = true;
            this.UnitPriceLbl.BackColor = System.Drawing.Color.DarkRed;
            this.UnitPriceLbl.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UnitPriceLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UnitPriceLbl.Location = new System.Drawing.Point(220, 349);
            this.UnitPriceLbl.Name = "UnitPriceLbl";
            this.UnitPriceLbl.Size = new System.Drawing.Size(99, 23);
            this.UnitPriceLbl.TabIndex = 17;
            this.UnitPriceLbl.Text = "Birim Fiyatı:";
            // 
            // ProductNameLbl
            // 
            this.ProductNameLbl.AutoSize = true;
            this.ProductNameLbl.BackColor = System.Drawing.Color.DarkRed;
            this.ProductNameLbl.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ProductNameLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProductNameLbl.Location = new System.Drawing.Point(220, 96);
            this.ProductNameLbl.Name = "ProductNameLbl";
            this.ProductNameLbl.Size = new System.Drawing.Size(81, 23);
            this.ProductNameLbl.TabIndex = 16;
            this.ProductNameLbl.Text = "Ürün Adı:";
            // 
            // GeriBtn
            // 
            this.GeriBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.GeriBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GeriBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GeriBtn.Location = new System.Drawing.Point(48, 28);
            this.GeriBtn.Name = "GeriBtn";
            this.GeriBtn.Size = new System.Drawing.Size(106, 39);
            this.GeriBtn.TabIndex = 15;
            this.GeriBtn.Text = "Geri";
            this.GeriBtn.UseVisualStyleBackColor = false;
            this.GeriBtn.Click += new System.EventHandler(this.GeriBtn_Click);
            // 
            // RtbxOR
            // 
            this.RtbxOR.Location = new System.Drawing.Point(821, 352);
            this.RtbxOR.Name = "RtbxOR";
            this.RtbxOR.Size = new System.Drawing.Size(359, 127);
            this.RtbxOR.TabIndex = 28;
            this.RtbxOR.Text = "";
            // 
            // QRKodCoz
            // 
            this.QRKodCoz.BackColor = System.Drawing.Color.SeaGreen;
            this.QRKodCoz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QRKodCoz.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.QRKodCoz.Location = new System.Drawing.Point(626, 391);
            this.QRKodCoz.Name = "QRKodCoz";
            this.QRKodCoz.Size = new System.Drawing.Size(171, 77);
            this.QRKodCoz.TabIndex = 29;
            this.QRKodCoz.Text = "QR Kod Çöz";
            this.QRKodCoz.UseVisualStyleBackColor = false;
            this.QRKodCoz.Click += new System.EventHandler(this.QRKodCoz_Click);
            // 
            // SilButon
            // 
            this.SilButon.BackColor = System.Drawing.Color.DarkRed;
            this.SilButon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SilButon.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SilButon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SilButon.Location = new System.Drawing.Point(406, 402);
            this.SilButon.Name = "SilButon";
            this.SilButon.Size = new System.Drawing.Size(122, 77);
            this.SilButon.TabIndex = 30;
            this.SilButon.Text = "Sil";
            this.SilButon.UseVisualStyleBackColor = false;
            this.SilButon.Click += new System.EventHandler(this.SilButon_Click);
            // 
            // Guncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1244, 506);
            this.Controls.Add(this.SilButon);
            this.Controls.Add(this.QRKodCoz);
            this.Controls.Add(this.RtbxOR);
            this.Controls.Add(this.pbxQR);
            this.Controls.Add(this.cbxCategoryIdUpdate);
            this.Controls.Add(this.GuncelleButon);
            this.Controls.Add(this.tbxStockAmountUpdate);
            this.Controls.Add(this.tbxQuantityUpdate);
            this.Controls.Add(this.tbxUnitPriceUpdate);
            this.Controls.Add(this.tbxProductNameUpdate);
            this.Controls.Add(this.CategoryNameLbl);
            this.Controls.Add(this.StokAmountLbl);
            this.Controls.Add(this.QuantityLbl);
            this.Controls.Add(this.UnitPriceLbl);
            this.Controls.Add(this.ProductNameLbl);
            this.Controls.Add(this.GeriBtn);
            this.Name = "Guncelle";
            this.Text = "Guncelle";
            this.Load += new System.EventHandler(this.Guncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ComboBox cbxCategoryIdUpdate;
        private System.Windows.Forms.Button GuncelleButon;
        private System.Windows.Forms.Label CategoryNameLbl;
        private System.Windows.Forms.Label StokAmountLbl;
        private System.Windows.Forms.Label QuantityLbl;
        private System.Windows.Forms.Label UnitPriceLbl;
        private System.Windows.Forms.Label ProductNameLbl;
        private System.Windows.Forms.Button GeriBtn;
        private System.Windows.Forms.Button QRKodCoz;
        public System.Windows.Forms.TextBox tbxStockAmountUpdate;
        public System.Windows.Forms.TextBox tbxQuantityUpdate;
        public System.Windows.Forms.TextBox tbxUnitPriceUpdate;
        public System.Windows.Forms.TextBox tbxProductNameUpdate;
        private System.Windows.Forms.Button SilButon;
        public System.Windows.Forms.PictureBox pbxQR;
        public System.Windows.Forms.RichTextBox RtbxOR;
    }
}