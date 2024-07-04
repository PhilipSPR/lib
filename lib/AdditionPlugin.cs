using System.Drawing;

namespace ds.test.impl
{
    internal class AdditionPlugin : BasePlugin
    {
        public override string PluginName => "Addition";
        public override string Version => "1.0";
        public override Image Image => new Bitmap(128, 128); // Пример изображения
        public override string Description => "Плагин сложения";

        public override int Run(int input1, int input2) 
            => input1 + input2;
    }
}

