using Cysharp.Text;

namespace MyMemo;

public static class MyMemoLogger
{
    private static LoggingMode _loggingMode = LoggingMode.None;

    public static void Initialize()
    {
        _loggingMode = LoggingMode.None;
    }
    
    public static void AddLoggingMode(LoggingMode loggingMode)
    {
        _loggingMode |= loggingMode;
    }
    
    /// <summary>
    /// コンソール上に表示するログ
    /// LoggingMode = Log
    /// </summary>
    public static void Log(string message)
    {
        if (_loggingMode.HasFlag(LoggingMode.Timestamp))
        {
            Console.WriteLine(AppendTimestamp(message));
            return;
        }

        Console.WriteLine(message);
    }

    /// <summary>
    /// デバッグ表示するログ
    /// LoggingMode = DebugLog
    /// </summary>
    public static void DebugLog(string message)
    {
        Log(ZString.Concat($"[Debug] ", message));
    }
    
    private static string AppendTimestamp(string message)
    {
        return $"{DateTime.Now:yyyy/MM/dd HH:mm:ss} {message}";
    }
}

[Flags]
public enum LoggingMode
{
    None = 0,
    Log = 1 << 0,
    DebugLog = 1 << 1,
    Timestamp = 1 << 2,
}