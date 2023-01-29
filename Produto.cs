using System.Globalization;

namespace Produtos {
    class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;

        // Construtor 1
        public Produto(string nome, double preco, int quantidade) {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        // SOBRECARGA

        // Construtor 2
        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
            Quantidade = 5;
        }

        // Construtor 3

        public Produto() {
            
        }

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade){
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            string content = $"{Nome}, $ {Preco.ToString("F2", CultureInfo.InvariantCulture)}, {Quantidade} unidades, Total: $ {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";

            return content;
        }
    }
}