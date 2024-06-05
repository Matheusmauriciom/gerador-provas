using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Concurso.Models;

namespace Concurso.Services
{
     public class RespostasService
    {
        private readonly ILogger<RespostasService> _logger;
        private List<QuestaoComResposta> QuestoesRespostasUsuario { get; } = new List<QuestaoComResposta>();

        public RespostasService(ILogger<RespostasService> logger)
        {
            _logger = logger;
        }

        public void AdicionarResposta(QuestaoComResposta resposta)
        {
            QuestoesRespostasUsuario.Add(resposta);
            _logger.LogInformation($"Resposta adicionada para a Questão {resposta.Questao.Id}");
            _logger.LogInformation($"Quantidade de respostas no RespostasService: {QuestoesRespostasUsuario.Count}");
        }

        public List<QuestaoComResposta> ObterRespostas()
        {   
            return QuestoesRespostasUsuario;
        }

        public void Reiniciar()
        {
            QuestoesRespostasUsuario.Clear();
            _logger.LogInformation("Respostas do serviço reiniciadas.");
        }
    }
}
