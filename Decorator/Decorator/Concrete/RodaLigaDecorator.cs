using Decorator.Decorator.Base;

namespace Decorator.Decorator.Concrete;

internal class RodaLigaDecorator : CarroDecorator
{
    public RodaLigaDecorator(ICarro carro) : base(carro)
    {
    }

    public override string RetornarCarro()
    {
        return base.RetornarCarro() + " com Roda de liga";
    }
}