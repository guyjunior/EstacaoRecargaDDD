using EstacaoDDD.Domain.Dominio.Entidades;
using EstacaoDDD.Domain.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstacaoDDD.Infra.Dados.Repositorio
{
    public class EstacaoRepositorio : RepositorioBase<Estacao>, IEstacao
    {
        public Estacao RecuperarPorNome(string nome)
        {
            throw new NotImplementedException();
        }
    }
}

