using Covid19.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19.Validations
{
    public class PacienteValidator : AbstractValidator<Paciente>
    {
        public PacienteValidator()
        {
            RuleFor(p => p.nome).NotEmpty().WithMessage("Nome do paciente é Obrigatário !")
                                         .NotNull().WithMessage("Nome do paciente é obrigatório")
                                         .MinimumLength(3).WithMessage("Nome pode ter no mínino 3 caracteres")
                                         .MaximumLength(40).WithMessage("Nome pode ter no máximo 40 caracteres");
            RuleFor(p => p.cidade).NotEmpty().WithMessage("Digite a cidade !");
            RuleFor(p => p.DataRegistro).NotEmpty().WithMessage("Digite a data de registro");
            RuleFor(p => p.estado).NotEmpty().WithMessage("Digite o estado");
            RuleFor(p => p.estado_civil).NotEmpty().WithMessage("Estado civil");
            RuleFor(p => p.flComorbidade).NotEmpty().WithMessage("Possui Comorbidade");
            RuleFor(p => p.id).NotEmpty().WithMessage("Digite Id");
            RuleFor(p => p.sexo).NotEmpty().WithMessage("Sexo");

        }
    }
}
