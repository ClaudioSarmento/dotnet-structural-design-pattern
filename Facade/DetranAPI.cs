namespace Facade;

public class DetranAPI
{
    private static readonly Random _random = new Random();
    public bool CNHValida(string numeroCNH)
    {
        return _random.Next(2) == 1;
    }

    public bool IPVAEmDia(string CPF)
    {
        return _random.Next(2) == 1;
    }

}
