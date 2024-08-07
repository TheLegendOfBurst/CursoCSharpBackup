using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Exercicios
{
    public class ExercicioOperadoresAritmeticos
    {
        /* 1. Questão: Crie um programa em C# que solicite ao usuário dois números inteiros e 
           calcule a soma desses números. Exiba o resultado com uma mensagem que informe a 
           soma dos dois números. */

        public static void Exercicio1()
        {

            Console.Write("Digite o primeiro número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            int soma = numero1 + numero2;
            Console.WriteLine($"A soma dos números {numero1} e {numero2} é {soma}.");
        }


        /* 2. Questão: Peça ao usuário para inserir dois números inteiros e calcule a diferença entre
           o primeiro e o segundo número. Exiba o resultado com uma mensagem que informe a
           subtração. */
        public static void Exercicio2()
        {

            Console.Write("Digite o primeiro número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            int diferenca = numero1 - numero2;
            Console.WriteLine($"A diferença entre {numero1} e {numero2} é {diferenca}.");
        }

        /* 3. Questão: Solicite ao usuário para inserir dois números inteiros e calcule a
           multiplicação desses números. Exiba o resultado com uma mensagem que informe a
           multiplicação. */
        public static void Exercicio3()
        {
            Console.Write("Digite o primeiro numero: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            int multiplicacao = numero1 * numero2;
            Console.WriteLine($"A multiplicacao dos numeros {numero1} e {numero2} é {multiplicacao}.");
        }

        /* 4. Questão: Peça ao usuário para inserir dois números inteiros e calcule a divisão do
           primeiro número pelo segundo. Exiba o resultado com uma mensagem que informe a
           divisão. Inclua tratamento para divisão por zero. */
        public static void Exercicio4()
        {
            Console.Write("Digite o primeiro numero: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            int divisao = numero1 / numero2;
            Console.WriteLine($"A divisao dos numeros {numero1} e {numero2} é {divisao}.");
        }
        /* 5. Questão: Solicite ao usuário para inserir dois números inteiros e calcule o resto da
           divisão do primeiro número pelo segundo. Exiba o resultado com uma mensagem que
           informe o resto da divisão. */
        public static void Exercicio5()
        {
            // Solicita o primeiro número ao usuário
            Console.Write("Digite o primeiro número inteiro: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            // Solicita o segundo número ao usuário
            Console.Write("Digite o segundo número inteiro: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            // Verifica se o divisor é zero para evitar divisão por zero
            if (numero2 == 0)
            {
                Console.WriteLine("Erro: Divisão por zero não é permitida.");
            }
            else
            {
                // Calcula o resto da divisão
                int resto = numero1 % numero2;

                // Exibe o resultado
                Console.WriteLine($"O resto da divisão de {numero1} por {numero2} é {resto}.");
            }
        }

        /* 6. Questão: Peça ao usuário para inserir um número inteiro e, em seguida, exiba o
              número incrementado em 1. Utilize o operador de incremento ++. */
        public static void Exercicio6()
        {
            Console.Write("Digite um numero inteiro: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            numero++;
            Console.WriteLine($"O numero incrementado em 1 é: {numero}");
        }


        /* 7. Questão: Solicite ao usuário para inserir um número inteiro e exiba o mesmo número
              decrementado em 1. Utilize o operador de decremento --. */
        public static void Exercicio7()
        {
            Console.Write("Digite um numero inteiro: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            numero--;
            Console.WriteLine($"O numero decrementado em 1 é: {numero}");
        }

        /* 8. Questão: Crie um programa que solicite ao usuário para inserir dois números inteiros e
              calcule a média desses números. Exiba a média com uma mensagem informativa. */
        public static void Exercicio8()
        {
            Console.Write("Digite o primeiro numero: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            double media = (numero1 + numero2) / 2.0;
            Console.WriteLine($"A media dos numeros {numero1} e {numero2} é {media}.");
        }

        /* 9. Questão: Peça ao usuário para inserir três números inteiros e calcule a soma dos dois
              primeiros números e, em seguida, subtraia o terceiro número do resultado. Exiba o
              resultado com uma mensagem explicativa. */
        public static void Exercicio9()
        {
            Console.Write("Digite o primeiro numero: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o terceiro numero: ");
            int numero3 = Convert.ToInt32(Console.ReadLine());
            int resultado = (numero1 + numero2) - numero3;
            Console.Write($"O resultado da soma de {numero1} e {numero2}, subtraído de {numero3}, é {resultado}.");
        }


        /* 10. Questão: Solicite ao usuário dois números inteiros e calcule o quadrado do primeiro
               número somado ao segundo número. Exiba o resultado com uma mensagem explicativa. */
        public static void Exercicio10()
        {
            Console.Write("Digite o primeiro numero: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            int resultado = (numero1 * numero1) + (numero2);
            Console.WriteLine($"O quadrado da soma de {numero1} e {numero2} é {resultado}.");
        }

        /* 11. Questão: Crie um programa que solicite ao usuário para inserir um valor e exiba o
               dobro desse valor e a metade desse valor. Utilize operadores aritméticos para fazer os cálculos. */
        public static void Exercicio11()
        {
            Console.Write("Digite um numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int dobro = numero * 2;
            int metade = numero / 2;
            Console.WriteLine($"O dobro do numero {numero} é {dobro} e a metade do numero {numero} é {metade}.");
        }

        /* 12. Questão: Peça ao usuário para inserir dois números inteiros e calcule o resultado da
               expressão (a + b) * (a - b). Exiba o resultado com uma mensagem informativa. */
        public static void Exercicio12()
        {
            Console.Write("Digite o primeiro numero: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            int resultado = (numero1 + numero2) * (numero1 - numero2);
            Console.WriteLine($"O resultado da expressao ({numero1} + {numero2}) * ({numero1} - {numero2}) é {resultado}.");
        }

        /* 13. Questão: Solicite ao usuário para inserir dois números inteiros e calcule a soma do
               quadrado do primeiro número com o quadrado do segundo número. Exiba o resultado com uma mensagem explicativa. */
        public static void Exercicio13()
        {
            Console.Write("Digite o primeiro numero: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            int resultado = (numero1 * numero1) + (numero2 * numero2);
            Console.WriteLine($"O resultado da soma do quadrado de {numero1} com o quadrado de {numero2} é {resultado}.");
        }

        /* 14. Questão: Crie um programa que solicite ao usuário para inserir um número inteiro e
               calcule o valor do número ao cubo. Exiba o resultado com uma mensagem explicativa. */
        public static void Exercicio14()
        {
            Console.Write("Digite um numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int resultado = numero * numero * numero;
            Console.WriteLine($"O valor do numero {numero} ao cubo é {resultado}.");
        }

        /* 15. Questão: Peça ao usuário para inserir dois números inteiros e calcule o resultado da
               expressão a * (b + a) / b. Exiba o resultado com uma mensagem informativa. */
        public static void Exercicio15()
        {
            Console.Write("Digite o primeiro numero: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            double resultado = (numero1 * (numero1 + numero2)) / numero2;
            Console.WriteLine($"O resultado da expressao {numero1} * ({numero1} + {numero2}) / {numero2} é {resultado}.");
        }

        /* 16. Questão: Solicite ao usuário para inserir um número inteiro e calcule o quadrado da
               diferença entre o número e 5. Exiba o resultado com uma mensagem explicativa. */
        public static void Exercicio16()
        {
            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int diferenca = numero - 5;
            int resultado = diferenca * diferenca;
            Console.WriteLine($"O quadrado da diferença entre {numero} e 5 é {resultado}.");
        }

        /* 17. Questão: Crie um programa que solicite ao usuário dois números inteiros e calcule a
               média aritmética entre eles. Exiba a média com uma mensagem explicativa. */
        public static void Exercicio17()
        {
            Console.Write("Digite o primeiro numero: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            double media = (numero1 + numero2) / 2.0;
            Console.WriteLine($"A media aritmetica entre {numero1} e {numero2} é {media}.");
        }

        /* 18. Questão: Peça ao usuário para inserir um valor em reais e calcule o valor em dólares,
               assumindo uma taxa de câmbio fixa de 5.0 reais por dólar. Exiba o resultado com uma mensagem explicativa. */
        public static void Exercicio18()
        {
            Console.Write("Digite o valor em reais: R$ ");
            double valorEmReais = Convert.ToDouble(Console.ReadLine());
            double valorEmDolares = valorEmReais / 5.0;
            Console.WriteLine($"O valor R$ {valorEmReais} reais equivale a USS {valorEmDolares} dolares.");
        }

        /* 19. Questão: Solicite ao usuário para inserir a quantidade de dias e calcule a quantidade total de horas.
               Exiba o resultado com uma mensagem explicativa. */
        public static void Exercicio19()
        {
            // Solicita ao usuário para inserir a quantidade de dias
            Console.Write("Digite a quantidade de dias: ");

            // Lê a entrada do usuário
            string? input = Console.ReadLine(); // Adicionando o operador ? para indicar que pode ser nulo
            int dias;

            // Verifica se a entrada é um número inteiro válido
            if (int.TryParse(input, out dias))
            {
                // Calcula a quantidade total de horas
                int horas = dias * 24;

                // Exibe o resultado com uma mensagem explicativa
                Console.WriteLine($"A quantidade total de horas para {dias} dias é {horas} horas.");
            }
            else
            {
                // Mensagem de erro para entrada inválida
                Console.WriteLine("Por favor, insira um número inteiro válido.");
            }
        }


        /* 20. Questão: Crie um programa que peça ao usuário para inserir a quantidade de horas e
               minutos e calcule o total em minutos. Exiba o resultado com uma mensagem explicativa. */
        public static void Exercicio20()
        {
            // Solicita ao usuário a quantidade de horas
            Console.Write("Digite a quantidade de horas: ");
            string? inputHoras = Console.ReadLine(); // Permite nulo
            int horas;

            // Verifica se a entrada para horas é um número inteiro válido
            if (!int.TryParse(inputHoras, out horas))
            {
                Console.WriteLine("Por favor, insira um número inteiro válido para horas.");
                return; // Sai do método se a entrada não for válida
            }

            // Solicita ao usuário a quantidade de minutos
            Console.Write("Digite a quantidade de minutos: ");
            string? inputMinutos = Console.ReadLine(); // Permite nulo
            int minutos;

            // Verifica se a entrada para minutos é um número inteiro válido
            if (!int.TryParse(inputMinutos, out minutos))
            {
                Console.WriteLine("Por favor, insira um número inteiro válido para minutos.");
                return; // Sai do método se a entrada não for válida
            }

            // Calcula o total de minutos
            int totalMinutos = (horas * 60) + minutos;

            // Exibe o resultado
            Console.WriteLine($"O total em minutos é: {totalMinutos} minutos.");
        }

    }
}
