namespace Bridge;

public abstract class JanelaAbstrata
{
    protected IJanelaBridge janela;

    public JanelaAbstrata(IJanelaBridge janela)
    {
        this.janela = janela;
    }

    public void desenharJanela(string titulo)
    {
        janela.desenharJanela(titulo);
    }

    public void desenharBotao(string titulo)
    {
        janela.desenharBotao(titulo);
    }

    public abstract void desenhar();
}
