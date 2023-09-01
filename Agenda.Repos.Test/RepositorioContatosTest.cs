using System;
using System.Collections.Generic;
using Agenda.Domain;
using Agenda.DAL;

//Externo
using NUnit.Framework;
using Moq;

namespace Agenda.Repos.Test
{
    [TestFixture]
    public class RepositorioContatosTest
    {
        Mock<IContatos> _contatos;
        Mock<ITelefones> _telefones;
        RepositorioContatos _repositorioContatos;

        [SetUp]
        public void Setup()
        {
            _contatos = new Mock<IContatos>();
            _telefones = new Mock<ITelefones>();
            _repositorioContatos = new RepositorioContatos(_contatos.Object, _telefones.Object);
        }

        [Test]
        public void DeveSerPossivelObterContatoComListaTelefone()
        {
            var telefoneId = Guid.NewGuid();
            var contatoId = Guid.NewGuid();
            var lstTelefone = new List<ITelefone>();
            //Montagem

            //Moq de IContato
           var mContato = IContatoConstr
                .Um()
                .ComId(contatoId)
                .ComNome("JOAO")
                .Obter();

            mContato.SetupSet(o => o.Telefones = It.IsAny<List<ITelefone>>())
                .Callback<List<ITelefone>>(p => lstTelefone = p);

                //Moq da função obterporID de IContatos
                _contatos.Setup(o => o.obter(contatoId))
                    .Returns(mContato.Object);

            //Moq de ITelefone
            ITelefone mockTelefone = ITelefoneConstr
                .Um()
                .Padrao()
                .ComId(telefoneId)
                .ComContatoId(contatoId)
                .Construir();

                //Moq da funcao obterTodosDoContato de ITelefones
                _telefones.Setup(o => o.obterTodosDoContato(contatoId))
                    .Returns(new List<ITelefone> { mockTelefone });

            //Executa
                //Chamar o metodo obterPorId de RepositorioContatos
                var contatoResultado = _repositorioContatos.obterPorId(contatoId);
                mContato.SetupGet(o => o.Telefones).Returns(lstTelefone);

            //Verifica
                //Verificar se o contato retornado contem os mesmo dados de Moq (Icontato) (ITelefone)
                Assert.AreEqual(mContato.Object.Id, contatoResultado.Id);
                Assert.AreEqual(mContato.Object.Nome, contatoResultado.Nome);
                Assert.AreEqual(1,contatoResultado.Telefones.Count);
                Assert.AreEqual(mockTelefone.Numero, contatoResultado.Telefones[0].Numero);
                Assert.AreEqual(mockTelefone.ID, contatoResultado.Telefones[0].ID);
                Assert.AreEqual(mContato.Object.Id, contatoResultado.Telefones[0].ContatoId);
        }

        [TearDown]
        public void TearDown()
        {
            _contatos = null;
            _telefones = null;
            _repositorioContatos = null;
        }
        
    }
}