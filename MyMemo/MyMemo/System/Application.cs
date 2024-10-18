namespace MyMemo;

public partial class Application
{
    private readonly Dictionary<string, ICommand> _commands = new();
    
    /// <summary>
    /// MyMemoApplicationのエントリポイント
    /// </summary>
    public void Run()
    {
        Initialize();
        
        do
        {
            // input
            string? input = Console.ReadLine();
            if (input == null) continue;
            MyMemoLogger.DebugLog($"input : {input}");

            // Parse input
            var inputParam = new Input(input);

            if (_commands.TryGetValue(inputParam.Command, out var command) == false)
            {
                MyMemoLogger.Log($"Command {inputParam.Command} not found.");
                continue;
            }

            MyMemoLogger.DebugLog($"Command {inputParam.Command} execute.");
            int resultCode = command.Execute(inputParam.Args);
            MyMemoLogger.DebugLog($"Command {inputParam.Command} end.");

            // エラーでの終了
            if (resultCode < 0)
            {
                MyMemoLogger.Log($"Fatal Error!!! Code {resultCode}");
                break;
            }

            // 正常終了
            if (resultCode == 0)
            {
                break;
            }
        } while (true);
    }

    private void Initialize()
    {
        AppSystemContainer.Instance.Initialize(this);
        RegisterCommand();
    }

    private void Register(ICommand command)
    {
        _commands.Add(command.CommandName, command);
    }

    public List<ICommand> GetAllCommands()
    {
        return _commands.Values.ToList();
    }

    private class Input
    {
        public string Command { get; }

        public readonly List<string> Args = [];

        public Input(string? inputStr)
        {
            if (string.IsNullOrEmpty(inputStr))
            {
                Command = string.Empty;
                return;
            }
            
            var inputArray = inputStr.Split(' ');
            Command = inputArray[0];
            for (var i = 1; i < inputArray.Length; i++)
            {
                Args.Add(inputArray[i]);
            }
        }
    }
}