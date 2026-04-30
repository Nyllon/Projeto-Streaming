namespace SistemaFilmes
{
    public class Categoria
    {
        // Encapsulamento: get público e sem set para definir apenas no construtor
        public string Nome { get; }

        public Categoria(string nome)
        {
            Nome = nome;
        }
    }
}