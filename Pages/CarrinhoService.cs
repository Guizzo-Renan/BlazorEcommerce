using System.Collections.Generic;

public class CarrinhoService
    {
        private List<ItemCarrinho> itensCarrinho = new List<ItemCarrinho>();
        

        public void AdicionarItemCarrinho(int produtoId, string nome, decimal preco, string imagem,int quantidade)
        {
          /*  var itemExistente = itensCarrinho.FirstOrDefault(item => item.ProdutoId == produtoId);

            if (itemExistente != null)
            {
                itemExistente.Quantidade += quantidade;
            }
            else
            {
*/

            
                var novoItem = new ItemCarrinho
                {
                    ProdutoId = produtoId,
                    Nome = nome,
                    Preco = preco,
                    Quantidade = quantidade,
                    Imagem = imagem
                };


                
                itensCarrinho.Add(novoItem);
              //  Console.WriteLine(itensCarrinho);
           // }
        }
        //}
   /*   public void AdicionarItemCarrinho(ItemCarrinho item)
        {
            itensCarrinho.Add(item);
        }
        */
        public List<ItemCarrinho> ObterItensCarrinho()
        {
            return itensCarrinho;
        }

     /*    public void AdicionarItemCarrinho(ItemCarrinho item)
        {
            itensCarrinho.Add(item);
        }
*/
        // Get the items in the cart
        public List<ItemCarrinho> GetItensCarrinho()
        {
            return itensCarrinho;
        }







        /*public void RemoverItemCarrinho(int itemId)
        {
            // Remove o item do carrinho com base no ID do produto
            var itemParaRemover = _itensCarrinho.FirstOrDefault(item => item.Produto.Id == itemId);

            if (itemParaRemover != null)
            {
                _itensCarrinho.Remove(itemParaRemover);
            }
        }

        public void LimparCarrinho()
        {
            // Limpa todos os itens do carrinho
            _itensCarrinho.Clear();
        }*/
    }


/*using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorApp.Shared
{
    public class CarrinhoService
    {
        private List<ItemCarrinho> _itensCarrinho;

        public CarrinhoService()
        {
            // Inicializa a lista de itens do carrinho vazia
            _itensCarrinho = new List<ItemCarrinho>();
        }

        public List<ItemCarrinho> GetItensCarrinho()
        {
            return _itensCarrinho;
        }

        public void AdicionarItemCarrinho(Produto produto, int quantidade)
        {
            // Verifica se o item já existe no carrinho
            var itemExistente = _itensCarrinho.FirstOrDefault(item => item.Produto.Id == produto.Id);

            if (itemExistente != null)
            {
                // Se o item já existe, atualiza a quantidade
                itemExistente.Quantidade += quantidade;
            }
            else
            {
                // Se o item não existe, adiciona um novo item ao carrinho
                var novoItem = new ItemCarrinho
                {
                    Produto = produto,
                    Quantidade = quantidade
                };
                _itensCarrinho.Add(novoItem);
            }
        }
*/