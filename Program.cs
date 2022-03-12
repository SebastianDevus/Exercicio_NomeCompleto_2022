string nome, sobrenome;

Console.Write("Digite seu primeiro nome: ");
nome = Console.ReadLine()!; // Insere o que o usuário digitou na variável nome

Console.Write("Digite seu sobrenome: ");
sobrenome = Console.ReadLine()!; // Insere o que o usuário digitou na variável sobrenome

Console.WriteLine($"Nome completo: {nome} {sobrenome}"); // Exibe a o conteúdo das variáveis 'nome' e 'sobrenome'

Console.WriteLine($"Nome de catálogo: {sobrenome.ToUpper()}, {nome}"); // Transforma o conteúdo da variável 'sobrenome' em maiúsculas, e exibe, seguido do conteúdo da variável 'nome'
