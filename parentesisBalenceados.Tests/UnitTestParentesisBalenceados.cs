using System;
using Xunit;
using ParentesisBalenceados;

namespace parentesisBalenceados.Tests
{
    public class UnitTestParentesisBalenceados
    {
        [Theory]
        [InlineData("[(()[]())]")]
        public void VerificaParentesis_VerificarParentesisEmOrdemCorreta(string strParentesis)
        {
            bool resultado = Program.VerificaParentesis(strParentesis);
            Assert.True(resultado);
        }
    }
}
