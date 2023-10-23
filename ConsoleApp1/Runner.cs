using System.Drawing;
using System.Text;
using ds.test.impl;

namespace ConsoleApp1;

public class Runner
{
    public string RunnerStart()
    {
        const int input1 = 10;
        const int input2 = 2;
        var image = System.Drawing.Image.FromFile("D:\\Полезное\\C#\\Тестовое\\MathOperation\\lib\\Images\\AdditionPlugin.png");
        Plugins.RegisterPlugin(new Custom("sad", "2.0", image, "abds"));
        var plugins = Plugins.GetPluginNames();
        var message = new StringBuilder();
        var count = Plugins.PluginsCount;
        foreach (var plugin in plugins)
        {   
            var pl = Plugins.GetPlugin(plugin);
            message.Append($"Result : {pl.Run(input1, input2)}, Name {pl.PluginName}, Image {pl.Image}, Version {pl.Version}\n");
        }
        
        return message.ToString();
    }
}