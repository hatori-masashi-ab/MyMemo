namespace MyMemo.Command;

public class Create : CommandBase
{
    public override string CommandName => "create";
    public override int Execute(List<string> args)
    {
        foreach (var arg in args)
        {
            Console.WriteLine(arg);
        }

        return SuccessCode;
    }

    public override string GetUsageString() => "create <filename>";
}