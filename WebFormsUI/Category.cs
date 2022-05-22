using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Entities.Concrete;
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
    public partial class CategoryFrm : Form
    {
        public CategoryFrm()
        {
            InitializeComponent();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }

        ICategoryService _categoryService;
        private void CategoryNameAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
               _categoryService.Add(new Category { 
                CategoryName=CategoryNameTxt.Text
            
            });
            MessageBox.Show("Kategori eklendi");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
           
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }
    }
}
