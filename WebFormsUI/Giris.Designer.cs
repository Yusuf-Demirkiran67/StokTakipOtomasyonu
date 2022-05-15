
namespace WebFormsUI
{
    partial class Giris
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
            this.label1 = new System.Windows.Forms.Label();
            this.SifreLbl = new System.Windows.Forms.Label();
            this.KullaniciAdiLbl = new System.Windows.Forms.Label();
            this.KullaniciAdiTxt = new System.Windows.Forms.TextBox();
            this.SifreTxt = new System.Windows.Forms.TextBox();
            this.GstrCheckBox = new System.Windows.Forms.CheckBox();
            this.GirisBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(117, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stok Takip Programı";
            // 
            // SifreLbl
            // 
            this.SifreLbl.AutoSize = true;
            this.SifreLbl.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.SifreLbl.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SifreLbl.Location = new System.Drawing.Point(30, 229);
            this.SifreLbl.Name = "SifreLbl";
            this.SifreLbl.Size = new System.Drawing.Size(57, 25);
            this.SifreLbl.TabIndex = 1;
            this.SifreLbl.Text = "Şifre:";
            // 
            // KullaniciAdiLbl
            // 
            this.KullaniciAdiLbl.AutoSize = true;
            this.KullaniciAdiLbl.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.KullaniciAdiLbl.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KullaniciAdiLbl.Location = new System.Drawing.Point(30, 137);
            this.KullaniciAdiLbl.Name = "KullaniciAdiLbl";
            this.KullaniciAdiLbl.Size = new System.Drawing.Size(125, 25);
            this.KullaniciAdiLbl.TabIndex = 2;
            this.KullaniciAdiLbl.Text = "Kullanıcı Adı:";
            // 
            // KullaniciAdiTxt
            // 
            this.KullaniciAdiTxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KullaniciAdiTxt.Location = new System.Drawing.Point(203, 136);
            this.KullaniciAdiTxt.Name = "KullaniciAdiTxt";
            this.KullaniciAdiTxt.Size = new System.Drawing.Size(171, 26);
            this.KullaniciAdiTxt.TabIndex = 3;
            // 
            // SifreTxt
            // 
            this.SifreTxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SifreTxt.Location = new System.Drawing.Point(203, 228);
            this.SifreTxt.Name = "SifreTxt";
            this.SifreTxt.Size = new System.Drawing.Size(171, 26);
            this.SifreTxt.TabIndex = 4;
            this.SifreTxt.UseSystemPasswordChar = true;
            // 
            // GstrCheckBox
            // 
            this.GstrCheckBox.AutoSize = true;
            this.GstrCheckBox.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.GstrCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GstrCheckBox.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GstrCheckBox.Location = new System.Drawing.Point(441, 232);
            this.GstrCheckBox.Name = "GstrCheckBox";
            this.GstrCheckBox.Size = new System.Drawing.Size(69, 24);
            this.GstrCheckBox.TabIndex = 5;
            this.GstrCheckBox.Text = "Göster";
            this.GstrCheckBox.UseVisualStyleBackColor = false;
            this.GstrCheckBox.CheckedChanged += new System.EventHandler(this.GstrCheckBox_CheckedChanged);
            // 
            // GirisBtn
            // 
            this.GirisBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GirisBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GirisBtn.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GirisBtn.Location = new System.Drawing.Point(203, 317);
            this.GirisBtn.Name = "GirisBtn";
            this.GirisBtn.Size = new System.Drawing.Size(171, 79);
            this.GirisBtn.TabIndex = 6;
            this.GirisBtn.Text = "Giriş";
            this.GirisBtn.UseVisualStyleBackColor = false;
            this.GirisBtn.Click += new System.EventHandler(this.GirisBtn_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(566, 465);
            this.Controls.Add(this.GirisBtn);
            this.Controls.Add(this.GstrCheckBox);
            this.Controls.Add(this.SifreTxt);
            this.Controls.Add(this.KullaniciAdiTxt);
            this.Controls.Add(this.KullaniciAdiLbl);
            this.Controls.Add(this.SifreLbl);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Giris";
            this.Text = "Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SifreLbl;
        private System.Windows.Forms.Label KullaniciAdiLbl;
        private System.Windows.Forms.TextBox KullaniciAdiTxt;
        private System.Windows.Forms.TextBox SifreTxt;
        private System.Windows.Forms.CheckBox GstrCheckBox;
        private System.Windows.Forms.Button GirisBtn;
    }
}

