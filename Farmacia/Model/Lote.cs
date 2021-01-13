using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.Model
{
    class Lote
    {
        private int id;
        private int qtde;
        private DateTime vencimento;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Qtde
        {
            get { return qtde; }
            set { qtde = value; }
        }
        public DateTime Vencimento
        {
            get { return vencimento; }
            set { vencimento = value; }
        }

        public Lote() {
            this.id = 0;
            this.qtde = 0;
            this.vencimento = new DateTime(0);
        }

        public Lote(int id, int qtde, DateTime vencimento)
        {

            this.id = Id;
            this.qtde = Qtde;
            this.vencimento = Vencimento;

        }

        public override string ToString()
        {
            return Id.ToString() + " - " + Qtde.ToString() + 
                " - "+Vencimento.ToString();
        }

    }
}
