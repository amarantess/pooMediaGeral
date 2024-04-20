﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaGeralPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "### Média Geral dos Alunos ###";

        Inicio:
            Console.WriteLine("------------------------");
            Console.WriteLine(" Média Geral dos Alunos ");
            Console.WriteLine("------------------------");

            Console.Write("Quantos Alunos? ");
            int nAlunos = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Aluno[] alunos = new Aluno[nAlunos];

            for (int i = 0; i < alunos.Length; i++)
            {
                Console.Clear();
                Console.Write($"Aluno #{i + 1} Nome..: ");
                string nome  = Console.ReadLine();

                Console.Write($"Aluno #{i + 1} Provas: ");
                int provas = int.Parse(Console.ReadLine());

                alunos[i] = new Aluno(nome, provas);

                Console.WriteLine($"Insira as notas do aluno {nome}");
                alunos[i].InserirNotas();
            }

            Console.Clear();

            double mediaGeral = 0;

            foreach (Aluno aluno in alunos)
            {
                Console.WriteLine($"Aluno: {aluno.Nome}");
                Console.WriteLine($"Média: {aluno.Media}");
                Console.WriteLine();

                mediaGeral += aluno.Media;
            }

            double resultadoFinal = mediaGeral / alunos.Length;

            Console.WriteLine($"Média geral dos alunos: {resultadoFinal}");

            Console.WriteLine("Deseja refazer? (Sim ou Não)");
            string op = Console.ReadLine();

            if (op == "Sim" || op == "sim")
            {
                goto Inicio;
            }

            Console.ReadKey();
        }
    }
}
