using ds.test.impl;

List<string> pluginsList = Plugins.GetPluginNames;

pluginsList.ForEach(x => Console.WriteLine(x));

IPlugin additionPlugin = Plugins.GetPlugin("Addition");

Console.WriteLine("Addition: " + additionPlugin.Version);
Console.WriteLine("Addition: " + additionPlugin.Image);
Console.WriteLine("Addition: " + additionPlugin.Run(1, 5));
Console.WriteLine("Addition: " + additionPlugin.Description);
Console.WriteLine("Addition: " + additionPlugin.PluginName);