using Praticando_métodos_e_construtores.Models;

Pessoa p1 = new Pessoa(nome: "Danilo", sobrenome: "Fernandes", idade: 21);

Pessoa p2 = new Pessoa(nome: "Maria", sobrenome: "Antonella", idade: 17);

Curso caligrafia = new Curso();

caligrafia.Nome = "Caligrafia";
caligrafia.Alunos = new List<Pessoa>();

caligrafia.AdicionarAluno(p1);
caligrafia.AdicionarAluno(p2);
caligrafia.ListarAlunos();


