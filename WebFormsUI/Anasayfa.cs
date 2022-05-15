using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using MessagingToolkit.QRCode.Codec;
using System;
using System.Windows.Forms;

namespace WebFormsUI
{
    public partial class Anasayfa : Form
    {

        Guncelle guncelle = null;
           
        public Anasayfa()
        {
            guncelle = new Guncelle(this);
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();

        }

        private void EkleBtn_Click(object sender, EventArgs e)
        {
            Ekle ekle = new Ekle();
            ekle.Show();
            this.Hide();
        }

        private void GuncelleBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lütfen güncellemek istediğiniz satırı seçin");

        }


        private void CikisBtn_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }

         IProductService _productService;
         ICategoryService _categoryService;

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();

        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productService.GetAll();
        }
        private void LoadCategories()
        {

            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";


            guncelle.cbxCategoryIdUpdate.DataSource = _categoryService.GetAll();
            guncelle.cbxCategoryIdUpdate.DisplayMember = "CategoryName";
            guncelle.cbxCategoryIdUpdate.ValueMember = "CategoryId";

        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProducts.DataSource =
              _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch
            {

                Console.WriteLine("Categori Hatası");
            }

        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtProductName.Text))
            {
                LoadProducts();
            }
            else
            {
                dgwProducts.DataSource = _productService.GetProductsByProductName(txtProductName.Text);
            }
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            var row = dgwProducts.CurrentRow;
            guncelle.tbxProductNameUpdate.Text = row.Cells[1].Value.ToString();
            guncelle.cbxCategoryIdUpdate.SelectedValue = row.Cells[2].Value;
            guncelle.tbxUnitPriceUpdate.Text = row.Cells[3].Value.ToString();
            guncelle.tbxQuantityUpdate.Text = row.Cells[4].Value.ToString();
            guncelle.tbxStockAmountUpdate.Text = row.Cells[5].Value.ToString();
            guncelle.Show();
            this.Hide();
            String QrMetin = "Ürün adı:" + guncelle.tbxProductNameUpdate.Text + "  ," + "Birim adedi:" +guncelle.tbxQuantityUpdate.Text + "  ," +
                  "Stok adedi" +guncelle.tbxStockAmountUpdate.Text + "   ,                                                                "
                  + "Birim Fiyatı:" +guncelle.tbxUnitPriceUpdate.Text;
            QRCodeEncoder encoder = new QRCodeEncoder();
           guncelle.pbxQR.Image = encoder.Encode(QrMetin);
            guncelle.RtbxOR.Clear();

        }

        private void SilBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lütfen silmek istediğiniz satırı seçin");
        }

        private void Anasayfa_Activated(object sender, EventArgs e)
        {
            LoadProducts();
        }
    }
}
