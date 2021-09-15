using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudCategoria.Shared
{
    public class Categoria
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome é obrigatório")]
        [MinLength(3, ErrorMessage = "O campo deve conter no mínimo 3 caracteres")]
        [StringLength(255, ErrorMessage = "O campo deve conter no máximo 255 caracteres")]
        public string Nome { get; set; }
    }
}
