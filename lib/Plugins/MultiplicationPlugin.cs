using System.Drawing;

namespace ds.test.impl;

internal class MultiplicationPlugin : Plugin
{
    public override string PluginName => nameof(MultiplicationPlugin);
    public override string Version => "1.0";
    public override string Description => "Multiplication of two numbers";
    public override Image Image => GetImage(nameof(MultiplicationPlugin));
    public override int Run(int input1, int input2) => input1 * input2;
}