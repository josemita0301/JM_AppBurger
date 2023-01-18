using JM_AppBurger.JM_Models;
using JM_AppBurger.JM_Data;

namespace JM_AppBurger.JM_Views;
[QueryProperty("Item", "Item")]
public partial class JM_BurgerItemPage : ContentPage
{
    public JM_Burger Item
    {
        get => BindingContext as JM_Burger;
        set => BindingContext = value;
    }

    //JM_Burger Item = new JM_Burger();
    //bool _flag;

    public JM_BurgerItemPage()
	{
		InitializeComponent();
	}

    private void JM_OnCheckBoxCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
       // _flag = e.Value;
    }

    private void JM_OnSaveClicked(object sender, EventArgs e)
    {
        //Item.Name = nameB.Text;
        //Item.Description = descB.Text;
        //Item.WithExtraCheese = _flag;
        App.BurgerRepo.AddNewBurger(Item);
        Shell.Current.GoToAsync("..");
    }

    private void JM_OnCancelClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }

    private void JM_OnDeleteItemClicked(object sender, EventArgs e)
    {
        App.BurgerRepo.DeleteItem(Item);
        Shell.Current.GoToAsync("..");
    }
}