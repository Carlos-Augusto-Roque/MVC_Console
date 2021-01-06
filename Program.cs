using System;
using MVC_Console.Controllers;
using MVC_Console.Models;

namespace MVC_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //instaciado um Produto e colocado para rodar o programa
            //então como não existia nenhuma pasta e nenhum arquivo , o programa criou (pasta = Database e arquivo = Produto.csv) 
            // Produto p1 = new Produto();

            //instanciado a classe produto controller 
            ProdutoController produtoController = new ProdutoController();

            produtoController.Cadastrar();

            produtoController.MostrarProdutos();//executar o método mostrar produtos
        }
    }
}
