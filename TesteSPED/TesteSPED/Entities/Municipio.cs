using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TesteSPED.Entities
{
    [Table("Municipios")]
    public class Municipio
    {
        [Key,Required,Column("COD_MUNICIPIO",Order =1)]
        public Int64 MunicipioId { get; set; }

        [Required,Column("NOME_MUNICIPIO",Order =2)]
        public string Nome { get; set; }

        [Required,Column("COD_ESTADO",Order =3)]
        public int EstadoId { get; set; }

        [ForeignKey("EstadoId")]
        public virtual Estado Estado { get; set; }





    }
}