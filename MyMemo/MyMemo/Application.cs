using MyMemo.Command;

namespace MyMemo;

public class Application
{
    /// <summary>
    /// MyMemoApplicationのエントリポイント
    /// </summary>
    public void Run()
    {
        Console.WriteLine(Directory.GetCurrentDirectory());

        var isExit = false;
        do
        {
            // input
            string? input = Console.ReadLine();
            if (input == null) continue;
            
            // Parse input
            var inputObj = new Input(input);

            switch (inputObj.Command) 
            {
                case "create":
                    new Create().Execute(inputObj.Args);
                    break;
                case "delete":
                    break;
                case "list":
                    break;
                case "exit":
                    isExit = true;
                    break;
                default:
                    MyMemoLogger.Log($"Command {inputObj.Command} is not found");
                    break;
            }


        } while (!isExit);
    }

    private class Input
    {
        public string Command { get; }

        public readonly List<string> Args = new();

        public Input(string? inputStr)
        {
            if (string.IsNullOrEmpty(inputStr))
            {
                Command = string.Empty;
                return;
            }
            
            var inputArray = inputStr.Split(' ');
            Command = inputArray[0];
            for (int i = 1; i < inputArray.Length; i++)
            {
                Args.Add(inputArray[i]);
            }
        }
    }
}