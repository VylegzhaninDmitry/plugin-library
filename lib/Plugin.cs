using System.Drawing;

namespace ds.test.impl;

internal abstract class Plugin : IPlugin
{

    public virtual string PluginName => string.Empty;
    public virtual string Version => string.Empty;
    public virtual string Description => string.Empty;
    public virtual Image Image => null!;
    public abstract int Run(int input1, int input2);
    
    protected static Image GetImage(string imageName) =>
#pragma warning disable CA1416
        Image.FromFile(Path.Combine("Images", $"{imageName}.png"));
#pragma warning restore CA1416
}