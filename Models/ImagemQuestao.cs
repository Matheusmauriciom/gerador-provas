using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Concurso.Models
{
 public class ImagemQuestao
    {
    [Key]
    public int Id { get; set; }
    public byte[] Imagem { get; set; }
    public int QuestaoId { get; set; }
    public Questao Questao { get; set; }
    }
}