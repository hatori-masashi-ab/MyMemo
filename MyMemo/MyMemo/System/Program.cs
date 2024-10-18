using MyMemo;

Console.WriteLine("===== Welcome to MyMemo! =====");

// ログシステム初期化
MyMemoLogger.Initialize();

// ランチャー起動
var launcher = new Launcher();
launcher.RunConsoleApp(args);

Console.WriteLine("===== Shut Down... =====");