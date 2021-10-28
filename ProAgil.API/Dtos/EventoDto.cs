using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProAgil.API.Dtos
{
    public class EventoDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "{0} precisa ter entre 3 e 100 caracteres")]
        public string Local { get; set; }
        public string DataEvento { get; set; }

        [Required (ErrorMessage = "{0} é obrigatório")]
        public string Tema { get; set; }

        [Display(Name = "Quantidade de Pessoas")]
        [Range(2, 120000, ErrorMessage = "{0} deve ser entre 2 e 120000")]
        public int QtdPessoas { get; set; }
        public string ImagemURL { get; set; }

        [Phone]
        public string Telefone { get; set; }

        [EmailAddress(ErrorMessage = "{0} inválido")]
        public string Email { get; set; }
        public List<LoteDto> Lotes { get; set; }
        public List<RedeSocialDto> RedeSociais { get; set; }
        public List<PalestranteDto> Palestrantes { get; set; }
    }
}