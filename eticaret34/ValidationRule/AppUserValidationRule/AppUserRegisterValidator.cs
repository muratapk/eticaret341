using eticaret34.Dto.AppUserDto;
using FluentValidation;

namespace eticaret34.ValidationRule.AppUserValidationRule
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("Bu Alanı Boş Geçemezsiniz");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Bu Alanı Boş Geçemezsiniz");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Bu Alanı Boş Geçemezsiniz");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Bu Alanı Boş Geçemezsiniz");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Bu Alanı Boş Geçemezsiniz");
        }
    }
}
