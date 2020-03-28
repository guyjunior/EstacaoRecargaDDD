using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstacaoDDD.Aplica;
using EstacaoDDD.Domain.Dominio.Entidades;
using Microsoft.AspNetCore.Http;
using EstacaoDDD.Infra.Dados.Config;
using Microsoft.EntityFrameworkCore;
using Sitecore.FakeDb;
using Microsoft.Data.SqlClient;
using System.Web.Mvc;

namespace EstacaoDDD.Apresentacao.Controllers
{
    public class EstacaoController : Controller
    {
        
       
        private readonly IEstacaoApp _estacaoApp;

        public EstacaoController(IEstacaoApp IEstacaoApp)
        {
            _estacaoApp = IEstacaoApp;
        }

        // GET: Estacao
        public ActionResult Index()
        {
            return View(_estacaoApp.Listar());
        }

        // GET: Estacao/Details/5
        public ActionResult Details(Guid id)
        {
            return View(_estacaoApp.RecuperarPorId(id));
        }

        // GET: Estacao/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Estacao/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Estacao estacao)
        {
            try
            {
                // TODO: Add insert logic here
                estacao.Id = Guid.NewGuid();
                _estacaoApp.Adicionar(estacao);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return View();
            }
        }

        // GET: Estacao/Edit/5
        public ActionResult Edit (Guid id)
        {

            return View(_estacaoApp.RecuperarPorId(id));
        }


        // POST: Estacao/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit (Estacao estacao)
        {
            try
            {
                // TODO: Add update logic here
                _estacaoApp.Atualizar(estacao);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


// GET: Estacao/Delete/5
        public ActionResult Delete(Guid id)
        {
            return View(_estacaoApp.RecuperarPorId(id));
        }

        // POST: Estacao/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Estacao estacao)
        {
            try
            {
                _estacaoApp.Excluir(estacao);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}