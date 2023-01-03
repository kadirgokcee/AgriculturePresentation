using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class TeamValidator : AbstractValidator<Team>
    {
        public TeamValidator()
        {
            RuleFor(x => x.PersonName).NotEmpty().WithMessage("Takım arkadaşı kısmını boş geçemezsiniz");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Görev kısmını boş geçemezsiniz");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Görsel yolu boş geçemezsiniz");
            RuleFor(x => x.PersonName).MaximumLength(50).WithMessage("Lütfen 50 karakterden az veri girişi yapın");
            RuleFor(x => x.PersonName).MinimumLength(4).WithMessage("Lütfen 4 karakterden fazla veri girişi yapın");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Lütfen 50 karakterden az veri girişi yapın");
            RuleFor(x => x.Title).MinimumLength(3).WithMessage("Lütfen 3 karakterden fazla veri girişi yapın");
     
        }
    }
}
