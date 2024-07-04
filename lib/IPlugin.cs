

namespace ds.test.impl
{
    public interface IPlugin
    {
        /// <summary>
        /// Имя плагина
        /// </summary>
        string PluginName { get; }
        /// <summary>
        /// Версия плагина
        /// </summary>
        string Version { get; }
        /// <summary>
        /// Получить изображение
        /// </summary>
        System.Drawing.Image Image { get; }
        /// <summary>
        /// Описание плагина
        /// </summary>
        string Description { get; }
        /// <summary>
        /// Исполнить
        /// </summary>
        /// <param name="input1">Первое целочисленое число</param>
        /// <param name="input2">Второе целочисленое число</param>
        /// <returns>Результат вычислений</returns>
        int Run(int input1, int input2);
    }
}
