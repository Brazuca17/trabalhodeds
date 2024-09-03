using LiteDB;
using Modelos;

namespace Controle;

public class ControleFornecedor : BaseControle
{
  //----------------------------------------------------------------------------

  public ControleFornecedor() : base()
  {
    NomeDaTabela = "Fornecedores";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int Id_Fornecedor)
  {
    var collection = liteDB.GetCollection<Cliente>(NomeDaTabela);
    return collection.FindOne(d => d.id == Id_Fornecedor);
  }

  //----------------------------------------------------------------------------

  public virtual List<Fornecedor>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Fornecedor>(NomeDaTabela);
    return new List<Fornecedor>(tabela.FindAll().OrderBy(d => d.Id_Fornecedor));
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int Id_Fornecedor)
  {
    var collection = liteDB.GetCollection<Fornecedor>(NomeDaTabela);
    collection.Delete(Id_Fornecedor);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Fornecedor Fornecedor)
  {
    var collection = liteDB.GetCollection<Fornecedor>(NomeDaTabela);
    collection.Upsert(Fornecedor);
  }

  //----------------------------------------------------------------------------
}