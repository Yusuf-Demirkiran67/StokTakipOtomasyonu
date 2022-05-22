
namespace WebFormsUI
{
    partial class Anasayfa
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
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.AraTxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EkleBtn = new System.Windows.Forms.Button();
            this.CikisBtn = new System.Windows.Forms.Button();
            this.SilBtn = new System.Windows.Forms.Button();
            this.GuncelleBtn = new System.Windows.Forms.Button();
            this.CategoryAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgwProducts.Location = new System.Drawing.Point(52, 164);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.RowHeadersVisible = false;
            this.dgwProducts.Size = new System.Drawing.Size(1138, 277);
            this.dgwProducts.TabIndex = 0;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(52, 47);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(449, 21);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            this.cbxCategory.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbxCategory_MouseClick);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(114, 119);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(387, 20);
            this.txtProductName.TabIndex = 2;
            this.txtProductName.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            // 
            // AraTxt
            // 
            this.AraTxt.AutoSize = true;
            this.AraTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AraTxt.Location = new System.Drawing.Point(48, 119);
            this.AraTxt.Name = "AraTxt";
            this.AraTxt.Size = new System.Drawing.Size(48, 24);
            this.AraTxt.TabIndex = 3;
            this.AraTxt.Text = "Ara:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(49, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ürün ismine göre ara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(49, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kategoriye göre listele";
            // 
            // EkleBtn
            // 
            this.EkleBtn.BackColor = System.Drawing.Color.Lime;
            this.EkleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EkleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EkleBtn.Location = new System.Drawing.Point(584, 47);
            this.EkleBtn.Name = "EkleBtn";
            this.EkleBtn.Size = new System.Drawing.Size(106, 73);
            this.EkleBtn.TabIndex = 6;
            this.EkleBtn.Text = "Ekle";
            this.EkleBtn.UseVisualStyleBackColor = false;
            this.EkleBtn.Click += new System.EventHandler(this.EkleBtn_Click);
            // 
            // CikisBtn
            // 
            this.CikisBtn.BackColor = System.Drawing.Color.Maroon;
            this.CikisBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CikisBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CikisBtn.Location = new System.Drawing.Point(1150, 447);
            this.CikisBtn.Name = "CikisBtn";
            this.CikisBtn.Size = new System.Drawing.Size(106, 73);
            this.CikisBtn.TabIndex = 7;
            this.CikisBtn.Text = "Çıkış";
            this.CikisBtn.UseVisualStyleBackColor = false;
            this.CikisBtn.Click += new System.EventHandler(this.CikisBtn_Click);
            // 
            // SilBtn
            // 
            this.SilBtn.BackColor = System.Drawing.Color.Red;
            this.SilBtn.Cursor = System.Windows.Forms.Cursors.Help;
            this.SilBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SilBtn.Location = new System.Drawing.Point(991, 47);
            this.SilBtn.Name = "SilBtn";
            this.SilBtn.Size = new System.Drawing.Size(106, 73);
            this.SilBtn.TabIndex = 8;
            this.SilBtn.Text = "Sil";
            this.SilBtn.UseVisualStyleBackColor = false;
            this.SilBtn.Click += new System.EventHandler(this.SilBtn_Click);
            // 
            // GuncelleBtn
            // 
            this.GuncelleBtn.BackColor = System.Drawing.Color.Goldenrod;
            this.GuncelleBtn.Cursor = System.Windows.Forms.Cursors.Help;
            this.GuncelleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GuncelleBtn.Location = new System.Drawing.Point(778, 47);
            this.GuncelleBtn.Name = "GuncelleBtn";
            this.GuncelleBtn.Size = new System.Drawing.Size(110, 73);
            this.GuncelleBtn.TabIndex = 9;
            this.GuncelleBtn.Text = "Güncelle";
            this.GuncelleBtn.UseVisualStyleBackColor = false;
            this.GuncelleBtn.Click += new System.EventHandler(this.GuncelleBtn_Click);
            // 
            // CategoryAdd
            // 
            this.CategoryAdd.BackColor = System.Drawing.Color.DarkGreen;
            this.CategoryAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CategoryAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CategoryAdd.Location = new System.Drawing.Point(507, 39);
            this.CategoryAdd.Name = "CategoryAdd";
            this.CategoryAdd.Size = new System.Drawing.Size(29, 33);
            this.CategoryAdd.TabIndex = 10;
            this.CategoryAdd.Text = "+";
            this.CategoryAdd.UseVisualStyleBackColor = false;
            this.CategoryAdd.Click += new System.EventHandler(this.CategoryAdd_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1257, 513);
            this.Controls.Add(this.CategoryAdd);
            this.Controls.Add(this.GuncelleBtn);
            this.Controls.Add(this.SilBtn);
            this.Controls.Add(this.CikisBtn);
            this.Controls.Add(this.EkleBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AraTxt);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.cbxCategory);
            this.Controls.Add(this.dgwProducts);
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.Activated += new System.EventHandler(this.Anasayfa_Activated);
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label AraTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EkleBtn;
        private System.Windows.Forms.Button CikisBtn;
        private System.Windows.Forms.Button SilBtn;
        private System.Windows.Forms.Button GuncelleBtn;
        public System.Windows.Forms.ComboBox cbxCategory;
        public System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.Button CategoryAdd;
    }
}