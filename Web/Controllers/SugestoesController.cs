﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Modelo.DAO;
using Modelo.PN;

namespace Web.Controllers
{
    public class SugestoesController : Controller
    {
        //private dbEventosEntities db = new dbEventosEntities();

        // GET: Sugestoes
        public ActionResult Index()
        {
            //var sugestoes = db.Sugestoes.Include(s => s.Usuario);
            var sugestoes = pnSugestoes.Listar();
            return View(sugestoes.ToList());
        }

        // GET: Sugestoes/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sugesto sugesto = pnSugestoes.Pesquisar(id);
            if (sugesto == null)
            {
                return HttpNotFound();
            }
            return View(sugesto);
        }

        // GET: Sugestoes/Create
        public ActionResult Create()
        {
            //ViewBag.Usuario_email = new SelectList(db.Usuarios, "email", "nome");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "titulo,descricao")] Sugesto s)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    s.Usuario_email = System.Web.HttpContext.Current.Session["email"].ToString();
                    pnSugestoes.Inserir(s, null);
                    return RedirectToAction("Index", "Eventoes");
                }
                catch (Exception) { }
            }

            return View();
        }

        // GET: Sugestoes/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sugesto sugesto = pnSugestoes.Pesquisar(id);
            if (sugesto == null)
            {
                return HttpNotFound();
            }
            return View(sugesto);
        }

        // POST: Sugestoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sugesto sugesto = pnSugestoes.Pesquisar(id);
            pnSugestoes.Excluir(sugesto);
            return RedirectToAction("Index");
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
