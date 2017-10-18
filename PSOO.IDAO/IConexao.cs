namespace PSOO.IDAO
{
    public interface IConexao
    {
        string ConnectionString { get; }
        string DedaultSchemaDB { get; }
    }
}
