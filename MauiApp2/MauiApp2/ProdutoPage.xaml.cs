namespace MauiApp2;

public partial class ProdutoPage : ContentPage
{
	public ProdutoPage(Produto produto)
	{
		InitializeComponent();
        BindingContext = produto;
    }
}