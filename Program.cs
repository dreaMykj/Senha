﻿string senha;

Console.Write("Olá, usuário. Por favor, digite sua senha: ");
senha = Console.ReadLine()!;

if (senha == "1234abcd")
{
    Console.WriteLine("Acesso permitido");
}
else
{
    Console.WriteLine("Acesso Negado");
}