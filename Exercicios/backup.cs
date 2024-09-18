/* 
 static void ListarConsultas()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                         LISTA DE CONSULTAS                                  ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════╝");

            // Exibir a linha da data e hora
            Console.Write($"║ Data e Hora: {DateTime.Now:dd/MM/yyyy HH:mm:ss}                             ║");
            int cursorY = Console.CursorTop; // Salvar a posição do cursor

            Console.WriteLine(); // Para avançar para a próxima linha

            if (consultas.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nNenhuma consulta cadastrada.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;

                // Cabeçalhos da tabela
                Console.WriteLine("╔═════╦══════════════════════╦═══════════════════════════════════╗");
                Console.WriteLine("║ ID  ║ Paciente             ║ Médico                            ║");
                Console.WriteLine("╠═════╬══════════════════════╬═══════════════════════════════════╣");

                foreach (var consulta in consultas)
                {
                    string nomePaciente = consulta.Paciente.Nome.Length > 20 ? consulta.Paciente.Nome.Substring(0, 20) : consulta.Paciente.Nome.PadRight(20);
                    string nomeMedico = consulta.Medico.Nome.Length > 33 ? consulta.Medico.Nome.Substring(0, 33) : consulta.Medico.Nome.PadRight(33);

                    Console.WriteLine($"║ {consulta.Id,-3} ║ {nomePaciente} ║ {nomeMedico} ║");
                }

                Console.WriteLine("╚═════╩══════════════════════╩═══════════════════════════════════╝");
                Console.ResetColor();
            }

            // Loop para atualizar a hora em tempo real
            while (true)
            {
                // Reposicionar o cursor para a linha da data e hora
                Console.SetCursorPosition(1, cursorY);

                // Definir a cor antes de imprimir a hora
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"Data e Hora: {DateTime.Now:dd/MM/yyyy HH:mm:ss}                                ║");

                // Espera 1 segundo antes de atualizar
                System.Threading.Thread.Sleep(1000);
            }
        }
 */

/* 
static void Main(string[] args)
    {
        CarregarDados();
        int opcao;
        do
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            
            // Exibe o relógio
            ExibirRelogio();

            Console.WriteLine("╔════════════════════════════════════════════════════════╗");
            Console.WriteLine("║            SISTEMA DE GERENCIAMENTO HOSPITALAR         ║");
            Console.WriteLine("╠════════════════════════════════════════════════════════╣");
            Console.WriteLine("║  1. Gerenciar Pacientes                                ║");
            Console.WriteLine("║  2. Gerenciar Médicos                                  ║");
            Console.WriteLine("║  3. Agendar Consulta                                   ║");
            Console.WriteLine("║  4. Listar Consultas                                   ║");
            Console.WriteLine("║  5. Gerar Relatório                                    ║");
            Console.WriteLine("║  0. Sair                                               ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════╝");
            Console.WriteLine("");
            Console.Write("Escolha uma opção: ");

            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Opção inválida. Por favor, insira um número.");
                Console.ResetColor();
                Console.ReadKey();
                continue;
            }

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
                case 5:
                    GerarRelatorio();
                    break;
                case 0:
                    SalvarDados();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Saindo...");
                    Console.ResetColor();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção inválida.");
                    Console.ResetColor();
                    break;
            }
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        } while (opcao != 0);
    }

    static void ExibirRelogio()
    {
        Console.SetCursorPosition(0, 0); // Move o cursor para o início da linha
        Console.WriteLine($"Hora atual: {DateTime.Now:HH:mm:ss}");
    }
*/