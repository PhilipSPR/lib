using System;
using System.Collections.Generic;
using System.Linq;

namespace ds.test.impl
{
    internal class PluginFactory : IPluginFactory
    {
        private readonly List<IPlugin> _plugins = new List<IPlugin>
        {
            new AdditionPlugin(),
            new MultiplicationPlugin(),
            new SubtractionPlugin(),
            new PowPlugin(),
        };

        public int PluginsCount => _plugins.Count();

        public List<string> GetPluginNames => _plugins.Select(p => p.PluginName).ToList();

        public IPlugin GetPlugin(string pluginName)
        {
            var plugin = _plugins.FirstOrDefault(p => p.PluginName.Equals(pluginName, StringComparison.OrdinalIgnoreCase));
            if (plugin == null)
            {
                throw new ArgumentException($"Плагин с именнем '{pluginName}' не найден.");
            }

            return plugin;
        }
    }
}
