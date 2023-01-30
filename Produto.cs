using System.Globalization;

namespace Produtos
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto() {
        }

        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        // Propertie definindo a operação de GET e SET
        public string Nome {
            get { return _nome; }
            set 
            { 
                if (value != null && value.Length > 1) 
                {
                    _nome = value;
                }
            }
        }

        public double Preco {
            get { return _preco; }
        }

        public int Quantidade {
            get { return _quantidade; }
        }



        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }

        public override string ToString()
        {
            string content = $"{_nome}, $ {_preco.ToString("F2", CultureInfo.InvariantCulture)}, {_quantidade} unidades, Total: $ {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";

            return content;
        }
    }
}