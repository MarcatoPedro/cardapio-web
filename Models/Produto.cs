using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardapioWeb.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name ="Nome do Produto")]
        [StringLength(100, ErrorMessage = "Limite de até {0} de caracteres ")]
        public string Nome { get; set; }

        [Display(Name = "Discrição curta do Produto")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Descricao_curta { get; set; }

        [Display(Name = "Discrição detalhada do Produto")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Descricao_detalhada { get; set; }

        [Display(Name = "Preço do Produto")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public decimal Preco { get; set; }

        [Display(Name = "Produto preferido")]
        public bool Produto_Preferido { get; set; }

        [Display(Name = "Produto em estoque")]
        public bool Em_Estoque { get; set; }

        public virtual Categoria Categoria { get; set; }
    }
}
