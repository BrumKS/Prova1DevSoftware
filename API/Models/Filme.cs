// PROP - cria a propriedade

using System;

namespace API.Models
{
    public class Filme
    {
        public Filme() => CriadoEm = DateTime.Now;

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string Distribuidora { get; set; }
        public int Classificacao { get; set; }
        
        public DateTime CriadoEm { get; set; }

        public override string ToString() =>
            $"Nome: {Nome} | tipo: {Tipo} | Distribuidora: {Distribuidora} | Classificação: {Classificacao} | Criado Em: {CriadoEm} ";
        
    }
}