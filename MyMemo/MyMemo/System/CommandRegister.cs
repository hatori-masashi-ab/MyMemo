using MyMemo.Command;

namespace MyMemo;

public partial class Application
{
    /// <summary>
    /// ここにコマンドを登録
    /// </summary>
    private void RegisterCommand()
    {
        Register(new Exit());
        Register(new Create());
        Register(new Usage());
    }
}