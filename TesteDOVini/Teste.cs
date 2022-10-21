using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TesteLoginVini;


namespace TesteDOVini
{
    [TestClass]
    public class Teste
    {
        [TestMethod]
        public void CamposOusenhasVazias()
        {

            //Arrange
            string user = "";
            string senha = "";

            LoginUser log = new LoginUser();

            //Ação
            try
            {
                log.Login(user, senha);
            }
            catch (ArgumentOutOfRangeException e)
            {
                //Assert
                StringAssert.Contains(e.Message, LoginUser.MensagemQuandoSenhaForIncorreta);
            }
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => { log.Login(user, senha); });
        }
    }
}
