using Exercicio01.Domain.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01.Domain.Entities
{
    public class Profissional : IEntity
    {
        public Guid Id { get; set; }
        private DateTime? _createAt;
        private DateTime? _updateAt;

        public DateTime? CreateAt { get => _createAt; set => _createAt = value; }
        public DateTime? UpdateAt { get => _updateAt; set => _updateAt = value; }

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

    }
}
