using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sharpcoder2_TechLife_Coinnecta_Backend.Domain.Model;

    public class Conta : Entity
    {
    public string? NumeroConta { get; set; }
    public DateTime DataAbertura = DateTime.Now;
    public TipoConta TipoConta { get; set; }
    public StatusConta StatusConta { get; set; }
    public double Saldo { get; set; } 

public double TaxaRendimento { get; set; }  = 0.005;
    // public double AtualizarBalanco(double quantia)
    
   
}

public enum TipoConta
{
    Corrente,
    Poupanca
}

public enum StatusConta
{
    Ativa,
    Inativa
}



