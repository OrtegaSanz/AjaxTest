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
    
    public partial class EMPLEADO
    {
        public int COD_EMP { get; set; }
        public string COD_TIPO_EMP { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public string DIRECCION { get; set; }
        public string CORREO { get; set; }
        public Nullable<decimal> TELEFONO { get; set; }
        public Nullable<System.DateTime> CUMPLEANOS { get; set; }
    
        public virtual TIPO_EMPLEADO TIPO_EMPLEADO { get; set; }
    }
}