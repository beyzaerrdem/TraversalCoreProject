using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator:AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x=>x.Description).NotEmpty().WithMessage("Açıklamayı boş bırakmayınız.");

            RuleFor(x => x.Description).MinimumLength(50).WithMessage("En az 50 karakter girmelisiniz.");

            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık giriniz.");


        }
    }
}
