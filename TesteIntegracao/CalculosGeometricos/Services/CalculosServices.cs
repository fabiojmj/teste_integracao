using CalculosGeometricos.Interfaces;
using CalculosGeometricos.ViewModel;

namespace CalculosGeometricos.Services
{
    public class CalculosServices : ICalculosServices
    {
        public double Potencia(PotenciaViewModel potencia)
        {
            return Math.Pow(potencia.numero, potencia.expoente);
        }

        public double Quadrado(int numero)
        {
            return Math.Pow(numero,2);
        }

        public int Soma(SomaViewModel soma)
        {
            return soma.Numero1 + soma.Numero2;
        }
    }
}
