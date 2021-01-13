using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Farmacia.Controller;
using Farmacia.Model;

namespace Farmacia
{
    class Program
    {


        static void Main(string[] args)
        {
            string op;
            int opl;
            Medicamentos m = new Medicamentos();
            Lote l = new Lote();

            Console.WriteLine("Farmacia da Ana");

            do {
                Console.WriteLine(" 0 - Finalizar Processo");
                Console.WriteLine(" 1 - Cadastrar Medicamento");
                Console.WriteLine(" 2 - Consultar Medicamento");
                Console.WriteLine(" 3 - Consultar Medicamento**");
                Console.WriteLine(" 4 - Comprar Medicamento");
                Console.WriteLine(" 5 - Vender Medicamento");
                Console.WriteLine(" 6 - Listar Medicamento");
                op = Console.ReadLine();
                
                while(!int.TryParse(op,out opl))
                {
                    Console.WriteLine("Informe uma opção válida");
                    op = Console.ReadLine();

                }
                switch (opl)
                {
                    case 1:
                        Console.WriteLine("");

                        Console.WriteLine("id");
                        int x = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nome medicamento");
                        string y = Console.ReadLine();
                        Console.WriteLine("Laboratorio ");
                        string xx = Console.ReadLine();

                        m.adicionar(x,y,  xx);

                        break;
                    case 2:
                        break;

                }

            } while (opl != 0);

            Console.ReadKey();
        }
    }
}
