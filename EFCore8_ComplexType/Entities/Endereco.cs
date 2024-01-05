using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore8_ComplexType.Entities;

public record Endereco(string Cep, string Local, string Cidade, string Estado);

