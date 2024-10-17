namespace MyMemo.Command;

public class Exit : CommandBase
{
    public override string CommandName => "exit";
    public override int Execute(List<string> args)
    {
        return ExitCode;
    }
}