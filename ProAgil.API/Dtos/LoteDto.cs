using System.ComponentModel.DataAnnotations;

namespace ProAgil.API.Dtos
{
    public class LoteDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        public decimal Preco { get; set; }
        public string DataInicio { get; set; }
        public string DataFim { get; set; }

        [Range(2, 120000, ErrorMessage = "{0} deve ser entre 2 e 120000")]
        public int Quantidade { get; set; }
    }
}