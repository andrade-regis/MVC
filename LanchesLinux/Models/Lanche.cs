using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesLinux.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key] public int LancheId { get; set; }

        [Required(ErrorMessage = "Obrigatório informar nome do lanche!")]
        [StringLength(50, ErrorMessage = "Tamanho máximo é 50 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar descrição do lanche!")]
        [StringLength(255, ErrorMessage = "Tamanho máximo é 255 caracteres")]
        [Display(Name = "Descrição")]
        public string DescriçãoCurta { get; set; }

        [Display(Name = "Descrição Completa")]
        [StringLength (255, ErrorMessage = "Tamanho máximo é 255 caracteres")] 
        public string DescriçãoDetalhada { get; set; }

        [Required(ErrorMessage = "Obrigatório informar preço do lanche!")]
        [Column(TypeName ="decimal(10,2)")]
        [Range(1,999.99, ErrorMessage = "Valor informado fora do limite estabelecido!")]
        public decimal Preço { get; set; }

        [Required(ErrorMessage = "Obrigatório informar imagem do lanche!")]
        [Display(Name = "Imagem")]
        public string ImagemUrl { get; set; }

        [Required(ErrorMessage = "Obrigatório informar thumbnail do lanche!")]
        [Display(Name = "Thumbnail")]
        public string ImagemThumbnailUrl { get; set; }

        [Required(ErrorMessage = "Obrigatório informar se o lanche é preferido!")]
        [Display(Name = "Preferido?")]
        public bool IsLanchePreferido{ get; set; }

        [Required(ErrorMessage = "Obrigatório informar se o lanche tem estoque!")]
        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }

        [Required(ErrorMessage = "Obrigatório informar categoria do lanche!")]
        [ForeignKey("Categoria")]
        [Display(Name = "Categoria")]
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
