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
using System.Globalization;

namespace Web.Controllers
{
    public class EventoesController : Controller
    {
        private dbEventosEntities db = new dbEventosEntities();

        // GET: Eventoes
        public ActionResult Index(List<string> filterValues = null)
        {
            if (System.Web.HttpContext.Current.Session["email"] != null)
            {
                List<Evento> eventos = pnEventos.Listar(System.Web.HttpContext.Current.Session["email"].ToString(), "atuais");

                //Ordem e filtro padrão
                eventos = eventos.Where(x => object.Equals(x.escopo, "Pessoal")).ToList();
                eventos = eventos.OrderByDescending(x => x.Inscricoes.Count()).ToList();

                return View(eventos);
            }
            return View(pnEventos.Listar("",""));
        }

        [HttpPost]
        public ActionResult FilterPartial(string filterValue, string orderValue)
        {
            List<Evento> eventos = pnEventos.Listar(System.Web.HttpContext.Current.Session["email"].ToString(), "atuais");
            eventos = eventos.Where(x => object.Equals(x.escopo,filterValue)).ToList();
            
            if(orderValue == "Popularidade")
            {
                eventos = eventos.OrderByDescending(x => x.Inscricoes.Count()).ToList();
            }
            else if(orderValue == "Proximidade")
            {
                eventos = eventos.OrderBy(x => x.data_inicio).ToList();
            }
            else
            {
                eventos = eventos.OrderByDescending(x => x.data_criacao).ToList();
            }


            return PartialView("_EventoesList", eventos);
        }

        [HttpPost]
        public ActionResult Index(string Tipo, string Query = "")
        {
           
            List<Evento> eventos = pnEventos.Listar(System.Web.HttpContext.Current.Session["email"].ToString(),"");
            IEnumerable<Evento> resultado;

            if (Query.Length > 0)
            {
                if (Tipo == "Disciplina")
                {
                    resultado = eventos.Where(x => x.Disciplina_nome != null && x.Disciplina_nome.ToLower().Contains(Query.ToLower()));
                }
                else if (Tipo == "Nome")
                {
                    resultado = eventos.Where(x => x.nome.ToLower().Contains(Query.ToLower()));
                }
                else
                {
                    DateTime parsed;
                    if (DateTime.TryParse("1." + Query + " 2000", out parsed))
                    {
                        int month = parsed.Month;
                        resultado = eventos.Where(x => x.data_inicio.Month == month);
                    }
                    else
                    {
                        TempData["msg"] = "<script>alert('Formato inadequado');</script>";
                        resultado = eventos.AsEnumerable();
                    }
                    
                }
            }
            else
            {
                resultado = eventos.AsEnumerable();
            }

            return View(resultado);
        }

        public ActionResult Checkin(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evento evento = pnEventos.Pesquisar(id);
            if (evento == null)
            {
                return HttpNotFound();
            }

            if (pnCheckin.Pesquisar(id, System.Web.HttpContext.Current.Session["email"].ToString()) == null)
            {
                pnCheckin.Inserir(id, System.Web.HttpContext.Current.Session["email"].ToString());
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("checked in already");
            }

            return RedirectToAction("Details", new { id = evento.Id });
        }

        public ActionResult SignUp(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evento evento = pnEventos.Pesquisar(id);
            if (evento == null)
            {
                return HttpNotFound();
            }

            if (pnInscricoes.Pesquisar(id, System.Web.HttpContext.Current.Session["email"].ToString()) == null)
            {
                pnInscricoes.Inserir(id, System.Web.HttpContext.Current.Session["email"].ToString());
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("ja inscrito");
            }

            return RedirectToAction("Details", new { id = evento.Id });
        }

