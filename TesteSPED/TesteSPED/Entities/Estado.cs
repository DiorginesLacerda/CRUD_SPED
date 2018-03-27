using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TesteSPED.Entities
{
    [Table("ESTADOS_IBGE")]
    public class Estado
    {
        [Key,Column("COD_ESTADO",Order =1)]
        public int EstadoId { get; set; }

        [Required,StringLength(2),Column("SIGLA_ESTADO")]
        public string Sigla { get; set; }

        public virtual IList<Municipio> Municipios { get; set; }
    }
}