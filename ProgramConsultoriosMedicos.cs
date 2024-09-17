using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Paciente
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Cpf { get; set; }

    public Paciente(int id, string nome, string cpf)
    {
        Id = id;
        Nome = nome;
        Cpf = cpf;
    }
}

class Medico
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Especialidade { get; set; }

    public Medico(int id, string nome, string especialidade)
    {
        Id = id;
        Nome = nome;
        Especialidade = especialidade;
    }
}

class Consulta
{
    public int Id { get; set; }
    public Paciente Paciente { get; set; }
    public Medico Medico { get; set; }
    public DateTime DataConsulta { get; set; }

    public Consulta(int id, Paciente paciente, Medico medico, DateTime dataConsulta)
    {
        Id = id;
        Paciente = paciente;
        Medico = medico;
        DataConsulta = dataConsulta;
    }
}


