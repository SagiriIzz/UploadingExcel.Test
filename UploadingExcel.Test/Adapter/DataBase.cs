using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace UploadingExcel.Test.Adapter
{
    public class DataBase
    {
        private readonly string _nameTable;
        private readonly string _idProcess;
        private readonly string _nameProcess;
        private readonly string _divisions;

        public DataBase(string nameTable, string idProcess, string nameProcess, string divisions)
        {
            _nameTable = nameTable;
            _idProcess = idProcess;
            _nameProcess = nameProcess;
            _divisions = divisions;
        }

        public async Task InsertValue()
        {
            var connectionString =
                "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BusProcesss;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            var sqlExpression =
                $"INSERT INTO {_nameTable} (id ,nameProcess, divisions ) VALUES ('{_idProcess}', '{_nameProcess}', '{_divisions}')";

            using (var connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                var command = new SqlCommand(sqlExpression, connection);
            }
        }
    }
}