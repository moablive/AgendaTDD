using System;
using System.Collections.Generic;

//Imports
using System.Configuration;
using System.Linq;
using Dapper;
using Agenda.Domain;
using System.Data.SqlClient;

namespace Agenda.DAL
{
    public class Contatos
    {
        //String DB
        string _strCon;
        public Contatos()
        {
            // Agenda.DALL.Test {app.config} 
            _strCon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        }

        public void Adicionar(Contato contato)
        {
            using (var con = new SqlConnection(_strCon))
            {
                con.Execute("INSERT INTO Contato (Id, Nome) VALUES (@Id, @Nome)", contato);
            }
        }

        public Contato Obter(Guid id)
        {
            Contato contato;

            using (var con = new SqlConnection(_strCon))
            {
                contato = con.QueryFirst<Contato>("select Id, Nome from Contato where Id = @Id", new { Id = id });
            }
            return contato;
        }

        public List<Contato> obterTodos()
        {
            var contatos = new List<Contato>();

            using (var con = new SqlConnection(_strCon))
            {
                contatos = con.Query<Contato>("select Id, Nome from Contato").ToList();
            }
            return contatos;
        }
    }
}
