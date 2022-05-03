using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAgenda.Dominio
{
    public class Tarefa : EntidadeBase
    {
        public Prioridade prioridade;

        public override string Validar()
        {
            throw new NotImplementedException();
        }
    }
}
