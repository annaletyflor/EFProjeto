namespace EFExemplo.Models
{
    public class Cliente
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateOnly DataNascimento { get; set; }
    }
}
