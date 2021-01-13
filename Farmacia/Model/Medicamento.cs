using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Model
{
    class Medicamento
    {

        private int id;
        private string nome;
        private string laboratorio;
        private Queue<Lote> lotes;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Laboratorio
        {
            get { return laboratorio; }
            set { laboratorio = value; }
        }

        public Queue<Lote> Lotes { 
        get { return lotes; }
                }

        public Medicamento(int id, string nome, string laboratorio)
        {
            id = Id;
            nome = Nome;
            laboratorio = Laboratorio;
        }
        public Medicamento()
        {
            this.id = 0;
            this.nome = "";
            this.laboratorio = "";
            this.lotes = new Queue<Lote>(0);
        }

        public override string ToString()
        {
            return this.Id.ToString() + " - " +
                this.nome.ToString() + " - " +
                this.laboratorio.ToString()+" "+
                this.lotes.ToString();

        }

        public int qtdeDisponivel()
        {
            int qtTotal = 0;
            foreach (Lote lote in lotes)
            {
                qtTotal += lote.Qtde;
            }

            return qtTotal;
        }
        public void comprar(Lote lote)
        {
            lotes.Enqueue(lote);
        }

        public bool vender(int qtde)
        {
            int saldo = qtde;
            if (qtdeDisponivel() >= qtde)
            {

                do
                {

                    if(lotes.Peek().Qtde >= saldo)
                    {
                        lotes.Peek().Qtde -= saldo;
                        saldo -= qtde;

                    }
                    else
                    {
                        saldo -= lotes.Dequeue().Qtde;
                    }

                } while (saldo > 0);
                return true;

            }
            else
            {
                return false;
            }



        }

    }
}
