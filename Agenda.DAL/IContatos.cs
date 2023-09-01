using System;
using Agenda.Domain;

namespace Agenda.DAL
{
    public interface IContatos
    {
        IContato obter(Guid  Id);
    }
}