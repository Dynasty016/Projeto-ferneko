namespace Projeto_ferneko_2.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Produto(string nome)
        {
            Nome = nome;
        }

        public decimal Preco { get; set; }
    }
}
