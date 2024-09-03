using LiteDB;
namespace Modelos;

public class ItemDeVenda
{
     [BsonId]
    public int Id_Venda { get; set; }
    public string NomeVenda { get; set; }
    public string Desconto { get; set; }
    public string Valor { get; set; }
    public string OBS { get; set; }

}
