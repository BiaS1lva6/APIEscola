using System.ComponentModel.DataAnnotations;

namespace APIEscola.Models
{
    public class Matricula
    {
        public Guid MatriculaId { get; set; } // Identificador único da matrícula

        [Required(ErrorMessage = "O Campo Aluno é Obrigatório")] // Campo Obrigatório
        public Guid AlunoId { get; set; } // Identificador do aluno associado à matrícula


        [Required(ErrorMessage = "O Campo Turma é Obrigatório")] // Campo Obrigatório
        public Guid TurmaId { get; set; } // Identificador da turma associada à matrícula

        public Aluno? Aluno { get; set; } // Navegação para o aluno associado à matrícula
        public Turma? Turma { get; set; } // Navegação para a turma associada à matrícula

        [Required(ErrorMessage = "O Campo Data de Matricula é Obrigatório")]
        [DataType(DataType.Date, ErrorMessage = "O Formato da Data não é Valido.")]
        public DateTime DataMatricula { get; set; } = DateTime.Now;
    }
}
