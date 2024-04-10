using CalculosGeometricos.ViewModel;

namespace CalculosGeometricos.Interfaces
{
    public interface ICalculosServices
    {
        int Soma(SomaViewModel soma);

        double Potencia(PotenciaViewModel potencia);

        double Quadrado(int numero);
    }
}
