using System;

//Comandos
//dotnet add package MySqlConnector
//dotnet add package Npgsql -- dotnet add testeProjetoExtensão.csproj package Npgsql
//dotnet add C:\Users\luanp\source\repos\testeProjetoExtensão\testeProjetoExtensão.csproj package MySqlConnector
//dotnet build

using System;
using System.Threading.Tasks;
using Npgsql;

namespace testeProjetoExtensão.resources.classes
{
    internal class clsConexao
    {
        public static NpgsqlConnection Conexao { get; private set; } = null!;
        private static string connectionString = "Host=127.0.0.1;Port=5432;Database=DB_AVALIACAO;Username=postgres;Password=3237;";

        public async Task getConexao()
        {
            if (ConexaoAtiva())
            {
                Console.WriteLine("A conexão já está aberta.");
                return;
            }

            Conexao = new NpgsqlConnection(connectionString);

            try
            {
                await Conexao.OpenAsync();
                Console.WriteLine("Conexão aberta com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao conectar ao banco de dados: " + ex.Message);
            }
        }

        public async Task closeConnection()
        {
            if (!ConexaoAtiva())
            {
                Console.WriteLine("A conexão já está fechada.");
                return;
            }

            try
            {
                await Conexao.CloseAsync();
                Console.WriteLine("Conexão fechada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao fechar a conexão: " + ex.Message);
            }
        }

        public static bool ConexaoAtiva()
        {
            if (Conexao == null) { return false; }
            if (Conexao.State == System.Data.ConnectionState.Closed) { return false; }
            if (Conexao.State == System.Data.ConnectionState.Broken) { return false; }

            return Conexao.State == System.Data.ConnectionState.Open;
        }
    }
}
