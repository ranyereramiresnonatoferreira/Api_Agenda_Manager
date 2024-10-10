namespace Agenda_Manager.Sql
{
    public class DBConnect
    {
        public string GetConnectionString(IConfiguration configuration)
        {
            var host = configuration["MySql:Host"];
            var port = configuration["MySql:Port"];
            var userName = configuration["MySql:UserName"];
            var password = configuration["MySql:Password"];
            var database = configuration["MySql:DataBase"];

            return $"Server={host};Port={port};User Id={userName};Password={password};Database={database};";
        }
    }
}
