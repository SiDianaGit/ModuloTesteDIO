using System.Reflection.Metadata;

namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        public int Somar (int num1, int num2)
        {
            return num1 + num2;
        }

        public bool EhPar (int num)
        {
            return num % 2 == 0; //se o resto da divisão retornar 0, então o número é par
        }
    }
}