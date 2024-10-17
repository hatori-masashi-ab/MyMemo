using System.Text;

namespace MyMemo.Command;

public class Usage : CommandBase
{
    public override string CommandName => "usage";

    public override int Execute(List<string> args)
    {
        StringBuilder sb = new();
        var commands = AppSystemContainer.Instance.GetAllCommands();
        foreach (var command in commands)
        {
            if (command.Equals(this)) continue;

            sb.AppendLine(command.GetUsageString());
        }

        MyMemoLogger.Log(sb.ToString());

        return SuccessCode;
    }
}