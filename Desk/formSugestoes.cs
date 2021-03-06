﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo.DAO;
using Modelo.PN;

namespace Desk
{
    public partial class formSugestoes : Form
    {
        Sugesto sugestao = new Sugesto();
        Usuario user;

        public formSugestoes(Usuario u)
        {
            InitializeComponent();
            this.user = u;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            dbEventosEntities db = new dbEventosEntities();

            try
            {

                Usuario atual = db.Usuarios.Find(this.user.email);

                sugestao.titulo = txtTitulo.Text;
                sugestao.descricao = txtDescricao.Text;
                sugestao.Usuario = atual;
                //sugestao.Usuario_email = atual.email;
      
                //fb.Evento = this.evento;

                if (!pnSugestoes.Inserir(sugestao, db))
                {
                    MessageBox.Show("Problema no envio de sugestão!");
                }
                else
                {
                    MessageBox.Show("Sugestão enviada.");

                    this.txtDescricao.Clear();
                    this.txtTitulo.Clear();
                    this.Hide();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
