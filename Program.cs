//string nome;
//string sobrenome;
//
Console.Clear();
//
//Console.Write($"{"Nome".PadRight(11, '.')}: ");
//nome = Console.ReadLine()!;
//
//Console.Write($"{"Sobrenome".PadRight(11, '.')}: ");
//sobrenome = Console.ReadLine()!;
//
//Console.WriteLine($"Meu nome é {nome} {sobrenome}");
//
//string valor = "abcdef".Insert(3, " xxxx ");
//
//Console.WriteLine(valor);

string oQueEuAcho;
string textoCensurado;

Console.Write("O que você acha de alunos que falam durante a aula? ");

oQueEuAcho = Console.ReadLine()!;

textoCensurado = oQueEuAcho
            .Replace("chato", "#%@$&")
            .Replace("chata", "#%@$&")
            .Replace("bobo", "#%@$&")
            .Replace("boba", "#%@$&")
            .Replace("feio", "#%@$&")
            .Replace("feia", "#%@$&")
            ;

Console.WriteLine($"Texto original: {oQueEuAcho}");
Console.WriteLine($"Texto censurado: {textoCensurado}");