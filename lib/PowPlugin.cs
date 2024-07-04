using System.Drawing;

namespace ds.test.impl
{
    internal class PowPlugin : BasePlugin
    {
        public override string PluginName => "Pow";
        public override string Version => "1.0";
        public override Image Image => new Bitmap(64, 64); // Пример изображения
        public override string Description => "Плагин возведения в степень";

        /// <summary>
        /// Результат возведения в степень
        /// </summary>
        /// <param name="input1">Вводимое число</param>
        /// <param name="input2">Вводимая степень</param>
        /// <returns></returns>
        public override int Run(int input1, int input2)
        {
            try
            {
                return Convert.ToInt32(Math.Pow(input1, input2));
            }
            catch(Exception ex)
            {
                throw new Exception($"При возведении в степень возникла ошибка: {ex.Message}");
            }
        } 
    }
}
