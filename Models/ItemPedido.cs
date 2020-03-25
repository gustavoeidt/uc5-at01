using System;
using System.Collections.Generic;

namespace mvc.Models
{
    public class ItemPedido
    {
        public int quantidade {get; set;}
        public String descricao {get; set;}
        public double valor_unitario {get; set;}
        
        public ItemPedido(int qtd, String desc, double vu)
        {
            quantidade = qtd;
            descricao = desc;
            valor_unitario = vu;
        }

        public ItemPedido()
        {
            
        }
    }
}