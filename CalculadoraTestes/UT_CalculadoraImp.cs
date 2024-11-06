using System.Runtime.CompilerServices;
using Calculadora.Services;

namespace CalculadoraTestes;

public class UT_CalculadoraImp //validação de classes
{
    CalculadoraImp _calc = new CalculadoraImp();

    [Fact] //Métodos de teste
    public void Test_Sum_5and10_Return_15()
    {
        //Arrange - Preparar o cenario e variaveis
        int num1 = 5;
        int num2 =10;

        //Act - Fazer a ação de soma, por exemplo
        int resultado = _calc.Somar(num1, num2);

        //Assert - Valida se o resultado da Ação é igual à esperada
        Assert.Equal(15, resultado);
    }

    [Fact] //Métodos de teste
    public void Test_Sum_10and10_Return_20()
    {
        //Arrange - Preparar o cenario e variaveis
        
        int num1 =10;
        int num2 =10;

        //Act - Fazer a ação de soma, por exemplo
        int resultado = _calc.Somar(num1, num2);

        //Assert - Valida se o resultado da Ação é igual à esperada
        Assert.Equal(20, resultado);
    }

    [Fact] //Métodos de teste
    public void Test_EhPar_4_Return_True()
    {
        //Arrange - Preparar o cenario e variaveis
        int num = 4;

        //Act - Fazer a ação de soma, por exemplo
        bool resultado = _calc.EhPar(num);

        //Assert - Valida se o resultado da Ação é igual à esperada
        Assert.True(resultado);
    }
    
    [Theory]  // Valida varios cenarios com um mesmo metodo, com um laço de repeticao
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    [InlineData(10)]
    public void Test_EhPar_Numeros_Return_True(int numero)
    {
        //Arrange - Preparar o cenario e variaveis
        //int num = 4;

        //Act - Fazer a ação de soma, por exemplo
        bool resultado = _calc.EhPar(numero);

        //Assert - Valida se o resultado da Ação é igual à esperada
        Assert.True(resultado);
    }


    [Theory]  // Valida varios cenarios com um mesmo metodo, com um laço de repeticao, refatorado
    [InlineData(new int[] { 2,4,6})]
    [InlineData(new int[] { 8,10,12})]
    public void Test_EhPar_ListNum_Return_True(int[] numeros)
    {
        //Arrange - Preparar o cenario e variaveis
        //int num = 4; substituido por um array

        //Act - Fazer a ação de soma, por exemplo +
        //Assert - Valida se o resultado da Ação é igual à esperada

        foreach (var item in numeros)
        {
            Assert.True(_calc.EhPar(item));
        }
        
        //or

        Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));


    }
}