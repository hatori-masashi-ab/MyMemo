namespace MyMemo.Command;

public class Create : ICommand
{
    public int Execute(List<string> args)
    {
        foreach (var arg in args)
        {
            Console.WriteLine(arg);
        }

        return 0;
    }
}