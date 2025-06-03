/* Menor ou Maior de idade
int idade;
//Console.WriteLine("Informe sua idade:");

//idade = Convert.ToInt32(Console.ReadLine());

//if (idade >= 18)
//{
//    Console.WriteLine($"Sua idade é {idade},você é maior de idade");
//} else
//{
//    Console.WriteLine($"Sua idade é {idade},você é menor de idade");
//}
*/

/** Maior ou menor que o salário mínimo
const decimal salarioMinimo = 1518m;

Console.WriteLine("Digite seu salário: R$ ");
decimal salarioPessoal = decimal.Parse(Console.ReadLine());

if (salarioPessoal >= salarioMinimo)
{
    Console.WriteLine($"Seu salário é maior que um salário mínimo. {salarioPessoal:C}");
}
else
{
    Console.WriteLine($"Você recebe um salário menor que o salário mínimo {salarioPessoal:C}");
}
**/

float num1 = 0f;
float num2 = 0f;
string operacaoMatematica;
string opcao;

while (true)
{
    Console.WriteLine("Informe o primeiro valor:\n " +
        "+ ou - ou * ou / ou s para sair");
    operacaoMatematica = Console.ReadLine();

    Console.WriteLine("Informe o primeiro valor");
    num1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Informe o segundo valor");
    num2 = float.Parse(Console.ReadLine());

    switch (operacaoMatematica)
    {
        case "+":
            Console.WriteLine($"Soma: {(num1 + num2):F2}");
            break;
        case "-":
            Console.WriteLine($"Substração: {(num1 - num2):F2}");
            break;
        case "*":
            Console.WriteLine($"Substração: {(num1 * num2):F2}");
            break;
        case "/":
            Console.WriteLine($"Substração: {(num1 / num2):F2}");
            break;
        default:
            Console.WriteLine("Informe uma opção válida");
            break;
    }

    Console.WriteLine("Deseja continuar s/n");
    opcao = Console.ReadLine();
    if (opcao != "s")
    {
        break;
    }
    else { Console.Clear(); }
}

/**
#region Estrutura IF
do
{
    Console.WriteLine("Informe o primeiro valor:\n " +
    "+ ou - ou * ou / ou s para sair");

    operacaoMatematica = Console.ReadLine();

    if (operacaoMatematica == "+" || operacaoMatematica == "-" || operacaoMatematica == "*" || operacaoMatematica == "/")
    {
        Console.WriteLine("Informe o primeiro valor");
        num1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Informe o segundo valor");
        num2 = float.Parse(Console.ReadLine());
    }
    if (operacaoMatematica == "+")
    {
        //Soma
        Console.WriteLine($"Soma: {num1 + num2}");
        Console.ReadLine();
    }
    else if (operacaoMatematica == "-")
    {
        //Subtração
        Console.WriteLine($"Subtração: {num1 - num2}");
        Console.ReadLine();
    }
    else if (operacaoMatematica == "*")
    {
        //Multiplicação
        Console.WriteLine($"Multiplicação: {num1 * num2}");
        Console.ReadLine();
    }
    else if (operacaoMatematica == "/")
    {
        //Divisão
        Console.WriteLine($"Divisão: {num1 / num2}");
        Console.ReadLine();
    }
    else if (operacaoMatematica == "s")
    {
        //Saindo
        Console.WriteLine("Desligando...");
        Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Digite uma operação disponíveis");
        Console.ReadLine();
    }

    Console.Clear();
} while (operacaoMatematica != "s");
#endregion
**/



