﻿using System;

class Program
{
    static void Main(string[] args)
    {
        var operacoes = new Operacoes();

        Console.WriteLine("===== Teste: Alterar e Excluir =====");

       
        var tarefa = new Tarefa
        {
            Id = 1, 
            Nome = "Tarefa alterada",
            Descricao = "Descricao atualizada",
            DataCriacao = DateTime.Now,
            Status = 1, 
            DataExecucao = null 
        };

        operacoes.Alterar(tarefa);
        Console.WriteLine("Alteracao executada.");

        
        Console.Write("ID para excluir: ");
        var entrada = Console.ReadLine();
        if (int.TryParse(entrada, out var idExcluir))
        {
            operacoes.Excluir(idExcluir);
            Console.WriteLine("Exclusao executada (se o ID existia).");
        }
        else
        {
            Console.WriteLine("ID invalido, pulando exclusao.");
        }

        Console.WriteLine("===== Fim =====");
    }
}
