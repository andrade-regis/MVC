namespace LanchesLinux.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        
        public string Nome{ get; set; }
        
        public string Descrição{ get; set; }

        public List<Lanche> Lanches { get; set;}
    }
}
