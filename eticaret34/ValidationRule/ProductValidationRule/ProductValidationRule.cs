using eticaret34.Models;
using FluentValidation;

namespace eticaret34.ValidationRule.ProductValidationRule
{
    public class ProductValidationRule : AbstractValidator<Product>
    {
        public ProductValidationRule()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Bu Alanı Boş Geçemezsiniz");
            RuleFor(x => x.ProductCode).NotEmpty().WithMessage("Bu Alanı Boş Geçemezsiniz");
            RuleFor(x => x.ProductDescription).NotEmpty().WithMessage("Bu Alanı Boş Geçemezsiniz");
            RuleFor(x => x.ProductPrice).NotEmpty().WithMessage("Bu Alanı Boş Geçemezsiniz");
            RuleFor(x => x.ResimYukle).NotEmpty().WithMessage("Bu Alanı Boş Geçemezsiniz");
        }
    }
}
