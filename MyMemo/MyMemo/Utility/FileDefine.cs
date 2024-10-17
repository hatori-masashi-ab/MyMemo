namespace MyMemo;

public static class FileDefine
{
    private static string RootDirectory => Directory.GetCurrentDirectory();
    
    // Settingの保存先
    public static string SettingDirectory = $"{RootDirectory}/Setting";
    
    // 作成したファイルの保存先
    public static string FileDirectory = $"{RootDirectory}/Files";
}