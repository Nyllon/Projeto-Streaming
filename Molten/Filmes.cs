namespace SistemaFilmes
{
    public class Filme
    {
        public string Titulo { get; }
        public int Duracao { get; }
        public Categoria Genero { get; }
        public int Avaliacao { get; }
        public int AnoLancamento { get; }

        // Construtor obrigatório
        public Filme(string titulo, int duracao, Categoria genero, int avaliacao, int anolancamento)
        {
            Titulo = titulo;
            Duracao = duracao;
            Genero = genero;
            Avaliacao = avaliacao;
            AnoLancamento = anolancamento;
        }

        public void Exibir()
        {
            Console.WriteLine($"Filme: [{Titulo}] | Duracao: [{Duracao}] min | Genero: [{Genero.Nome}] | Avaliacao: [{Avaliacao}] | AnoLancamento: [{AnoLancamento}]");
        }
    }
}