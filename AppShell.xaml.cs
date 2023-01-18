namespace JM_AppBurger;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(JM_Views.JM_BurgerItemPage), typeof(JM_Views.JM_BurgerItemPage));
        Routing.RegisterRoute(nameof(JM_Views.JM_BurgerListPage), typeof(JM_Views.JM_BurgerListPage));
    }
}
