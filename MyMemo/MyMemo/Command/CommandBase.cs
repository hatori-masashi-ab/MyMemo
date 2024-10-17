namespace MyMemo.Command;

public abstract class CommandBase : ICommand
{
    public abstract string CommandName { get; }
    public abstract int Execute(List<string> args);
    public virtual string GetUsageString() => CommandName;
    
    protected const int SuccessCode = 1;
    protected const int ExitCode = 0;
    protected const int ErrorCode = -1;
}