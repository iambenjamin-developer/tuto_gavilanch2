//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gavilanch2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRODUCTOS
    {
        public int ID { get; set; }
        public string DESCRIPCION { get; set; }
        public int STOCK { get; set; }
        public decimal PRECIO { get; set; }
        public bool ACTIVO { get; set; }
        public Nullable<System.DateTime> FECHAVENCIMIENTO { get; set; }
        public byte[] FOTO { get; set; }
    }
}
