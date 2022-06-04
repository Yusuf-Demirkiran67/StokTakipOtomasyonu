using Business.Abstract;
using Business.Utilities;
using Business.ValidationRules.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
             ValidationTool.Validate(new CategoryValidator(), category);
             
            if (CategoryRepaet(category.CategoryName))
            {
               
                _categoryDal.Add(category);
            }
            else
            {
                throw new Exception("Bu kategori zaten sistemde var ");
            }
           
            

            
           
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public bool CategoryRepaet(string categoryName)
        {
            if (_categoryDal.Get(p => p.CategoryName.ToLower().Contains(categoryName.ToLower()))==null)
            {
                return true;
               
            }
            else
            {
                return false;
            }
        }
    }
}
