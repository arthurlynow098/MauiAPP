using MauiApp2;

namespace MauiApp2
{
    public partial class AdicionarProdutoPage : ContentPage
    {
        public AdicionarProdutoPage()
        {
            InitializeComponent();
        }

        private async void btnSalvarProduto_Clicked(object sender, EventArgs e)
        {
            // Verifica se os campos est�o preenchidos
            if (string.IsNullOrWhiteSpace(entryNome.Text) ||
                string.IsNullOrWhiteSpace(entryPreco.Text) ||
                pickerCategoria.SelectedIndex == -1)
            {
                await DisplayAlert("Erro", "Por favor, preencha todos os campos.", "OK");
                return;
            }

            // Tenta converter o pre�o para decimal
            if (!decimal.TryParse(entryPreco.Text, out decimal preco))
            {
                await DisplayAlert("Erro", "Pre�o inv�lido.", "OK");
                return;
            }

            // Cria e adiciona o novo produto � lista
            Produto novoProduto = new Produto
            {
                Nome = entryNome.Text,
                Preco = preco,
                Categoria = pickerCategoria.SelectedItem.ToString(),
                DataValidade = dateValidade.Date // <-- Aqui pegamos a data do DatePicker
            };

            Produto.Lista.Add(novoProduto);

            await DisplayAlert("Sucesso", "Produto salvo com sucesso!", "OK");

            // Limpa os campos
            entryNome.Text = string.Empty;
            entryPreco.Text = string.Empty;
            pickerCategoria.SelectedIndex = -1;
            dateValidade.Date = DateTime.Today; // <-- Opcional: reseta o DatePicker
        }
    }
}
