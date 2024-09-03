using LiteDB;

namespace Modelos;

public class Cliente : Registro
{
    internal int id;

    [BsonId]
  public int idCliente { get; set; }
  public string Nome { get; set; }
  public string Sobrenome { get; set; }
  public string Telefone { get; set; }
  public string Cpf { get; set; }
  public int Id { get; internal set; }

}