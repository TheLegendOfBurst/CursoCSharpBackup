using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1 Modifique o método LerArmazenar para armazenar o sobrenome do usuário e exibi-lo junto com o nome:
// 2 Peça ao usuário para inserir a idade e exiba o nome e a idade:
// 3 Peça ao usuário para inserir a cidade e exiba o nome e a cidade:
// 4 Armazene o nome do usuário em maiúsculas e exiba-o:
// 5 Armazene o nome do usuário em minúsculas e exiba-o:
// 6 Peça ao usuário para inserir seu nome e idade, depois exiba ambos em uma única linha:
// 7 Peça ao usuário para inserir seu nome e cidade de nascimento, depois exiba ambos:
// 8 Peça ao usuário para inserir seu nome e profissão, depois exiba ambos:
// 9 Peça ao usuário para inserir seu nome e país de origem, depois exiba ambos:
// 10 Peça ao usuário para inserir seu nome e número favorito, depois exiba ambos:
// 11 Peça ao usuário para inserir seu nome e hobby favorito, depois exiba ambos:
// 12 Peça ao usuário para inserir seu nome e cor favorita, depois exiba ambos:
// 13 Peça ao usuário para inserir seu nome e filme favorito, depois exiba ambos:
// 14 Peça ao usuário para inserir seu nome e gênero musical favorito, depois exiba ambos:
// 15 Peça ao usuário para inserir seu nome e animal favorito, depois exiba ambos:
// 16 Peça ao usuário para inserir seu nome e esporte favorito, depois exiba ambos:
// 17 Peça ao usuário para inserir seu nome e comida favorita, depois exiba ambos:
// 18 Peça ao usuário para inserir seu nome e banda favorita, depois exiba ambos:
// 19 Peça ao usuário para inserir seu nome e livro favorito, depois exiba ambos:
// 20 Peça ao usuário para inserir seu nome e um lema de vida, depois exiba ambos:

