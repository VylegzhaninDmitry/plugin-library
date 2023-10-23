using System.Drawing;

namespace ds.test.impl;

internal class SubtractionPlugin : Plugin
{
    public override string PluginName => nameof(SubtractionPlugin);
    public override string Version => "1.0";
    public override string Description => "Subtraction of two numbers";
    public override Image Image => GetImage(nameof(SubtractionPlugin));
    public override int Run(int input1, int input2) => input1 - input2;
}