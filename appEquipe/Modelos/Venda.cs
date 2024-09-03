using LiteDB;
namespace Modelos;

public class Id_Venda
{
    [BsonId]
  public int Id_Da_Venda { get; set; }
  public string Cliente { get; set; }
  public string Total { get; set; }
  public string Desconto { get; set; }
  public string DataDeEntrega{ get; set; }
  public string DataDePedido { get; set; }
  public string ListaintenVenda { get; set; }
}