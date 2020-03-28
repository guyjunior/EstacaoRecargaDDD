using EstacaoDDD.Domain.Dominio.Entidades;
using EstacaoDDD.Domain.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstacaoDDD.Infra.Dados.Repositorio
{
    public class TipoRecargaRepositorio : RepositorioBase<TipoRecarga>, ITipoRecarga
    {
        //Por herança já possui os métodos CRUD 
        //Por Implementar IProduto, precisa implementar o método RecuperarPorNome:
        public TipoRecarga RecuperarPorNome(string nome)
        {
            throw new NotImplementedException();
        }
    }
}
