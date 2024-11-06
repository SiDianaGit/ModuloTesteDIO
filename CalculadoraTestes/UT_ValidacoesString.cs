using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;

namespace CalculadoraTestes
{
    public class UT_ValidacoesString
    {

        ValidacoesString _vStr = new ValidacoesString();
            
        [Fact] //Métodos de teste
        public void Test_String_abcde_Return_5()
        {
            //Arrange - Preparar o cenario e variaveis
            string texto = "abcde";

            //Act - Fazer a ação de soma, por exemplo
            int resultado = _vStr.ContarCaracteres(texto);

            //Assert - Valida se o resultado da Ação é igual à esperada
            Assert.Equal(5, resultado);
        }    
    }
}