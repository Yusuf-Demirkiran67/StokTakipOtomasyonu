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
    public partial class Guncelle : Form
    {
        Anasayfa anasayfa = null;
        // Anasayfa anasayfa = new Anasayfa();
        public Guncelle(Anasayfa anasayfa)
        {
            this.anasayfa = anasayfa;
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();

        }

        //Anasayfa anasayfa= (Anasayfa)Application.OpenForms["Anasayfa"];
         IProductService _productService;
       ICategoryService _categoryService;

        private void GuncelleButon_Click(object sender, EventArgs e)
        {
            
            try
            {
                _productService.Update(new Product
                {
                    ProductId = Convert.ToInt32(anasayfa.dgwProducts.CurrentRow.Cells[0].Value),
                    CategoryId = Convert.ToInt32(cbxCategoryIdUpdate.SelectedValue),
                    ProductName = tbxProductNameUpdate.Text,
                    QuantityPerUnit = tbxQuantityUpdate.Text,
                    UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                    UnitsInStock = Convert.ToInt16(tbxStockAmountUpdate.Text)
                });
                

                MessageBox.Show("Ürün Güncellendi !");
                String QrMetin = "Ürün adı:" + tbxProductNameUpdate.Text + "  ," + "Birim adedi:" + tbxQuantityUpdate.Text + "  ," +
                  "Stok adedi" + tbxStockAmountUpdate.Text + "   ,                                                                "
                  + "Birim Fiyatı:" + tbxUnitPriceUpdate.Text;
                QRCodeEncoder encoder = new QRCodeEncoder();
                pbxQR.Image = encoder.Encode(QrMetin);
                RtbxOR.Clear();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

            }
        }

        private void GeriBtn_Click(object sender, EventArgs e)
        {
           
            anasayfa.Show();
            this.Hide();
        }

        private void Guncelle_Load(object sender, EventArgs e)
        {
            
            //LoadProducts();
        }

        private void LoadProducts()
        {
           
            //anasayfa.dgwProducts.DataSource = _productService.GetAll();
        }

        private void QRKodCoz_Click(object sender, EventArgs e)
        {
            QRCodeDecoder decoder = new QRCodeDecoder();
            RtbxOR.Text = (decoder.Decode(new QRCodeBitmapImage(pbxQR.Image as Bitmap)));
        }

        private void SilButon_Click(object sender, EventArgs e)
        {
            
            if (anasayfa.dgwProducts.CurrentRow != null)
            {
                try
                {
                    _productService.Delete(new Product
                    {
                        ProductId = Convert.ToInt32(anasayfa.dgwProducts.CurrentRow.Cells[0].Value)
                    });
                    MessageBox.Show("Ürün silindi");
                    LoadProducts();
                }
                catch (Exception exception)
                {

                    MessageBox.Show(exception.Message);
                }

            }


        }

        private void cbxCategoryIdUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
