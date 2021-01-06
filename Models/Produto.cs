using System.Collections.Generic;
using System.IO;

namespace MVC_Console.Models
{
    public class Produto
    {
        //atributos
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        private const string PATH = "Database/Produto.csv"; //caminho do arquivo

        //método construtor
        public Produto(){
            string pasta = PATH.Split("/")[0];//split gera um array - vai dividir no /  
            //(a pasta = Database) e (o arquivo = Produto.csv)

            //estrutura condicional 
            if(!Directory.Exists(pasta)){//caso não uma pasta
                Directory.CreateDirectory(pasta);//então, criar uma pasta 
            } 
            
            //estrutura condicional
            if(!File.Exists(PATH)){//caso não exista o arquivo Produto.csv
                File.Create(PATH);//então criar o arquivo
            }
        }

        //método para ler os produtos
        public List<Produto> Ler(){
            
            //lista vazia
            List<Produto> produtos = new List<Produto>();

            //pegar as informações do csv
            string[] linhas = File.ReadAllLines(PATH);

            //estrutura de repetição para leitura de todos itens de cada linha separando em todos ; = atributos
            foreach (var item in linhas)
            {
                //separar atributos pelo ( ; )
                string[] atributos = item.Split(";");

                //Criado um produto vazio para poder colocar na lista final de produtos
                Produto p = new Produto();

                p.Codigo = int.Parse(atributos[0]);//o código do produto será a posição 0 dos atributos
                p.Nome = atributos[1];//o nome do produto será a posição 1 dos atributos
                p.Preco = float.Parse(atributos[2]);//o preço do produto será a posição 2 dos atributos

                produtos.Add(p);//adicionar o produto na lista 
            }

            return produtos;
        }

        //metodo para preparar as linhas do arquivo CSV
        public string PrepararLinhaCSV(Produto prod){
            
            //preparado a linha para o formato CSV
            return $"{prod.Codigo};{prod.Nome};{prod.Preco}";
        }


        //metodo para inserir as linhas no arquivo
        public void Inserir(Produto p){

            //preparado um array de string para o método AppendAllLines
            string[] linhas = {PrepararLinhaCSV(p)};

            //inserido um o array das linhas no arquivo CSV
            File.AppendAllLines(PATH,linhas); 
        }         
    }
}