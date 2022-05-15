using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebFormsUI
{
    public partial class Giris : Form
    {
       
        public Giris()
        {
            InitializeComponent();
        }
        
        private void GirisBtn_Click(object sender, EventArgs e)
        {
            if (KullaniciAdiTxt.Text.ToUpper() == "ADMİN" && SifreTxt.Text == "1234")
            {
                Anasayfa anasayfa = new Anasayfa();
                anasayfa.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Hatalı giriş yaptınız !!!");
            }
        }

        private void GstrCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (GstrCheckBox.CheckState==CheckState.Checked)
            {
                SifreTxt.UseSystemPasswordChar = false;

            }
            else 
            {
                SifreTxt.UseSystemPasswordChar = true;
            }
        }
    }
}
