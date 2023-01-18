namespace JM_AppBurger.JM_Views;
using JM_AppBurger.JM_Models;
public partial class JM_BurgerListPage : ContentPage
{
    public JM_BurgerListPage()
	{
		InitializeComponent();
        LoadData();
        BindingContext= this;

    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        {
            LoadData();
        }
    }

    private void LoadData()
    {
        List<JM_Burger> burger = App.BurgerRepo.GetAllBurgers();
        burgerList.ItemsSource = burger;
    }
    async void JM_OnItemAdded(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(JM_BurgerItemPage), true, new Dictionary<string, object>()
        {
            ["Item"] = new JM_Burger()
        });
    }

    async void JM_CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        JM_Burger jmburger= new JM_Burger();
        jmburger = burgerList.SelectedItem as JM_Burger;

        await Shell.Current.GoToAsync(nameof(JM_BurgerItemPage), true, new Dictionary<string, object>()
        {
            ["Item"] = jmburger
        });
    }
}