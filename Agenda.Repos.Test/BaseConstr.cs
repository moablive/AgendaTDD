//EXTERNO
using AutoFixture;
using Moq;

namespace Agenda.Repos.Test
{
    public class BaseConstr<T> where T : class
    {
        protected readonly Fixture _fixture;
        protected readonly Mock<T> _mock;

        protected BaseConstr()
        {
            _fixture = new Fixture();
            _mock = new Mock<T>();
        }

        //ITelefone || IContato
        public T Construir()
        {
            return _mock.Object;
        }

        public Mock<T> Obter()
        {
            return _mock;
        }
    }
}
