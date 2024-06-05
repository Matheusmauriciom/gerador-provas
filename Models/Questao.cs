using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Concurso.Models
{
    public class Questao
    {
        [Key]
        public int Id { get; set; }
        public int DisciplinaId { get; set; }
        public DisciplinaModels Disciplina { get; set; }

        [Required(ErrorMessage ="Informe o tópico")]
        public string Topico { get; set; } = string.Empty;
        public string Enunciado { get; set; } = string.Empty;
        public List<Alternativa> Alternativas { get; set; } = new List<Alternativa>();
        public string Fonte { get; set; } = string.Empty;
        public string CaminhoImagem { get; set; } = string.Empty;

        public List<ImagemQuestao> Imagens { get; set; } = new List<ImagemQuestao>();

    }
}