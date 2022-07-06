using desafioKw.Enum;
using System.ComponentModel.DataAnnotations;

namespace desafioKw.Models
{
    public class Cartao
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public SituacaoCardEnum Situacao { get; set; }
        [Required(ErrorMessage = "O campo de titulo é obrigatório")]
        [StringLength(100, ErrorMessage = "O título não pode exceder 100 caracteres")]
        public string TituloCard { get; set; }
        [Required(ErrorMessage = "O campo de projeto é obrigatório")]
        public string Projeto { get; set; }
        [Required(ErrorMessage = "O campo de data previsão é obrigatório")]
        public DateTime DataPrevisao { get; set; }
        [Required(ErrorMessage = "O campo de descricao é obrigatório")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "O campo de equipe é obrigatório")]
        public TimeEnum Equipe { get; set; }
        [Required(ErrorMessage = "O campo de fase é obrigatório")]
        public FaseEnum Fase { get; set; }
        [Required(ErrorMessage = "A posição vertical é obrigatória")]
        public int posicaoVertical { get; set; }
        [Required(ErrorMessage = "O posicao horizontal é obrigatória")]
        public int posicaoHorizontal { get; set; }

    }
}
