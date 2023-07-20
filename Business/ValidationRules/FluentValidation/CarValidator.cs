using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(x => x.Description).NotEmpty();
            RuleFor(x => x.Description).MinimumLength(2);
            RuleFor(x => x.Description).MaximumLength(20);

            RuleFor(x => x.DailyPrice).GreaterThan(0);
        }
    }
}
