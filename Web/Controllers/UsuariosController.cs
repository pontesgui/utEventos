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
    public class UsuariosController : Controller
    {
        //private dbEventosEntities db = new dbEventosEntities();

        // GET: Usuarios
        public ActionResult Index()
        {
            return View(pnUsuarios.Listar());
        }

        // GET: Usuarios/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                System.Diagnostics.Debug.WriteLine("null parameter");
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            id = HttpUtility.UrlDecode(id);
            Usuario usuario = pnUsuarios.Pesquisar(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        // GET: Usuarios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Usuarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "nome,email,senha,data_nascimento,tipo")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    pnUsuarios.Inserir(usuario);
                    return RedirectToAction("Index");
                }
               catch (Exception) { }
            }

            return View(usuario);
        }

        // GET: Usuarios/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario usuario = pnUsuarios.Pesquisar(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        // POST: Usuarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "nome,email,senha,data_nascimento,tipo")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(usuario).State = EntityState.Modified;
                //db.SaveChanges();
                pnUsuarios.Alterar(usuario);

                if (object.Equals(usuario.email, System.Web.HttpContext.Current.Session["email"].ToString())){
                    Usuario u = pnUsuarios.Pesquisar(usuario.email);
                    System.Web.HttpContext.Current.Session["nome"] = u.nome;
                    System.Web.HttpContext.Current.Session["email"] = u.email;
                    System.Web.HttpContext.Current.Session["tipo"] = u.tipo;
                }

                return RedirectToAction("Index");
            }
            return View(usuario);
        }

        // GET: Usuarios/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario usuario = pnUsuarios.Pesquisar(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Usuario usuario = pnUsuarios.Pesquisar(id);
            pnUsuarios.Excluir(usuario);
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
