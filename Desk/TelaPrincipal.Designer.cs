﻿namespace Desk
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.utEventos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpCategorias = new System.Windows.Forms.GroupBox();
            this.lnkCategoriaCad = new System.Windows.Forms.LinkLabel();
            this.lblTipoConta = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lnkCalSem = new System.Windows.Forms.LinkLabel();
            this.lnkCalMen = new System.Windows.Forms.LinkLabel();
            this.lnkCalDia = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lnkFeedback = new System.Windows.Forms.LinkLabel();
            this.lnkEvenGlo = new System.Windows.Forms.LinkLabel();
            this.lnkEvenPes = new System.Windows.Forms.LinkLabel();
            this.lnkEvenDis = new System.Windows.Forms.LinkLabel();
            this.lnkEvenNovo = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lnkFeed = new System.Windows.Forms.LinkLabel();
            this.lnkVerPerfil = new System.Windows.Forms.LinkLabel();
            this.lnkEditarPerfil = new System.Windows.Forms.LinkLabel();
            this.lnkSair = new System.Windows.Forms.LinkLabel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.lnkSugestoes = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.grpCategorias.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // utEventos
            // 
            this.utEventos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.utEventos.AutoSize = true;
            this.utEventos.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utEventos.Location = new System.Drawing.Point(37, 8);
            this.utEventos.Name = "utEventos";
            this.utEventos.Size = new System.Drawing.Size(100, 23);
            this.utEventos.TabIndex = 9;
            this.utEventos.Text = "utEventos";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.grpCategorias);
            this.panel1.Controls.Add(this.lblTipoConta);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.utEventos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 533);
            this.panel1.TabIndex = 10;
            // 
            // grpCategorias
            // 
            this.grpCategorias.Controls.Add(this.lnkCategoriaCad);
            this.grpCategorias.Location = new System.Drawing.Point(3, 463);
            this.grpCategorias.Name = "grpCategorias";
            this.grpCategorias.Size = new System.Drawing.Size(171, 65);
            this.grpCategorias.TabIndex = 14;
            this.grpCategorias.TabStop = false;
            this.grpCategorias.Text = "Categorias";
            this.grpCategorias.Visible = false;
            // 
            // lnkCategoriaCad
            // 
            this.lnkCategoriaCad.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.lnkCategoriaCad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnkCategoriaCad.AutoSize = true;
            this.lnkCategoriaCad.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lnkCategoriaCad.LinkColor = System.Drawing.Color.Black;
            this.lnkCategoriaCad.Location = new System.Drawing.Point(20, 30);
            this.lnkCategoriaCad.Name = "lnkCategoriaCad";
            this.lnkCategoriaCad.Size = new System.Drawing.Size(53, 13);
            this.lnkCategoriaCad.TabIndex = 8;
            this.lnkCategoriaCad.TabStop = true;
            this.lnkCategoriaCad.Text = "Gerenciar";
            this.lnkCategoriaCad.VisitedLinkColor = System.Drawing.Color.Black;
            this.lnkCategoriaCad.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCategoriaCad_LinkClicked);
            // 
            // lblTipoConta
            // 
            this.lblTipoConta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTipoConta.AutoSize = true;
            this.lblTipoConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoConta.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTipoConta.Location = new System.Drawing.Point(32, 42);
            this.lblTipoConta.Name = "lblTipoConta";
            this.lblTipoConta.Size = new System.Drawing.Size(123, 25);
            this.lblTipoConta.TabIndex = 0;
            this.lblTipoConta.Text = "lblTipoConta";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lnkCalSem);
            this.groupBox3.Controls.Add(this.lnkCalMen);
            this.groupBox3.Controls.Add(this.lnkCalDia);
            this.groupBox3.Location = new System.Drawing.Point(3, 357);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(171, 100);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Calendário";
            // 
            // lnkCalSem
            // 
            this.lnkCalSem.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.lnkCalSem.AutoSize = true;
            this.lnkCalSem.LinkColor = System.Drawing.Color.Black;
            this.lnkCalSem.Location = new System.Drawing.Point(20, 48);
            this.lnkCalSem.Name = "lnkCalSem";
            this.lnkCalSem.Size = new System.Drawing.Size(48, 13);
            this.lnkCalSem.TabIndex = 9;
            this.lnkCalSem.TabStop = true;
            this.lnkCalSem.Text = "Semanal";
            this.lnkCalSem.VisitedLinkColor = System.Drawing.Color.Black;
            this.lnkCalSem.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCalSem_LinkClicked);
            // 
            // lnkCalMen
            // 
            this.lnkCalMen.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.lnkCalMen.AutoSize = true;
            this.lnkCalMen.LinkColor = System.Drawing.Color.Black;
            this.lnkCalMen.Location = new System.Drawing.Point(20, 71);
            this.lnkCalMen.Name = "lnkCalMen";
            this.lnkCalMen.Size = new System.Drawing.Size(41, 13);
            this.lnkCalMen.TabIndex = 10;
            this.lnkCalMen.TabStop = true;
            this.lnkCalMen.Text = "Mensal";
            this.lnkCalMen.VisitedLinkColor = System.Drawing.Color.Black;
            this.lnkCalMen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCalMen_LinkClicked);
            // 
            // lnkCalDia
            // 
            this.lnkCalDia.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.lnkCalDia.AutoSize = true;
            this.lnkCalDia.LinkColor = System.Drawing.Color.Black;
            this.lnkCalDia.Location = new System.Drawing.Point(20, 26);
            this.lnkCalDia.Name = "lnkCalDia";
            this.lnkCalDia.Size = new System.Drawing.Size(34, 13);
            this.lnkCalDia.TabIndex = 8;
            this.lnkCalDia.TabStop = true;
            this.lnkCalDia.Text = "Diário";
            this.lnkCalDia.VisitedLinkColor = System.Drawing.Color.Black;
            this.lnkCalDia.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCalDia_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lnkSugestoes);
            this.groupBox2.Controls.Add(this.lnkFeedback);
            this.groupBox2.Controls.Add(this.lnkEvenGlo);
            this.groupBox2.Controls.Add(this.lnkEvenPes);
            this.groupBox2.Controls.Add(this.lnkEvenDis);
            this.groupBox2.Controls.Add(this.lnkEvenNovo);
            this.groupBox2.Location = new System.Drawing.Point(3, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(171, 153);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eventos";
            // 
            // lnkFeedback
            // 
            this.lnkFeedback.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.lnkFeedback.AutoSize = true;
            this.lnkFeedback.LinkColor = System.Drawing.Color.Black;
            this.lnkFeedback.Location = new System.Drawing.Point(20, 108);
            this.lnkFeedback.Name = "lnkFeedback";
            this.lnkFeedback.Size = new System.Drawing.Size(55, 13);
            this.lnkFeedback.TabIndex = 8;
            this.lnkFeedback.TabStop = true;
            this.lnkFeedback.Text = "Feedback";
            this.lnkFeedback.VisitedLinkColor = System.Drawing.Color.Black;
            this.lnkFeedback.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkFeedback_LinkClicked);
            // 
            // lnkEvenGlo
            // 
            this.lnkEvenGlo.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.lnkEvenGlo.AutoSize = true;
            this.lnkEvenGlo.LinkColor = System.Drawing.Color.Black;
            this.lnkEvenGlo.Location = new System.Drawing.Point(20, 86);
            this.lnkEvenGlo.Name = "lnkEvenGlo";
            this.lnkEvenGlo.Size = new System.Drawing.Size(84, 13);
            this.lnkEvenGlo.TabIndex = 7;
            this.lnkEvenGlo.TabStop = true;
            this.lnkEvenGlo.Text = "Eventos Globais";
            this.lnkEvenGlo.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // lnkEvenPes
            // 
            this.lnkEvenPes.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.lnkEvenPes.AutoSize = true;
            this.lnkEvenPes.LinkColor = System.Drawing.Color.Black;
            this.lnkEvenPes.Location = new System.Drawing.Point(20, 38);
            this.lnkEvenPes.Name = "lnkEvenPes";
            this.lnkEvenPes.Size = new System.Drawing.Size(75, 13);
            this.lnkEvenPes.TabIndex = 5;
            this.lnkEvenPes.TabStop = true;
            this.lnkEvenPes.Text = "Meus Eventos";
            this.lnkEvenPes.VisitedLinkColor = System.Drawing.Color.Black;
            this.lnkEvenPes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEvenPes_LinkClicked);
            // 
            // lnkEvenDis
            // 
            this.lnkEvenDis.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.lnkEvenDis.AutoSize = true;
            this.lnkEvenDis.LinkColor = System.Drawing.Color.Black;
            this.lnkEvenDis.Location = new System.Drawing.Point(20, 62);
            this.lnkEvenDis.Name = "lnkEvenDis";
            this.lnkEvenDis.Size = new System.Drawing.Size(114, 13);
            this.lnkEvenDis.TabIndex = 6;
            this.lnkEvenDis.TabStop = true;
            this.lnkEvenDis.Text = "Eventos de Disciplinas";
            this.lnkEvenDis.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // lnkEvenNovo
            // 
            this.lnkEvenNovo.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.lnkEvenNovo.AutoSize = true;
            this.lnkEvenNovo.LinkColor = System.Drawing.Color.Black;
            this.lnkEvenNovo.Location = new System.Drawing.Point(20, 15);
            this.lnkEvenNovo.Name = "lnkEvenNovo";
            this.lnkEvenNovo.Size = new System.Drawing.Size(89, 13);
            this.lnkEvenNovo.TabIndex = 4;
            this.lnkEvenNovo.TabStop = true;
            this.lnkEvenNovo.Text = "Cria novo Evento";
            this.lnkEvenNovo.VisitedLinkColor = System.Drawing.Color.Black;
            this.lnkEvenNovo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEvenNovo_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lnkFeed);
            this.groupBox1.Controls.Add(this.lnkVerPerfil);
            this.groupBox1.Controls.Add(this.lnkEditarPerfil);
            this.groupBox1.Controls.Add(this.lnkSair);
            this.groupBox1.Location = new System.Drawing.Point(3, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 122);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conta";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lnkFeed
            // 
            this.lnkFeed.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.lnkFeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnkFeed.AutoSize = true;
            this.lnkFeed.LinkColor = System.Drawing.Color.Black;
            this.lnkFeed.Location = new System.Drawing.Point(20, 22);
            this.lnkFeed.Name = "lnkFeed";
            this.lnkFeed.Size = new System.Drawing.Size(31, 13);
            this.lnkFeed.TabIndex = 1;
            this.lnkFeed.TabStop = true;
            this.lnkFeed.Text = "Feed";
            this.lnkFeed.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // lnkVerPerfil
            // 
            this.lnkVerPerfil.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.lnkVerPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnkVerPerfil.AutoSize = true;
            this.lnkVerPerfil.LinkColor = System.Drawing.Color.Black;
            this.lnkVerPerfil.Location = new System.Drawing.Point(20, 46);
            this.lnkVerPerfil.Name = "lnkVerPerfil";
            this.lnkVerPerfil.Size = new System.Drawing.Size(77, 13);
            this.lnkVerPerfil.TabIndex = 2;
            this.lnkVerPerfil.TabStop = true;
            this.lnkVerPerfil.Text = "Visualizar Perfil";
            this.lnkVerPerfil.VisitedLinkColor = System.Drawing.Color.Black;
            this.lnkVerPerfil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkVerPerfil_LinkClicked);
            // 
            // lnkEditarPerfil
            // 
            this.lnkEditarPerfil.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.lnkEditarPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnkEditarPerfil.AutoSize = true;
            this.lnkEditarPerfil.LinkColor = System.Drawing.Color.Black;
            this.lnkEditarPerfil.Location = new System.Drawing.Point(20, 69);
            this.lnkEditarPerfil.Name = "lnkEditarPerfil";
            this.lnkEditarPerfil.Size = new System.Drawing.Size(60, 13);
            this.lnkEditarPerfil.TabIndex = 3;
            this.lnkEditarPerfil.TabStop = true;
            this.lnkEditarPerfil.Text = "Editar Perfil";
            this.lnkEditarPerfil.VisitedLinkColor = System.Drawing.Color.Black;
            this.lnkEditarPerfil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEditarPerfil_LinkClicked);
            // 
            // lnkSair
            // 
            this.lnkSair.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.lnkSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lnkSair.AutoSize = true;
            this.lnkSair.LinkColor = System.Drawing.Color.Black;
            this.lnkSair.Location = new System.Drawing.Point(20, 91);
            this.lnkSair.Name = "lnkSair";
            this.lnkSair.Size = new System.Drawing.Size(25, 13);
            this.lnkSair.TabIndex = 0;
            this.lnkSair.TabStop = true;
            this.lnkSair.Text = "Sair";
            this.lnkSair.VisitedLinkColor = System.Drawing.Color.Black;
            this.lnkSair.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.mainPanel.Location = new System.Drawing.Point(180, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(713, 533);
            this.mainPanel.TabIndex = 11;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // lnkSugestoes
            // 
            this.lnkSugestoes.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.lnkSugestoes.AutoSize = true;
            this.lnkSugestoes.LinkColor = System.Drawing.Color.Black;
            this.lnkSugestoes.Location = new System.Drawing.Point(20, 130);
            this.lnkSugestoes.Name = "lnkSugestoes";
            this.lnkSugestoes.Size = new System.Drawing.Size(57, 13);
            this.lnkSugestoes.TabIndex = 9;
            this.lnkSugestoes.TabStop = true;
            this.lnkSugestoes.Text = "Sugestões";
            this.lnkSugestoes.VisitedLinkColor = System.Drawing.Color.Black;
            this.lnkSugestoes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSugestoes_LinkClicked);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 533);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TelaPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "utEventos";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpCategorias.ResumeLayout(false);
            this.grpCategorias.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label utEventos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel lnkEditarPerfil;
        private System.Windows.Forms.LinkLabel lnkSair;
        private System.Windows.Forms.LinkLabel lnkVerPerfil;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.LinkLabel lnkCalSem;
        private System.Windows.Forms.LinkLabel lnkCalMen;
        private System.Windows.Forms.LinkLabel lnkCalDia;
        private System.Windows.Forms.LinkLabel lnkEvenGlo;
        private System.Windows.Forms.LinkLabel lnkEvenPes;
        private System.Windows.Forms.LinkLabel lnkEvenDis;
        private System.Windows.Forms.LinkLabel lnkEvenNovo;
        private System.Windows.Forms.LinkLabel lnkFeed;
        private System.Windows.Forms.Label lblTipoConta;
        private System.Windows.Forms.GroupBox grpCategorias;
        private System.Windows.Forms.LinkLabel lnkCategoriaCad;
        private System.Windows.Forms.LinkLabel lnkFeedback;
        private System.Windows.Forms.LinkLabel lnkSugestoes;
    }
}