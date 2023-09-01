using System;

namespace Agenda.Domain
{
    public interface ITelefone
    {
        Guid ID { get; set; }
        string Numero { get; set; }
        Guid ContatoId { get; set; }
        
    }
}
