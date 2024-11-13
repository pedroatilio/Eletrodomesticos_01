﻿namespace Eletrodomesticos_01.Models
{
    public abstract class Eletrodomestico
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public double ConsumoEnergetico { get; set; }

        public abstract string ExibirDetalhes();
    }
}
