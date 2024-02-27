using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using ProjetoHotel_DIO.Models;


namespace ProjetoHotel_DIO.Models
{
    public class Reserva(int diasreservados)
    {
       public List<Pessoa> Hospede { get; set; }
       public Suite Suite {get; set; }
        public int DiasReservados { get; set; } = diasreservados;

        //Realiza o cadastro dos hóspedes
        public void CadastrarHospedes(List<Pessoa> hospede){
            
            if (hospede.Count() < Suite.Capacidade){
              Hospede = hospede;
            }
            else{
                throw new Exception("Já foi atingido a quantidade máxima de pessoas para esse quarto.");
            }
        }
        
        //Realiza o cadastro da Suíte
        public void CadastrarSuite(Suite suite){
                Suite = suite;
        }

        //Obtem a Quantidade de hóspedes com base no count da lista de hospedes
        public int ObterQuantidadedeHospedes(){
            return Hospede.Count();
        }


        //Realiza o calculo da diária no hotel, levando em conta os 10% de desconto quando o hóspede for ficar mais que 10 dias.
        public decimal CalcularValorDiaria(){

            decimal ValorTotal = 0;
            if (DiasReservados > 10){
                
                decimal ValorTotalSemDesconto = DiasReservados * Suite.ValorDiaria;
                ValorTotal = ValorTotalSemDesconto * 0.90M;
            }
            else{
                 ValorTotal = DiasReservados * Suite.ValorDiaria;
            }
            
            return ValorTotal;
        }
}
}