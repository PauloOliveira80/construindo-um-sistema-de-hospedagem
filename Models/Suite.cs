using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoHotel_DIO.Models
{
    public class Suite
    {
        //Define a classe suíte e os parametros que ela deve receber
        public Suite(string tiposuite, int capacidade, decimal valordiaria)
        {
            TipoSuite = tiposuite;
            Capacidade = capacidade;
            ValorDiaria = valordiaria;
        }
        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public Decimal ValorDiaria { get; set; }
    }
}