namespace CursoCSharp.Exercicios
{ /*
    public class ExercicioTiposPrimitivos
    {
        // 1. Modifique o método LerArmazenar para armazenar o sobrenome do usuário e exibi-lo junto com o nome:
        public static void Exercicio1()
        {
            string? nome;
            string? sobrenome;
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite seu sobrenome: ");
            sobrenome = Console.ReadLine();
            Console.WriteLine($"Nome: {nome}, Sobrenome: {sobrenome}");
        }

        // 2. Peça ao usuário para inserir a idade e exiba o nome e a idade:
        public static void Exercicio2()
        {
            string? nome;
            long idade;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            if (long.TryParse(Console.ReadLine(), out idade))
            {
                // idades maiores que o valor máximo permitido por int são aceitas
                Console.WriteLine($"Nome: {nome}, Idade: {idade}");
            }
            else
            {
                Console.WriteLine("Idade inválida.");
            }
        }

        // 3. Peça ao usuário para inserir a cidade e exiba o nome e a cidade:
        public static void Exercicio3()
        {
            string? nome;
            string? cidade;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite sua cidade: ");
            cidade = Console.ReadLine();

            Console.WriteLine($"Nome: {nome}, Cidade: {cidade}");
        }

        // 4. Armazene o nome do usuário em maiúsculas e exiba-o:
        public static void Exercicio4()
        {
            string? nome;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine()?.ToUpper();

            Console.WriteLine($"O seu nome em maiúsculo é {nome}");
        }

        // 5. Armazene o nome do usuário em minúsculas e exiba-o:
        public static void Exercicio5()
        {
            string? nome;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine()?.ToLower();

            Console.WriteLine($"O seu nome em minúsculo é {nome}");
        }

        // 6. Peça ao usuário para inserir seu nome e idade, depois exiba ambos em uma única linha:
        public static void Exercicio6()
        {
            string? nome;
            string? idade;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            idade = Console.ReadLine();

            Console.WriteLine($"Nome: {nome}, Idade: {idade}");
        }

        // 7. Peça ao usuário para inserir seu nome e cidade de nascimento, depois exiba ambos:
        public static void Exercicio7()
        {
            string? nome;
            string? cidadeNascimento;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite sua cidade de nascimento: ");
            cidadeNascimento = Console.ReadLine();

            Console.WriteLine($"Nome: {nome}, Cidade de Nascimento: {cidadeNascimento}");
        }

        // 8. Peça ao usuário para inserir seu nome e profissão, depois exiba ambos:
        public static void Exercicio8()
        {
            string? nome;
            string? profissao;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite sua profissão: ");
            profissao = Console.ReadLine();

            Console.WriteLine($"Nome: {nome}, Profissão: {profissao}");
        }

        // 9. Peça ao usuário para inserir seu nome e país de origem, depois exiba ambos:
        public static void Exercicio9()
        {
            string? nome;
            string? paisOrigem;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite seu país de origem: ");
            paisOrigem = Console.ReadLine();

            Console.WriteLine($"Nome: {nome}, País de Origem: {paisOrigem}");
        }

        // 10. Peça ao usuário para inserir seu nome e número favorito, depois exiba ambos:
        public static void Exercicio10()
        {
            string? nome;
            string? numeroFavorito;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite seu número favorito: ");
            numeroFavorito = Console.ReadLine();

            Console.WriteLine($"Nome: {nome}, Número Favorito: {numeroFavorito}");
        }

        // 11. Peça ao usuário para inserir seu nome e hobby favorito, depois exiba ambos:
        public static void Exercicio11()
        {
            string? nome;
            string? hobbyFavorito;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite seu hobby favorito: ");
            hobbyFavorito = Console.ReadLine();

            Console.WriteLine($"Nome: {nome}, Hobby Favorito: {hobbyFavorito}");
        }

        // 12. Peça ao usuário para inserir seu nome e cor favorita, depois exiba ambos:
        public static void Exercicio12()
        {
            string? nome;
            string? corFavorita;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite sua cor favorita: ");
            corFavorita = Console.ReadLine();

            Console.WriteLine($"Nome: {nome}, Cor Favorita: {corFavorita}");
        }

        // 13. Peça ao usuário para inserir seu nome e filme favorito, depois exiba ambos:
        public static void Exercicio13()
        {
            string? nome;
            string? filmeFavorito;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite seu filme favorito: ");
            filmeFavorito = Console.ReadLine();

            Console.WriteLine($"Nome: {nome}, Filme Favorito: {filmeFavorito}");
        }

        // 14. Peça ao usuário para inserir seu nome e gênero musical favorito, depois exiba ambos:
        public static void Exercicio14()
        {
            string? nome;
            string? generoMusicalFavorito;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite seu gênero musical favorito: ");
            generoMusicalFavorito = Console.ReadLine();

            Console.WriteLine($"Nome: {nome}, Gênero Musical Favorito: {generoMusicalFavorito}");
        }

        // 15. Peça ao usuário para inserir seu nome e animal favorito, depois exiba ambos:
        public static void Exercicio15()
        {
            string? nome;
            string? animalFavorito;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite seu animal favorito: ");
            animalFavorito = Console.ReadLine();

            Console.WriteLine($"Nome: {nome}, Animal Favorito: {animalFavorito}");
        }

        // 16. Peça ao usuário para inserir seu nome e esporte favorito, depois exiba ambos:
        public static void Exercicio16()
        {
            string? nome;
            string? esporteFavorito;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite seu esporte favorito: ");
            esporteFavorito = Console.ReadLine();

            Console.WriteLine($"Nome: {nome}, Esporte Favorito: {esporteFavorito}");
        }

        // 17. Peça ao usuário para inserir seu nome e comida favorita, depois exiba ambos:
        public static void Exercicio17()
        {
            string? nome;
            string? comidaFavorita;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite sua comida favorita: ");
            comidaFavorita = Console.ReadLine();

            Console.WriteLine($"Nome: {nome}, Comida Favorita: {comidaFavorita}");
        }

        // 18. Peça ao usuário para inserir seu nome e banda favorita, depois exiba ambos:
        public static void Exercicio18()
        {
            string? nome;
            string? bandaFavorita;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite sua banda favorita: ");
            bandaFavorita = Console.ReadLine();

            Console.WriteLine($"Nome: {nome}, Banda Favorita: {bandaFavorita}");
        }

        // 19. Peça ao usuário para inserir seu nome e livro favorito, depois exiba ambos:
        public static void Exercicio19()
        {
            string? nome;
            string? livroFavorito;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite seu livro favorito: ");
            livroFavorito = Console.ReadLine();

            Console.WriteLine($"Nome: {nome}, Livro Favorito: {livroFavorito}");
        }

        // 20. Peça ao usuário para inserir seu nome e um lema de vida, depois exiba ambos:
        public static void Exercicio20()
        {
            string? nome;
            string? lemaDeVida;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite seu lema de vida: ");
            lemaDeVida = Console.ReadLine();
        }
    }*/
}
    