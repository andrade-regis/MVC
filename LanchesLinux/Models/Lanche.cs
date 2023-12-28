namespace LanchesLinux.Models
{
    public class Lanche
    {
        public int LancheId { get; set; }

        public string Nome { get; set; }
        
        public string DescriçãoCurta { get; set; }
        
        public string DescriçãoDetalhada { get; set; }
        
        public decimal Preço { get; set; }
        
        public string ImagemUrl { get; set; }
        
        public string ImagemThumbnailUrl { get; set; }
        
        public bool IsLanchePreferido{ get; set; }
        
        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
