using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Praticando_métodos_e_construtores.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos;

        public void AdicionarAluno(Pessoa alunos)
        {
            Alunos.Add(alunos);
        }

        public void RemoverAluno(Pessoa alunos)
        {
            Alunos.Remove(alunos);
        }

        public int AlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }
        public void ListarAlunos()
        {
            Console.WriteLine("Lista de alunos do curso de Caligrafia");
            foreach (Pessoa aluno in Alunos )
            {
                Console.WriteLine($"Nome: {aluno.NomeCompleto} - Idade: {aluno.Idade} anos");
            }
        }
    }
}