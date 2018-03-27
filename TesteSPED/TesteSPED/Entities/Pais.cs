using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TesteSPED.Entities
{
    [Table("PAIS_IBGE")]
    public class Pais
    {
        [Key,Column("COD_PAIS", Order =1)]
        public string PaisId { get; set; }

        [Required,Column("NOME_PAIS",Order =2)]
        public string NomePais { get; set; }

        public virtual IList<Participante> Participantes { get; set; }
    }
}