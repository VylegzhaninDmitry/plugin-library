using System.Drawing;

namespace ds.test.impl;

internal class AdditionPlugin : Plugin
{
    public override string PluginName => nameof(AdditionPlugin);
    public override string Version => "1.0";
    public override string Description => "Addition of two numbers";
    public override Image Image => GetImage(nameof(AdditionPlugin));
    public override int Run(int input1, int input2) => input1 + input2;
}