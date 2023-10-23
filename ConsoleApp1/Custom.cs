using System.Drawing;
using ds.test.impl;

namespace ConsoleApp1;

public class Custom : IPlugin
{
    public Custom(string pluginName, string version, Image image, string description)
    {
        PluginName = pluginName;
        Version = version;
        Image = image;
        Description = description;
    }

    public string PluginName { get; }
    public string Version { get; }
    public Image Image { get; }
    public string Description { get; }
    public int Run(int input1, int input2)
    {
        return (input1 + input2) * 2;
    }
}