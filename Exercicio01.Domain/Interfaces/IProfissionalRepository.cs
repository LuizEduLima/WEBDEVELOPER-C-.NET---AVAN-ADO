using Exercicio01.Domain.Core.Interfaces;
using Exercicio01.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01.Domain.Interfaces
{
    public interface IProfissionalRepository : IRepository<Profissional, Guid>
    {
        Task<Profissional> GetById(string Cpf);
        Task<Profissional> GetByTelefone(string Telefone);
        Task<Profissional> GetByEmal(string Email);
    }
}
