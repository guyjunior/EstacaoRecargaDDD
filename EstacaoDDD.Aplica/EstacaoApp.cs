using System;
using System.Collections.Generic;
using System.Text;
using EstacaoDDD.Domain.Dominio.Interfaces;
using EstacaoDDD.Domain.Dominio.Entidades;
using EstacaoDDD.Aplica;


namespace EstacaoDDD.Aplica
{
    public class EstacaoApp : IEstacaoApp
    {
        IEstacao _estacaoInterface;

        public EstacaoApp(IEstacao estacaoInterface)
        {
            _estacaoInterface = estacaoInterface;
        }

        public void Adicionar(Estacao obj)
        {
            _estacaoInterface.Adicionar(obj);
        }

        public void Atualizar(Estacao obj)
        {
            _estacaoInterface.Atualizar(obj);
        }

        public void Excluir(Estacao obj)
        {
            _estacaoInterface.Excluir(obj);
        }

        public IList<Estacao> Listar()
        {
            return _estacaoInterface.Listar();
        }

        public Estacao RecuperarPorId(Guid id)
        {
            return _estacaoInterface.RecuperarPorId(id);
        }
    }

}
