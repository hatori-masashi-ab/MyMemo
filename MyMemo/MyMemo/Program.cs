// See https://aka.ms/new-console-template for more information

using MyMemo;

Console.WriteLine("===== Welcome to MyMemo! =====");

// ログシステム初期化
MyMemoLogger.Initialize();

var launcher = new Launcher();
launcher.RunConsoleApp(args);

Console.WriteLine("===== Shut Down... =====");