//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AjaxTest.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ORDEN_ATENCION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ORDEN_ATENCION()
        {
            this.COMPROBANTE_PAGO = new HashSet<COMPROBANTE_PAGO>();
            this.DETALLE_ORDEN_ATENCION = new HashSet<DETALLE_ORDEN_ATENCION>();
            this.VENTAS_DIARIAS = new HashSet<VENTAS_DIARIAS>();
        }
    
        public string COD_ORDEN_ATENCION { get; set; }
        public string PLACA { get; set; }
        public int DNI { get; set; }
    
        public virtual C_AUTO C_AUTO { get; set; }
        public virtual CLIENTE CLIENTE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPROBANTE_PAGO> COMPROBANTE_PAGO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLE_ORDEN_ATENCION> DETALLE_ORDEN_ATENCION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENTAS_DIARIAS> VENTAS_DIARIAS { get; set; }
    }
}
