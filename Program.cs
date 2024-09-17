﻿using CursoCSharp;
using CursoCSharp.Exercicios;
using CursoCSharp.Guia;
using CursoCSharp.Paradigmas;
using CursoCSharpBackup.Guia;
using CursoCSharpBackup.Paradigmas;
using Microsoft.VisualBasic;
using System;


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace GerenciamentoHospital
{
    class Program
    {
        static List<Paciente> pacientes = new List<Paciente>();
        static List<Medico> medicos = new List<Medico>();
        static List<Consulta> consultas = new List<Consulta>();
        static string arquivoPacientes = @"C:\Users\Aluno Noite\Documents\CursoC#\CursoCSharpBackup\Armazenamento Json\pacientes.json";
        static string arquivoMedicos = @"C:\Users\Aluno Noite\Documents\CursoC#\CursoCSharpBackup\Armazenamento Json\medicos.json";
        static string arquivoConsultas = @"C:\Users\Aluno Noite\Documents\CursoC#\CursoCSharpBackup\Armazenamento Json\consultas.json";
        static int proximoIdPaciente = 1;
        static int proximoIdMedico = 1;
        static int proximoIdConsulta = 1;

        static void Main(string[] args)
        {
            CarregarDados();
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("======== SISTEMA DE GERENCIAMENTO HOSPITALAR ========");
                Console.WriteLine("1. Gerenciar Pacientes");
                Console.WriteLine("2. Gerenciar Médicos");
                Console.WriteLine("3. Agendar Consulta");
                Console.WriteLine("4. Listar Consultas");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        MenuPacientes();
                        break;
                    case 2:
                        MenuMedicos();
                        break;
                    case 3:
                        AgendarConsulta();
                        break;
                    case 4:
                        ListarConsultas();
                        break;
                    case 0:
                        SalvarDados();
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            } while (opcao != 0);
        }

        // Métodos de gerenciamento de pacientes
        static void MenuPacientes()
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("==== Gerenciar Pacientes ====");
                Console.WriteLine("1. Adicionar Paciente");
                Console.WriteLine("2. Listar Pacientes");
                Console.WriteLine("3. Atualizar Paciente");
                Console.WriteLine("4. Remover Paciente");
                Console.WriteLine("0. Voltar");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarPaciente();
                        break;
                    case 2:
                        ListarPacientes();
                        break;
                    case 3:
                        AtualizarPaciente();
                        break;
                    case 4:
                        RemoverPaciente();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            } while (opcao != 0);
        }

        static void AdicionarPaciente()
        {
            Console.Write("Digite o nome do paciente: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o CPF do paciente: ");
            string cpf = Console.ReadLine();
            Paciente novoPaciente = new Paciente(proximoIdPaciente++, nome, cpf);
            pacientes.Add(novoPaciente);
            SalvarPacientes();
            Console.WriteLine("Paciente adicionado com sucesso!");
        }

        static void ListarPacientes()
        {
            Console.WriteLine("=== Lista de Pacientes ===");
            if (pacientes.Count == 0)
            {
                Console.WriteLine("\nNenhum paciente cadastrado.");
            }
            else
            {
                foreach (var paciente in pacientes)
                {
                    Console.WriteLine($"ID: {paciente.Id} - Nome: {paciente.Nome} - CPF: {paciente.Cpf}");
                }
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        static void AtualizarPaciente()
        {
            ListarPacientes();
            Console.Write("Digite o ID do paciente a ser atualizado: ");
            int id = int.Parse(Console.ReadLine());
            var paciente = pacientes.FirstOrDefault(p => p.Id == id);

            if (paciente != null)
            {
                Console.Write("Novo nome: ");
                paciente.Nome = Console.ReadLine();
                Console.Write("Novo CPF: ");
                paciente.Cpf = Console.ReadLine();
                SalvarPacientes();
                Console.WriteLine("Paciente atualizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Paciente não encontrado.");
            }
        }

        static void RemoverPaciente()
        {
            ListarPacientes();
            Console.Write("Digite o ID do paciente a ser removido: ");
            int id = int.Parse(Console.ReadLine());
            var paciente = pacientes.FirstOrDefault(p => p.Id == id);

            if (paciente != null)
            {
                pacientes.Remove(paciente);
                SalvarPacientes();
                Console.WriteLine("Paciente removido com sucesso.");
            }
            else
            {
                Console.WriteLine("Paciente não encontrado.");
            }
        }

        // Métodos de gerenciamento de médicos
        static void MenuMedicos()
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("==== Gerenciar Médicos ====");
                Console.WriteLine("1. Adicionar Médico");
                Console.WriteLine("2. Listar Médicos");
                Console.WriteLine("3. Atualizar Médico");
                Console.WriteLine("4. Remover Médico");
                Console.WriteLine("0. Voltar");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarMedico();
                        break;
                    case 2:
                        ListarMedicos();
                        break;
                    case 3:
                        AtualizarMedico();
                        break;
                    case 4:
                        RemoverMedico();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            } while (opcao != 0);
        }

        static void AdicionarMedico()
        {
            Console.Write("Digite o nome do médico: ");
            string nome = Console.ReadLine();
            Console.Write("Digite a especialidade do médico: ");
            string especialidade = Console.ReadLine();
            Medico novoMedico = new Medico(proximoIdMedico++, nome, especialidade);
            medicos.Add(novoMedico);
            SalvarMedicos();
            Console.WriteLine("Médico adicionado com sucesso!");
        }

        static void ListarMedicos()
        {
            Console.WriteLine("=== Lista de Médicos ===");
            if (medicos.Count == 0)
            {
                Console.WriteLine("\nNenhum médico cadastrado.");
            }
            else
            {
                foreach (var medico in medicos)
                {
                    Console.WriteLine($"ID: {medico.Id} - Nome: {medico.Nome} - Especialidade: {medico.Especialidade}");
                }
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        static void AtualizarMedico()
        {
            ListarMedicos();
            Console.Write("Digite o ID do médico a ser atualizado: ");
            int id = int.Parse(Console.ReadLine());
            var medico = medicos.FirstOrDefault(m => m.Id == id);

            if (medico != null)
            {
                Console.Write("Novo nome: ");
                medico.Nome = Console.ReadLine();
                Console.Write("Nova especialidade: ");
                medico.Especialidade = Console.ReadLine();
                SalvarMedicos();
                Console.WriteLine("Médico atualizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Médico não encontrado.");
            }
        }

        static void RemoverMedico()
        {
            ListarMedicos();
            Console.Write("Digite o ID do médico a ser removido: ");
            int id = int.Parse(Console.ReadLine());
            var medico = medicos.FirstOrDefault(m => m.Id == id);

            if (medico != null)
            {
                medicos.Remove(medico);
                SalvarMedicos();
                Console.WriteLine("Médico removido com sucesso.");
            }
            else
            {
                Console.WriteLine("Médico não encontrado.");
            }
        }

        // Métodos de agendamento de consultas
        static void AgendarConsulta()
        {
            Console.Clear();
            Console.WriteLine("==== Agendar Consulta ====");
            ListarPacientes();
            Console.Write("Digite o ID do paciente: ");
            int idPaciente = int.Parse(Console.ReadLine());
            var paciente = pacientes.FirstOrDefault(p => p.Id == idPaciente);

            if (paciente != null)
            {
                ListarMedicos();
                Console.Write("Digite o ID do médico: ");
                int idMedico = int.Parse(Console.ReadLine());
                var medico = medicos.FirstOrDefault(m => m.Id == idMedico);

                if (medico != null)
                {
                    Console.Write("Digite a data da consulta (dd/MM/yyyy): ");
                    DateTime dataConsulta = DateTime.Parse(Console.ReadLine());

                    Consulta novaConsulta = new Consulta(proximoIdConsulta++, paciente, medico, dataConsulta);
                    consultas.Add(novaConsulta);
                    SalvarConsultas();
                    Console.WriteLine("Consulta agendada com sucesso!");
                }
                else
                {
                    Console.WriteLine("Médico não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("Paciente não encontrado.");
            }
        }

        static void ListarConsultas()
        {
            Console.Clear();
            Console.WriteLine("=== Lista de Consultas ===");
            if (consultas.Count == 0)
            {
                Console.WriteLine("\nNenhuma consulta cadastrada.");
            }
            else
            {
                foreach (var consulta in consultas)
                {
                    Console.WriteLine($"ID: {consulta.Id} - Paciente: {consulta.Paciente.Nome} - Médico: {consulta.Medico.Nome} ");
                }
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        // Métodos de persistência de dados
        static void CarregarDados()
        {
            if (File.Exists(arquivoPacientes))
                pacientes = JsonSerializer.Deserialize<List<Paciente>>(File.ReadAllText(arquivoPacientes));
            if (File.Exists(arquivoMedicos))
                medicos = JsonSerializer.Deserialize<List<Medico>>(File.ReadAllText(arquivoMedicos));
            if (File.Exists(arquivoConsultas))
                consultas = JsonSerializer.Deserialize<List<Consulta>>(File.ReadAllText(arquivoConsultas));

            proximoIdPaciente = pacientes.Any() ? pacientes.Max(p => p.Id) + 1 : 1;
            proximoIdMedico = medicos.Any() ? medicos.Max(m => m.Id) + 1 : 1;
            proximoIdConsulta = consultas.Any() ? consultas.Max(c => c.Id) + 1 : 1;
        }

        static void SalvarDados()
        {
            SalvarPacientes();
            SalvarMedicos();
            SalvarConsultas();
        }

        static void SalvarPacientes()
        {
            File.WriteAllText(arquivoPacientes, JsonSerializer.Serialize(pacientes));
        }

        static void SalvarMedicos()
        {
            File.WriteAllText(arquivoMedicos, JsonSerializer.Serialize(medicos));
        }

        static void SalvarConsultas()
        {
            File.WriteAllText(arquivoConsultas, JsonSerializer.Serialize(consultas));
        }
    }
}








/*bool resultado;
resultado = _3_Guia_OperadoresLogicos.ELogico(true, true);
Console.WriteLine($"O resultado de AND lógico é {resultado}");
resultado = _3_Guia_OperadoresLogicos.OULogico(true, true);
Console.WriteLine($"O resultado de OR lógico é {resultado}");
resultado = _3_Guia_OperadoresLogicos.Negacao(true);
Console.WriteLine($"O resultado de NOT lógico é {resultado}");
resultado = _3_Guia_OperadoresLogicos.OUExclusivo(true, true);
Console.WriteLine($"O resultado de XOR lógico é {resultado}");

// _5_Guia_OperadoresAtribuicao.AtribuicaoSimples();
// _5_Guia_OperadoresAtribuicao.AtribuicaoSoma();
// _5_Guia_OperadoresAtribuicao.AtribuicaoSubtracao();
// _5_Guia_OperadoresAtribuicao.AtribuicaoMultiplicacao();
// _5_Guia_OperadoresAtribuicao.AtribuicaoDivisao();
// _5_Guia_OperadoresAtribuicao.AtribuicaoModulo();
// _5_Guia_OperadoresAtribuicao.AtribuicaoAnd();
// _5_Guia_OperadoresAtribuicao.AtribuicaoOr();
// _5_Guia_OperadoresAtribuicao.AtribuicaoXor();
// _5_Guia_OperadoresAtribuicao.AtribuicaoDeslocamentoEsquerda();
// _5_Guia_OperadoresAtribuicao.AtribuicaoDeslocamentoDireita();
// _6_Guia_OperadoresComparacao.DemonstrarOperadores();
// _7_Guia_OperadorTernario.DemonstrarTernario();
// _8_Guia_Conversao.DemonstrarConversoes();
// _9_Guia_EstruturaCondicionais.DemostrarCondicional();
// _10_Guia_EstruturaRepeticao.DemonstrarRepeticoes();
// _11_Guia_Arrays.DemonstraArray();

var exemplo = new ExemploUsoDynamic();
exemplo.DemonstrarUsoDynamic(); 

var exemplo = new ExemploUsoLINQ();
exemplo.DemonstrarUsoLINQ(); */

/* var nulo = new NullableTypesDemo();
nulo.ExibirValores();
nulo.ExplicarConceitos(); */

/*
namespace BibliotecaVeiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicialização de objetos
            Biblioteca biblioteca = new Biblioteca();
            Garagem garagem = new Garagem();
            Usuario usuario = new Usuario("João Silva", "12345678900");
            Cliente cliente = new Cliente("Maria Oliveira", "98765432100");

            // Loop do menu principal
            int opcao = 0;
            do
            {
                Console.Clear(); // Limpa a tela para uma melhor organização visual
                Console.WriteLine("==============================================");
                Console.WriteLine("==========   SISTEMA DE GERENCIAMENTO   ======");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Biblioteca de Livros");
                Console.WriteLine("2. Sistema de Gerenciamento de Veículos");
                Console.WriteLine("0. Sair");
                Console.WriteLine("==============================================");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        MenuBiblioteca(biblioteca, usuario);
                        break;
                    case 2:
                        MenuVeiculos(garagem, cliente);
                        break;
                    case 0:
                        Console.WriteLine("\nSaindo do programa...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
            } while (opcao != 0);
        }

        static void MenuBiblioteca(Biblioteca biblioteca, Usuario usuario)
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("==========   BIBLIOTECA DE LIVROS   ==========");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Adicionar Livro");
                Console.WriteLine("2. Listar Livros");
                Console.WriteLine("3. Emprestar Livro");
                Console.WriteLine("4. Devolver Livro");
                Console.WriteLine("5. Exibir Livros Emprestados");
                Console.WriteLine("0. Voltar");
                Console.WriteLine("==============================================");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarLivro(biblioteca);
                        break;
                    case 2:
                        biblioteca.ListarLivros();
                        break;
                    case 3:
                        EmprestarLivro(biblioteca, usuario);
                        break;
                    case 4:
                        DevolverLivro(biblioteca, usuario);
                        break;
                    case 5:
                        usuario.ExibirLivrosEmprestados();
                        break;
                    case 0:
                        Console.WriteLine("\nVoltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey(); // Pausa para permitir que o usuário veja a mensagem antes de continuar
            } while (opcao != 0);
        }

        static void MenuVeiculos(Garagem garagem, Cliente cliente)
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("=======   SISTEMA DE VEÍCULOS - GARAGEM   =====");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Adicionar Veículo");
                Console.WriteLine("2. Listar Veículos");
                Console.WriteLine("3. Comprar Veículo");
                Console.WriteLine("4. Vender Veículo");
                Console.WriteLine("5. Exibir Veículos Comprados");
                Console.WriteLine("0. Voltar");
                Console.WriteLine("==============================================");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarVeiculo(garagem);
                        break;
                    case 2:
                        ListarVeiculos(garagem);
                        break;
                    case 3:
                        ComprarVeiculo(garagem, cliente);
                        break;
                    case 4:
                        VenderVeiculo(garagem);
                        break;
                    case 5:
                        cliente.ExibirVeiculosComprados();
                        break;
                    case 0:
                        Console.WriteLine("\nVoltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey(); // Pausa para permitir que o usuário veja a mensagem antes de continuar
            } while (opcao != 0);
        }

        static void AdicionarLivro(Biblioteca biblioteca)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=========   ADICIONAR NOVO LIVRO   ==========");
            Console.WriteLine("==============================================");
            Console.Write("Digite o título do livro: ");
            string titulo = Console.ReadLine();
            Console.Write("Digite o autor do livro: ");
            string autor = Console.ReadLine();
            Console.Write("Digite o ano de publicação: ");
            int ano = int.Parse(Console.ReadLine());
            Console.Write("Digite o número de páginas: ");
            int paginas = int.Parse(Console.ReadLine());

            Livro livro = new Livro(titulo, autor, ano, paginas);
            biblioteca.AdicionarLivro(livro);
            Console.WriteLine("\nLivro adicionado com sucesso!");
        }

        static void EmprestarLivro(Biblioteca biblioteca, Usuario usuario)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("==========   EMPRÉSTIMO DE LIVRO   ==========");
            Console.WriteLine("==============================================");
            Console.Write("Digite o título do livro a ser emprestado: ");
            string titulo = Console.ReadLine();
            Livro livro = biblioteca.BuscarLivroPorTitulo(titulo);
            if (livro != null)
            {
                usuario.EmprestarLivro(livro, biblioteca);
                Console.WriteLine("\nLivro emprestado com sucesso!");
            }
            else
            {
                Console.WriteLine("\nLivro não encontrado no acervo.");
            }
        }

        static void DevolverLivro(Biblioteca biblioteca, Usuario usuario)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("===========   DEVOLUÇÃO DE LIVRO   ===========");
            Console.WriteLine("==============================================");
            Console.Write("Digite o título do livro a ser devolvido: ");
            string titulo = Console.ReadLine();
            Livro livro = usuario.BuscarLivroEmprestadoPorTitulo(titulo); // Verifique se o livro está emprestado
            if (livro != null)
            {
                usuario.DevolverLivro(livro, biblioteca);
                Console.WriteLine("\nLivro devolvido com sucesso!");
            }
            else
            {
                Console.WriteLine("\nLivro não encontrado na lista de empréstimos.");
            }
        }

        static void AdicionarVeiculo(Garagem garagem)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=========   ADICIONAR NOVO VEÍCULO   =========");
            Console.WriteLine("==============================================");
            Console.Write("Digite a marca do veículo: ");
            string marca = Console.ReadLine();
            Console.Write("Digite o modelo do veículo: ");
            string modelo = Console.ReadLine();
            Console.Write("Digite o ano do veículo: ");
            int ano = int.Parse(Console.ReadLine());
            Console.Write("Digite a quilometragem do veículo: ");
            int quilometragem = int.Parse(Console.ReadLine());

            Veiculo veiculo = new Veiculo(marca, modelo, ano, quilometragem);
            garagem.AdicionarVeiculo(veiculo);
            Console.WriteLine("\nVeículo adicionado com sucesso!");
        }

        static void ListarVeiculos(Garagem garagem)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("======   LISTA DE VEÍCULOS DISPONÍVEIS   =====");
            Console.WriteLine("==============================================");
            var veiculos = garagem.ListarTodosVeiculos(); // Obtém todos os veículos da garagem

            if (veiculos.Count == 0)
            {
                Console.WriteLine("\nNenhum veículo disponível.");
            }
            else
            {
                foreach (var veiculo in veiculos) // Itera sobre a lista de veículos
                {
                    veiculo.ExibirDetalhes(); // Exibe os detalhes de cada veículo
                }
            }
        }

        static void ComprarVeiculo(Garagem garagem, Cliente cliente)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=========   COMPRA DE VEÍCULO   =============");
            Console.WriteLine("==============================================");
            Console.Write("Digite o modelo do veículo a ser comprado: ");
            string modelo = Console.ReadLine();
            Veiculo veiculo = garagem.BuscarVeiculoPorModelo(modelo);
            if (veiculo != null)
            {
                cliente.ComprarVeiculo(veiculo, garagem);
                Console.WriteLine("\nVeículo comprado com sucesso!");
            }
            else
            {
                Console.WriteLine("\nVeículo não encontrado.");
            }
        }

        static void VenderVeiculo(Garagem garagem)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("==========   VENDA DE VEÍCULO   =============");
            Console.WriteLine("==============================================");
            Console.Write("Digite o modelo do veículo a ser vendido: ");
            string modelo = Console.ReadLine();
            Veiculo veiculo = garagem.BuscarVeiculoPorModelo(modelo);
            if (veiculo != null)
            {
                garagem.VenderVeiculo(veiculo);
                Console.WriteLine("\nVeículo vendido com sucesso!");
            }
            else
            {
                Console.WriteLine("\nVeículo não encontrado.");
            }
        }
    }

    public class Biblioteca
    {
        private List<Livro> livros = new List<Livro>();

        public void AdicionarLivro(Livro livro)
        {
            livros.Add(livro);
        }

        public void ListarLivros()
        {
            foreach (var livro in livros)
            {
                livro.ExibirDetalhes();
            }
        }

        public Livro BuscarLivroPorTitulo(string titulo)
        {
            return livros.FirstOrDefault(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
        }

        public void AdicionarLivroDevolvido(Livro livro)
        {
            if (!livros.Contains(livro))
            {
                livros.Add(livro);
            }
        }
    }

    public class Usuario
    {
        private List<Livro> livrosEmprestados = new List<Livro>();
        public string Nome { get; set; }
        public string CPF { get; set; }

        public Usuario(string nome, string cpf)
        {
            Nome = nome;
            CPF = cpf;
        }

        public void EmprestarLivro(Livro livro, Biblioteca biblioteca)
        {
            if (livro != null && biblioteca != null)
            {
                livrosEmprestados.Add(livro);
                biblioteca.AdicionarLivroDevolvido(livro);
            }
        }

        public void DevolverLivro(Livro livro, Biblioteca biblioteca)
        {
            if (livrosEmprestados.Remove(livro))
            {
                biblioteca.AdicionarLivroDevolvido(livro);
            }
        }

        public Livro BuscarLivroEmprestadoPorTitulo(string titulo)
        {
            return livrosEmprestados.FirstOrDefault(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
        }

        public void ExibirLivrosEmprestados()
        {
            foreach (var livro in livrosEmprestados)
            {
                livro.ExibirDetalhes();
            }
        }
    }

    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Ano { get; set; }
        public int Paginas { get; set; }

        public Livro(string titulo, string autor, int ano, int paginas)
        {
            Titulo = titulo;
            Autor = autor;
            Ano = ano;
            Paginas = paginas;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Título: {Titulo}, Autor: {Autor}, Ano: {Ano}, Páginas: {Paginas}");
        }
    }

    public class Garagem
    {
        private List<Veiculo> veiculos = new List<Veiculo>();

        public void AdicionarVeiculo(Veiculo veiculo)
        {
            veiculos.Add(veiculo);
        }

        public List<Veiculo> ListarTodosVeiculos()
        {
            return veiculos;
        }

        public Veiculo BuscarVeiculoPorModelo(string modelo)
        {
            return veiculos.FirstOrDefault(v => v.Modelo.Equals(modelo, StringComparison.OrdinalIgnoreCase));
        }

        public void VenderVeiculo(Veiculo veiculo)
        {
            if (veiculos.Contains(veiculo))
            {
                veiculos.Remove(veiculo);
            }
        }
    }

    public class Cliente
    {
        private List<Veiculo> veiculosComprados = new List<Veiculo>();
        public string Nome { get; set; }
        public string CPF { get; set; }

        public Cliente(string nome, string cpf)
        {
            Nome = nome;
            CPF = cpf;
        }

        public void ComprarVeiculo(Veiculo veiculo, Garagem garagem)
        {
            if (veiculo != null && garagem != null)
            {
                veiculosComprados.Add(veiculo);
                garagem.VenderVeiculo(veiculo);
            }
        }

        public void ExibirVeiculosComprados()
        {
            foreach (var veiculo in veiculosComprados)
            {
                veiculo.ExibirDetalhes();
            }
        }
    }

    public class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public int Quilometragem { get; set; }

        public Veiculo(string marca, string modelo, int ano, int quilometragem)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Quilometragem = quilometragem;
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}, Quilometragem: {Quilometragem}");
        }
    }
}
*/

/*
// Instância de Cachorro
Cachorro cachorro = new Cachorro("Rex");
cachorro.ExibirInformacoes();
cachorro.FazerSom();
cachorro.ExplicarHeranca();

// Instância de Gato
Gato gato = new Gato("Mimi");
gato.ExibirInformacoes();
gato.FazerSom();
gato.ExplicarHeranca();

agregacao
// Criando um objeto Endereco que pode existir independentemente
Endereco endereco = new Endereco("Rua Principal", "Cidade Exemplo");

// Criando um objeto Pessoa que contém um Endereco (agregação)
PessoaAgrecacao pessoa = new PessoaAgrecacao("João", endereco);

// Exibir as informações da pessoa e seu endereço
pessoa.ExibirInformacoes();

// Explicando o conceito de agregação
pessoa.ExplicarAgregacao();


associacao
// Criando um objeto Departamento
Departamento departamento = new Departamento("Recursos Humanos");

// Criando um objeto Funcionario que está associado a um Departamento
Funcionario funcionarioComDepartamento = new Funcionario("Ana", departamento);

// Criando um objeto Funcionario sem associação a nenhum Departamento
Funcionario funcionarioSemDepartamento = new Funcionario("Carlos");

// Exibir as informações dos funcionários
funcionarioComDepartamento.ExibirInformacoes();
funcionarioSemDepartamento.ExibirInformacoes();

// Explicando o conceito de associação
funcionarioComDepartamento.ExplicarAssociacao();



// Criando um objeto Carro, que inclui a criação de um Motor
Carro carro = new Carro("Fusca", "Motor 1600");

// Exibindo informações sobre o carro e seu motor
carro.ExibirInformacoes();

// Explicando o conceito de composição
carro.ExplicarComposicao();


// Criando funcionários
FuncionarioMulti funcionario1 = new FuncionarioMulti("Ana");
FuncionarioMulti funcionario2 = new FuncionarioMulti("Carlos");

// Criando um projeto
Projeto projeto = new Projeto("Desenvolvimento de Software");

// Adicionando funcionários ao projeto
projeto.AdicionarFuncionario(funcionario1);
projeto.AdicionarFuncionario(funcionario2);

// Exibindo informações sobre o projeto e seus funcionários
projeto.ExibirInformacoes();

// Explicando o conceito de multiplicidade
projeto.ExplicarMultiplicidade();


AnimalAbs cachorro = new CachorroAbs("Davi");
AnimalAbs gato = new GatoAbs("Amanda");

// Exibindo informações e fazendo som dos animais
cachorro.ExibirInformacoes();
cachorro.FazerSom();

gato.ExibirInformacoes();
gato.FazerSom();

// Explicando o conceito de classe abstrata
cachorro.ExplicarClasseAbstrata();
*/
/*
// Criando instâncias de classes que implementam a interface
IAnimal cachorro = new CachorroInter("Rex");
IAnimal gato = new GatoInter("Mimi");

// Exibindo informações e sons dos animais
cachorro.ExibirInformacoes();
cachorro.FazerSom();

gato.ExibirInformacoes();
gato.FazerSom();

// Explicando o conceito de interface
ExplicadorDeInterface explicador = new ExplicadorDeInterface();
explicador.ExplicarInterface();
*/