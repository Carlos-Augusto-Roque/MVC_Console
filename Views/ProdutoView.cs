using System;
using System.Collections.Generic;
using MVC_Console.Models;

namespace MVC_Console.Views
{
    public class ProdutoView
    {
        //método para listar os produtos
        public void ListarTodos(List<Produto> produtos){

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            System.Console.WriteLine("---Lista dos Produtos---");
            System.Console.WriteLine();

            //leitura dos atributos de cada produto
            foreach (Produto item in produtos)
            {
                System.Console.WriteLine($"Código: {item.Codigo}");
                System.Console.WriteLine($"Nome: {item.Nome}");
                System.Console.WriteLine($"Preço: R$ {item.Preco}");
                System.Console.WriteLine();
            }
            
            Console.ResetColor();
        }
    }
}