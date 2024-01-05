using EFCore8_ComplexType;
using EFCore8_ComplexType.Entities;

using var _context = new AppDbContext();

//var endereco = new Endereco("1024500", "Rua Projetada 100", "Betim", "MG");

//var cliente1 = new Cliente
//{
//    Nome = "Maria",
//    Endereco = endereco
//};

//var cliente2 = new Cliente
//{
//    Nome = "Pedro",
//    Endereco = endereco
//};

//_context.Clientes.Add(cliente1);
//_context.Clientes.Add(cliente2);
//_context.SaveChanges();

//cliente1.Endereco = cliente1.Endereco with { Local = "Rua Projetada 300" };
//_context.SaveChanges();

//var endereco = _context.Clientes.Select(e => e.Endereco).First();

var clientes = _context.Clientes.Where(e => e.Endereco.Estado == "SP").ToList();

Console.ReadKey();