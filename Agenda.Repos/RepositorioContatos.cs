using System;
using System.Collections.Generic;
using Agenda.DAL;
using Agenda.Domain;

namespace Agenda.Repos
{
    public class RepositorioContatos
    {
        private readonly IContatos _contatos;
        private readonly ITelefones _telefones;

        public RepositorioContatos(IContatos contatos, ITelefones telefones)
        {
            _contatos = contatos;
            _telefones = telefones;
        }

        public IContato obterPorId(Guid Id)
        {
            IContato contato = _contatos.obter(Id);
            List<ITelefone> lstTelefone = _telefones.obterTodosDoContato(Id);
            contato.Telefones = lstTelefone;

            return contato;
        }
    }
}