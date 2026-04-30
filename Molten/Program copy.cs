using System;
using SistemaFilmes;

class Program
{
    static void Main(string[] args)
    {
        // 1. Categorias
        Categoria Acao = new Categoria("Ação");
        Categoria Drama = new Categoria("Drama");
        Categoria Comedia = new Categoria("Comédia");
        Categoria FiccaoCientifica = new Categoria("Ficção Científica");
        Categoria Terror = new Categoria("Terror");
        Categoria Aventura = new Categoria("Aventura");
        Categoria Documentario = new Categoria("Documentário");
        Categoria Animacao = new Categoria("Animação");
        Categoria Suspense = new Categoria("Suspense");
        Categoria Fantasia = new Categoria("Fantasia");
        Categoria Romance = new Categoria("Romance");

        // 2. Filmes (Adicionados Avaliação de 0-10 e Ano de Lançamento)
        Filme filme1 = new Filme("Vingadores Ultimato", 181, Acao, 9, 2019);
        Filme filme2 = new Filme("Crepúsculo", 127, Drama, 5, 2008);
        Filme filme3 = new Filme("The Batman", 176, Acao, 8, 2022);
        Filme filme4 = new Filme("Golpe Baixo", 113, Comedia, 7, 2005);
        Filme filme5 = new Filme("Star Wars: IV - Uma Nova Esperança", 121, FiccaoCientifica, 10, 1977);
        Filme filme6 = new Filme("Meu namorado é um Zumbi", 98, Romance, 6, 2013);
        Filme filme7 = new Filme("Jumanji: Bem Vindo à Selva", 119, Aventura, 7, 2017);
        Filme filme8 = new Filme("Pânico 7", 114, Terror, 6, 2026); 
        Filme filme9 = new Filme("Apollo 11", 93, Documentario, 9, 2019);
        Filme filme10 = new Filme("Um lugar Silencioso", 90, Suspense, 8, 2018);
        Filme filme11 = new Filme("Gato de Botas 2: O Último Pedido", 102, Animacao, 10, 2022);
        Filme filme12 = new Filme("Toy Story 2", 92, Animacao, 9, 1999);
        Filme filme13 = new Filme("Harry Potter e a Pedra Filosofal", 152, Fantasia, 9, 2001);
        Filme filme14 = new Filme("Shrek 2", 93, Animacao, 10, 2004);

        // 3. Exibição
        Console.WriteLine("----------------------------------- LISTA DE FILMES -----------------------------------");
        filme1.Exibir();
        filme2.Exibir();
        filme3.Exibir();
        filme4.Exibir();
        filme5.Exibir();
        filme6.Exibir();
        filme7.Exibir();
        filme8.Exibir();
        filme9.Exibir();
        filme10.Exibir();
        filme11.Exibir();
        filme12.Exibir();
        filme13.Exibir();
        filme14.Exibir();
        Console.WriteLine("---------------------------------------------------------------------------------------");
    }
}