using System.Linq;
using Agenda.DAL;
using Agenda.Domain;

//EXTERNOS
using NUnit.Framework;
using AutoFixture;

namespace Agenda.DALL.Test 
{
    public class ContatosTest
    {
        private Contatos _contatos;
        Fixture _fixture;
      
        // RODA ANTES DOS TESTE
        [SetUp]
        public void Setup()
        {
            _contatos = new Contatos();
            _fixture = new Fixture();
        }

        [Test]
        public void AdicionarContatoTest()
        {
            //CRIANDO COM Fixture o contato
            var contato = _fixture.Create<Contato>();
            _contatos.Adicionar(contato);

            Assert.True(true);
        }

        [Test]
        public void obterTodosOsContatosTest()
        {
            //CRIANDO COM Fixture o contato
            var contato1 = _fixture.Create<Contato>();
            var contato2 = _fixture.Create<Contato>();

            //ADD contato 1 e 2
            _contatos.Adicionar(contato1);
            _contatos.Adicionar(contato2);
            var listConato = _contatos.obterTodos();
            var contatoResultado = listConato.Where(o => o.Id == contato1.Id).FirstOrDefault();

            //Verifica
            Assert.IsTrue(listConato.Count() > 1);
            Assert.AreEqual(contato1.Id, contatoResultado.Id);
            Assert.AreEqual(contato1.Nome, contatoResultado.Nome);
        }

        [Test]
        public void ObterContatoTest()
        {
            //CRIANDO COM Fixture o contato
            Contato contato = _fixture.Create<Contato>();
            Contato contatoResultado;

            _contatos.Adicionar(contato);
            contatoResultado = _contatos.Obter(contato.Id);

            Assert.AreEqual(contato.Id, contatoResultado.Id);
            Assert.AreEqual(contato.Nome, contatoResultado.Nome);
        }

        //RODA DEPOIS de CADA TESTE
        [TearDown]
        public void TearDown()
        {
            _contatos = null;
            _fixture = null;
        }
    }
}
