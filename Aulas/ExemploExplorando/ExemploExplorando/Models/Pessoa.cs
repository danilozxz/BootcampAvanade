using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        public Pessoa()
        {
            
        }
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        private string _nome;
        private int _idade;
        public string Nome
        {
            get => _nome.ToUpper();
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio.");
                }
                _nome = value;
            }
        }

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        public int Idade
        {
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor do que zero.");
                }
                _idade = value;
            }
        }
        public void Apresentar()
        {
            Console.WriteLine($"Meu nome é {NomeCompleto} e eu tenho {Idade} anos.");
        }
    }
}






// namespace ExemploExplorando.Models
// {
//     public class Pessoa
//     {
//         private string _nome;
//         public string Nome
//         {
//             get => _nome.ToUpper();
//             set => ValidarPropiedadeNome(value);

//         }
//         private int _idade;
//         public int Idade
//         {
//             get => _idade;
//             set => ValidarPropiedadeIdade(value);
//         }

//         public void ValidarPropiedadeNome(string valor)
//         {
//             if (valor == "")
//             {
//                 throw new ArgumentException("O nome não pode ser vazio.");
//             }
//             _nome = valor;
//         }

//         public void ValidarPropiedadeIdade(int valor)
//         {
//             if (valor < 0)
//             {
//                 throw new ArgumentException("A idade não pode ser menor do que zero.");
//             }
//             _idade = valor;
//         }
//         public void Apresentar()
//         {
//             Console.WriteLine($"Meu nome é {Nome} e eu tenho {Idade} anos.");
//         }
//     }
// }