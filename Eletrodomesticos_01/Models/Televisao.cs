using System.Reflection;
using System.Text.RegularExpressions;

namespace Eletrodomesticos_01.Models
{
    public class Televisao : Eletrodomestico
    {
        public int TamanhoTela { get; set; }
        public bool EhSmart { get; set; }
        public override string ExibirDetalhes()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}, Consumo: {ConsumoEnergetico}, Tela: {TamanhoTela}, Smart: {(EhSmart ? "Sim" : "Não")}";
        }
    }
}
