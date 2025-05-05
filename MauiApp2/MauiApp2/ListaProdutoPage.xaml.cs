using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Maui.Controls;

namespace MauiApp2
{
    public partial class ListaProdutoPage : ContentPage
    {
        public ListaProdutoPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            AtualizarLista(filtroCategoriaPicker.SelectedItem?.ToString() ?? "Todas");
        }

        private void FiltrarPorCategoria(object sender, EventArgs e)
        {
            string categoriaSelecionada = filtroCategoriaPicker.SelectedItem?.ToString() ?? "Todas";
            AtualizarLista(categoriaSelecionada);
        }

        private void AtualizarLista(string categoria)
        {
            IEnumerable<Produto> listaFiltrada = Produto.Lista;

            if (categoria != "Todas")
            {
                listaFiltrada = listaFiltrada.Where(p => p.Categoria == categoria);
            }

            listaFiltrada = listaFiltrada
                .OrderBy(p => p.DataValidade ?? DateTime.MaxValue);

            lstProduto.ItemsSource = listaFiltrada.ToList();
        }

        private async void OnProdutoSelecionado(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection?.FirstOrDefault() is Produto produtoSelecionado)
            {
                await Navigation.PushAsync(new ProdutoPage(produtoSelecionado));
                ((CollectionView)sender).SelectedItem = null; // desfaz seleção visual
            }
        }
    }
}
