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

        //metodo para cadastrar os produtos
        public Produto CadastrarProduto(){

            Produto produto = new Produto();//instaciado um objeto Produto

            System.Console.Write($"Código do Produto: ");
            produto.Codigo = int.Parse(Console.ReadLine());

            System.Console.Write($"Descrição do Produto: ");
            produto.Nome = Console.ReadLine();
            
            System.Console.Write($"Preço do Produto: R$ ");
            produto.Preco = float.Parse(Console.ReadLine());

            return produto;
        }
    }
}