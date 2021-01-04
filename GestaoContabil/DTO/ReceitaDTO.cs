
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoContabil.DTO
{
    public class ReceitaDTO : BaseDTO
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool Recebido { get; set; }
    }
}
