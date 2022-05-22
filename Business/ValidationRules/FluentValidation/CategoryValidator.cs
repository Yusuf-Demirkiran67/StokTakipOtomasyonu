using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CategoryValidator: AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(p => p.CategoryName).NotEmpty().WithMessage( "Bu alan boş geçilemez");
            RuleFor(p => p.CategoryName).Must(CategoryRepaet);
            
        }

        private bool CategoryRepaet(string arg)
        {
            return true;
            
        }
    }
}
