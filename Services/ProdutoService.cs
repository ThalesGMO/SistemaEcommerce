using System.Security.Cryptography.X509Certificates;
using SistemaEcommerce.Classe;
using SistemaEcommerce.Classes;
using SistemaEcommerce.Enum;
using SistemaEcommerce.Interface;
using SistemaEcommerce.Interfaces;

namespace SistemaEcommerce.Service;

public class ProdutoService
{
    private IProdutoRepository ProdutoRepositoryGlobal;
    private INotification NotificationGlobal;

    public ProdutoService(IProdutoRepository produtoRepositoryRecebido, INotification notificationRecebido)
    {
        ProdutoRepositoryGlobal = produtoRepositoryRecebido;
        NotificationGlobal = notificationRecebido;
    }

    public void AdicionarProdutoFisico(string nome, decimal preco, string codigoProduto, int quantidadeEstoque)
    {
        ProdutoFisico produtoFisico = new ProdutoFisico(nome, preco, codigoProduto, quantidadeEstoque);

        if (produtoFisico.SetEstoque(quantidadeEstoque) != null)
        {
            ProdutoRepositoryGlobal.AdicionarProduto(produtoFisico);
            return;
        }
        NotificationGlobal.AdicionarNotificacao("Produto não cadastrado, erro no estoque inserido", NotificationEnum.Erro);
    }

    public void AdicionarProdutoVirtual(string nome, decimal preco, string codigoProduto, double tamanhoMb)
    {
        ProdutoVirtual produtoVirtual = new ProdutoVirtual(nome, preco, codigoProduto, tamanhoMb);

        if (produtoVirtual.SetTamanho(tamanhoMb) != null)
        {
            ProdutoRepositoryGlobal.AdicionarProduto(produtoVirtual);
            return;
        }
        NotificationGlobal.AdicionarNotificacao("Produto não cadastrado, erro no tamanho do produto", NotificationEnum.Erro);
    }

    public void ListarProdutos(int escolha)
    {
        if (ProdutoRepositoryGlobal.ListarProdutos().Count() == 0)
        {
            NotificationGlobal.AdicionarNotificacao("Não existem produtos para listar nesse momento", NotificationEnum.Erro);
            return;
        }

        foreach (Produto produto in ProdutoRepositoryGlobal.ListarProdutos())
        {
            if (produto is ProdutoFisico && escolha == 1)
                Console.WriteLine(produto.ToString());
            else if (produto is ProdutoVirtual && escolha == 2)
                Console.WriteLine(produto.ToString());
            else
                Console.WriteLine(produto.ToString());
        }
    }

    public void RemoverProduto(string codigoEscolhido)
    {
        ProdutoRepositoryGlobal.RemoverProduto(ProdutoRepositoryGlobal.ListarProdutos().FirstOrDefault(produto => produto.CodigoProduto == codigoEscolhido));
    }
}
