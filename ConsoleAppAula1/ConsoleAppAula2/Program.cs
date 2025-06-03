//Se o aluno tiver mais que 3 faltas já era
//Se a nota do aluno for menor que 60 já era também

/**
string nomeAluno;
int nota;
int faltas;
string opcao;

while(true){
    Console.WriteLine("Qual o nome do aluno?");
    nomeAluno = Console.ReadLine();

    Console.WriteLine($"Qual a nota do aluno {nomeAluno}?");
    nota = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Quantas faltas o aluno {nomeAluno} tem?");
    faltas = Convert.ToInt32(Console.ReadLine());


    if (nota >= 60 ||faltas <= 3)
    {
        Console.WriteLine($"O aluno {nomeAluno} foi aprovado");
    }
    else
    {
        Console.WriteLine($"O aluno {nomeAluno} foi reprovado");
    }

    Console.WriteLine("Deseja contiunar? s/n");
    opcao = Console.ReadLine();

    if (opcao != "s")
    {
        Console.WriteLine("Desligando");
        break;
    }

    Console.Clear();
}
**/

#region Tabuada com FOR
//int tabuada;
//Console.WriteLine("Informe a tabuada:");
//tabuada = Convert.ToInt32(Console.ReadLine());

//for(int contador = 0; contador <= 10; contador++)
//{
//    Console.WriteLine($"{ tabuada } X { contador } = {tabuada * contador}");
//}

#endregion

#region Contador com WHILE
//int contador = 0;

//while(contador < 10)
//{
//    Console.WriteLine(contador);
//    contador++;
//}
#endregion

#region PERCORRENDO ARRAYS COM FOREACH
//string[] nomes = { "Abacaxi", "Maçã", "Banana" };
//int[] numeros = { 1, 2, 3, 4, 5 };

//foreach(int i in numeros)
//{
//    Console.WriteLine(i);
//}

//foreach (string i in nomes)
//{
//    Console.WriteLine(i);
//}

#endregion

#region TREINANDO FUNÇÕES

//int idadeAluno;

//bool MaiorDeIdade(int idade)
//{
//    if (idade >= 18)
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }
//}

//void MaiorDeIdade2(int idade)
//{
//    if (idade >= 18)
//    {
//        Console.WriteLine("Aluno maior de idade");
//    }
//    else
//    {
//        Console.WriteLine("Aluno menor de idade");
//    }
//}

//Console.WriteLine("Informe sua idade:");
//idadeAluno = Convert.ToInt32(Console.ReadLine());   
//if(MaiorDeIdade(idadeAluno) == true)
//{
//    Console.WriteLine("Aluno maior de idade");
//}
//else
//{
//    Console.WriteLine("Aluno menor de idade");
//}

//MaiorDeIdade2(16);
#endregion

#region TREINANDO RETORNO DE FUNÇÕES
//Função para somar do tipo void
void Somar(int n1, int n2)
{
    Console.WriteLine($"{n1 + n2}");
}

//Função que retorne a multiplicação Resultado int
int Multiplicar(int n1, int n2)
{
    int resultado  = n1 * n2;
    return resultado;
}

Somar(1, 2);
Console.WriteLine(Multiplicar(7, 1));
#endregion