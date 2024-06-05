using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Concurso.Models
{
    public class QuestaoComResposta
    {
           [Key]
        public int QuestaoComRespostaId { get; set; }
        
        public int QuestaoId { get; set; }
        public Questao Questao { get; set; } = null!;
        public string RespostaUsuario { get; set; } =string.Empty;
        public int AlternativaId { get; set; }
        public Alternativa AlternativaEscolhida { get; set; } = null!;
        
        public bool RespostaCorreta { get; set; }     
    }
}