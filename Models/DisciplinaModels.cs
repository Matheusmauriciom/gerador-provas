using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.ComponentModel;


namespace Concurso.Models
{
   
     [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DisciplinaModels
    {   
        [Description("Português")]
        Português,

        [Description("Matemática")]
        Matemática,

        [Description("Conhecimento Específicos")]
        ConhecimentoEspecíficos,

        [Description("Direito Administrativo")]
        DireitoAdministrativo,

        [Description("Direito Constitucional")]
        DireitoConstitucional,

        [Description("Noções de Ética no Serviço Publico")]
        Ética,

        [Description("Noções de informática")]
        Informática,

        [Description("Legislação")]
        Legislação,

        [Description("Raciocinio logico")]
        RaciocinioLógico,

        [Description("Ingles Técnico")]
        Inglês
    }
}