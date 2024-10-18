namespace MyMemo;

public class AppSystemContainer
{
    public static AppSystemContainer Instance => _instance ??= new AppSystemContainer();
    private static AppSystemContainer? _instance;

    private Application _application = null;
    
    public void Initialize(Application application)
    {
        _application = application;
    }

    public List<ICommand> GetAllCommands() => _application.GetAllCommands();
}