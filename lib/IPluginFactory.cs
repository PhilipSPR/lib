using ds.test.impl;

public interface IPluginFactory
{
    /// <summary>
    /// Колличество плагинов
    /// </summary>
    static int PluginsCount { get; }
    /// <summary>
    /// Вернуть список плагинов
    /// </summary>
    static List<string> GetPluginNames { get; }

    /// <summary>
    /// Получить плагин
    /// </summary>
    /// <param name="pluginName">Имя плагина</param>
    /// <returns></returns>
    abstract IPlugin GetPlugin(string pluginName);
}
