using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa42
{
    public interface CarroDAO
    {
        void cadastrar(Carro carro);
        List<Carro> buscarPorModelo(string modelo);
    }
}
