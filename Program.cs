
using System.Text;
using ProjetoHotel_DIO.Models;

// Cria a lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

//Cria duas Pessoas
Pessoa p1 = new Pessoa("Hospede1", "Sobrenome1");
Pessoa p2 = new Pessoa ("Hospede2", "Sobrenome2");

//Adiciona as duas pessoas a lista de hóspedes
hospedes.Add(p1);
hospedes.Add(p2);

//Define as caracteristicas da Suite
Suite suite = new Suite("Premium", 4, 30);

//Cadastra a quantidade de dias que o usuario irá ficar no hotel
Reserva reserva = new Reserva(11);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);


// Mostra no console a quantidade de hóspedes e o calculo do valor da diária.
Console.WriteLine($"A lista de hospedes é : {reserva.ObterQuantidadedeHospedes()}");
Console.WriteLine($"O valor da diária ficou em: {reserva.CalcularValorDiaria()}");
