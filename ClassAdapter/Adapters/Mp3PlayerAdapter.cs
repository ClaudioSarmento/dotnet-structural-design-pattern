using ClassAdapter.Libs;

namespace ClassAdapter.Adapters;

public class Mp3PlayerAdapter : IPlayer
{
    public void Play(string file)
    {
        var mp3 = new Mp3Player(file);
        mp3.Run();
    }
}
