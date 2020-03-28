using System;

namespace EstacaoDDD.Domain.Dominio.Entidades
{
    public class Estacao
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public string Tipo { get; set; }

        public Double Longitude { get; set; }

        public Double Latitude { get; set; }
    }
}

