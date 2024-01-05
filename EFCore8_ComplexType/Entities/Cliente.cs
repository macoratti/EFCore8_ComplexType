namespace EFCore8_ComplexType.Entities;

public class Cliente
{
    public int ClienteId { get; set; }
    public string? Nome { get; set; }
    public required Endereco Endereco { get; set; }
}
