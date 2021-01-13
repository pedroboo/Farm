using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Farmacia.Model;

namespace Farmacia.Controller
{
    class Medicamentos
    {

        private List<Medicamento> listaMedicamentos;

        public List<Medicamento> ListaMedicamentos
        {
            get { return listaMedicamentos; }
        }

        public Medicamentos()
        {
            listaMedicamentos = new List<Medicamento>();
        }

        public void adicionar(Medicamento medicamento)
        {
            listaMedicamentos.Add(medicamento);
        }
        public bool deletar(Medicamento medicamento)
        {
            bool soDelete = (pesquisar(medicamento).qtdeDisponivel() == 0);

            if (soDelete)
            {
                listaMedicamentos.Remove(medicamento);
            }
                return true;

        }
        

        public Medicamento pesquisar(Medicamento medicamento)
        {
            Medicamento medicamentoProc;
            medicamentoProc = new Medicamento();

            foreach(Medicamento med in listaMedicamentos)
            {
                if (med.Equals(medicamento)){
                    medicamentoProc = med;
                    
                } 
            }

            return medicamentoProc;

        }

    }
}
