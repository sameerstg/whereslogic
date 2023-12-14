using System.Collections.Generic;

public class Pool
{
    public List<Wire> wire;
    public List<Module> modules;
    public Pool()
    {
        wire = new();
        modules = new();
    }
}
