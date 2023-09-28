using eticaret34.Models;
using FluentValidation;

namespace eticaret34.ValidationRule.CategoryValidationRule
{
    public class CategoryValidationRule:AbstractValidator<Category>
    {
        public CategoryValidationRule()
        {
            RuleFor(x=>x.CategoryName).NotEmpty().WithMessage("Bu Alanı Boş Geçmezsiniz");
        }
    }
}
