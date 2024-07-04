using System.Drawing;

namespace ds.test.impl
{
    internal class SubtractionPlugin : BasePlugin
    {
        public override string PluginName => "Subtraction";
        public override string Version => "1.0";
        public override Image Image => new Bitmap(64, 64); // Пример изображения
        public override string Description => "Плагин вычитания";

        public override int Run(int input1, int input2) 
            => input1 - input2;
    }
}

