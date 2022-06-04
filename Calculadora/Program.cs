﻿//Permitindo que os métodos de Visuais sejam chamados
using Calculadora.Lib;

string operacaoDesejada;

Console.Clear();

Console.WriteLine("-----Calculadora Aritmética-----\n");
Console.WriteLine("[+] Adição");
Console.WriteLine("[-] Subtração");
Console.WriteLine("[*] Multiplicação");
Console.WriteLine("[/] Divisão");
Console.WriteLine("[^] Exponenciação");
Console.Write("\nEscolha uma operação: ");
operacaoDesejada = Console.ReadLine()!;

// Chama o método apropriado dependendo da operação escolhida
// Os métodos estão no diretório Calculadora.Lib, arquivo AritmeticaVisuais
try
{
    switch (operacaoDesejada)
    {
        case ("+"):
            AritmeticaVisuais.AdicaoVisuais();
            break;

        case ("-"):
            AritmeticaVisuais.SubtracaoVisuais();
            break;

        case ("*"):
            AritmeticaVisuais.MultiplicacaoVisuais();
            break;

        case ("/"):
            AritmeticaVisuais.DivisaoVisuais();
            break;

        case ("^"):
            AritmeticaVisuais.ExponenciacaoVisuais();
            break;

        default:
            throw new Exception("Opção inválida!");
    }
}
catch (Exception e)
{
    Console.WriteLine(); // Espaçamento
    AritmeticaVisuais.ExibeMensagemDeErro(e.Message);
}
finally
{
    Console.ResetColor();
}


// Pausando após a operação para o usuário ver o resultado e limpar o console depois
Console.Write("\nPressione uma tecla para finalizar...");
Console.ReadKey();
Console.Clear();