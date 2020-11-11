using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TesteBestProjects.Models;
using System.Drawing;
using System.Net;

namespace TesteBestProjects.Controllers
{
    public class PessoasController : Controller
    {
        PessoaDbContext db;

        public PessoasController()
        {
            db = new PessoaDbContext();
        }


        // GET: Pessoas
        public ActionResult Index()
        {

            var pessoas = db.Pessoa.ToList();
            return View(pessoas);
        }


        //Create

        public ActionResult Create()
        {
            ViewBag.Pessoas = db.Pessoa;
            var model = new PessoaViewModel();
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PessoaViewModel model)
        {

            if (ModelState.IsValid)
            {
                var pessoa = new Pessoa();
                pessoa.Nome = model.Nome;
                pessoa.Telefone = model.Telefone;
                pessoa.Celular = model.Celular;

                db.Pessoa.Add(pessoa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }



        //Edit
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pessoa produto = db.Pessoa.Find(id);
            if (produto == null)
            {
                return HttpNotFound();
            }

            return View(produto);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PessoaId,Nome,Telefone,Celular")] Pessoa model)
        {
            if (ModelState.IsValid)
            {
                var produto = db.Pessoa.Find(model.PessoaId);
                if (produto == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                produto.Nome = model.Nome;
                produto.Telefone = model.Telefone;
                produto.Celular = model.Celular;

                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);
        }


        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Pessoa pessoa = db.Pessoa.Find(id);
            if (pessoa == null)
            {
                return HttpNotFound();
            }
            return View(pessoa);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pessoa pessoa = db.Pessoa.Find(id);
            db.Pessoa.Remove(pessoa);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}