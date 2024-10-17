namespace MyMemo;
using ConsoleAppFramework;

public class Launcher
{
    public void RunConsoleApp(string[] args)
    {
        var app = ConsoleApp.Create();

        app.Add("", Run);
        app.Add("Logging", LoggingModeRun);
        app.Add("Setting", SettingModeRun);

        app.Run(args);
    }

    /// <summary>
    /// Command入力なしで通常モード起動を行います。
    /// </summary>
    private void Run()
    {
        var application = new Application();
        application.Run();
    }

    /// <summary>
    /// LoggingModeで実行します。
    /// </summary>
    private void LoggingModeRun()
    {
        MyMemoLogger.AddLoggingMode(LoggingMode.Log);
        MyMemoLogger.AddLoggingMode(LoggingMode.DebugLog);
        MyMemoLogger.AddLoggingMode(LoggingMode.Timestamp);
        
        MyMemoLogger.Log("Normal Log");
        MyMemoLogger.DebugLog("Debug Log");

        Run();
    }

    /// <summary>
    /// Settingを実行します。
    /// </summary>
    private void SettingModeRun()
    {
        
    }
}