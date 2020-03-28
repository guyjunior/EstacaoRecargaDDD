using System;
using System.Collections.Generic;
using System.Text;
using EstacaoDDD.Domain.Dominio.Entidades;


namespace EstacaoDDD.Domain.Dominio.Interfaces
{
    public interface IEstacao : IBase<Estacao>
    {
        //Herdando todos os métodos de IBase
        public Estacao RecuperarPorNome(string nome);
        
    }
}
