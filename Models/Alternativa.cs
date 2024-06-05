using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Concurso.Models
{
public class Alternativa
{
    [Key]
    public int Id { get; set; }

    public string Descricao { get; set; } =string.Empty;
    public bool Correta { get; set; }
    public int QuestaoId { get; set; }
    public Questao Questao { get; set; } = null!;
}
}