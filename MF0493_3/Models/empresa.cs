//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MF0493_3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Empresa
    {
        public string nif { get; set; }
        public string nombre { get; set; }
        public string email { get; set; }
        public Nullable<System.DateTime> ff { get; set; }
        public string poblacion { get; set; }
        public string telefono { get; set; }
        public string logo { get; set; }
        public Nullable<bool> activa { get; set; }
        public string usr { get; set; }
    
        public virtual Usuario Usuario { get; set; }
    }
}