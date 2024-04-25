namespace Proyecto_calculadora
{
    public class Funciones
    {
        public void restar(int a , int b)
        {
            int calculo = a - b;
            Console.WriteLine("La resta de {0} y {1} es : {3} ",a, b, calculo);
        }
        public void dividir(int a , int b)
        {
            int calculo = a / b;
            Console.WriteLine("La division de {0} y {1} es : {3} ",a, b, calculo);
        }
    }
}
