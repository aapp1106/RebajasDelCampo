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
    
    public partial class Venta
    {
        public Venta()
        {
            this.DetalleFactura = new HashSet<DetalleFactura>();
            this.Devolucion = new HashSet<Devolucion>();
        }
    
        public int VentaId { get; set; }
        public System.DateTime FechaVenta { get; set; }
        public int CantidadVenta { get; set; }
        public int ClienteCompra { get; set; }
        public int VendedorVende { get; set; }
        public decimal ValorTotalVenta { get; set; }
    
        public virtual ICollection<DetalleFactura> DetalleFactura { get; set; }
        public virtual ICollection<Devolucion> Devolucion { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Usuario Usuario1 { get; set; }
    }
}
