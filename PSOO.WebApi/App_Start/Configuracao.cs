using PSOO.IDAO;
using System.Configuration;

namespace PSOO.WebApi.App_Start
{
    public class Configuracao : IConexao
    {
        public string ConnectionString { get; }

        public string DedaultSchemaDB { get; }

        public Configuracao()
        {
            this.DedaultSchemaDB =  ConfigurationManager.AppSettings["defaultSchema"];
            this.ConnectionString = ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;
        }
    }
}