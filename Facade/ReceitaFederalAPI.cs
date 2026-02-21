using System;

namespace Facade;

public class ReceitaFederalAPI
{
    private static readonly Random _random = new Random();
    public bool CPFAtivo(string cpf)
    {
        return _random.Next(2) == 1;
    }

}
