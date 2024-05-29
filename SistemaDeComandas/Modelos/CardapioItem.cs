using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaDeComandas.Modelos
{
    public class CardapioItem
    {
        //Key = Chave primaria da tabela
        //DatabaseGenerated = Valor gerado da coluna sera realizado pelo DB
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public bool PossuiPreparo { get; set; }
    }
}
