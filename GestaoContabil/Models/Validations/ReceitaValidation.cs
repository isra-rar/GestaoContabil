using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoContabil.Models.Validations
{
    public class ReceitaValidation : AbstractValidator<Receita>
    {
        public ReceitaValidation()
        {
            RuleFor(f => f.Descricao)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(6, 100)
                .WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(f => f.Valor)
                .NotNull().WithMessage("O campo {PropertyName} precisa ser fornecido");

            RuleFor(f => f.Data)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");

            RuleFor(f => f.Recebido)
                .NotNull()
                .WithMessage("O campo {PropertyName} precisa ser fornecido");

        }
       
    }
}
