namespace DemoFluxor.Models;

public class AddItemToCartAction
{
    public Item ItemToAdd { get; }

    public AddItemToCartAction(Item itemToAdd)
    {
        this.ItemToAdd = itemToAdd;
    }
}
