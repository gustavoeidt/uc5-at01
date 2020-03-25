/****
Classes estáticas não precisam ser instanciadas.
No ASP.NET Core MVC, classes estáticas vivem do início 
ao fim da execução do programa.
Por isso, Dados deve ser usado para manipular as informações
dos pedidos.
Exemplos de uso:
Dados.PedidoAtual.PropriedadeDePedido = "Algum Valor";
Dados.PedidoAtual.MetodoDePedido();
*****/

namespace mvc.Models
{
    public static class Dados{
        public static Pedido pedidoAtual {get; set;}
        static Dados()
        {
            pedidoAtual = new Pedido();
        }

        public static void incluir(ItemPedido itemPedido)
        {
            pedidoAtual.adicionaPedido(itemPedido);
        }

        public static Pedido listar()
        {
            return pedidoAtual;
        }
    }
}