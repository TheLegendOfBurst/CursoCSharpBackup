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