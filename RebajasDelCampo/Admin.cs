//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RebajasDelCampo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Admin
    {
        public Admin()
        {
            this.CompraProductos = new HashSet<CompraProductos>();
        }
    
        public int IdAdmin { get; set; }
        public string User { get; set; }
        public byte[] Pass { get; set; }
    
        public virtual ICollection<CompraProductos> CompraProductos { get; set; }
    }
}
