using LiteDB;

namespace Modelos;

public class MateriaPrima : Registro
{
  [BsonId]
  public int idMateriaPrima { get; set; }
  public string Nome { get; set; }
  public string Quantidade { get; set; }
  public string Peso { get; set; }
}

