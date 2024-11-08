namespace SQLiteDemoAssignment;

public partial class App : Application
{
    internal static object _carRepo;

    public App()
	{
		InitializeComponent();

		//MainPage = new AppShell();
		MainPage = new Assignment12();
		
	}
}
