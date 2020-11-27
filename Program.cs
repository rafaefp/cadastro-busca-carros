using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa42
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            CarroDAO dao = new CarroDAOImp();
            Carro carro = new Carro()
            {
                marca = "Honda",
                modelo = "Civic",
                ano = 2016,
                cor = "Marrom"
            };
            dao.cadastrar(carro);
            Console.WriteLine("Carro cadastrado!");
            Console.ReadLine();
            */

            CarroDAO dao = new CarroDAOImp();

            List<Carro> carros = dao.buscarPorModelo("Civic");
            foreach(var item in carros)
            {
                Console.WriteLine(item.marca);
                Console.WriteLine(item.modelo);
                Console.WriteLine(item.ano);
                Console.WriteLine(item.cor);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
