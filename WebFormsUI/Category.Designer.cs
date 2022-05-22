
namespace WebFormsUI
{
    partial class CategoryFrm
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
            this.CategoryNameTxt = new System.Windows.Forms.TextBox();
            this.CategoryNameLbl = new System.Windows.Forms.Label();
            this.CategoryNameAddBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CategoryNameTxt
            // 
            this.CategoryNameTxt.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CategoryNameTxt.Location = new System.Drawing.Point(148, 110);
            this.CategoryNameTxt.Name = "CategoryNameTxt";
            this.CategoryNameTxt.Size = new System.Drawing.Size(164, 25);
            this.CategoryNameTxt.TabIndex = 0;
            // 
            // CategoryNameLbl
            // 
            this.CategoryNameLbl.AutoSize = true;
            this.CategoryNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CategoryNameLbl.Location = new System.Drawing.Point(12, 110);
            this.CategoryNameLbl.Name = "CategoryNameLbl";
            this.CategoryNameLbl.Size = new System.Drawing.Size(112, 20);
            this.CategoryNameLbl.TabIndex = 1;
            this.CategoryNameLbl.Text = "Kategori Adı:";
            // 
            // CategoryNameAddBtn
            // 
            this.CategoryNameAddBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.CategoryNameAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CategoryNameAddBtn.Location = new System.Drawing.Point(95, 189);
            this.CategoryNameAddBtn.Name = "CategoryNameAddBtn";
            this.CategoryNameAddBtn.Size = new System.Drawing.Size(138, 63);
            this.CategoryNameAddBtn.TabIndex = 2;
            this.CategoryNameAddBtn.Text = "Ekle";
            this.CategoryNameAddBtn.UseVisualStyleBackColor = false;
            this.CategoryNameAddBtn.Click += new System.EventHandler(this.CategoryNameAddBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BackBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BackBtn.Location = new System.Drawing.Point(16, 12);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(74, 37);
            this.BackBtn.TabIndex = 3;
            this.BackBtn.Text = "Geri";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // CategoryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(324, 315);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.CategoryNameAddBtn);
            this.Controls.Add(this.CategoryNameLbl);
            this.Controls.Add(this.CategoryNameTxt);
            this.Name = "CategoryFrm";
            this.Text = "Kategori Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CategoryNameTxt;
        private System.Windows.Forms.Label CategoryNameLbl;
        private System.Windows.Forms.Button CategoryNameAddBtn;
        private System.Windows.Forms.Button BackBtn;
    }
}