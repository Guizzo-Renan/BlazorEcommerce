using System.Collections.Generic;

public class ProdutoService
{
    private Produto itensDoCarrinho;

    public ProdutoService()
    {
        itensDoCarrinho = new Produto();
    }

    public void AdicionarProduto(Produto produto)
    {
        itensDoCarrinho = produto;
    }

    public Produto ObterItensDoCarrinho()
    {
        return itensDoCarrinho;
    }
}
