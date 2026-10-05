namespace Ucu.Poo.RoleplayGame;

public class Malo : Character
{
    public int VP { get; }

    public Malo(string name, int vp) : base(name)
    {
        this.VP = vp;
    }
}