using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome:"Danilo", sobrenome:"Fernandes");
Pessoa p2 = new Pessoa(nome:"Evelyn", sobrenome:"Sabrina");
Pessoa p3 = new Pessoa(nome:"Maluca", sobrenome:"da Noite");
Pessoa p4 = new Pessoa(nome:"Bruno", sobrenome:"Joseph");


Curso cursoDeIngles = new Curso();



cursoDeIngles.Nome = "Inglês para devs";
cursoDeIngles.Alunos = new List<Pessoa>();


cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.AdicionarAluno(p3);
cursoDeIngles.AdicionarAluno(p4);

cursoDeIngles.ListarAlunos();

cursoDeIngles.RemoverAluno(p3);


Console.WriteLine("\n======== \n");
cursoDeIngles.ListarAlunos();





















// p1.Nome = "Danilo";
// p1.Sobrenome = "Fernandes";
// p1.Idade = 21;

// p1.Apresentar();