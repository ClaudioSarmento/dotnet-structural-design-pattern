using Proxy;

ConfiguracaoProxy configuracaoProxy = new();
configuracaoProxy.Inicializar();
configuracaoProxy.SetConfig("Key001", "teste");
Console.WriteLine(configuracaoProxy.GetConfig("Key001"));
