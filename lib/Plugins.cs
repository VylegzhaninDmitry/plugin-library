using System.Drawing;
using static System.IO.Path;

namespace ds.test.impl;

public static class Plugins
{
    private static readonly List<IPlugin> _plugins = new();

    static Plugins()
    {
        _plugins.Add(new AdditionPlugin());
        _plugins.Add(new MultiplicationPlugin());
        _plugins.Add(new SubtractionPlugin());
        _plugins.Add(new DivisionPlugin());
    }
    /// <summary>
    /// Get plugin count
    /// </summary>
    public static int PluginsCount => 
        _plugins.Count;

    /// <summary>
    /// Get plugin names
    /// </summary>
    /// <returns>Array plugin names</returns>
    public static string[] GetPluginNames() => 
        _plugins.Select(plugin => plugin.PluginName).ToArray();

    /// <summary>
    /// Get plugin by name
    /// </summary>
    /// <param name="pluginName">Plugin name</param>
    /// <returns>Plugin</returns>
    /// <exception cref="NullReferenceException">the exception that is thrown when a method call is invalid for the object's current state.</exception>
    public static IPlugin GetPlugin(string pluginName) =>
        _plugins.Find(plugin => plugin.PluginName == pluginName) ?? throw new Exception($"This name {pluginName} doesn't exist");

    /// <summary>
    /// Register plugin
    /// </summary>
    /// <param name="plugin">Custom plugin</param>
    public static void RegisterPlugin(IPlugin plugin) => 
        _plugins.Add(plugin);
}