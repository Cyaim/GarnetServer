﻿using Garnet;

// 重命名终端显示的名字
Console.Title = "GarnetServer";

// 由于JSON文件中不能添加注释,所以我这里将配置文件的详细参数文档链接放在代码里.
// See https://microsoft.github.io/garnet/docs/getting-started/configuration to learn how to customize your configuration
try
{
    using var server = new GarnetServer(args);
    server.Start();
    Thread.Sleep(Timeout.Infinite);
}
catch (Exception ex)
{
    Console.WriteLine($"Unable to initialize server due to exception: {ex.Message}");
}