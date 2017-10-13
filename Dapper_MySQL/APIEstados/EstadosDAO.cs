using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using Dapper.Contrib.Extensions;

namespace APIEstados
{
    public class EstadosDAO
    {
        private IConfiguration _configuracoes;

        public EstadosDAO(IConfiguration config)
        {
            _configuracoes = config;
        }

        public IEnumerable<Estado> ListarTodos()
        {
            using (MySqlConnection conexao = new MySqlConnection(
                _configuracoes.GetConnectionString("BaseEstados")))
            {
                return conexao.GetAll<Estado>();
            }
        }
    }
}