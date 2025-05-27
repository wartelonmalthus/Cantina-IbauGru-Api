using CantinaIbauGru.Domain.Entities;

namespace CantinaIbauGru.Domain;

public class teste
{
    public  void testeMetodo()
    {
        Product teste = new Product();

        var id = teste.CreateAt;

        var dataatual = teste.MudarDataDeCriacao(DateTime.Now);

    }
}
