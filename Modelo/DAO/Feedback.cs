//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Modelo.DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Feedback
    {
        [Key]
        public int Id { get; set; }
        public string titulo { get; set; }
        public string descricao { get; set; }
        public int EventoId { get; set; }
        public string Usuario_email { get; set; }
        public string data_criacao { get; set; }
    
        public virtual Evento Evento { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
