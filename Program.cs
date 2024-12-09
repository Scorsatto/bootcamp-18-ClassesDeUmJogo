using bootcamp_18_ClassesDeUmJogo;

Heroi heroi = new Heroi();

Console.WriteLine("Informe o nome do heroi");
heroi.Nome = Console.ReadLine();

Console.WriteLine("Informe a idade do heroi");
heroi.Idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe a classe do heroi");
heroi.Tipo = Console.ReadLine();

heroi.Atacar();


