using LiteDB;
namespace Modelos;


public class Fornecedor
{
     [BsonId]
    public int Id_Fornecedor { get; set; }
    public string Nome { get; set; }
    public string CNPJ { get; set; }
    public string Endereço { get; set; }
    public string MateriaPrima { get; set; }
}

