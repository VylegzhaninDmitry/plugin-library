using System.Drawing;

namespace ds.test.impl;

internal class DivisionPlugin: Plugin
{
    public override string PluginName => nameof(DivisionPlugin);
    public override string Version => "1.0";
    public override string Description => "Division of two numbers";
    public override Image Image => GetImage(nameof(DivisionPlugin));
    public override int Run(int input1, int input2) => input1 == 0 ? throw new DivideByZeroException() : input1 / input2;
}