using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Entities.Concrete;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WebFormsUI
{
    public partial class Ekle : Form
    {

        public Ekle()
        {

            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();

        }
        //Anasayfa anasayfa1 = (Anasayfa)Application.OpenForms["Anasayfa"];
        private void Ekle_Load(object sender, EventArgs e)
        {
            LoadCategory();
        }

        private void LoadCategory()
        {

            cbxCategoryId.DataSource = _categoryService.GetAll();
            cbxCategoryId.DisplayMember = "CategoryName";
            cbxCategoryId.ValueMember = "CategoryId";


        }

        private void GeriBtn_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }
        IProductService _productService;
        ICategoryService _categoryService;
        private void EkleButon_Click(object sender, EventArgs e)
        {

            try
            {
                _productService.Add(new Product
                {
                    CategoryId = Convert.ToInt32(cbxCategoryId.SelectedValue),
                    ProductName = tbxProductName.Text,
                    QuantityPerUnit = tbxQuantity.Text,
                    UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                    UnitsInStock = Convert.ToInt16(tbxStockAmount.Text)
                });

                String QrMetin = "Ürün adı:" + tbxProductName.Text + "  ," + "Birim adedi:" + tbxQuantity.Text + "  ," +
                    "Stok adedi" + tbxStockAmount.Text + "    ,                     " + "Birim Fiyatı:" + tbxUnitPrice.Text;
                QRCodeEncoder encoder = new QRCodeEncoder();
                pbxQr.Image = encoder.Encode(QrMetin);
                MessageBox.Show("Ürün Kaydedildi !");
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }

        private void Qrcoz_Click(object sender, EventArgs e)
        {
            QRCodeDecoder decoder = new QRCodeDecoder();
            rtbxQr.Text = (decoder.Decode(new QRCodeBitmapImage(pbxQr.Image as Bitmap)));
        }

        private void pbxQr_Click(object sender, EventArgs e)
        {

        }
    }
}
