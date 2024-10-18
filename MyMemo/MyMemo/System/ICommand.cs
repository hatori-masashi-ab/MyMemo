namespace MyMemo;

public interface ICommand
{
    string CommandName { get; }
    int Execute(List<string> args);
    string GetUsageString();
}