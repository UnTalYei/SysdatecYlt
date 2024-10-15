using FluentValidation;
using Sysdatec.PruebaTecnica.Application.Database.User.Commands.CreateUser;

namespace TarkerYlt.Booking.Application.Validators.User
{
    public class CreateUserValidator : AbstractValidator<CreateUserModel>
    {
        public CreateUserValidator()
        {
            RuleFor(x => x.UserId).GreaterThan(0).WithMessage("El Id del usuario debe ser mayor a cero.");
            RuleFor(x => x.FirstName).Length(3, int.MaxValue).WithMessage("Por favor ingrese mínimo 3 caracteres.");
            RuleFor(x => x.LastName).NotNull().NotEmpty().MaximumLength(50);
            RuleFor(x => x.UserName).NotNull().NotEmpty().MaximumLength(50);
            RuleFor(x => x.Email).EmailAddress().WithMessage("Por favor, ingrese una dirección de correo electrónico válida.");
        }
    }
}
