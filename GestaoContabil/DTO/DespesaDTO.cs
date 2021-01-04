
using System.ComponentModel.DataAnnotations;

namespace GestaoContabil.DTO
{
    public class DespesaDTO : BaseDTO
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool Pago { get; set; }

    }
}
