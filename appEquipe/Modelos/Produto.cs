using LiteDB;
namespace Modelos;


public class Produto
{

    [BsonId]
  public int Id_Produto { get; set; }
  public string NomeProduto { get; set; }

}
