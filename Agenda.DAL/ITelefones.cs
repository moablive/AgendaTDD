using System;
using System.Collections.Generic;
using Agenda.Domain;

namespace Agenda.DAL
{
    public interface ITelefones
    {
        List<ITelefone> obterTodosDoContato(Guid ContatoId);
    }
}