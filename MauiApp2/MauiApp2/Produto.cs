using System;
using System.Collections.Generic;

namespace MauiApp2
{
    public class Produto
    {
        public decimal Preco { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }

        public DateTime? DataValidade { get; set; }
        public bool EstaVencido => DataValidade.HasValue && DataValidade.Value < DateTime.Today;


        public static List<Produto> Lista { get; } = new List<Produto>

{
    new Produto() { Nome = "Buzina", Preco = 300, Categoria = "Acessórios", DataValidade = new DateTime(2025, 04, 20) },
    new Produto() { Nome = "Mouse", Preco = 30, Categoria = "Informática", DataValidade = new DateTime(2026, 01, 01) },
    new Produto() { Nome = "Paçoca", Preco = 3, Categoria = "Alimento", DataValidade = new DateTime(2024, 12, 01) },
    new Produto() { Nome = "Notebook", Preco = 3000, Categoria = "Informática", DataValidade = new DateTime(2027, 05, 10) },
    new Produto() { Nome = "Moto", Preco = 30000, Categoria = "Automóvel", DataValidade = new DateTime(2030, 01, 01) }
};


    }
}
