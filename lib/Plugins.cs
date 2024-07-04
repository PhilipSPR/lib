namespace ds.test.impl
{
    public static class Plugins
    {
        /// <summary>
        /// Список плагинов
        /// </summary>
        private static readonly PluginFactory _factory = new PluginFactory();

        /// <summary>
        /// Колличество плагинов
        /// </summary>
        public static int PluginsCount => _factory.PluginsCount;
        /// <summary>
        /// Вернуть имена плагинов
        /// </summary>
        public static List<string> GetPluginNames => _factory.GetPluginNames;
        /// <summary>
        /// Получить плагин
        /// </summary>
        /// <param name="pluginName"></param>
        /// <returns></returns>
        public static IPlugin GetPlugin(string pluginName) => _factory.GetPlugin(pluginName);
    }
}
