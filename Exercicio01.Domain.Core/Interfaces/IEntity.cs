namespace Exercicio01.Domain.Core.Interfaces
{
    public interface IEntity
    {
        public Guid Id { get; set; }
        public DateTime? CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }

    }

}
