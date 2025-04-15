using System.ComponentModel.DataAnnotations;

namespace APIEscola.Models
{
    public class Turma
    {
        public Guid TurmaId { get; set; } // Identificador único da turma

        [Required(ErrorMessage = "O Campo Sigla é Obrigatório")] // Campo Obrigatório
        [MaxLength(10, ErrorMessage = "A Sigla deve ter no máximo 10 caracteres")] // Máximo de 10 caracteres
        public string? Sigla { get; set; }

        [Required(ErrorMessage = "O Campo Descrição é Obrigatório")] // Campo Obrigatório
        [MaxLength(255, ErrorMessage = "A Descrição deve ter no máximo 255 caracteres")] // Máximo de 255 caracteres
        public string? Descricao { get; set; }

        [Required(ErrorMessage = "O Campo Data Final é Obrigatório")]
        [StringLength(11, ErrorMessage = "O campo Data Final Deve ter 11 dígitos")]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "O Campo Data Final deve conter apenas números")]
        public DateOnly DataFim { get; set; } // Ano da turma

        [Required(ErrorMessage = "O Campo Data inicio é Obrigatório")]
        [StringLength(11, ErrorMessage = "O campo Data inicio Deve ter 11 dígitos")]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "O Campo Data Inicio deve conter apenas números")]
        public DateOnly DataInicio { get; set; } // Semestre da turma

        [Required(ErrorMessage = "O Campo Curso é Obrigatório")] // Campo Obrigatório
        public Guid CursoId { get; set; } // Identificador do curso associado à turma

        public Curso? Curso { get; set; } // Navegação para o curso associado à turma
    }
}