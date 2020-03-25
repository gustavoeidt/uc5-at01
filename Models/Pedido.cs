using System;
using System.Collections.Generic;

namespace mvc.Models
{
    public class Pedido
    {
        List<ItemPedido> itemPedido;

        public  Pedido()
        {
            itemPedido = new List<ItemPedido>();
        }

        public void adicionaPedido(ItemPedido item)
        {
            itemPedido.Add(item);
        }

        public double totalPedido()
        {
            double total = 0;
            foreach (var item in itemPedido)
            {
                total += item.valor_unitario * item.quantidade;
            }
            return total;
        }

        public List<ItemPedido> listar()
        {
            return itemPedido;
        }
    }
}