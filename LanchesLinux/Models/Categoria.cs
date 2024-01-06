using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesLinux.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key] public int CategoriaId { get; set; }

        [StringLength(100,ErrorMessage = "Tamanho máximo é 100 caracteres")]
        [Required(ErrorMessage = "Obrigatório informar nome da categoria")]
        public string Nome{ get; set; }

        [Required(ErrorMessage = "Obrigatório informar descrição da categoria")]
        [StringLength(200, ErrorMessage = "Tamanho máximo é 200 caracteres")]
        public string Descrição{ get; set; }

        public List<Lanche> Lanches { get; set;}
    }
}
