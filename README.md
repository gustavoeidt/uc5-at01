# Atividade 01 da Unidade Curricular 5 do Módulo 1
## Contexto:

A ID Websistemas recebeu a demanda de um sistema simples de registros de pedidos em um bar/restaurante. Caso a ideia evolua, ele poderá ser usado por restaurantes de uma rede local que está interessada em um sistema via web para os controles da rotina dos estabelecimentos.  
Você tem a missão de iniciar os testes com esse projeto criando pequenos protótipos (programas que serão usados como base para a implementação real) que irão servir como prova de conceito para o sistema. Primeiro fará programação de uma aplicação do tipo Console e, em seguida, uma correspondente em ASP.NET Core MVC.  

# Atividade:
### Etapa 1: Faça um sistema de pedidos de restaurante em um projeto Console.

1. Criar uma classe “ItemPedido” com as propriedades “descricao”, “valor_unitario” e “quantidade”.  
2. Criar uma classe “Pedido” com uma propriedade privada do tipo lista (List<>) de “ItemPedido” e métodos para incluir item no pedido e para totalizar o pedido – este, retorna um valor Double com o total de todos os itens da lista.  
3. Inclua também um construtor em “Pedido” para instanciar uma nova lista na propriedade criada.  
4. Crie um programa em que seja possível informar vários itens de um pedido.  
5. O usuário informa descrição, valor e quantidade.  
6. O programa pergunta se deseja inserir novo pedido. Se sim, usuário pode incluir novo pedido. Se não, o programa exibe o total do pedido.  

### Etapa 2: Faça uma versão do sistema anterior, mas usando ASP.NET Core MVC
1. Inclua no projeto, na pasta Models, as classes ItemPedido e Pedido usadas no projeto anterior. Cuidado com os namespaces.  
2. Inclua ainda uma classe chamada “Dados”, com o código a seguir  

```
/****
Classes estáticas não precisam ser instanciadas.
No ASP.NET Core MVC, classes estáticas vivem do início 
ao fim da execução do programa.
Por isso, Dados deve ser usado para manipular as informações
dos pedidos.
Exemplos de uso:
Dados.PedidoAtual.PropriedadeDePedido = "Algum Valor";
Dados.PedidoAtual.MetodoDePedido();
*/

public static class Dados{
   public static Pedido PedidoAtual { get; set;}
   static Dados()
   {
       PedidoAtual = new Pedido();
   }
}
```
3. A classe “Dados” será necessária para manipular os dados no sistema web.  
4. Crie uma página com formulário para registrar um item de pedido. Cada item incluído será registrado no objeto estático “PedidoAtual” da classe “Dados”.  
5. Crie uma segunda página para listar todos os itens do “PedidoAtual” e mostrar, ao fim, o total do pedido.  
