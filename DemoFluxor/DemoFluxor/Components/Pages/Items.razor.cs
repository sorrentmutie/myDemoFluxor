using DemoFluxor.Models;
using Fluxor;
using Microsoft.AspNetCore.Components;

namespace DemoFluxor.Components.Pages;

public partial class Items
{
    [Inject]
    private IState<CartState> CartState { get; set; }

    [Inject]
    public IDispatcher Dispatcher { get; set; }

    private string Name { get; set; }
    private decimal Price { get; set; }

    private void AddItem()
    {
        var itemToAdd = new Item(Name, Price);
        var addItemAction = new AddItemToCartAction(itemToAdd);
        Dispatcher.Dispatch(addItemAction);
    }
}

