// See https://aka.ms/new-console-template for more information


public class Health
{
    int _hp = 12;

    public int Gethp() => _hp;

    public void damage(int outch)
    {
        _hp -= outch;
    }
    
}

int Main()
{
    return 0;
}

Main();