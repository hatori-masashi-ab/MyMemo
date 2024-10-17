namespace MyMemo.Command;

public interface ICommand
{
    int Execute(List<string> args);
}