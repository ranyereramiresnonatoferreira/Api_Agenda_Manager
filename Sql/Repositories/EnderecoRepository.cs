using Agenda_Manager.Models.Models;
using Dapper;
using MySqlConnector;

namespace Agenda_Manager.Sql.Repositories
{
    public class EnderecoRepository
    {
        private readonly string connectionString;

        public EnderecoRepository(IConfiguration configuration)
        {
            connectionString = configuration["MySql:ConnectionString"];
        }

        public async Task Add(EnderecoModel endereco)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                await connection.OpenAsync();

                using (var transaction = await connection.BeginTransactionAsync())
                {
                    try
                    {
                        var sql = @"";

                        var parameters = new DynamicParameters();

                        await connection.ExecuteAsync(sql, parameters, transaction);

                        await transaction.CommitAsync();
                    }
                    catch (Exception)
                    {
                        await transaction.RollbackAsync();
                        throw;
                    }
                    finally
                    {
                        await connection.CloseAsync();
                    }
                }
            }
        }
    }
}