        public ActionResult SignOut(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evento evento = pnEventos.Pesquisar(id);
            if (evento == null)
            {
                return HttpNotFound();
            }

            Inscricao inscr = pnInscricoes.Pesquisar(id, System.Web.HttpContext.Current.Session["email"].ToString());
            if (inscr != null)
            {
                pnInscricoes.Excluir(inscr);
            }

            return RedirectToAction("Details", new { id = evento.Id });
        }

        public ActionResult Museu()
        {
            return View(pnEventos.Listar(System.Web.HttpContext.Current.Session["email"].ToString(), "passados"));
        }

        // GET: Eventoes/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evento evento = pnEventos.Pesquisar(id);
            if (evento == null)
            {
                return HttpNotFound();
            }
            return View(evento);
        }

        // GET: Eventoes/Create
        public ActionResult Create()
        {
            ViewBag.Categoria_nome = new SelectList(db.Categorias, "nome", "nome");
            ViewBag.Disciplina_nome = new SelectList(db.Disciplinas, "nome", "nome");

            if (ViewBag.Disciplina_nome == null)
            {
                ViewBag.Disciplina_nome = new SelectList("Outros", "nome");
            }
            if (ViewBag.Categoria_nome == null)
            {
                ViewBag.Categoria_nome = new SelectList("Outros", "nome");
            }


            Evento evento = new Evento();
            string inicio = (DateTime.Now).AddDays(1).ToString("yyyy-MM-ddThh:mm");
            string fim = (DateTime.Now).AddDays(1).ToString("yyyy-MM-ddThhmm");
            evento.data_inicio = DateTime.ParseExact(inicio, "yyyy-MM-ddThh:mm", CultureInfo.InvariantCulture);
            evento.data_fim = DateTime.ParseExact(fim, "yyyy-MM-ddThhmm", CultureInfo.InvariantCulture);

            return View(evento);
        }

        // POST: Eventoes/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "nome,data_inicio,data_fim,capacidade,escopo,Disciplina_nome,importante,Categoria_nome")] Evento evento)
        {
            if (ModelState.IsValid)
            {
                if(evento.capacidade == null)
                {
                    evento.capacidade = 0;
                }
                evento.criador = System.Web.HttpContext.Current.Session["email"].ToString();
                pnEventos.Inserir(evento, null);
                return RedirectToAction("Index");
            }

            ViewBag.criador = new SelectList(db.Usuarios, "email", "nome", evento.criador);
            ViewBag.Disciplina_nome = new SelectList(db.Categorias, "nome", "nome", evento.Disciplina_nome);
            ViewBag.Categoria_nome = new SelectList(db.Categorias, "nome", "nome", evento.Categoria_nome);
            return View(evento);
        }

        // GET: Eventoes/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evento evento = pnEventos.Pesquisar(id);
            if (evento == null)
            {
                return HttpNotFound();
            }
            ViewBag.criador = new SelectList(db.Usuarios, "email", "nome", evento.criador);
            ViewBag.Categoria_nome = new SelectList(db.Categorias, "nome", "nome", evento.Categoria_nome);
            ViewBag.Disciplina_nome = new SelectList(db.Disciplinas, "nome", "nome");
            return View(evento);
        }

        // POST: Eventoes/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,nome,data_inicio,data_fim,escopo,importante,Categoria_nome")] Evento evento)
        {
            if (ModelState.IsValid)
            {
                evento.criador = System.Web.HttpContext.Current.Session["email"].ToString();
                pnEventos.Alterar(evento, null);
                return RedirectToAction("Index");
            }
            ViewBag.criador = new SelectList(db.Usuarios, "email", "nome", evento.criador);
            ViewBag.Categoria_nome = new SelectList(db.Categorias, "nome", "nome", evento.Categoria_nome);
            return View(evento);
        }

        // GET: Eventoes/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evento evento = pnEventos.Pesquisar(id);
            if (evento == null)
            {
                return HttpNotFound();
            }
            return View(evento);
        }

        // POST: Eventoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Evento evento = pnEventos.Pesquisar(id);
            pnEventos.Excluir(evento);
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
