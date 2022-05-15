
namespace WebFormsUI
{
    partial class Ekle
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
            this.GeriBtn = new System.Windows.Forms.Button();
            this.ProductNameLbl = new System.Windows.Forms.Label();
            this.UnitPriceLbl = new System.Windows.Forms.Label();
            this.QuantityLbl = new System.Windows.Forms.Label();
            this.StokAmountLbl = new System.Windows.Forms.Label();
            this.CategoryNameLbl = new System.Windows.Forms.Label();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            this.tbxStockAmount = new System.Windows.Forms.TextBox();
            this.EkleButon = new System.Windows.Forms.Button();
            this.cbxCategoryId = new System.Windows.Forms.ComboBox();
            this.pbxQr = new System.Windows.Forms.PictureBox();
            this.rtbxQr = new System.Windows.Forms.RichTextBox();
            this.Qrcoz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxQr)).BeginInit();
            this.SuspendLayout();
            // 
            // GeriBtn
            // 
            this.GeriBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.GeriBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GeriBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GeriBtn.Location = new System.Drawing.Point(27, 13);
            this.GeriBtn.Name = "GeriBtn";
            this.GeriBtn.Size = new System.Drawing.Size(106, 39);
            this.GeriBtn.TabIndex = 0;
            this.GeriBtn.Text = "Geri";
            this.GeriBtn.UseVisualStyleBackColor = false;
            this.GeriBtn.Click += new System.EventHandler(this.GeriBtn_Click);
            // 
            // ProductNameLbl
            // 
            this.ProductNameLbl.AutoSize = true;
            this.ProductNameLbl.BackColor = System.Drawing.Color.DarkRed;
            this.ProductNameLbl.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ProductNameLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProductNameLbl.Location = new System.Drawing.Point(199, 81);
            this.ProductNameLbl.Name = "ProductNameLbl";
            this.ProductNameLbl.Size = new System.Drawing.Size(81, 23);
            this.ProductNameLbl.TabIndex = 1;
            this.ProductNameLbl.Text = "Ürün Adı:";
            // 
            // UnitPriceLbl
            // 
            this.UnitPriceLbl.AutoSize = true;
            this.UnitPriceLbl.BackColor = System.Drawing.Color.DarkRed;
            this.UnitPriceLbl.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UnitPriceLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UnitPriceLbl.Location = new System.Drawing.Point(199, 334);
            this.UnitPriceLbl.Name = "UnitPriceLbl";
            this.UnitPriceLbl.Size = new System.Drawing.Size(99, 23);
            this.UnitPriceLbl.TabIndex = 3;
            this.UnitPriceLbl.Text = "Birim Fiyatı:";
            // 
            // QuantityLbl
            // 
            this.QuantityLbl.AutoSize = true;
            this.QuantityLbl.BackColor = System.Drawing.Color.DarkRed;
            this.QuantityLbl.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.QuantityLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.QuantityLbl.Location = new System.Drawing.Point(199, 265);
            this.QuantityLbl.Name = "QuantityLbl";
            this.QuantityLbl.Size = new System.Drawing.Size(102, 23);
            this.QuantityLbl.TabIndex = 4;
            this.QuantityLbl.Text = "Birim Adedi:";
            // 
            // StokAmountLbl
            // 
            this.StokAmountLbl.AutoSize = true;
            this.StokAmountLbl.BackColor = System.Drawing.Color.DarkRed;
            this.StokAmountLbl.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StokAmountLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StokAmountLbl.Location = new System.Drawing.Point(199, 204);
            this.StokAmountLbl.Name = "StokAmountLbl";
            this.StokAmountLbl.Size = new System.Drawing.Size(97, 23);
            this.StokAmountLbl.TabIndex = 5;
            this.StokAmountLbl.Text = "Stok Adedi:";
            // 
            // CategoryNameLbl
            // 
            this.CategoryNameLbl.AutoSize = true;
            this.CategoryNameLbl.BackColor = System.Drawing.Color.DarkRed;
            this.CategoryNameLbl.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CategoryNameLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CategoryNameLbl.Location = new System.Drawing.Point(199, 143);
            this.CategoryNameLbl.Name = "CategoryNameLbl";
            this.CategoryNameLbl.Size = new System.Drawing.Size(78, 23);
            this.CategoryNameLbl.TabIndex = 6;
            this.CategoryNameLbl.Text = "Kategori ";
            // 
            // tbxProductName
            // 
            this.tbxProductName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxProductName.Location = new System.Drawing.Point(336, 84);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(171, 22);
            this.tbxProductName.TabIndex = 7;
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUnitPrice.Location = new System.Drawing.Point(336, 337);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(171, 22);
            this.tbxUnitPrice.TabIndex = 8;
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxQuantity.Location = new System.Drawing.Point(336, 265);
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.Size = new System.Drawing.Size(171, 22);
            this.tbxQuantity.TabIndex = 9;
            // 
            // tbxStockAmount
            // 
            this.tbxStockAmount.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxStockAmount.Location = new System.Drawing.Point(336, 204);
            this.tbxStockAmount.Name = "tbxStockAmount";
            this.tbxStockAmount.Size = new System.Drawing.Size(171, 22);
            this.tbxStockAmount.TabIndex = 10;
            // 
            // EkleButon
            // 
            this.EkleButon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EkleButon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EkleButon.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EkleButon.Location = new System.Drawing.Point(336, 387);
            this.EkleButon.Name = "EkleButon";
            this.EkleButon.Size = new System.Drawing.Size(171, 77);
            this.EkleButon.TabIndex = 12;
            this.EkleButon.Text = "Ekle";
            this.EkleButon.UseVisualStyleBackColor = false;
            this.EkleButon.Click += new System.EventHandler(this.EkleButon_Click);
            // 
            // cbxCategoryId
            // 
            this.cbxCategoryId.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxCategoryId.FormattingEnabled = true;
            this.cbxCategoryId.Location = new System.Drawing.Point(336, 142);
            this.cbxCategoryId.Name = "cbxCategoryId";
            this.cbxCategoryId.Size = new System.Drawing.Size(171, 24);
            this.cbxCategoryId.TabIndex = 13;
            // 
            // pbxQr
            // 
            this.pbxQr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxQr.Location = new System.Drawing.Point(702, 34);
            this.pbxQr.Name = "pbxQr";
            this.pbxQr.Size = new System.Drawing.Size(502, 289);
            this.pbxQr.TabIndex = 14;
            this.pbxQr.TabStop = false;
            this.pbxQr.Click += new System.EventHandler(this.pbxQr_Click);
            // 
            // rtbxQr
            // 
            this.rtbxQr.Location = new System.Drawing.Point(911, 337);
            this.rtbxQr.Name = "rtbxQr";
            this.rtbxQr.Size = new System.Drawing.Size(293, 146);
            this.rtbxQr.TabIndex = 15;
            this.rtbxQr.Text = "";
            // 
            // Qrcoz
            // 
            this.Qrcoz.BackColor = System.Drawing.Color.SeaGreen;
            this.Qrcoz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Qrcoz.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Qrcoz.Location = new System.Drawing.Point(702, 375);
            this.Qrcoz.Name = "Qrcoz";
            this.Qrcoz.Size = new System.Drawing.Size(171, 77);
            this.Qrcoz.TabIndex = 26;
            this.Qrcoz.Text = "QR Kod Çöz";
            this.Qrcoz.UseVisualStyleBackColor = false;
            this.Qrcoz.Click += new System.EventHandler(this.Qrcoz_Click);
            // 
            // Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1250, 506);
            this.Controls.Add(this.Qrcoz);
            this.Controls.Add(this.rtbxQr);
            this.Controls.Add(this.pbxQr);
            this.Controls.Add(this.cbxCategoryId);
            this.Controls.Add(this.EkleButon);
            this.Controls.Add(this.tbxStockAmount);
            this.Controls.Add(this.tbxQuantity);
            this.Controls.Add(this.tbxUnitPrice);
            this.Controls.Add(this.tbxProductName);
            this.Controls.Add(this.CategoryNameLbl);
            this.Controls.Add(this.StokAmountLbl);
            this.Controls.Add(this.QuantityLbl);
            this.Controls.Add(this.UnitPriceLbl);
            this.Controls.Add(this.ProductNameLbl);
            this.Controls.Add(this.GeriBtn);
            this.Name = "Ekle";
            this.Text = "Ekle";
            this.Load += new System.EventHandler(this.Ekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxQr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GeriBtn;
        private System.Windows.Forms.Label ProductNameLbl;
        private System.Windows.Forms.Label UnitPriceLbl;
        private System.Windows.Forms.Label QuantityLbl;
        private System.Windows.Forms.Label StokAmountLbl;
        private System.Windows.Forms.Label CategoryNameLbl;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.TextBox tbxStockAmount;
        private System.Windows.Forms.Button EkleButon;
        public System.Windows.Forms.ComboBox cbxCategoryId;
        private System.Windows.Forms.PictureBox pbxQr;
        private System.Windows.Forms.RichTextBox rtbxQr;
        private System.Windows.Forms.Button Qrcoz;
    }
}