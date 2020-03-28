using EstacaoDDD.Domain.Dominio.Interfaces;
using EstacaoDDD.Domain.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstacaoDDD.Domain.Dominio.Interfaces
{
    public interface ITipoRecarga : IBase<TipoRecarga>
    {
        //Herdar todos os métodos de IBase
        //TODO: Outros contratos relevantes para produto
        //Exemplo: RecuperarPorNome()

        TipoRecarga RecuperarPorNome(string nome);
    }
}
