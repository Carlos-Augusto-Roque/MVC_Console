using System.Collections.Generic;
using MVC_Console.Models;
using MVC_Console.Views;

namespace MVC_Console.Controllers
{
    public class ProdutoController
    {
        //instaciado a classe produto
        Produto produto = new Produto();

        //instaciado a classe produto view
        ProdutoView produtoView = new ProdutoView();


        //metodo para cadastrar produto
        public void Cadastrar(){

            produto.Inserir(produtoView.CadastrarProduto());
        }

        
        //método para mostrar os produtos
        public void MostrarProdutos(){
            List<Produto> todos = produto.Ler();//captura das informações do csv
            produtoView.ListarTodos(todos);//lista as informações no view
        }
    }
}