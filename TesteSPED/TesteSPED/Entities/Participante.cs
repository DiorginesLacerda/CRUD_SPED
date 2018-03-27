using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TesteSPED.Entities
{
    [Table("Participante")]
    public class Participante
    {
        [Required, MaxLength(4),Column("REG", Order =1)]
        public string Reg { get { return "0150"; } }

        [Required,MaxLength(60),Column("COD_PART", Order =2),Key]
        public string CodPart { get; set; }

        [Required,MaxLength(100),Column("NOME",Order =3)]
        public string Nome { get; set; }

        [Required,MaxLength(5),Column("COD_PAIS",Order =4)]
        public string PaisId { get; set; }
        [ForeignKey("PaisId")]
        public virtual Pais Pais { get; set; }

        [StringLength(14), Column("CNPJ",Order =5)]
        public string Cnpj { get; set; }

        [StringLength(11), Column("CPF", Order = 6)]
        public string Cpf { get; set; }

        [MaxLength(14),Column("IE",Order =7)]
        public string IE { get; set; }

        [StringLength(7),Column("COD_MUN",Order =8)]
        public string MunicipioId { get; set; }

        [StringLength(9),Column("SUFRAMA", Order =9)]
        public string Suframa { get; set; }

        [Required,MaxLength(60),Column("END",Order =10)]
        public string Endereco { get; set; }

        [MaxLength(10),Column("NUM",Order =11)]
        public string Numero { get; set; }

        [MaxLength(60),Column("COMPL",Order =12)]
        public string Complemento { get; set; }

        [MaxLength(60),Column("BAIRRO",Order =13)]
        public string Bairro { get; set; }

        
    }
}