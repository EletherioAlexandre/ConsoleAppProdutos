using System.Globalization;
using Produtos;
internal class Program
{
    private static void Main(string[] args)
    {
        // Console.WriteLine("Entre os dados do produto:");

        // Console.Write("Nome: ");
        // string nome = Console.ReadLine();

        // Console.Write("Preço: ");
        // double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        // Produto p = new Produto(nome, preco);

        Produto p = new Produto("TV", 500.00, 10);


        System.Console.WriteLine(p.Nome);
        System.Console.WriteLine("OK!");
        System.Console.WriteLine();
        System.Console.Write("Insira um novo nome: ");
        string newName = Console.ReadLine();

        p.Nome = newName;

        System.Console.Write("Novo nome: " + p.Nome);


        // Console.WriteLine();
        // Console.WriteLine("Dados do produto: " + p);
        // Console.WriteLine();

        // Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
        // int qte = int.Parse(Console.ReadLine());
        // p.AdicionarProdutos(qte);

        // Console.WriteLine();
        // Console.WriteLine("Dados atualizados: " + p);
        // Console.WriteLine();

        // Console.Write("Digite o número de produtos a ser removido do estoque: ");
        // qte = int.Parse(Console.ReadLine());
        // p.RemoverProdutos(qte);

        // Console.WriteLine();
        // Console.WriteLine("Dados atualizados: " + p);
    }
}