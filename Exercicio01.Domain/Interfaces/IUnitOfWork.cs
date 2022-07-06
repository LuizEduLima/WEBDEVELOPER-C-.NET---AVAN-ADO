using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01.Domain.Interfaces
{

    public interface IUnitOfWork : IDisposable
    {
        void BeginTransaction();
        void CommitTransaction();
        void RollbackTransaction();
       

        public IProfissionalRepository ProfissionalRepository { get; set; }


    }
}
