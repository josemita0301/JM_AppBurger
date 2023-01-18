using JM_AppBurger.JM_Data;

namespace JM_AppBurger;

public partial class App : Application
{
    public static JM_BurgerDatabase BurgerRepo { get; private set; }

    public App(JM_BurgerDatabase repo)
	{
		InitializeComponent();

		MainPage = new AppShell();

        BurgerRepo = repo;
    }
}
