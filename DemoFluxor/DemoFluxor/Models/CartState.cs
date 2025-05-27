using Fluxor;
using System.Collections.Immutable;

namespace DemoFluxor.Models;

[FeatureState]
public record CartState
{
    public bool IsLoading { get; }
    public bool IsSaving { get; }

    public ImmutableArray<Item> ItemsInCart { get; } = ImmutableArray.Create<Item>();

    private CartState() { } // Serve a costruire lo stato iniziale

    public CartState(ImmutableArray<Item> itemsInCart, bool isLoading, bool isSaving)
    {
        IsSaving = isSaving;
        IsLoading = isLoading;
        ItemsInCart = itemsInCart;
    }

    public CartState(ImmutableArray<Item> itemsInCart)
    {
        ItemsInCart = itemsInCart;
    }
}